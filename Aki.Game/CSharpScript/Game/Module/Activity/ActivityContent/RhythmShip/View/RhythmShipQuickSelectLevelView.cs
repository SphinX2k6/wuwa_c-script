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
	// Token: 0x0200623B RID: 25147
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipQuickSelectLevelView : UiViewBase
	{
		// Token: 0x0603F616 RID: 259606 RVA: 0x00F52698 File Offset: 0x00F50898
		public RhythmShipQuickSelectLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F617 RID: 259607 RVA: 0x00F526B3 File Offset: 0x00F508B3
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateScrollViewComponent))
			};
		}

		// Token: 0x0603F618 RID: 259608 RVA: 0x00F526EC File Offset: 0x00F508EC
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipQuickSelectLevelView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipQuickSelectLevelView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F619 RID: 259609 RVA: 0x00F5272F File Offset: 0x00F5092F
		protected override void OnStart()
		{
			IRhythmShipQuickSelectLevelViewData rhythmShipQuickSelectLevelViewData = this.OpenParam as IRhythmShipQuickSelectLevelViewData;
			this.CurrentShowType = ((rhythmShipQuickSelectLevelViewData != null) ? rhythmShipQuickSelectLevelViewData.OpenShowType : ERhythmShipPlanetType.Normal);
		}

		// Token: 0x0603F61A RID: 259610 RVA: 0x00F52750 File Offset: 0x00F50950
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

		// Token: 0x0603F61B RID: 259611 RVA: 0x00F52888 File Offset: 0x00F50A88
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

		// Token: 0x04021183 RID: 135555
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021184 RID: 135556
		[Nullable(2)]
		private MultiTemplateScrollView PlanetMultiTemplateScrollView;

		// Token: 0x04021185 RID: 135557
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x04021186 RID: 135558
		private ERhythmShipPlanetType CurrentShowType = ERhythmShipPlanetType.Normal;
	}
}
