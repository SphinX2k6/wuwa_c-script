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
	// Token: 0x020051AC RID: 20908
	[NullableContext(2)]
	[Nullable(0)]
	public class RhythmShipPauseView : UiViewBase
	{
		// Token: 0x060342BA RID: 213690 RVA: 0x00E98DBD File Offset: 0x00E96FBD
		[NullableContext(1)]
		public RhythmShipPauseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060342BB RID: 213691 RVA: 0x00E98DD0 File Offset: 0x00E96FD0
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

		// Token: 0x060342BC RID: 213692 RVA: 0x00E98EC0 File Offset: 0x00E970C0
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipPauseView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipPauseView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060342BD RID: 213693 RVA: 0x00E98F04 File Offset: 0x00E97104
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

		// Token: 0x060342BE RID: 213694 RVA: 0x00E98F9C File Offset: 0x00E9719C
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

		// Token: 0x060342BF RID: 213695 RVA: 0x00E99041 File Offset: 0x00E97241
		private void OnClickReStartBtn()
		{
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).Forget<bool>();
		}

		// Token: 0x060342C0 RID: 213696 RVA: 0x00E99053 File Offset: 0x00E97253
		private void OnClickSetBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipSetView, null, null);
		}

		// Token: 0x0401BA98 RID: 113304
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BA99 RID: 113305
		private SongDetailPanel SongPanel;

		// Token: 0x0401BA9A RID: 113306
		private RoleDetailPanel RolePanel;

		// Token: 0x0401BA9B RID: 113307
		private ERhythmShipPlanetType PlanetType = ERhythmShipPlanetType.Normal;
	}
}
