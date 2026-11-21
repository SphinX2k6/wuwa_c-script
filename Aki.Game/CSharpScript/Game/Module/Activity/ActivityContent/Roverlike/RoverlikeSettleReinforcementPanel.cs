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
	// Token: 0x020050BF RID: 20671
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSettleReinforcementPanel : UiPanelBase, IRoverlikeSettleSelectablePanel
	{
		// Token: 0x06033BB5 RID: 211893 RVA: 0x00E7AA6D File Offset: 0x00E78C6D
		public void BindOnItemClick(Action<int, int> callback)
		{
			this.OnItemClick = callback;
		}

		// Token: 0x06033BB6 RID: 211894 RVA: 0x00E7AA78 File Offset: 0x00E78C78
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

		// Token: 0x06033BB7 RID: 211895 RVA: 0x00E7AB23 File Offset: 0x00E78D23
		protected override void OnStart()
		{
			this.ReinforcementLayout = new GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData>(base.GetGridLayout(1), new Func<RoverlikeEntrySmallGridItem>(this.CreateReinforcementItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06033BB8 RID: 211896 RVA: 0x00E7AB58 File Offset: 0x00E78D58
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

		// Token: 0x06033BB9 RID: 211897 RVA: 0x00E7AC24 File Offset: 0x00E78E24
		public void SelectByKey(int key)
		{
			GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> reinforcementLayout = this.ReinforcementLayout;
			if (reinforcementLayout == null)
			{
				return;
			}
			reinforcementLayout.SelectGridProxyByKey(key, false);
		}

		// Token: 0x06033BBA RID: 211898 RVA: 0x00E7AC3D File Offset: 0x00E78E3D
		public void ClearSelect()
		{
			GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> reinforcementLayout = this.ReinforcementLayout;
			if (reinforcementLayout == null)
			{
				return;
			}
			reinforcementLayout.DeselectCurrentGridProxy();
		}

		// Token: 0x06033BBB RID: 211899 RVA: 0x00E7AC4F File Offset: 0x00E78E4F
		private RoverlikeEntrySmallGridItem CreateReinforcementItem()
		{
			RoverlikeEntrySmallGridItem roverlikeEntrySmallGridItem = new RoverlikeEntrySmallGridItem();
			roverlikeEntrySmallGridItem.BindOnItemClick(new Action<IRoverlikeEntrySmallGridData, int>(this.OnGridItemClick));
			return roverlikeEntrySmallGridItem;
		}

		// Token: 0x06033BBC RID: 211900 RVA: 0x00E7AC68 File Offset: 0x00E78E68
		private void OnGridItemClick(IRoverlikeEntrySmallGridData data, int key)
		{
			Action<int, int> onItemClick = this.OnItemClick;
			if (onItemClick == null)
			{
				return;
			}
			onItemClick(data.ConfigId, key);
		}

		// Token: 0x0401B6C7 RID: 112327
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> ReinforcementLayout;

		// Token: 0x0401B6C8 RID: 112328
		[Nullable(2)]
		private Action<int, int> OnItemClick;

		// Token: 0x0200AD84 RID: 44420
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040359D9 RID: 219609
			public const int TxtNum = 0;

			// Token: 0x040359DA RID: 219610
			public const int LayoutReinforcement = 1;

			// Token: 0x040359DB RID: 219611
			public const int ReinforcementItem = 2;

			// Token: 0x040359DC RID: 219612
			public const int ItemEmpty = 3;
		}
	}
}
