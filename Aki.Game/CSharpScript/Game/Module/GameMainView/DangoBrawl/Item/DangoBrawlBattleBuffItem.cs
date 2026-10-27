using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x02005A0D RID: 23053
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlBattleBuffItem : GridProxyAbstract<DangoBrawlBattleBuffItemData>
	{
		// Token: 0x0603A751 RID: 239441 RVA: 0x00DE8B40 File Offset: 0x00DE6D40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITextureTransitionComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnBuffDetail));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603A752 RID: 239442 RVA: 0x00DE8C4C File Offset: 0x00DE6E4C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlBattleBuffItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlBattleBuffItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A753 RID: 239443 RVA: 0x00DE8C90 File Offset: 0x00DE6E90
		protected override void OnStart()
		{
			UUITexture texture = base.GetTexture(0);
			UUITextureTransitionComponent uiTextureTransitionComponent = base.GetUiTextureTransitionComponent(1);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			if (uiTextureTransitionComponent != null)
			{
				UUIItem uuiitem = uiTextureTransitionComponent.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
			}
			this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0603A754 RID: 239444 RVA: 0x00DE8CE6 File Offset: 0x00DE6EE6
		protected override void OnBeforeDestroy()
		{
			this.ClearBuffTipsHover();
		}

		// Token: 0x0603A755 RID: 239445 RVA: 0x00DE8CF0 File Offset: 0x00DE6EF0
		private UniTask CreateBuffTips()
		{
			DangoBrawlBattleBuffItem.<CreateBuffTips>d__14 <CreateBuffTips>d__;
			<CreateBuffTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuffTips>d__.<>4__this = this;
			<CreateBuffTips>d__.<>1__state = -1;
			<CreateBuffTips>d__.<>t__builder.Start<DangoBrawlBattleBuffItem.<CreateBuffTips>d__14>(ref <CreateBuffTips>d__);
			return <CreateBuffTips>d__.<>t__builder.Task;
		}

		// Token: 0x0603A756 RID: 239446 RVA: 0x00DE8D33 File Offset: 0x00DE6F33
		private void ClearBuffTipsHover()
		{
			this.CancelTipsHoverHideTimer();
			UUIButtonComponent button = base.GetButton(3);
			if (button != null)
			{
				button.OnPointEnterCallBack.Unbind();
			}
			if (button == null)
			{
				return;
			}
			button.OnPointExitCallBack.Unbind();
		}

		// Token: 0x0603A757 RID: 239447 RVA: 0x00DE8D64 File Offset: 0x00DE6F64
		private void SetBuffActive(bool isActivate)
		{
			this.IsBuffActivate = isActivate;
			UUITexture texture = base.GetTexture(0);
			if (texture != null)
			{
				texture.SetUIActive(!isActivate);
			}
			UUITextureTransitionComponent uiTextureTransitionComponent = base.GetUiTextureTransitionComponent(1);
			if (uiTextureTransitionComponent != null)
			{
				UUIItem uuiitem = uiTextureTransitionComponent.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(isActivate);
				}
			}
			if (!isActivate)
			{
				this.CloseBuffTips();
			}
		}

		// Token: 0x0603A758 RID: 239448 RVA: 0x00DE8DBD File Offset: 0x00DE6FBD
		private void SetBuffNum(int floorValue)
		{
			this.CurFloorValue = floorValue;
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText((floorValue <= 0) ? string.Empty : floorValue.ToString(), true);
		}

		// Token: 0x0603A759 RID: 239449 RVA: 0x00DE8DEA File Offset: 0x00DE6FEA
		public override void Refresh(DangoBrawlBattleBuffItemData data, bool isSelected, int gridIndex)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopCurrentSequence(false, true);
			}
			this.RefreshInternal(data).Forget();
			this.HandleBuffByOperation(data);
		}

		// Token: 0x0603A75A RID: 239450 RVA: 0x00DE8E14 File Offset: 0x00DE7014
		private UniTask RefreshInternal(DangoBrawlBattleBuffItemData data)
		{
			DangoBrawlBattleBuffItem.<RefreshInternal>d__19 <RefreshInternal>d__;
			<RefreshInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshInternal>d__.<>4__this = this;
			<RefreshInternal>d__.data = data;
			<RefreshInternal>d__.<>1__state = -1;
			<RefreshInternal>d__.<>t__builder.Start<DangoBrawlBattleBuffItem.<RefreshInternal>d__19>(ref <RefreshInternal>d__);
			return <RefreshInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0603A75B RID: 239451 RVA: 0x00DE8E60 File Offset: 0x00DE7060
		private UniTask LoadAllTextures(string grayIcon, string icon, string holdIcon)
		{
			DangoBrawlBattleBuffItem.<LoadAllTextures>d__20 <LoadAllTextures>d__;
			<LoadAllTextures>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadAllTextures>d__.<>4__this = this;
			<LoadAllTextures>d__.grayIcon = grayIcon;
			<LoadAllTextures>d__.icon = icon;
			<LoadAllTextures>d__.holdIcon = holdIcon;
			<LoadAllTextures>d__.<>1__state = -1;
			<LoadAllTextures>d__.<>t__builder.Start<DangoBrawlBattleBuffItem.<LoadAllTextures>d__20>(ref <LoadAllTextures>d__);
			return <LoadAllTextures>d__.<>t__builder.Task;
		}

		// Token: 0x0603A75C RID: 239452 RVA: 0x00DE8EBC File Offset: 0x00DE70BC
		private void HandleBuffByOperation(DangoBrawlBattleBuffItemData data)
		{
			EDangoBrawlBuffVisualOp? operation = data.Operation;
			if (operation != null)
			{
				if (operation != null)
				{
					switch (operation.GetValueOrDefault())
					{
					case EDangoBrawlBuffVisualOp.Add:
						this.HandleBuffAdd(data);
						return;
					case EDangoBrawlBuffVisualOp.StackChange:
						this.HandleBuffStackChange(data);
						return;
					case EDangoBrawlBuffVisualOp.Remove:
						this.HandleBuffRemove(data);
						return;
					default:
						return;
					}
				}
			}
			else
			{
				this.SetBuffActive(data.IsActivate);
				this.SetBuffNum(data.FloorValue);
			}
		}

		// Token: 0x0603A75D RID: 239453 RVA: 0x00DE8F30 File Offset: 0x00DE7130
		private void HandleBuffAdd(DangoBrawlBattleBuffItemData data)
		{
			this.SetBuffActive(true);
			this.SetBuffNum(data.FloorValue);
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("BuffUp", false, null, false);
		}

		// Token: 0x0603A75E RID: 239454 RVA: 0x00DE8F70 File Offset: 0x00DE7170
		private void HandleBuffStackChange(DangoBrawlBattleBuffItemData data)
		{
			int curFloorValue = this.CurFloorValue;
			int floorValue = data.FloorValue;
			this.SetBuffNum(floorValue);
			if (floorValue > curFloorValue)
			{
				LevelSequencePlayer seqPlayer = this.SeqPlayer;
				if (seqPlayer == null)
				{
					return;
				}
				seqPlayer.PlayLevelSequenceByName("BuffStart", false, null, false);
			}
		}

		// Token: 0x0603A75F RID: 239455 RVA: 0x00DE8FB6 File Offset: 0x00DE71B6
		private void HandleBuffRemove(DangoBrawlBattleBuffItemData data)
		{
			this.SetBuffActive(false);
			this.SetBuffNum(0);
		}

		// Token: 0x0603A760 RID: 239456 RVA: 0x00DE8FC6 File Offset: 0x00DE71C6
		public override object GetKey(DangoBrawlBattleBuffItemData data, int displayIndex)
		{
			return data.ConfigId;
		}

		// Token: 0x0603A761 RID: 239457 RVA: 0x00DE8FD3 File Offset: 0x00DE71D3
		private static bool CanHoverBuffTips()
		{
			return !Info.Instance.IsMobileInputModel();
		}

		// Token: 0x0603A762 RID: 239458 RVA: 0x00DE8FE2 File Offset: 0x00DE71E2
		private void OnBuffTipsPointEnter()
		{
			if (!DangoBrawlBattleBuffItem.CanHoverBuffTips() || !this.IsBuffActivate)
			{
				return;
			}
			this.CancelTipsHoverHideTimer();
			DangoBrawlSmallTips buffTips = this.BuffTips;
			if (buffTips == null)
			{
				return;
			}
			buffTips.Show(false);
		}

		// Token: 0x0603A763 RID: 239459 RVA: 0x00DE900B File Offset: 0x00DE720B
		private void OnBuffTipsPointExit()
		{
			if (!DangoBrawlBattleBuffItem.CanHoverBuffTips() || !this.IsBuffActivate)
			{
				return;
			}
			this.ScheduleTipsHoverHide();
		}

		// Token: 0x0603A764 RID: 239460 RVA: 0x00DE9023 File Offset: 0x00DE7223
		private void ScheduleTipsHoverHide()
		{
			this.CancelTipsHoverHideTimer();
			this.TipsHoverHideTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.TipsHoverHideTimer = null;
				DangoBrawlSmallTips buffTips = this.BuffTips;
				if (buffTips == null)
				{
					return;
				}
				buffTips.Hide();
			}, 50f, null, null, true, 1f);
		}

		// Token: 0x0603A765 RID: 239461 RVA: 0x00DE9054 File Offset: 0x00DE7254
		private void CancelTipsHoverHideTimer()
		{
			TimerHandle tipsHoverHideTimer = this.TipsHoverHideTimer;
			if (tipsHoverHideTimer != null)
			{
				tipsHoverHideTimer.Remove();
			}
			this.TipsHoverHideTimer = null;
		}

		// Token: 0x0603A766 RID: 239462 RVA: 0x00DE906F File Offset: 0x00DE726F
		private void CloseBuffTips()
		{
			this.CancelTipsHoverHideTimer();
			DangoBrawlSmallTips buffTips = this.BuffTips;
			if (buffTips != null && buffTips.GetActive())
			{
				this.BuffTips.Hide();
			}
		}

		// Token: 0x0603A767 RID: 239463 RVA: 0x00DE9096 File Offset: 0x00DE7296
		private void OnClickBtnBuffDetail()
		{
			this.CloseBuffTips();
			Action<int> onClickBuff = this.OnClickBuff;
			if (onClickBuff == null)
			{
				return;
			}
			onClickBuff(this.CurBuffConfigId);
		}

		// Token: 0x0401E756 RID: 124758
		[Nullable(2)]
		public Action<int> OnClickBuff;

		// Token: 0x0401E757 RID: 124759
		private int CurBuffConfigId;

		// Token: 0x0401E758 RID: 124760
		private int CurFloorValue;

		// Token: 0x0401E759 RID: 124761
		private bool IsBuffActivate;

		// Token: 0x0401E75A RID: 124762
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401E75B RID: 124763
		[Nullable(2)]
		private DangoBrawlSmallTips BuffTips;

		// Token: 0x0401E75C RID: 124764
		[Nullable(2)]
		private TimerHandle TipsHoverHideTimer;

		// Token: 0x0401E75D RID: 124765
		private const string SEQ_BUFF_ADD = "BuffUp";

		// Token: 0x0401E75E RID: 124766
		private const string SEQ_BUFF_UP = "BuffStart";

		// Token: 0x0200BC73 RID: 48243
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04038DC1 RID: 232897
			TexBuffDisactive,
			// Token: 0x04038DC2 RID: 232898
			TexBuffActive,
			// Token: 0x04038DC3 RID: 232899
			TxtBuffNum,
			// Token: 0x04038DC4 RID: 232900
			BtnBuffDetail,
			// Token: 0x04038DC5 RID: 232901
			BuffDetailTips
		}
	}
}
