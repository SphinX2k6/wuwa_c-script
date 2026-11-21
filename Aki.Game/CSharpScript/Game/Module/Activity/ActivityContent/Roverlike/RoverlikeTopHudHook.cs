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
	// Token: 0x020050CD RID: 20685
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTopHudHook : IBattleTopPanelHook
	{
		// Token: 0x06033C4B RID: 212043 RVA: 0x00E7DCC4 File Offset: 0x00E7BEC4
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

		// Token: 0x06033C4C RID: 212044 RVA: 0x00E7DD0F File Offset: 0x00E7BF0F
		public void OnShow(TopPanel topPanel)
		{
			if (this.HudPanel == null)
			{
				return;
			}
			this.ApplyHide(true);
			this.HudPanel.StartShow();
		}

		// Token: 0x06033C4D RID: 212045 RVA: 0x00E7DD2C File Offset: 0x00E7BF2C
		public void OnHide(TopPanel topPanel)
		{
			RoverlikeBattleTopPanel hudPanel = this.HudPanel;
			if (hudPanel == null)
			{
				return;
			}
			hudPanel.EndShow();
		}

		// Token: 0x06033C4E RID: 212046 RVA: 0x00E7DD3E File Offset: 0x00E7BF3E
		public void OnAddEventListener(TopPanel topPanel)
		{
		}

		// Token: 0x06033C4F RID: 212047 RVA: 0x00E7DD40 File Offset: 0x00E7BF40
		public void OnRemoveEventListener(TopPanel topPanel)
		{
		}

		// Token: 0x06033C50 RID: 212048 RVA: 0x00E7DD42 File Offset: 0x00E7BF42
		public void OnRefresh(TopPanel topPanel)
		{
			this.ApplyHide(true);
		}

		// Token: 0x06033C51 RID: 212049 RVA: 0x00E7DD4B File Offset: 0x00E7BF4B
		public void OnReset(TopPanel topPanel)
		{
			this.ApplyHide(false);
			this.HudPanel = null;
		}

		// Token: 0x06033C52 RID: 212050 RVA: 0x00E7DD5C File Offset: 0x00E7BF5C
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

		// Token: 0x06033C53 RID: 212051 RVA: 0x00E7DDC8 File Offset: 0x00E7BFC8
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

		// Token: 0x0401B6FB RID: 112379
		[Nullable(2)]
		private RoverlikeBattleTopPanel HudPanel;

		// Token: 0x0401B6FC RID: 112380
		private readonly List<EBattleUiChild> HideChildren;
	}
}
