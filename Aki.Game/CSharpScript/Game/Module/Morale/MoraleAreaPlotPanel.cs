using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200539E RID: 21406
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaPlotPanel : UiPanelBase
	{
		// Token: 0x06036B15 RID: 224021 RVA: 0x00CF1CBC File Offset: 0x00CEFEBC
		public UniTask Init(UUIItem item, MoraleAreaData areaData)
		{
			MoraleAreaPlotPanel.<Init>d__5 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.areaData = areaData;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleAreaPlotPanel.<Init>d__5>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06036B16 RID: 224022 RVA: 0x00CF1D10 File Offset: 0x00CEFF10
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < this.AllPlotIdList.Count; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x06036B17 RID: 224023 RVA: 0x00CF1D5C File Offset: 0x00CEFF5C
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaPlotPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaPlotPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036B18 RID: 224024 RVA: 0x00CF1DA0 File Offset: 0x00CEFFA0
		private UniTask InitAreaPlotList()
		{
			MoraleAreaPlotPanel.<InitAreaPlotList>d__8 <InitAreaPlotList>d__;
			<InitAreaPlotList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAreaPlotList>d__.<>4__this = this;
			<InitAreaPlotList>d__.<>1__state = -1;
			<InitAreaPlotList>d__.<>t__builder.Start<MoraleAreaPlotPanel.<InitAreaPlotList>d__8>(ref <InitAreaPlotList>d__);
			return <InitAreaPlotList>d__.<>t__builder.Task;
		}

		// Token: 0x06036B19 RID: 224025 RVA: 0x00CF1DE4 File Offset: 0x00CEFFE4
		private void AddAreaPlotItem(MoraleAreaPlotItem item)
		{
			this.PlotList.Add(item);
			this.PlotMap[item.PlotData.Id] = item;
			int flagId = item.PlotData.FlagId;
			List<MoraleAreaPlotItem> list;
			if (this.FlagToPlotMap.TryGetValue(flagId, out list))
			{
				list.Add(item);
				return;
			}
			this.FlagToPlotMap[flagId] = new List<MoraleAreaPlotItem>
			{
				item
			};
		}

		// Token: 0x06036B1A RID: 224026 RVA: 0x00CF1E50 File Offset: 0x00CF0050
		public void UpdatePlotState()
		{
			foreach (MoraleAreaPlotItem moraleAreaPlotItem in this.PlotList)
			{
				moraleAreaPlotItem.UpdatePlotState();
			}
		}

		// Token: 0x06036B1B RID: 224027 RVA: 0x00CF1EA0 File Offset: 0x00CF00A0
		public void HideAllPlot()
		{
			foreach (MoraleAreaPlotItem moraleAreaPlotItem in this.PlotList)
			{
				moraleAreaPlotItem.SetPlotActive(false);
			}
		}

		// Token: 0x06036B1C RID: 224028 RVA: 0x00CF1EF4 File Offset: 0x00CF00F4
		public void ShowAllPlot()
		{
			foreach (MoraleAreaPlotItem moraleAreaPlotItem in this.PlotList)
			{
				moraleAreaPlotItem.SetPlotActive(true);
			}
		}

		// Token: 0x06036B1D RID: 224029 RVA: 0x00CF1F48 File Offset: 0x00CF0148
		public void UpdateData()
		{
			this.UpdatePlotState();
		}

		// Token: 0x0401CE2F RID: 118319
		public MoraleAreaData AreaData;

		// Token: 0x0401CE30 RID: 118320
		public readonly List<MoraleAreaPlotItem> PlotList = new List<MoraleAreaPlotItem>();

		// Token: 0x0401CE31 RID: 118321
		public readonly Dictionary<int, List<MoraleAreaPlotItem>> FlagToPlotMap = new Dictionary<int, List<MoraleAreaPlotItem>>();

		// Token: 0x0401CE32 RID: 118322
		public readonly Dictionary<int, MoraleAreaPlotItem> PlotMap = new Dictionary<int, MoraleAreaPlotItem>();

		// Token: 0x0401CE33 RID: 118323
		public IReadOnlyList<int> AllPlotIdList;
	}
}
