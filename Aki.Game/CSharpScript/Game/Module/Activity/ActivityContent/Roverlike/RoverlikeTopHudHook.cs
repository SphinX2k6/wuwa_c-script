using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200614F RID: 24911
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTopHudHook : IBattleTopPanelHook
	{
		// Token: 0x0603EF8B RID: 257931 RVA: 0x00F36DF0 File Offset: 0x00F34FF0
		public UniTask OnInitAsync(TopPanel topPanel)
		{
			RoverlikeTopHudHook.<OnInitAsync>d__2 <OnInitAsync>d__;
			<OnInitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnInitAsync>d__.<>4__this = this;
			<OnInitAsync>d__.topPanel = topPanel;
			<OnInitAsync>d__.<>1__state = -1;
			<OnInitAsync>d__.<>t__builder.Start<RoverlikeTopHudHook.<OnInitAsync>d__2>(ref <OnInitAsync>d__);
			return <OnInitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EF8C RID: 257932 RVA: 0x00F36E3B File Offset: 0x00F3503B
		public void OnShow(TopPanel topPanel)
		{
			if (this.HudPanel == null)
			{
				return;
			}
			this.ApplyHide(true);
			this.HudPanel.StartShow();
		}

		// Token: 0x0603EF8D RID: 257933 RVA: 0x00F36E58 File Offset: 0x00F35058
		public void OnHide(TopPanel topPanel)
		{
			RoverlikeBattleTopPanel hudPanel = this.HudPanel;
			if (hudPanel == null)
			{
				return;
			}
			hudPanel.EndShow();
		}

		// Token: 0x0603EF8E RID: 257934 RVA: 0x00F36E6A File Offset: 0x00F3506A
		public void OnAddEventListener(TopPanel topPanel)
		{
		}

		// Token: 0x0603EF8F RID: 257935 RVA: 0x00F36E6C File Offset: 0x00F3506C
		public void OnRemoveEventListener(TopPanel topPanel)
		{
		}

		// Token: 0x0603EF90 RID: 257936 RVA: 0x00F36E6E File Offset: 0x00F3506E
		public void OnRefresh(TopPanel topPanel)
		{
			this.ApplyHide(true);
		}

		// Token: 0x0603EF91 RID: 257937 RVA: 0x00F36E77 File Offset: 0x00F35077
		public void OnReset(TopPanel topPanel)
		{
			this.ApplyHide(false);
			this.HudPanel = null;
		}

		// Token: 0x0603EF92 RID: 257938 RVA: 0x00F36E88 File Offset: 0x00F35088
		private void ApplyHide(bool hide)
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			foreach (EBattleUiChild childType in this.HideChildren)
			{
				childViewData.SetChildVisible(EBattleUiVisibleReason.Custom, childType, !hide, true, 0);
			}
		}

		// Token: 0x0603EF93 RID: 257939 RVA: 0x00F36EF4 File Offset: 0x00F350F4
		public unsafe RoverlikeTopHudHook()
		{
			int num = 7;
			List<EBattleUiChild> list = new List<EBattleUiChild>(num);
			CollectionsMarshal.SetCount<EBattleUiChild>(list, num);
			Span<EBattleUiChild> span = CollectionsMarshal.AsSpan<EBattleUiChild>(list);
			int num2 = 0;
			*span[num2] = EBattleUiChild.MiniMap;
			num2++;
			*span[num2] = EBattleUiChild.TopButton;
			num2++;
			*span[num2] = EBattleUiChild.HomeButton;
			num2++;
			*span[num2] = EBattleUiChild.ExitButton;
			num2++;
			*span[num2] = EBattleUiChild.Formation;
			num2++;
			*span[num2] = EBattleUiChild.GamepadFormation;
			num2++;
			*span[num2] = EBattleUiChild.Chat;
			this.HideChildren = list;
			base..ctor();
		}

		// Token: 0x04020DCE RID: 134606
		[Nullable(2)]
		private RoverlikeBattleTopPanel HudPanel;

		// Token: 0x04020DCF RID: 134607
		private readonly List<EBattleUiChild> HideChildren;
	}
}
