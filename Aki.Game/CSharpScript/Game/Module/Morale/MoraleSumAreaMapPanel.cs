using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200439D RID: 17309
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleSumAreaMapPanel : UiPanelBase
	{
		// Token: 0x0602BB88 RID: 179080 RVA: 0x00C45538 File Offset: 0x00C43738
		public UniTask Init(UUIItem item, MoraleAreaData areaData)
		{
			MoraleSumAreaMapPanel.<Init>d__4 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.areaData = areaData;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleSumAreaMapPanel.<Init>d__4>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB89 RID: 179081 RVA: 0x00C4558C File Offset: 0x00C4378C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnSelf))
			};
		}

		// Token: 0x0602BB8A RID: 179082 RVA: 0x00C4564C File Offset: 0x00C4384C
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleSumAreaMapPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleSumAreaMapPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB8B RID: 179083 RVA: 0x00C4568F File Offset: 0x00C4388F
		public void UpdateData()
		{
			this.AreaTitle.UpdateData();
			MoraleAreaPlotPanel areaPlotPanel = this.AreaPlotPanel;
			if (areaPlotPanel != null)
			{
				areaPlotPanel.UpdateData();
			}
			this.CheckAreaLight();
		}

		// Token: 0x0602BB8C RID: 179084 RVA: 0x00C456B3 File Offset: 0x00C438B3
		public void InitData()
		{
			this.AreaTitle.UpdateData();
			this.AreaPlotPanel.HideAllPlot();
			this.CheckAreaLight();
		}

		// Token: 0x0602BB8D RID: 179085 RVA: 0x00C456D4 File Offset: 0x00C438D4
		public void CheckAreaLight()
		{
			bool uiactive = this.AreaData.IsAllUiFlagActive();
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0602BB8E RID: 179086 RVA: 0x00C456FF File Offset: 0x00C438FF
		public void SetRecommendLightActive(bool active)
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x0602BB8F RID: 179087 RVA: 0x00C45713 File Offset: 0x00C43913
		private void OnBtnSelf()
		{
			UiManager.Instance.OpenView(EUiViewName.MoraleAreaInfoView, new MoraleAreaInfoView.Params
			{
				AreaId = this.AreaData.Id
			}, null);
		}

		// Token: 0x0602BB90 RID: 179088 RVA: 0x00C4573C File Offset: 0x00C4393C
		public UniTask PlayEnterEffect(IReadOnlyList<MoraleAreaPlotData> plotList)
		{
			MoraleSumAreaMapPanel.<PlayEnterEffect>d__12 <PlayEnterEffect>d__;
			<PlayEnterEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEnterEffect>d__.<>4__this = this;
			<PlayEnterEffect>d__.plotList = plotList;
			<PlayEnterEffect>d__.<>1__state = -1;
			<PlayEnterEffect>d__.<>t__builder.Start<MoraleSumAreaMapPanel.<PlayEnterEffect>d__12>(ref <PlayEnterEffect>d__);
			return <PlayEnterEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB91 RID: 179089 RVA: 0x00C45788 File Offset: 0x00C43988
		public UniTask PlayLoopEffect(IReadOnlyList<MoraleAreaPlotData> plotList)
		{
			MoraleSumAreaMapPanel.<PlayLoopEffect>d__13 <PlayLoopEffect>d__;
			<PlayLoopEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayLoopEffect>d__.<>4__this = this;
			<PlayLoopEffect>d__.plotList = plotList;
			<PlayLoopEffect>d__.<>1__state = -1;
			<PlayLoopEffect>d__.<>t__builder.Start<MoraleSumAreaMapPanel.<PlayLoopEffect>d__13>(ref <PlayLoopEffect>d__);
			return <PlayLoopEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB92 RID: 179090 RVA: 0x00C457D4 File Offset: 0x00C439D4
		public UniTask PlayNewUnlockEffect(IReadOnlyList<MoraleAreaPlotData> plotList)
		{
			MoraleSumAreaMapPanel.<PlayNewUnlockEffect>d__14 <PlayNewUnlockEffect>d__;
			<PlayNewUnlockEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayNewUnlockEffect>d__.<>4__this = this;
			<PlayNewUnlockEffect>d__.plotList = plotList;
			<PlayNewUnlockEffect>d__.<>1__state = -1;
			<PlayNewUnlockEffect>d__.<>t__builder.Start<MoraleSumAreaMapPanel.<PlayNewUnlockEffect>d__14>(ref <PlayNewUnlockEffect>d__);
			return <PlayNewUnlockEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB93 RID: 179091 RVA: 0x00C4581F File Offset: 0x00C43A1F
		public void LogIdList(List<int> idList, string title)
		{
		}

		// Token: 0x0602BB94 RID: 179092 RVA: 0x00C45824 File Offset: 0x00C43A24
		public List<MoraleAreaPlotItem> GetBelongCurAreaPlotItemList(IReadOnlyList<MoraleAreaPlotData> plotList)
		{
			Dictionary<int, MoraleAreaPlotItem> plotMap = this.AreaPlotPanel.PlotMap;
			List<MoraleAreaPlotItem> list = new List<MoraleAreaPlotItem>();
			for (int i = 0; i < plotList.Count; i++)
			{
				MoraleAreaPlotData moraleAreaPlotData = plotList[i];
				MoraleAreaPlotItem item;
				if (moraleAreaPlotData.AreaId == this.AreaData.Id && plotMap.TryGetValue(moraleAreaPlotData.Id, out item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0602BB95 RID: 179093 RVA: 0x00C45888 File Offset: 0x00C43A88
		public void OnTick(float delta)
		{
			for (int i = 0; i < this.AreaPlotPanel.PlotList.Count; i++)
			{
				this.AreaPlotPanel.PlotList[i].OnTick(delta);
			}
		}

		// Token: 0x04017912 RID: 96530
		public MoraleAreaData AreaData;

		// Token: 0x04017913 RID: 96531
		public MoraleSumAreaTitleItem AreaTitle;

		// Token: 0x04017914 RID: 96532
		public MoraleAreaPlotPanel AreaPlotPanel;

		// Token: 0x0200A094 RID: 41108
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031E40 RID: 204352
			public const int BtnSelf = 0;

			// Token: 0x04031E41 RID: 204353
			public const int ItemAreaTitle = 1;

			// Token: 0x04031E42 RID: 204354
			public const int TexMapBg = 2;

			// Token: 0x04031E43 RID: 204355
			public const int ItemPlotPanel = 3;

			// Token: 0x04031E44 RID: 204356
			public const int ItemAreaLight = 4;

			// Token: 0x04031E45 RID: 204357
			public const int ItemRecommendLight = 5;
		}
	}
}
