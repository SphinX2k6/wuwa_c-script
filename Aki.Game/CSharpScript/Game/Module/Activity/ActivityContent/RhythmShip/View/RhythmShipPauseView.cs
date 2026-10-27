using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x0200622E RID: 25134
	[NullableContext(2)]
	[Nullable(0)]
	public class RhythmShipPauseView : UiViewBase
	{
		// Token: 0x0603F5F9 RID: 259577 RVA: 0x00F51E64 File Offset: 0x00F50064
		[NullableContext(1)]
		public RhythmShipPauseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F5FA RID: 259578 RVA: 0x00F51E74 File Offset: 0x00F50074
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickExitBtn)),
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickReStartBtn)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickSetBtn))
			};
		}

		// Token: 0x0603F5FB RID: 259579 RVA: 0x00F51F64 File Offset: 0x00F50164
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipPauseView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipPauseView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F5FC RID: 259580 RVA: 0x00F51FA8 File Offset: 0x00F501A8
		protected override void OnStart()
		{
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
			RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(RhythmShipModel.Instance.RhythmShipLevelId);
			if (rhythmShipLevelById == null)
			{
				return;
			}
			this.PlanetType = (ERhythmShipPlanetType)RhythmShipConfig.Instance.GetRhythmShipPlanetById(rhythmShipLevelById.Value.Planet).Value.Type;
			SongDetailPanel songPanel = this.SongPanel;
			if (songPanel != null)
			{
				songPanel.RefreshPanel();
			}
			RoleDetailPanel rolePanel = this.RolePanel;
			if (rolePanel == null)
			{
				return;
			}
			rolePanel.RefreshPanel();
		}

		// Token: 0x0603F5FD RID: 259581 RVA: 0x00F52040 File Offset: 0x00F50240
		private void OnClickExitBtn()
		{
			RhythmGameController.Instance.OnStopRhythmGame(true);
			int rhythmShipLevelId = RhythmShipModel.Instance.RhythmShipLevelId;
			RhythmShipLevel? rhythmShipLevel;
			int? planetId = (RhythmShipConfig.Instance.GetRhythmShipLevelById(rhythmShipLevelId) != null) ? new int?(rhythmShipLevel.GetValueOrDefault().Planet) : null;
			RhythmShipChoseLevelViewData param = new RhythmShipChoseLevelViewData
			{
				OpenShowType = this.PlanetType,
				PlanetId = planetId,
				LevelId = new int?(rhythmShipLevelId),
				SubLevelId = new int?(RhythmShipModel.Instance.RhythmShipSubLevelId)
			};
			UiManager.Instance.OpenView(EUiViewName.RhythmShipChoseLevelView, param, null);
		}

		// Token: 0x0603F5FE RID: 259582 RVA: 0x00F520E5 File Offset: 0x00F502E5
		private void OnClickReStartBtn()
		{
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().Forget<bool>();
		}

		// Token: 0x0603F5FF RID: 259583 RVA: 0x00F520F6 File Offset: 0x00F502F6
		private void OnClickSetBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipSetView, null, null);
		}

		// Token: 0x04021169 RID: 135529
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402116A RID: 135530
		private SongDetailPanel SongPanel;

		// Token: 0x0402116B RID: 135531
		private RoleDetailPanel RolePanel;

		// Token: 0x0402116C RID: 135532
		private ERhythmShipPlanetType PlanetType = ERhythmShipPlanetType.Normal;
	}
}
