using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055E7 RID: 21991
	[NullableContext(2)]
	[Nullable(0)]
	public class MapRoguePopupBase : UiPanelBase
	{
		// Token: 0x0603803C RID: 229436 RVA: 0x00D4469C File Offset: 0x00D4289C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnMaskBtnClick))
			};
		}

		// Token: 0x0603803D RID: 229437 RVA: 0x00D44748 File Offset: 0x00D42948
		protected override UniTask OnBeforeStartAsync()
		{
			MapRoguePopupBase.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRoguePopupBase.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603803E RID: 229438 RVA: 0x00D4478C File Offset: 0x00D4298C
		protected override void OnBeforeShow()
		{
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo == null)
			{
				return;
			}
			this.MoodBar.SetLimit(gameInfo.MoodMin, gameInfo.MoodMax);
			this.MoodBar.SetCurrentValue(gameInfo.Mood);
			int teamLvAnim = gameInfo.TeamLvAnim;
			this.PanelLv.SetLv(teamLvAnim, false);
			int lvCurrent = gameInfo.TeamLv;
			if (teamLvAnim == lvCurrent)
			{
				return;
			}
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.PanelLv.SetLv(lvCurrent, true);
			}, 500f, null, null, true, 1f);
		}

		// Token: 0x0603803F RID: 229439 RVA: 0x00D4482B File Offset: 0x00D42A2B
		private void OnBackBtnClick()
		{
			MapRogueController.Instance.OpenExploreEnd(false);
		}

		// Token: 0x06038040 RID: 229440 RVA: 0x00D44838 File Offset: 0x00D42A38
		private void OnMaskBtnClick()
		{
			Action onMaskClick = this.OnMaskClick;
			if (onMaskClick == null)
			{
				return;
			}
			onMaskClick();
		}

		// Token: 0x06038041 RID: 229441 RVA: 0x00D4484A File Offset: 0x00D42A4A
		private void OnBtnHelp()
		{
			MapRogueController.Instance.OpenMapHelpView();
		}

		// Token: 0x06038042 RID: 229442 RVA: 0x00D44858 File Offset: 0x00D42A58
		public void SetMaskButtonVisible(bool bVisible)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x06038043 RID: 229443 RVA: 0x00D4487F File Offset: 0x00D42A7F
		[NullableContext(1)]
		public void SetHelpCallBack(Action call)
		{
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetHelpCallBack(call);
		}

		// Token: 0x0401D6E4 RID: 120548
		protected LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x0401D6E5 RID: 120549
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401D6E6 RID: 120550
		protected MapRoguePanelLv PanelLv;

		// Token: 0x0401D6E7 RID: 120551
		protected MapRogueTitleItem MapTitleItem;

		// Token: 0x0401D6E8 RID: 120552
		public MapRogueMoodBar MoodBar;

		// Token: 0x0401D6E9 RID: 120553
		public Action OnMaskClick;

		// Token: 0x0401D6EA RID: 120554
		private const int LV_CHANGE_DELAY = 500;
	}
}
