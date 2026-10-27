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
	// Token: 0x02004E44 RID: 20036
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeTalentTreeNodeRowItem : GridProxyAbstract<RoguelikeTalentTreeNodeRowData>
	{
		// Token: 0x06033A72 RID: 211570 RVA: 0x00C17504 File Offset: 0x00C15704
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

		// Token: 0x06033A73 RID: 211571 RVA: 0x00C17570 File Offset: 0x00C15770
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeTalentTreeNodeRowItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeTalentTreeNodeRowItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A74 RID: 211572 RVA: 0x00C175B3 File Offset: 0x00C157B3
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<int>(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnSkillLevelUp));
		}

		// Token: 0x06033A75 RID: 211573 RVA: 0x00C175D1 File Offset: 0x00C157D1
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnSkillLevelUp));
		}

		// Token: 0x06033A76 RID: 211574 RVA: 0x00C175F0 File Offset: 0x00C157F0
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

		// Token: 0x06033A77 RID: 211575 RVA: 0x00C176F0 File Offset: 0x00C158F0
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

		// Token: 0x06033A78 RID: 211576 RVA: 0x00C178B4 File Offset: 0x00C15AB4
		public override object GetKey(RoguelikeTalentTreeNodeRowData data, int displayIndex)
		{
			return data.Row;
		}

		// Token: 0x06033A79 RID: 211577 RVA: 0x00C178C4 File Offset: 0x00C15AC4
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

		// Token: 0x06033A7A RID: 211578 RVA: 0x00C17960 File Offset: 0x00C15B60
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

		// Token: 0x06033A7B RID: 211579 RVA: 0x00C17994 File Offset: 0x00C15B94
		private void RefreshAllDots()
		{
			foreach (UUIItem uuiitem in this.LineList.GetAllDots())
			{
				uuiitem.SetUIActive(false);
			}
		}

		// Token: 0x06033A7C RID: 211580 RVA: 0x00C179EC File Offset: 0x00C15BEC
		[NullableContext(2)]
		private UUIItem GetLineByIndex(int index)
		{
			return this.LineList.GetLinesByIndexInLineId(index) ?? this.NodeList.GetLineByIndexInLineId(index);
		}

		// Token: 0x0401B631 RID: 112177
		private RoguelikeTalentTreeNodeRowData Data;

		// Token: 0x0401B632 RID: 112178
		private RoguelikeTalentTreeNodeGroupItem NodeList;

		// Token: 0x0401B633 RID: 112179
		private RoguelikeTalentTreeLineGroupItem LineList;

		// Token: 0x0200B001 RID: 45057
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04035707 RID: 218887
			public const int ItemNodeList = 0;

			// Token: 0x04035708 RID: 218888
			public const int ItemLineList = 1;
		}
	}
}
