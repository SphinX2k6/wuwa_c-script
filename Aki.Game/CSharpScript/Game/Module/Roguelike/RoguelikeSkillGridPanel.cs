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
	// Token: 0x02004E2B RID: 20011
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSkillGridPanel : UiPanelBase, IGridProxy<List<RogueTalentTree>>
	{
		// Token: 0x17007ECF RID: 32463
		// (get) Token: 0x0603399E RID: 211358 RVA: 0x00C12F37 File Offset: 0x00C11137
		// (set) Token: 0x0603399F RID: 211359 RVA: 0x00C12F3F File Offset: 0x00C1113F
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

		// Token: 0x17007ED0 RID: 32464
		// (get) Token: 0x060339A0 RID: 211360 RVA: 0x00C12F48 File Offset: 0x00C11148
		// (set) Token: 0x060339A1 RID: 211361 RVA: 0x00C12F50 File Offset: 0x00C11150
		public int GridIndex { get; set; }

		// Token: 0x17007ED1 RID: 32465
		// (get) Token: 0x060339A2 RID: 211362 RVA: 0x00C12F59 File Offset: 0x00C11159
		// (set) Token: 0x060339A3 RID: 211363 RVA: 0x00C12F61 File Offset: 0x00C11161
		public int DisplayIndex { get; set; }

		// Token: 0x060339A4 RID: 211364 RVA: 0x00C12F6C File Offset: 0x00C1116C
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

		// Token: 0x060339A5 RID: 211365 RVA: 0x00C12FF6 File Offset: 0x00C111F6
		public RoguelikeSkillNode GetNodeByPos(int pos)
		{
			return this.NodeMap[pos];
		}

		// Token: 0x060339A6 RID: 211366 RVA: 0x00C13004 File Offset: 0x00C11204
		protected override void OnStart()
		{
		}

		// Token: 0x060339A7 RID: 211367 RVA: 0x00C13008 File Offset: 0x00C11208
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

		// Token: 0x060339A8 RID: 211368 RVA: 0x00C130E0 File Offset: 0x00C112E0
		public void Refresh(List<RogueTalentTree> data, bool isSelected, int gridIndex)
		{
			this.NodeDataList = data;
			this.BuildNode();
		}

		// Token: 0x060339A9 RID: 211369 RVA: 0x00C130EF File Offset: 0x00C112EF
		public void Clear()
		{
		}

		// Token: 0x060339AA RID: 211370 RVA: 0x00C130F1 File Offset: 0x00C112F1
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x060339AB RID: 211371 RVA: 0x00C130F3 File Offset: 0x00C112F3
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x060339AC RID: 211372 RVA: 0x00C130F5 File Offset: 0x00C112F5
		public object GetKey(List<RogueTalentTree> data, int gridIndex)
		{
			return null;
		}

		// Token: 0x0401B5F0 RID: 112112
		public List<RoguelikeSkillNode> NodeMap = new List<RoguelikeSkillNode>();

		// Token: 0x0401B5F1 RID: 112113
		public List<RogueTalentTree> NodeDataList = new List<RogueTalentTree>();

		// Token: 0x0200AFD9 RID: 45017
		[NullableContext(0)]
		private class ERoguelikeSkillGridPanelDefine
		{
			// Token: 0x04035632 RID: 218674
			public const int Pos1 = 0;

			// Token: 0x04035633 RID: 218675
			public const int Pos2 = 1;

			// Token: 0x04035634 RID: 218676
			public const int Pos3 = 2;
		}
	}
}
