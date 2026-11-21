using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003E0D RID: 15885
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeTalentTreeNodeRowItem : GridProxyAbstract<RoguelikeTalentTreeNodeRowData>
	{
		// Token: 0x060288DD RID: 166109 RVA: 0x00B60A2C File Offset: 0x00B5EC2C
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

		// Token: 0x060288DE RID: 166110 RVA: 0x00B60A98 File Offset: 0x00B5EC98
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeTalentTreeNodeRowItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeTalentTreeNodeRowItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060288DF RID: 166111 RVA: 0x00B60ADB File Offset: 0x00B5ECDB
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<int>(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnSkillLevelUp));
		}

		// Token: 0x060288E0 RID: 166112 RVA: 0x00B60AF9 File Offset: 0x00B5ECF9
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnSkillLevelUp));
		}

		// Token: 0x060288E1 RID: 166113 RVA: 0x00B60B18 File Offset: 0x00B5ED18
		private void OnSkillLevelUp(int skillId)
		{
			foreach (KeyValuePair<int, bool> keyValuePair in RoguelikeModel.Instance.GetTalentTreeViewModel().LineActiveMap[this.Data.Row])
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int index = num;
				bool flag2 = flag;
				UUIItem lineByIndex = this.GetLineByIndex(index);
				UUIItem uuiitem = lineByIndex;
				bool bUseChangeColor = !flag2;
				FColor? fcolor = new FColor?(lineByIndex.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
				foreach (UUIItem uuiitem2 in this.LineList.GetDotsByIndexInLineId(index))
				{
					UUIItem uuiitem3 = uuiitem2;
					bool bUseChangeColor2 = !flag2;
					fcolor = new FColor?(uuiitem2.changeColor);
					uuiitem3.SetChangeColor(bUseChangeColor2, fcolor);
				}
			}
		}

		// Token: 0x060288E2 RID: 166114 RVA: 0x00B60C18 File Offset: 0x00B5EE18
		public override void Refresh(RoguelikeTalentTreeNodeRowData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.ResetAllLines();
			this.ResetAllNodes();
			this.RefreshAllDots();
			foreach (RoguelikeTalentTreeNodeData roguelikeTalentTreeNodeData in data.NodeList)
			{
				RoguelikeTalentTreeNodeItem nodeItem = this.NodeList.GetNodeItem(roguelikeTalentTreeNodeData.Index);
				if (nodeItem != null)
				{
					nodeItem.SetNodeActive(true);
				}
				RoguelikeTalentTreeNodeItem nodeItem2 = this.NodeList.GetNodeItem(roguelikeTalentTreeNodeData.Index);
				if (nodeItem2 != null)
				{
					nodeItem2.Refresh(roguelikeTalentTreeNodeData);
				}
			}
			RoguelikeTalentTreeViewModel talentTreeViewModel = RoguelikeModel.Instance.GetTalentTreeViewModel();
			foreach (KeyValuePair<int, bool> keyValuePair in talentTreeViewModel.LineActiveMap[data.Row])
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int num2 = num;
				bool flag2 = flag;
				UUIItem lineByIndex = this.GetLineByIndex(num2);
				UUIItem uuiitem = lineByIndex;
				bool bUseChangeColor = !flag2;
				FColor? fcolor = new FColor?(lineByIndex.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
				lineByIndex.SetUIActive(true);
				foreach (UUIItem uuiitem2 in this.LineList.GetDotsByIndexInLineId(num2))
				{
					int index = RogueTalentTreeDefine.rogueLineIndex2NodeIndex(num2);
					if (!talentTreeViewModel.IsDotVisible(data.Row, index))
					{
						uuiitem2.SetUIActive(false);
					}
					else
					{
						UUIItem uuiitem3 = uuiitem2;
						bool bUseChangeColor2 = !flag2;
						fcolor = new FColor?(uuiitem2.changeColor);
						uuiitem3.SetChangeColor(bUseChangeColor2, fcolor);
						uuiitem2.SetUIActive(true);
					}
				}
			}
		}

		// Token: 0x060288E3 RID: 166115 RVA: 0x00B60DDC File Offset: 0x00B5EFDC
		public override object GetKey(RoguelikeTalentTreeNodeRowData data, int displayIndex)
		{
			return data.Row;
		}

		// Token: 0x060288E4 RID: 166116 RVA: 0x00B60DEC File Offset: 0x00B5EFEC
		private void ResetAllLines()
		{
			foreach (UUIItem uuiitem in this.LineList.GetAllLines())
			{
				uuiitem.SetUIActive(false);
			}
			foreach (UUIItem uuiitem2 in this.NodeList.GetAllLines())
			{
				uuiitem2.SetUIActive(false);
			}
		}

		// Token: 0x060288E5 RID: 166117 RVA: 0x00B60E88 File Offset: 0x00B5F088
		private void ResetAllNodes()
		{
			for (int i = 0; i < 6; i++)
			{
				RoguelikeTalentTreeNodeItem nodeItem = this.NodeList.GetNodeItem(i);
				if (nodeItem != null)
				{
					nodeItem.SetNodeActive(false);
				}
			}
		}

		// Token: 0x060288E6 RID: 166118 RVA: 0x00B60EBC File Offset: 0x00B5F0BC
		private void RefreshAllDots()
		{
			foreach (UUIItem uuiitem in this.LineList.GetAllDots())
			{
				uuiitem.SetUIActive(false);
			}
		}

		// Token: 0x060288E7 RID: 166119 RVA: 0x00B60F14 File Offset: 0x00B5F114
		[NullableContext(2)]
		private UUIItem GetLineByIndex(int index)
		{
			return this.LineList.GetLinesByIndexInLineId(index) ?? this.NodeList.GetLineByIndexInLineId(index);
		}

		// Token: 0x04016004 RID: 90116
		private RoguelikeTalentTreeNodeRowData Data;

		// Token: 0x04016005 RID: 90117
		private RoguelikeTalentTreeNodeGroupItem NodeList;

		// Token: 0x04016006 RID: 90118
		private RoguelikeTalentTreeLineGroupItem LineList;

		// Token: 0x02009A33 RID: 39475
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04030137 RID: 196919
			public const int ItemNodeList = 0;

			// Token: 0x04030138 RID: 196920
			public const int ItemLineList = 1;
		}
	}
}
