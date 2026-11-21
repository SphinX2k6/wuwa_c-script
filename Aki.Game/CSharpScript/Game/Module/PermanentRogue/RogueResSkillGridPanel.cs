using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042FC RID: 17148
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResSkillGridPanel : UiPanelBase, IGridProxy<List<RogueResTalentTree>>
	{
		// Token: 0x170056E6 RID: 22246
		// (get) Token: 0x0602B5FE RID: 177662 RVA: 0x00C30DD2 File Offset: 0x00C2EFD2
		// (set) Token: 0x0602B5FF RID: 177663 RVA: 0x00C30DDA File Offset: 0x00C2EFDA
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<List<RogueResTalentTree>>, List<RogueResTalentTree>> ScrollViewDelegate { [return: Nullable(new byte[]
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

		// Token: 0x170056E7 RID: 22247
		// (get) Token: 0x0602B600 RID: 177664 RVA: 0x00C30DE3 File Offset: 0x00C2EFE3
		// (set) Token: 0x0602B601 RID: 177665 RVA: 0x00C30DEB File Offset: 0x00C2EFEB
		public int GridIndex { get; set; }

		// Token: 0x170056E8 RID: 22248
		// (get) Token: 0x0602B602 RID: 177666 RVA: 0x00C30DF4 File Offset: 0x00C2EFF4
		// (set) Token: 0x0602B603 RID: 177667 RVA: 0x00C30DFC File Offset: 0x00C2EFFC
		public int DisplayIndex { get; set; }

		// Token: 0x0602B604 RID: 177668 RVA: 0x00C30E08 File Offset: 0x00C2F008
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602B605 RID: 177669 RVA: 0x00C30E62 File Offset: 0x00C2F062
		public RogueResSkillNode GetNodeByPos(int pos)
		{
			return this.NodeMap[pos];
		}

		// Token: 0x0602B606 RID: 177670 RVA: 0x00C30E70 File Offset: 0x00C2F070
		protected override void OnStart()
		{
		}

		// Token: 0x0602B607 RID: 177671 RVA: 0x00C30E74 File Offset: 0x00C2F074
		public void BuildNode()
		{
			foreach (RogueResTalentTree data in this.NodeDataList)
			{
				RogueResSort? config = ConfigRogueResSortById.GetConfig(data.Id, true);
				UUIItem item = base.GetItem(config.Value.Row);
				RogueResSkillNode skillNode = new RogueResSkillNode(item, data, this.RootItem);
				while (this.NodeMap.Count <= config.Value.Row)
				{
					this.NodeMap.Add(null);
				}
				this.NodeMap[config.Value.Row] = skillNode;
				skillNode.CreateThenShowByResourceIdAsync("RoguelikeSkillNodeB", item, false).ContinueWith(delegate()
				{
					skillNode.Refresh(null);
				});
			}
		}

		// Token: 0x0602B608 RID: 177672 RVA: 0x00C30F78 File Offset: 0x00C2F178
		public void Refresh(List<RogueResTalentTree> data, bool isSelected, int gridIndex)
		{
			this.NodeDataList = data;
			this.BuildNode();
		}

		// Token: 0x0602B609 RID: 177673 RVA: 0x00C30F87 File Offset: 0x00C2F187
		public void Clear()
		{
		}

		// Token: 0x0602B60A RID: 177674 RVA: 0x00C30F89 File Offset: 0x00C2F189
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0602B60B RID: 177675 RVA: 0x00C30F8B File Offset: 0x00C2F18B
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0602B60C RID: 177676 RVA: 0x00C30F8D File Offset: 0x00C2F18D
		public object GetKey(List<RogueResTalentTree> data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x040176BF RID: 95935
		public List<RogueResSkillNode> NodeMap = new List<RogueResSkillNode>();

		// Token: 0x040176C0 RID: 95936
		public List<RogueResTalentTree> NodeDataList = new List<RogueResTalentTree>();

		// Token: 0x040176C1 RID: 95937
		private IGridProxy<List<RogueResTalentTree>> GridProxyImplementation;
	}
}
