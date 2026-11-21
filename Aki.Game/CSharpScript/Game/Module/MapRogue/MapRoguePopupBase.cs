using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045BD RID: 17853
	[NullableContext(2)]
	[Nullable(0)]
	public class MapRoguePopupBase : UiPanelBase
	{
		// Token: 0x0602CF3A RID: 184122 RVA: 0x00C923E4 File Offset: 0x00C905E4
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

		// Token: 0x0602CF3B RID: 184123 RVA: 0x00C92490 File Offset: 0x00C90690
		protected override UniTask OnBeforeStartAsync()
		{
			MapRoguePopupBase.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRoguePopupBase.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CF3C RID: 184124 RVA: 0x00C924D4 File Offset: 0x00C906D4
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

		// Token: 0x0602CF3D RID: 184125 RVA: 0x00C92573 File Offset: 0x00C90773
		private void OnBackBtnClick()
		{
			MapRogueController.Instance.OpenExploreEnd(false);
		}

		// Token: 0x0602CF3E RID: 184126 RVA: 0x00C92580 File Offset: 0x00C90780
		private void OnMaskBtnClick()
		{
			Action onMaskClick = this.OnMaskClick;
			if (onMaskClick == null)
			{
				return;
			}
			onMaskClick();
		}

		// Token: 0x0602CF3F RID: 184127 RVA: 0x00C92592 File Offset: 0x00C90792
		private void OnBtnHelp()
		{
			MapRogueController.Instance.OpenMapHelpView();
		}

		// Token: 0x0602CF40 RID: 184128 RVA: 0x00C925A0 File Offset: 0x00C907A0
		public void SetMaskButtonVisible(bool bVisible)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x0602CF41 RID: 184129 RVA: 0x00C925C7 File Offset: 0x00C907C7
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

		// Token: 0x0401816F RID: 98671
		protected LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x04018170 RID: 98672
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04018171 RID: 98673
		protected MapRoguePanelLv PanelLv;

		// Token: 0x04018172 RID: 98674
		protected MapRogueTitleItem MapTitleItem;

		// Token: 0x04018173 RID: 98675
		public MapRogueMoodBar MoodBar;

		// Token: 0x04018174 RID: 98676
		public Action OnMaskClick;

		// Token: 0x04018175 RID: 98677
		private const int LV_CHANGE_DELAY = 500;
	}
}
