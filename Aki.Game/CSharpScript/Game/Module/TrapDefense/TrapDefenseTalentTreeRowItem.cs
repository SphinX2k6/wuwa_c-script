using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AD5 RID: 19157
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseTalentTreeRowItem : GridProxyAbstract<TrapDefenseTalentTreeRowData>
	{
		// Token: 0x060319E6 RID: 203238 RVA: 0x00B82904 File Offset: 0x00B80B04
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060319E7 RID: 203239 RVA: 0x00B82970 File Offset: 0x00B80B70
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseTalentTreeRowItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseTalentTreeRowItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319E8 RID: 203240 RVA: 0x00B829B4 File Offset: 0x00B80BB4
		public override void Refresh(TrapDefenseTalentTreeRowData data, bool isSelected, int gridIndex)
		{
			this.ResetAllLines();
			this.ResetAllNodes();
			this.RefreshAllDots();
			foreach (TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData in data.NodeList)
			{
				TrapDefenseTalentTreeNodeItem nodeItem = this.NodeList.GetNodeItem(trapDefenseTalentTreeNodeData.Index);
				if (nodeItem != null)
				{
					nodeItem.SetNodeActive(true);
				}
				TrapDefenseTalentTreeNodeItem nodeItem2 = this.NodeList.GetNodeItem(trapDefenseTalentTreeNodeData.Index);
				if (nodeItem2 != null)
				{
					nodeItem2.Refresh(trapDefenseTalentTreeNodeData);
				}
			}
			foreach (KeyValuePair<int, ETrapDefenseTalentTreePathType> keyValuePair in TrapDefenseModel.Instance.TalentTreeData.LineTypeMap[data.Row])
			{
				int key = keyValuePair.Key;
				ETrapDefenseTalentTreePathType value = keyValuePair.Value;
				ValueTuple<UUIItem, UUIItem>? linesByIndex = this.GetLinesByIndex(key);
				if (linesByIndex != null)
				{
					UUIItem item = linesByIndex.Value.Item1;
					UUIItem item2 = linesByIndex.Value.Item2;
					item.SetUIActive(value == ETrapDefenseTalentTreePathType.Solid);
					item2.SetUIActive(value == ETrapDefenseTalentTreePathType.Dashed);
					foreach (ValueTuple<UUIItem, UUIItem> valueTuple in this.LineList.GetDotsByIndexInLineId(key))
					{
						UUIItem item3 = valueTuple.Item1;
						UUIItem item4 = valueTuple.Item2;
						int index = TrapDefenseDefine.LineIndex2NodeIndex(key);
						if (!TrapDefenseModel.Instance.TalentTreeData.IsDotVisible(data.Row, index))
						{
							item3.SetUIActive(false);
							item4.SetUIActive(false);
						}
						else if (item3.IsUIActiveInHierarchy())
						{
							item4.SetUIActive(false);
						}
						else
						{
							item3.SetUIActive(value == ETrapDefenseTalentTreePathType.Solid);
							item4.SetUIActive(value == ETrapDefenseTalentTreePathType.Dashed);
						}
					}
				}
			}
		}

		// Token: 0x060319E9 RID: 203241 RVA: 0x00B82BD0 File Offset: 0x00B80DD0
		public override object GetKey(TrapDefenseTalentTreeRowData data, int displayIndex)
		{
			return data.Row;
		}

		// Token: 0x060319EA RID: 203242 RVA: 0x00B82BE0 File Offset: 0x00B80DE0
		private void ResetAllLines()
		{
			List<UUIItem> allLines = this.LineList.GetAllLines();
			for (int i = 0; i < allLines.Count; i++)
			{
				UUIItem uuiitem = allLines[i];
				uuiitem.SetUIActive(false);
				if (i < 8)
				{
					uuiitem.SetStretchRight(-8.5f);
				}
			}
			foreach (UUIItem uuiitem2 in this.NodeList.GetAllLines())
			{
				uuiitem2.SetUIActive(false);
			}
		}

		// Token: 0x060319EB RID: 203243 RVA: 0x00B82C74 File Offset: 0x00B80E74
		private void ResetAllNodes()
		{
			for (int i = 0; i < 6; i++)
			{
				TrapDefenseTalentTreeNodeItem nodeItem = this.NodeList.GetNodeItem(i);
				if (nodeItem != null)
				{
					nodeItem.SetNodeActive(false);
				}
			}
		}

		// Token: 0x060319EC RID: 203244 RVA: 0x00B82CA8 File Offset: 0x00B80EA8
		private void RefreshAllDots()
		{
			foreach (UUIItem uuiitem in this.LineList.GetAllDots())
			{
				uuiitem.SetUIActive(false);
			}
		}

		// Token: 0x060319ED RID: 203245 RVA: 0x00B82D00 File Offset: 0x00B80F00
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<UUIItem, UUIItem>? GetLinesByIndex(int index)
		{
			ValueTuple<UUIItem, UUIItem>? linesByIndexInLineId = this.LineList.GetLinesByIndexInLineId(index);
			if (linesByIndexInLineId != null)
			{
				return linesByIndexInLineId;
			}
			return this.NodeList.GetLinesByIndexInLineId(index);
		}

		// Token: 0x0401A816 RID: 108566
		private TrapDefenseTalentTreeRowNodeListItem NodeList;

		// Token: 0x0401A817 RID: 108567
		private TrapDefenseTalentTreeRowLineListItem LineList;

		// Token: 0x0200AC4F RID: 44111
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040345C9 RID: 214473
			public const int ItemNodeList = 0;

			// Token: 0x040345CA RID: 214474
			public const int ItemLineList = 1;
		}
	}
}
