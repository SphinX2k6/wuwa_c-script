using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006141 RID: 24897
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSettleReinforcementPanel : UiPanelBase, IRoverlikeSettleSelectablePanel
	{
		// Token: 0x0603EEF5 RID: 257781 RVA: 0x00F33B8D File Offset: 0x00F31D8D
		public void BindOnItemClick(Action<int, int> callback)
		{
			this.OnItemClick = callback;
		}

		// Token: 0x0603EEF6 RID: 257782 RVA: 0x00F33B98 File Offset: 0x00F31D98
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EEF7 RID: 257783 RVA: 0x00F33C43 File Offset: 0x00F31E43
		protected override void OnStart()
		{
			this.ReinforcementLayout = new GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData>(base.GetGridLayout(1), new Func<RoverlikeEntrySmallGridItem>(this.CreateReinforcementItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603EEF8 RID: 257784 RVA: 0x00F33C78 File Offset: 0x00F31E78
		public void Refresh(List<int> configIdList)
		{
			base.GetText(0).SetText(configIdList.Count.ToString(), true);
			List<IRoverlikeEntrySmallGridData> list = new List<IRoverlikeEntrySmallGridData>();
			foreach (int configId in configIdList)
			{
				RoverlikeEntrySmallGridData item = new RoverlikeEntrySmallGridData
				{
					ConfigId = configId,
					Type = RoverRogueGainDataType.RoverRogueGainRoleEnhance
				};
				list.Add(item);
			}
			bool flag = list.Count > 0;
			GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> reinforcementLayout = this.ReinforcementLayout;
			if (reinforcementLayout != null)
			{
				reinforcementLayout.SetActive(flag);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			if (flag)
			{
				this.ReinforcementLayout.RefreshByData(list, null, true);
			}
		}

		// Token: 0x0603EEF9 RID: 257785 RVA: 0x00F33D44 File Offset: 0x00F31F44
		public void SelectByKey(int key)
		{
			GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> reinforcementLayout = this.ReinforcementLayout;
			if (reinforcementLayout == null)
			{
				return;
			}
			reinforcementLayout.SelectGridProxyByKey(key, false);
		}

		// Token: 0x0603EEFA RID: 257786 RVA: 0x00F33D5D File Offset: 0x00F31F5D
		public void ClearSelect()
		{
			GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> reinforcementLayout = this.ReinforcementLayout;
			if (reinforcementLayout == null)
			{
				return;
			}
			reinforcementLayout.DeselectCurrentGridProxy();
		}

		// Token: 0x0603EEFB RID: 257787 RVA: 0x00F33D6F File Offset: 0x00F31F6F
		private RoverlikeEntrySmallGridItem CreateReinforcementItem()
		{
			RoverlikeEntrySmallGridItem roverlikeEntrySmallGridItem = new RoverlikeEntrySmallGridItem();
			roverlikeEntrySmallGridItem.BindOnItemClick(new Action<IRoverlikeEntrySmallGridData, int>(this.OnGridItemClick));
			return roverlikeEntrySmallGridItem;
		}

		// Token: 0x0603EEFC RID: 257788 RVA: 0x00F33D88 File Offset: 0x00F31F88
		private void OnGridItemClick(IRoverlikeEntrySmallGridData data, int key)
		{
			Action<int, int> onItemClick = this.OnItemClick;
			if (onItemClick == null)
			{
				return;
			}
			onItemClick(data.ConfigId, key);
		}

		// Token: 0x04020D9A RID: 134554
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> ReinforcementLayout;

		// Token: 0x04020D9B RID: 134555
		[Nullable(2)]
		private Action<int, int> OnItemClick;

		// Token: 0x0200C39D RID: 50077
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B078 RID: 241784
			public const int TxtNum = 0;

			// Token: 0x0403B079 RID: 241785
			public const int LayoutReinforcement = 1;

			// Token: 0x0403B07A RID: 241786
			public const int ReinforcementItem = 2;

			// Token: 0x0403B07B RID: 241787
			public const int ItemEmpty = 3;
		}
	}
}
