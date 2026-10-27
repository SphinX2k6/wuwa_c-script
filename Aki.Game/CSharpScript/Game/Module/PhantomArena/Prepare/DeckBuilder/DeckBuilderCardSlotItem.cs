using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005196 RID: 20886
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderCardSlotItem : GridProxyAbstract<IDeckBuilderCardSlotItemData>
	{
		// Token: 0x0603569B RID: 218779 RVA: 0x00CA63A8 File Offset: 0x00CA45A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUISprite))
			};
		}

		// Token: 0x0603569C RID: 218780 RVA: 0x00CA64A0 File Offset: 0x00CA46A0
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardSlotItem.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardSlotItem.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603569D RID: 218781 RVA: 0x00CA64E4 File Offset: 0x00CA46E4
		[NullableContext(1)]
		public override void Refresh(IDeckBuilderCardSlotItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			DeckCardSlotInfo slotInfo = data.SlotInfo;
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(slotInfo.CardId);
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshLockState();
			this.RefreshRedDot();
			base.GetText(3).SetText(phantomBattleCardConfig.Cost.ToString(), true);
			UUIText text = base.GetText(4);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("×");
			defaultInterpolatedStringHandler.AppendFormatted<int>(slotInfo.Count);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phantomBattleCardConfig.Name, Array.Empty<object>());
			base.SetTextureByPath(phantomBattleCardConfig.DeckFaceTexture, base.GetTexture(1), null, null);
			this.RefreshElement(slotInfo.Element);
			this.RefreshOutlookState();
			if (data.NeedPlayAddAnim)
			{
				data.NeedPlayAddAnim = false;
				this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
			}
		}

		// Token: 0x0603569E RID: 218782 RVA: 0x00CA65FD File Offset: 0x00CA47FD
		public void RefreshLockState()
		{
			base.GetItem(6).SetUIActive(this.Data.Locked);
		}

		// Token: 0x0603569F RID: 218783 RVA: 0x00CA6618 File Offset: 0x00CA4818
		public void RefreshOutlookState()
		{
			string path = this.Data.OutlookUnlocked ? "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_IconOutsideTeamListGold.SP_IconOutsideTeamListGold" : "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_IconOutsideTeamListNor.SP_IconOutsideTeamListNor";
			this.SetSpriteByPath(path, base.GetSprite(9), false, null, null);
		}

		// Token: 0x060356A0 RID: 218784 RVA: 0x00CA6659 File Offset: 0x00CA4859
		public void RefreshRedDot()
		{
			base.GetItem(7).SetUIActive(this.Data.RedDotState);
		}

		// Token: 0x060356A1 RID: 218785 RVA: 0x00CA6672 File Offset: 0x00CA4872
		private void RefreshElement(int elementId)
		{
			this.ElementItem.Refresh((ECardElement)elementId, false, 0);
		}

		// Token: 0x060356A2 RID: 218786 RVA: 0x00CA6682 File Offset: 0x00CA4882
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060356A3 RID: 218787 RVA: 0x00CA6695 File Offset: 0x00CA4895
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060356A4 RID: 218788 RVA: 0x00CA66A8 File Offset: 0x00CA48A8
		private bool CanToggleExecuteChangeInternal()
		{
			return this.CanToggleChange == null || this.CanToggleChange(this);
		}

		// Token: 0x060356A5 RID: 218789 RVA: 0x00CA66C0 File Offset: 0x00CA48C0
		private void OnItemTogglePointDownCallBack(EToggleState _)
		{
			if (this.TickHandleId != -1)
			{
				TickSystem.Instance.Remove(this.TickHandleId);
				this.TickHandleId = -1;
			}
			this.HoldTime = 0f;
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.PressTick), "DeckBuilderCardSlotItem", ETickingGroup.TG_PrePhysics, true, 0, true);
			this.TickHandleId = ((ticker != null) ? ticker.Id : -1);
		}

		// Token: 0x060356A6 RID: 218790 RVA: 0x00CA672C File Offset: 0x00CA492C
		private void OnItemTogglePointUpCallBackWithEventData(EToggleState state, ULGUIPointerEventData eventData)
		{
			USceneComponent usceneComponent = (eventData != null) ? eventData.dragComponent : null;
			if (usceneComponent != null && usceneComponent.IsValid())
			{
				return;
			}
			if (this.TickHandleId != -1)
			{
				Action longPressEndCallback = this.LongPressEndCallback;
				if (longPressEndCallback != null)
				{
					longPressEndCallback();
				}
				TickSystem.Instance.Remove(this.TickHandleId);
				this.TickHandleId = -1;
			}
			this.TickHandleId = -1;
			if (this.HoldTime < this.LongPressStartTime)
			{
				Action<DeckBuilderCardSlotItem> shortClickCallback = this.ShortClickCallback;
				if (shortClickCallback != null)
				{
					shortClickCallback(this);
				}
			}
			this.HoldTime = 0f;
		}

		// Token: 0x060356A7 RID: 218791 RVA: 0x00CA67B6 File Offset: 0x00CA49B6
		private void OnToggleStateChangeInternal(EToggleState state)
		{
			Action<DeckBuilderCardSlotItem, EToggleState> onToggleStateChange = this.OnToggleStateChange;
			if (onToggleStateChange == null)
			{
				return;
			}
			onToggleStateChange(this, state);
		}

		// Token: 0x060356A8 RID: 218792 RVA: 0x00CA67CC File Offset: 0x00CA49CC
		private void PressTick(float deltaTime)
		{
			this.HoldTime += deltaTime;
			if (this.HoldTime >= this.LongPressStartTime)
			{
				float arg = (this.HoldTime - this.LongPressStartTime) / (this.LongPressEndTime - this.LongPressStartTime);
				Action<DeckBuilderCardSlotItem, float> longPressCallback = this.LongPressCallback;
				if (longPressCallback != null)
				{
					longPressCallback(this, arg);
				}
			}
			if (this.HoldTime > this.LongPressEndTime)
			{
				Action longPressEndCallback = this.LongPressEndCallback;
				if (longPressEndCallback != null)
				{
					longPressEndCallback();
				}
				if (this.TickHandleId != -1)
				{
					TickSystem.Instance.Remove(this.TickHandleId);
					this.TickHandleId = -1;
				}
			}
		}

		// Token: 0x060356A9 RID: 218793 RVA: 0x00CA6864 File Offset: 0x00CA4A64
		private bool OnItemTogglePointerBeginDragCallBack(ULGUIPointerEventData _)
		{
			Action longPressEndCallback = this.LongPressEndCallback;
			if (longPressEndCallback != null)
			{
				longPressEndCallback();
			}
			if (this.TickHandleId != -1)
			{
				TickSystem.Instance.Remove(this.TickHandleId);
				this.TickHandleId = -1;
			}
			return true;
		}

		// Token: 0x060356AA RID: 218794 RVA: 0x00CA6899 File Offset: 0x00CA4A99
		private void OnPointEnter(EToggleState _)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			Action<int> onPointEnterCallback = this.OnPointEnterCallback;
			if (onPointEnterCallback == null)
			{
				return;
			}
			onPointEnterCallback(this.Data.SlotInfo.CardId);
		}

		// Token: 0x060356AB RID: 218795 RVA: 0x00CA68C8 File Offset: 0x00CA4AC8
		private void OnPointExit(EToggleState _)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			Action onPointExitCallback = this.OnPointExitCallback;
			if (onPointExitCallback == null)
			{
				return;
			}
			onPointExitCallback();
		}

		// Token: 0x060356AC RID: 218796 RVA: 0x00CA68E7 File Offset: 0x00CA4AE7
		public DeckCardSlotInfo GetData()
		{
			IDeckBuilderCardSlotItemData data = this.Data;
			if (data == null)
			{
				return null;
			}
			return data.SlotInfo;
		}

		// Token: 0x060356AD RID: 218797 RVA: 0x00CA68FA File Offset: 0x00CA4AFA
		public void TriggerLongPress()
		{
			Action<DeckBuilderCardSlotItem, float> longPressCallback = this.LongPressCallback;
			if (longPressCallback == null)
			{
				return;
			}
			longPressCallback(this, -1f);
		}

		// Token: 0x0401C623 RID: 116259
		protected IDeckBuilderCardSlotItemData Data;

		// Token: 0x0401C624 RID: 116260
		private CardElementItem ElementItem;

		// Token: 0x0401C625 RID: 116261
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401C626 RID: 116262
		private float HoldTime;

		// Token: 0x0401C627 RID: 116263
		private int TickHandleId = -1;

		// Token: 0x0401C628 RID: 116264
		public float LongPressStartTime;

		// Token: 0x0401C629 RID: 116265
		public float LongPressEndTime;

		// Token: 0x0401C62A RID: 116266
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<DeckBuilderCardSlotItem, bool> CanToggleChange;

		// Token: 0x0401C62B RID: 116267
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem, float> LongPressCallback;

		// Token: 0x0401C62C RID: 116268
		public Action LongPressEndCallback;

		// Token: 0x0401C62D RID: 116269
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem> ShortClickCallback;

		// Token: 0x0401C62E RID: 116270
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem, EToggleState> OnToggleStateChange;

		// Token: 0x0401C62F RID: 116271
		public Action<int> OnPointEnterCallback;

		// Token: 0x0401C630 RID: 116272
		public Action OnPointExitCallback;

		// Token: 0x0200B306 RID: 45830
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036416 RID: 222230
			public const int ItemToggle = 0;

			// Token: 0x04036417 RID: 222231
			public const int CardSlotTexture = 1;

			// Token: 0x04036418 RID: 222232
			public const int NameText = 2;

			// Token: 0x04036419 RID: 222233
			public const int CostText = 3;

			// Token: 0x0403641A RID: 222234
			public const int CountText = 4;

			// Token: 0x0403641B RID: 222235
			public const int ElementItem = 5;

			// Token: 0x0403641C RID: 222236
			public const int LockItem = 6;

			// Token: 0x0403641D RID: 222237
			public const int RedDotItem = 7;

			// Token: 0x0403641E RID: 222238
			public const int LineItem = 8;

			// Token: 0x0403641F RID: 222239
			public const int BgSprite = 9;
		}
	}
}
