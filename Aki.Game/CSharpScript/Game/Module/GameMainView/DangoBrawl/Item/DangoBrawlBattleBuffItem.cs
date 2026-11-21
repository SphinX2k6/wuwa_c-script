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
	// Token: 0x020049E9 RID: 18921
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlBattleBuffItem : GridProxyAbstract<DangoBrawlBattleBuffItemData>
	{
		// Token: 0x0602F69A RID: 194202 RVA: 0x00D390C0 File Offset: 0x00D372C0
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

		// Token: 0x0602F69B RID: 194203 RVA: 0x00D391CC File Offset: 0x00D373CC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlBattleBuffItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlBattleBuffItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F69C RID: 194204 RVA: 0x00D39210 File Offset: 0x00D37410
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

		// Token: 0x0602F69D RID: 194205 RVA: 0x00D39266 File Offset: 0x00D37466
		protected override void OnBeforeDestroy()
		{
			this.ClearBuffTipsHover();
		}

		// Token: 0x0602F69E RID: 194206 RVA: 0x00D39270 File Offset: 0x00D37470
		private UniTask CreateBuffTips()
		{
			DangoBrawlBattleBuffItem.<CreateBuffTips>d__14 <CreateBuffTips>d__;
			<CreateBuffTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuffTips>d__.<>4__this = this;
			<CreateBuffTips>d__.<>1__state = -1;
			<CreateBuffTips>d__.<>t__builder.Start<DangoBrawlBattleBuffItem.<CreateBuffTips>d__14>(ref <CreateBuffTips>d__);
			return <CreateBuffTips>d__.<>t__builder.Task;
		}

		// Token: 0x0602F69F RID: 194207 RVA: 0x00D392B3 File Offset: 0x00D374B3
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

		// Token: 0x0602F6A0 RID: 194208 RVA: 0x00D392E4 File Offset: 0x00D374E4
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

		// Token: 0x0602F6A1 RID: 194209 RVA: 0x00D3933D File Offset: 0x00D3753D
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

		// Token: 0x0602F6A2 RID: 194210 RVA: 0x00D3936A File Offset: 0x00D3756A
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

		// Token: 0x0602F6A3 RID: 194211 RVA: 0x00D39394 File Offset: 0x00D37594
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

		// Token: 0x0602F6A4 RID: 194212 RVA: 0x00D393E0 File Offset: 0x00D375E0
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

		// Token: 0x0602F6A5 RID: 194213 RVA: 0x00D3943C File Offset: 0x00D3763C
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

		// Token: 0x0602F6A6 RID: 194214 RVA: 0x00D394B0 File Offset: 0x00D376B0
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

		// Token: 0x0602F6A7 RID: 194215 RVA: 0x00D394F0 File Offset: 0x00D376F0
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

		// Token: 0x0602F6A8 RID: 194216 RVA: 0x00D39536 File Offset: 0x00D37736
		private void HandleBuffRemove(DangoBrawlBattleBuffItemData data)
		{
			this.SetBuffActive(false);
			this.SetBuffNum(0);
		}

		// Token: 0x0602F6A9 RID: 194217 RVA: 0x00D39546 File Offset: 0x00D37746
		public override object GetKey(DangoBrawlBattleBuffItemData data, int displayIndex)
		{
			return data.ConfigId;
		}

		// Token: 0x0602F6AA RID: 194218 RVA: 0x00D39553 File Offset: 0x00D37753
		private static bool CanHoverBuffTips()
		{
			return !Info.Instance.IsMobileInputModel();
		}

		// Token: 0x0602F6AB RID: 194219 RVA: 0x00D39562 File Offset: 0x00D37762
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

		// Token: 0x0602F6AC RID: 194220 RVA: 0x00D3958B File Offset: 0x00D3778B
		private void OnBuffTipsPointExit()
		{
			if (!DangoBrawlBattleBuffItem.CanHoverBuffTips() || !this.IsBuffActivate)
			{
				return;
			}
			this.ScheduleTipsHoverHide();
		}

		// Token: 0x0602F6AD RID: 194221 RVA: 0x00D395A3 File Offset: 0x00D377A3
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

		// Token: 0x0602F6AE RID: 194222 RVA: 0x00D395D4 File Offset: 0x00D377D4
		private void CancelTipsHoverHideTimer()
		{
			TimerHandle tipsHoverHideTimer = this.TipsHoverHideTimer;
			if (tipsHoverHideTimer != null)
			{
				tipsHoverHideTimer.Remove();
			}
			this.TipsHoverHideTimer = null;
		}

		// Token: 0x0602F6AF RID: 194223 RVA: 0x00D395EF File Offset: 0x00D377EF
		private void CloseBuffTips()
		{
			this.CancelTipsHoverHideTimer();
			DangoBrawlSmallTips buffTips = this.BuffTips;
			if (buffTips != null && buffTips.GetActive())
			{
				this.BuffTips.Hide();
			}
		}

		// Token: 0x0602F6B0 RID: 194224 RVA: 0x00D39616 File Offset: 0x00D37816
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

		// Token: 0x040191FD RID: 102909
		[Nullable(2)]
		public Action<int> OnClickBuff;

		// Token: 0x040191FE RID: 102910
		private int CurBuffConfigId;

		// Token: 0x040191FF RID: 102911
		private int CurFloorValue;

		// Token: 0x04019200 RID: 102912
		private bool IsBuffActivate;

		// Token: 0x04019201 RID: 102913
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04019202 RID: 102914
		[Nullable(2)]
		private DangoBrawlSmallTips BuffTips;

		// Token: 0x04019203 RID: 102915
		[Nullable(2)]
		private TimerHandle TipsHoverHideTimer;

		// Token: 0x04019204 RID: 102916
		private const string SEQ_BUFF_ADD = "BuffUp";

		// Token: 0x04019205 RID: 102917
		private const string SEQ_BUFF_UP = "BuffStart";

		// Token: 0x0200A67C RID: 42620
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x0403378D RID: 210829
			TexBuffDisactive,
			// Token: 0x0403378E RID: 210830
			TexBuffActive,
			// Token: 0x0403378F RID: 210831
			TxtBuffNum,
			// Token: 0x04033790 RID: 210832
			BtnBuffDetail,
			// Token: 0x04033791 RID: 210833
			BuffDetailTips
		}
	}
}
