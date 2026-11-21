using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DF4 RID: 15860
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSkillGridPanel : UiPanelBase, IGridProxy<List<RogueTalentTree>>
	{
		// Token: 0x1700527F RID: 21119
		// (get) Token: 0x06028809 RID: 165897 RVA: 0x00B5C46B File Offset: 0x00B5A66B
		// (set) Token: 0x0602880A RID: 165898 RVA: 0x00B5C473 File Offset: 0x00B5A673
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<List<RogueTalentTree>>, List<RogueTalentTree>> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x17005280 RID: 21120
		// (get) Token: 0x0602880B RID: 165899 RVA: 0x00B5C47C File Offset: 0x00B5A67C
		// (set) Token: 0x0602880C RID: 165900 RVA: 0x00B5C484 File Offset: 0x00B5A684
		public int GridIndex { get; set; }

		// Token: 0x17005281 RID: 21121
		// (get) Token: 0x0602880D RID: 165901 RVA: 0x00B5C48D File Offset: 0x00B5A68D
		// (set) Token: 0x0602880E RID: 165902 RVA: 0x00B5C495 File Offset: 0x00B5A695
		public int DisplayIndex { get; set; }

		// Token: 0x0602880F RID: 165903 RVA: 0x00B5C4A0 File Offset: 0x00B5A6A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06028810 RID: 165904 RVA: 0x00B5C52A File Offset: 0x00B5A72A
		public RoguelikeSkillNode GetNodeByPos(int pos)
		{
			return this.NodeMap[pos];
		}

		// Token: 0x06028811 RID: 165905 RVA: 0x00B5C538 File Offset: 0x00B5A738
		protected override void OnStart()
		{
		}

		// Token: 0x06028812 RID: 165906 RVA: 0x00B5C53C File Offset: 0x00B5A73C
		public void BuildNode()
		{
			foreach (RogueTalentTree data in this.NodeDataList)
			{
				UUIItem item = base.GetItem(data.Row);
				RoguelikeSkillNode skillNode = new RoguelikeSkillNode(item, data, this.RootItem);
				while (this.NodeMap.Count <= data.Row)
				{
					this.NodeMap.Add(null);
				}
				this.NodeMap[data.Row] = skillNode;
				skillNode.CreateThenShowByResourceIdAsync("RoguelikeSkillNodeB", item, false).ContinueWith(delegate()
				{
					skillNode.Refresh(null);
				});
			}
		}

		// Token: 0x06028813 RID: 165907 RVA: 0x00B5C614 File Offset: 0x00B5A814
		public void Refresh(List<RogueTalentTree> data, bool isSelected, int gridIndex)
		{
			this.NodeDataList = data;
			this.BuildNode();
		}

		// Token: 0x06028814 RID: 165908 RVA: 0x00B5C623 File Offset: 0x00B5A823
		public void Clear()
		{
		}

		// Token: 0x06028815 RID: 165909 RVA: 0x00B5C625 File Offset: 0x00B5A825
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06028816 RID: 165910 RVA: 0x00B5C627 File Offset: 0x00B5A827
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06028817 RID: 165911 RVA: 0x00B5C629 File Offset: 0x00B5A829
		public object GetKey(List<RogueTalentTree> data, int gridIndex)
		{
			return null;
		}

		// Token: 0x04015FC3 RID: 90051
		public List<RoguelikeSkillNode> NodeMap = new List<RoguelikeSkillNode>();

		// Token: 0x04015FC4 RID: 90052
		public List<RogueTalentTree> NodeDataList = new List<RogueTalentTree>();

		// Token: 0x02009A0B RID: 39435
		[NullableContext(0)]
		private class ERoguelikeSkillGridPanelDefine
		{
			// Token: 0x04030062 RID: 196706
			public const int Pos1 = 0;

			// Token: 0x04030063 RID: 196707
			public const int Pos2 = 1;

			// Token: 0x04030064 RID: 196708
			public const int Pos3 = 2;
		}
	}
}
