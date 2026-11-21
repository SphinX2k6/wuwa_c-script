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
	// Token: 0x02003A7D RID: 14973
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseTalentTreeRowItem : GridProxyAbstract<TrapDefenseTalentTreeRowData>
	{
		// Token: 0x06026776 RID: 157558 RVA: 0x00AC68B8 File Offset: 0x00AC4AB8
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

		// Token: 0x06026777 RID: 157559 RVA: 0x00AC6924 File Offset: 0x00AC4B24
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseTalentTreeRowItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseTalentTreeRowItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026778 RID: 157560 RVA: 0x00AC6968 File Offset: 0x00AC4B68
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

		// Token: 0x06026779 RID: 157561 RVA: 0x00AC6B84 File Offset: 0x00AC4D84
		public override object GetKey(TrapDefenseTalentTreeRowData data, int displayIndex)
		{
			return data.Row;
		}

		// Token: 0x0602677A RID: 157562 RVA: 0x00AC6B94 File Offset: 0x00AC4D94
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

		// Token: 0x0602677B RID: 157563 RVA: 0x00AC6C28 File Offset: 0x00AC4E28
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

		// Token: 0x0602677C RID: 157564 RVA: 0x00AC6C5C File Offset: 0x00AC4E5C
		private void RefreshAllDots()
		{
			foreach (UUIItem uuiitem in this.LineList.GetAllDots())
			{
				uuiitem.SetUIActive(false);
			}
		}

		// Token: 0x0602677D RID: 157565 RVA: 0x00AC6CB4 File Offset: 0x00AC4EB4
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

		// Token: 0x04015168 RID: 86376
		private TrapDefenseTalentTreeRowNodeListItem NodeList;

		// Token: 0x04015169 RID: 86377
		private TrapDefenseTalentTreeRowLineListItem LineList;

		// Token: 0x0200966F RID: 38511
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EF7A RID: 192378
			public const int ItemNodeList = 0;

			// Token: 0x0402EF7B RID: 192379
			public const int ItemLineList = 1;
		}
	}
}
