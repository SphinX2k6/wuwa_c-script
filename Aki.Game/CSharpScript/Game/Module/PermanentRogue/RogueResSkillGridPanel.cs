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
	// Token: 0x0200532C RID: 21292
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResSkillGridPanel : UiPanelBase, IGridProxy<List<RogueResTalentTree>>
	{
		// Token: 0x17008326 RID: 33574
		// (get) Token: 0x06036702 RID: 222978 RVA: 0x00CE3402 File Offset: 0x00CE1602
		// (set) Token: 0x06036703 RID: 222979 RVA: 0x00CE340A File Offset: 0x00CE160A
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

		// Token: 0x17008327 RID: 33575
		// (get) Token: 0x06036704 RID: 222980 RVA: 0x00CE3413 File Offset: 0x00CE1613
		// (set) Token: 0x06036705 RID: 222981 RVA: 0x00CE341B File Offset: 0x00CE161B
		public int GridIndex { get; set; }

		// Token: 0x17008328 RID: 33576
		// (get) Token: 0x06036706 RID: 222982 RVA: 0x00CE3424 File Offset: 0x00CE1624
		// (set) Token: 0x06036707 RID: 222983 RVA: 0x00CE342C File Offset: 0x00CE162C
		public int DisplayIndex { get; set; }

		// Token: 0x06036708 RID: 222984 RVA: 0x00CE3438 File Offset: 0x00CE1638
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06036709 RID: 222985 RVA: 0x00CE3492 File Offset: 0x00CE1692
		public RogueResSkillNode GetNodeByPos(int pos)
		{
			return this.NodeMap[pos];
		}

		// Token: 0x0603670A RID: 222986 RVA: 0x00CE34A0 File Offset: 0x00CE16A0
		protected override void OnStart()
		{
		}

		// Token: 0x0603670B RID: 222987 RVA: 0x00CE34A4 File Offset: 0x00CE16A4
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

		// Token: 0x0603670C RID: 222988 RVA: 0x00CE35A8 File Offset: 0x00CE17A8
		public void Refresh(List<RogueResTalentTree> data, bool isSelected, int gridIndex)
		{
			this.NodeDataList = data;
			this.BuildNode();
		}

		// Token: 0x0603670D RID: 222989 RVA: 0x00CE35B7 File Offset: 0x00CE17B7
		public void Clear()
		{
		}

		// Token: 0x0603670E RID: 222990 RVA: 0x00CE35B9 File Offset: 0x00CE17B9
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603670F RID: 222991 RVA: 0x00CE35BB File Offset: 0x00CE17BB
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06036710 RID: 222992 RVA: 0x00CE35BD File Offset: 0x00CE17BD
		public object GetKey(List<RogueResTalentTree> data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x0401CC89 RID: 117897
		public List<RogueResSkillNode> NodeMap = new List<RogueResSkillNode>();

		// Token: 0x0401CC8A RID: 117898
		public List<RogueResTalentTree> NodeDataList = new List<RogueResTalentTree>();

		// Token: 0x0401CC8B RID: 117899
		private IGridProxy<List<RogueResTalentTree>> GridProxyImplementation;
	}
}
