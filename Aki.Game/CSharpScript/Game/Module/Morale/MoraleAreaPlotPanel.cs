using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004381 RID: 17281
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaPlotPanel : UiPanelBase
	{
		// Token: 0x0602BA5B RID: 178779 RVA: 0x00C40D64 File Offset: 0x00C3EF64
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

		// Token: 0x0602BA5C RID: 178780 RVA: 0x00C40DB8 File Offset: 0x00C3EFB8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < this.AllPlotIdList.Count; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x0602BA5D RID: 178781 RVA: 0x00C40E04 File Offset: 0x00C3F004
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaPlotPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaPlotPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA5E RID: 178782 RVA: 0x00C40E48 File Offset: 0x00C3F048
		private UniTask InitAreaPlotList()
		{
			MoraleAreaPlotPanel.<InitAreaPlotList>d__8 <InitAreaPlotList>d__;
			<InitAreaPlotList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAreaPlotList>d__.<>4__this = this;
			<InitAreaPlotList>d__.<>1__state = -1;
			<InitAreaPlotList>d__.<>t__builder.Start<MoraleAreaPlotPanel.<InitAreaPlotList>d__8>(ref <InitAreaPlotList>d__);
			return <InitAreaPlotList>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA5F RID: 178783 RVA: 0x00C40E8C File Offset: 0x00C3F08C
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

		// Token: 0x0602BA60 RID: 178784 RVA: 0x00C40EF8 File Offset: 0x00C3F0F8
		public void UpdatePlotState()
		{
			foreach (MoraleAreaPlotItem moraleAreaPlotItem in this.PlotList)
			{
				moraleAreaPlotItem.UpdatePlotState();
			}
		}

		// Token: 0x0602BA61 RID: 178785 RVA: 0x00C40F48 File Offset: 0x00C3F148
		public void HideAllPlot()
		{
			foreach (MoraleAreaPlotItem moraleAreaPlotItem in this.PlotList)
			{
				moraleAreaPlotItem.SetPlotActive(false);
			}
		}

		// Token: 0x0602BA62 RID: 178786 RVA: 0x00C40F9C File Offset: 0x00C3F19C
		public void ShowAllPlot()
		{
			foreach (MoraleAreaPlotItem moraleAreaPlotItem in this.PlotList)
			{
				moraleAreaPlotItem.SetPlotActive(true);
			}
		}

		// Token: 0x0602BA63 RID: 178787 RVA: 0x00C40FF0 File Offset: 0x00C3F1F0
		public void UpdateData()
		{
			this.UpdatePlotState();
		}

		// Token: 0x040178C7 RID: 96455
		public MoraleAreaData AreaData;

		// Token: 0x040178C8 RID: 96456
		public readonly List<MoraleAreaPlotItem> PlotList = new List<MoraleAreaPlotItem>();

		// Token: 0x040178C9 RID: 96457
		public readonly Dictionary<int, List<MoraleAreaPlotItem>> FlagToPlotMap = new Dictionary<int, List<MoraleAreaPlotItem>>();

		// Token: 0x040178CA RID: 96458
		public readonly Dictionary<int, MoraleAreaPlotItem> PlotMap = new Dictionary<int, MoraleAreaPlotItem>();

		// Token: 0x040178CB RID: 96459
		public IReadOnlyList<int> AllPlotIdList;
	}
}
