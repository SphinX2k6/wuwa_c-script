using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053BA RID: 21434
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleSumAreaMapPanel : UiPanelBase
	{
		// Token: 0x06036C42 RID: 224322 RVA: 0x00CF6490 File Offset: 0x00CF4690
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

		// Token: 0x06036C43 RID: 224323 RVA: 0x00CF64E4 File Offset: 0x00CF46E4
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

		// Token: 0x06036C44 RID: 224324 RVA: 0x00CF65A4 File Offset: 0x00CF47A4
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleSumAreaMapPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleSumAreaMapPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036C45 RID: 224325 RVA: 0x00CF65E7 File Offset: 0x00CF47E7
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

		// Token: 0x06036C46 RID: 224326 RVA: 0x00CF660B File Offset: 0x00CF480B
		public void InitData()
		{
			this.AreaTitle.UpdateData();
			this.AreaPlotPanel.HideAllPlot();
			this.CheckAreaLight();
		}

		// Token: 0x06036C47 RID: 224327 RVA: 0x00CF662C File Offset: 0x00CF482C
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

		// Token: 0x06036C48 RID: 224328 RVA: 0x00CF6657 File Offset: 0x00CF4857
		public void SetRecommendLightActive(bool active)
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06036C49 RID: 224329 RVA: 0x00CF666B File Offset: 0x00CF486B
		private void OnBtnSelf()
		{
			UiManager.Instance.OpenView(EUiViewName.MoraleAreaInfoView, new MoraleAreaInfoView.Params
			{
				AreaId = this.AreaData.Id
			}, null);
		}

		// Token: 0x06036C4A RID: 224330 RVA: 0x00CF6694 File Offset: 0x00CF4894
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

		// Token: 0x06036C4B RID: 224331 RVA: 0x00CF66E0 File Offset: 0x00CF48E0
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

		// Token: 0x06036C4C RID: 224332 RVA: 0x00CF672C File Offset: 0x00CF492C
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

		// Token: 0x06036C4D RID: 224333 RVA: 0x00CF6777 File Offset: 0x00CF4977
		public void LogIdList(List<int> idList, string title)
		{
		}

		// Token: 0x06036C4E RID: 224334 RVA: 0x00CF677C File Offset: 0x00CF497C
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

		// Token: 0x06036C4F RID: 224335 RVA: 0x00CF67E0 File Offset: 0x00CF49E0
		public void OnTick(float delta)
		{
			for (int i = 0; i < this.AreaPlotPanel.PlotList.Count; i++)
			{
				this.AreaPlotPanel.PlotList[i].OnTick(delta);
			}
		}

		// Token: 0x0401CE7A RID: 118394
		public MoraleAreaData AreaData;

		// Token: 0x0401CE7B RID: 118395
		public MoraleSumAreaTitleItem AreaTitle;

		// Token: 0x0401CE7C RID: 118396
		public MoraleAreaPlotPanel AreaPlotPanel;

		// Token: 0x0200B65C RID: 46684
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040373EB RID: 226283
			public const int BtnSelf = 0;

			// Token: 0x040373EC RID: 226284
			public const int ItemAreaTitle = 1;

			// Token: 0x040373ED RID: 226285
			public const int TexMapBg = 2;

			// Token: 0x040373EE RID: 226286
			public const int ItemPlotPanel = 3;

			// Token: 0x040373EF RID: 226287
			public const int ItemAreaLight = 4;

			// Token: 0x040373F0 RID: 226288
			public const int ItemRecommendLight = 5;
		}
	}
}
