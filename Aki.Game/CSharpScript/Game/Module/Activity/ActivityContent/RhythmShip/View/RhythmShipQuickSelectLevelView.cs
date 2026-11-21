using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051B9 RID: 20921
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipQuickSelectLevelView : UiViewBase
	{
		// Token: 0x060342D7 RID: 213719 RVA: 0x00E995F4 File Offset: 0x00E977F4
		public RhythmShipQuickSelectLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060342D8 RID: 213720 RVA: 0x00E9960F File Offset: 0x00E9780F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateScrollViewComponent))
			};
		}

		// Token: 0x060342D9 RID: 213721 RVA: 0x00E99648 File Offset: 0x00E97848
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipQuickSelectLevelView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipQuickSelectLevelView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060342DA RID: 213722 RVA: 0x00E9968B File Offset: 0x00E9788B
		protected override void OnStart()
		{
			IRhythmShipQuickSelectLevelViewData rhythmShipQuickSelectLevelViewData = this.OpenParam as IRhythmShipQuickSelectLevelViewData;
			this.CurrentShowType = ((rhythmShipQuickSelectLevelViewData != null) ? rhythmShipQuickSelectLevelViewData.OpenShowType : ERhythmShipPlanetType.Normal);
		}

		// Token: 0x060342DB RID: 213723 RVA: 0x00E996AC File Offset: 0x00E978AC
		private void InitScrollViewData()
		{
			foreach (int num in RhythmShipConfig.Instance.GetRhythmShipPlanetIdListByType((int)this.CurrentShowType, RhythmShipModel.Instance.ActivityId))
			{
				RhythmShipQuickSelectLevelData rhythmShipQuickSelectLevelData = new RhythmShipQuickSelectLevelData();
				RhythmShipPlanet? rhythmShipPlanet;
				string titleText = ((RhythmShipConfig.Instance.GetRhythmShipPlanetById(num) != null) ? rhythmShipPlanet.GetValueOrDefault().Name : null) ?? "";
				rhythmShipQuickSelectLevelData.TitleText = titleText;
				RhythmShipQuickSelectLevelGirdItemTitleData item = new RhythmShipQuickSelectLevelGirdItemTitleData(rhythmShipQuickSelectLevelData);
				this.ScrollDataList.Add(item);
				List<int> rhythmShipLevelIdListByPlanet = RhythmShipConfig.Instance.GetRhythmShipLevelIdListByPlanet(num);
				if (rhythmShipLevelIdListByPlanet != null)
				{
					foreach (int levelConfig in rhythmShipLevelIdListByPlanet)
					{
						RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevelData rhythmShipQuickSelectLevelGirdItemLevelData = new RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevelData(new RhythmShipQuickSelectLevelData
						{
							LevelConfig = levelConfig
						});
						rhythmShipQuickSelectLevelGirdItemLevelData.OnClickButtonCallBack = new Action<int>(this.OnClickLevelItemClick);
						this.ScrollDataList.Add(rhythmShipQuickSelectLevelGirdItemLevelData);
					}
				}
			}
		}

		// Token: 0x060342DC RID: 213724 RVA: 0x00E997E4 File Offset: 0x00E979E4
		private void OnClickLevelItemClick(int levelId)
		{
			if (!RhythmShipModel.Instance.GetLevelIsUnlock(levelId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(RhythmShipModel.Instance.GetLevelLockTips(levelId) ?? "RhythmShipLevelLockTips", Array.Empty<object>());
				return;
			}
			RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(levelId);
			if (rhythmShipLevelById == null)
			{
				return;
			}
			RhythmShipPlanet? rhythmShipPlanetById = RhythmShipConfig.Instance.GetRhythmShipPlanetById(rhythmShipLevelById.Value.Planet);
			if (rhythmShipPlanetById == null)
			{
				return;
			}
			EventSystem.Instance.Emit<int, int, int>(EEventName.OnRhythmShipJumpLevel, rhythmShipPlanetById.Value.Type, rhythmShipPlanetById.Value.Id, levelId);
			base.CloseMe(null);
		}

		// Token: 0x0401BAB2 RID: 113330
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BAB3 RID: 113331
		[Nullable(2)]
		private MultiTemplateScrollView PlanetMultiTemplateScrollView;

		// Token: 0x0401BAB4 RID: 113332
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401BAB5 RID: 113333
		private ERhythmShipPlanetType CurrentShowType = ERhythmShipPlanetType.Normal;
	}
}
