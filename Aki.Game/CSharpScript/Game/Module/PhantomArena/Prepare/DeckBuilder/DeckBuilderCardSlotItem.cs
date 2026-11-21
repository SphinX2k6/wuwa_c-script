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
	// Token: 0x02004166 RID: 16742
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderCardSlotItem : GridProxyAbstract<IDeckBuilderCardSlotItemData>
	{
		// Token: 0x0602A596 RID: 173462 RVA: 0x00BF395C File Offset: 0x00BF1B5C
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

		// Token: 0x0602A597 RID: 173463 RVA: 0x00BF3A54 File Offset: 0x00BF1C54
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardSlotItem.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardSlotItem.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A598 RID: 173464 RVA: 0x00BF3A98 File Offset: 0x00BF1C98
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

		// Token: 0x0602A599 RID: 173465 RVA: 0x00BF3BB1 File Offset: 0x00BF1DB1
		public void RefreshLockState()
		{
			base.GetItem(6).SetUIActive(this.Data.Locked);
		}

		// Token: 0x0602A59A RID: 173466 RVA: 0x00BF3BCC File Offset: 0x00BF1DCC
		public void RefreshOutlookState()
		{
			string path = this.Data.OutlookUnlocked ? "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_IconOutsideTeamListGold.SP_IconOutsideTeamListGold" : "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_IconOutsideTeamListNor.SP_IconOutsideTeamListNor";
			this.SetSpriteByPath(path, base.GetSprite(9), false, null, null);
		}

		// Token: 0x0602A59B RID: 173467 RVA: 0x00BF3C0D File Offset: 0x00BF1E0D
		public void RefreshRedDot()
		{
			base.GetItem(7).SetUIActive(this.Data.RedDotState);
		}

		// Token: 0x0602A59C RID: 173468 RVA: 0x00BF3C26 File Offset: 0x00BF1E26
		private void RefreshElement(int elementId)
		{
			this.ElementItem.Refresh((ECardElement)elementId, false, 0);
		}

		// Token: 0x0602A59D RID: 173469 RVA: 0x00BF3C36 File Offset: 0x00BF1E36
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0602A59E RID: 173470 RVA: 0x00BF3C49 File Offset: 0x00BF1E49
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602A59F RID: 173471 RVA: 0x00BF3C5C File Offset: 0x00BF1E5C
		private bool CanToggleExecuteChangeInternal()
		{
			return this.CanToggleChange == null || this.CanToggleChange(this);
		}

		// Token: 0x0602A5A0 RID: 173472 RVA: 0x00BF3C74 File Offset: 0x00BF1E74
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

		// Token: 0x0602A5A1 RID: 173473 RVA: 0x00BF3CE0 File Offset: 0x00BF1EE0
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

		// Token: 0x0602A5A2 RID: 173474 RVA: 0x00BF3D6A File Offset: 0x00BF1F6A
		private void OnToggleStateChangeInternal(EToggleState state)
		{
			Action<DeckBuilderCardSlotItem, EToggleState> onToggleStateChange = this.OnToggleStateChange;
			if (onToggleStateChange == null)
			{
				return;
			}
			onToggleStateChange(this, state);
		}

		// Token: 0x0602A5A3 RID: 173475 RVA: 0x00BF3D80 File Offset: 0x00BF1F80
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

		// Token: 0x0602A5A4 RID: 173476 RVA: 0x00BF3E18 File Offset: 0x00BF2018
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

		// Token: 0x0602A5A5 RID: 173477 RVA: 0x00BF3E4D File Offset: 0x00BF204D
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

		// Token: 0x0602A5A6 RID: 173478 RVA: 0x00BF3E7C File Offset: 0x00BF207C
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

		// Token: 0x0602A5A7 RID: 173479 RVA: 0x00BF3E9B File Offset: 0x00BF209B
		public DeckCardSlotInfo GetData()
		{
			IDeckBuilderCardSlotItemData data = this.Data;
			if (data == null)
			{
				return null;
			}
			return data.SlotInfo;
		}

		// Token: 0x0602A5A8 RID: 173480 RVA: 0x00BF3EAE File Offset: 0x00BF20AE
		public void TriggerLongPress()
		{
			Action<DeckBuilderCardSlotItem, float> longPressCallback = this.LongPressCallback;
			if (longPressCallback == null)
			{
				return;
			}
			longPressCallback(this, -1f);
		}

		// Token: 0x04017058 RID: 94296
		protected IDeckBuilderCardSlotItemData Data;

		// Token: 0x04017059 RID: 94297
		private CardElementItem ElementItem;

		// Token: 0x0401705A RID: 94298
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401705B RID: 94299
		private float HoldTime;

		// Token: 0x0401705C RID: 94300
		private int TickHandleId = -1;

		// Token: 0x0401705D RID: 94301
		public float LongPressStartTime;

		// Token: 0x0401705E RID: 94302
		public float LongPressEndTime;

		// Token: 0x0401705F RID: 94303
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<DeckBuilderCardSlotItem, bool> CanToggleChange;

		// Token: 0x04017060 RID: 94304
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem, float> LongPressCallback;

		// Token: 0x04017061 RID: 94305
		public Action LongPressEndCallback;

		// Token: 0x04017062 RID: 94306
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem> ShortClickCallback;

		// Token: 0x04017063 RID: 94307
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DeckBuilderCardSlotItem, EToggleState> OnToggleStateChange;

		// Token: 0x04017064 RID: 94308
		public Action<int> OnPointEnterCallback;

		// Token: 0x04017065 RID: 94309
		public Action OnPointExitCallback;

		// Token: 0x02009D3F RID: 40255
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030E6B RID: 200299
			public const int ItemToggle = 0;

			// Token: 0x04030E6C RID: 200300
			public const int CardSlotTexture = 1;

			// Token: 0x04030E6D RID: 200301
			public const int NameText = 2;

			// Token: 0x04030E6E RID: 200302
			public const int CostText = 3;

			// Token: 0x04030E6F RID: 200303
			public const int CountText = 4;

			// Token: 0x04030E70 RID: 200304
			public const int ElementItem = 5;

			// Token: 0x04030E71 RID: 200305
			public const int LockItem = 6;

			// Token: 0x04030E72 RID: 200306
			public const int RedDotItem = 7;

			// Token: 0x04030E73 RID: 200307
			public const int LineItem = 8;

			// Token: 0x04030E74 RID: 200308
			public const int BgSprite = 9;
		}
	}
}
