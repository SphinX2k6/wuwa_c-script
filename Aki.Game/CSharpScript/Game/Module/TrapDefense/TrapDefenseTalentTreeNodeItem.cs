using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A7C RID: 14972
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeNodeItem : UiPanelBase
	{
		// Token: 0x0602676A RID: 157546 RVA: 0x00AC640C File Offset: 0x00AC460C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602676B RID: 157547 RVA: 0x00AC6622 File Offset: 0x00AC4822
		protected override void OnStart()
		{
			TrapDefenseModel.Instance.ViewModelTalentTree.AddDelegateOnNodeSelect(new Action<TrapDefenseTalentTreeNodeData, bool>(this.OnSelectedNodeChange));
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602676C RID: 157548 RVA: 0x00AC6650 File Offset: 0x00AC4850
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelTalentTree.RemoveDelegateOnNodeSelect(new Action<TrapDefenseTalentTreeNodeData, bool>(this.OnSelectedNodeChange));
		}

		// Token: 0x0602676D RID: 157549 RVA: 0x00AC6670 File Offset: 0x00AC4870
		public void Refresh(TrapDefenseTalentTreeNodeData data)
		{
			this.Data = data;
			base.GetItem(5).SetUIActive(!data.IsUnlock);
			base.GetItem(6).SetUIActive(this.Data.IsUnlock);
			bool flag = TrapDefenseModel.Instance.TalentTreeData.CanNodeUnlock(this.Data);
			bool flag2 = TrapDefenseModel.Instance.TalentTreeData.CanNodeAfford(this.Data);
			base.GetItem(11).SetUIActive(flag && flag2 && !data.IsUnlock);
			base.GetItem(12).SetUIActive(flag && flag2 && !data.IsUnlock);
			UUISprite sprite = base.GetSprite(7);
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = !data.IsUnlock;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			this.SetSpriteByPath(data.Icon, sprite, false, null, null);
			string sequenceName = data.IsUnlock ? "Loop" : "Start1";
			this.SeqPlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
			if (data.IsUnlock && !this.NodeUnlockStateCache)
			{
				this.SeqPlayer.PlayLevelSequenceByName("Start2", false, null, false);
			}
			this.NodeUnlockStateCache = data.IsUnlock;
		}

		// Token: 0x0602676E RID: 157550 RVA: 0x00AC67BC File Offset: 0x00AC49BC
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<UUIItem, UUIItem> GetUpLines()
		{
			return new ValueTuple<UUIItem, UUIItem>(base.GetItem(2), base.GetItem(0));
		}

		// Token: 0x0602676F RID: 157551 RVA: 0x00AC67D1 File Offset: 0x00AC49D1
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<UUIItem, UUIItem> GetDownLines()
		{
			return new ValueTuple<UUIItem, UUIItem>(base.GetItem(3), base.GetItem(1));
		}

		// Token: 0x06026770 RID: 157552 RVA: 0x00AC67E6 File Offset: 0x00AC49E6
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<UUIItem, UUIItem> GetMidLines()
		{
			return new ValueTuple<UUIItem, UUIItem>(base.GetItem(10), base.GetItem(9));
		}

		// Token: 0x06026771 RID: 157553 RVA: 0x00AC6800 File Offset: 0x00AC4A00
		public UUIItem[] GetAllLines()
		{
			return new UUIItem[]
			{
				base.GetItem(2),
				base.GetItem(0),
				base.GetItem(3),
				base.GetItem(1),
				base.GetItem(9),
				base.GetItem(10)
			};
		}

		// Token: 0x06026772 RID: 157554 RVA: 0x00AC6851 File Offset: 0x00AC4A51
		public void SetNodeActive(bool isActive)
		{
			base.GetItem(8).SetUIActive(isActive);
		}

		// Token: 0x06026773 RID: 157555 RVA: 0x00AC6860 File Offset: 0x00AC4A60
		private void OnClick(EToggleState state)
		{
			TrapDefenseModel.Instance.ViewModelTalentTree.SelectNode(this.Data, false);
		}

		// Token: 0x06026774 RID: 157556 RVA: 0x00AC6878 File Offset: 0x00AC4A78
		private void OnSelectedNodeChange(TrapDefenseTalentTreeNodeData node, bool _)
		{
			if (node == this.Data)
			{
				base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x04015165 RID: 86373
		private TrapDefenseTalentTreeNodeData Data;

		// Token: 0x04015166 RID: 86374
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04015167 RID: 86375
		private bool NodeUnlockStateCache = true;

		// Token: 0x0200966E RID: 38510
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EF6D RID: 192365
			public const int ItemDashedLineUp = 0;

			// Token: 0x0402EF6E RID: 192366
			public const int ItemDashedLineDown = 1;

			// Token: 0x0402EF6F RID: 192367
			public const int ItemSolidLineUp = 2;

			// Token: 0x0402EF70 RID: 192368
			public const int ItemSolidLineDown = 3;

			// Token: 0x0402EF71 RID: 192369
			public const int Toggle = 4;

			// Token: 0x0402EF72 RID: 192370
			public const int ItemLock = 5;

			// Token: 0x0402EF73 RID: 192371
			public const int ItemUnlock = 6;

			// Token: 0x0402EF74 RID: 192372
			public const int SpriteIcon = 7;

			// Token: 0x0402EF75 RID: 192373
			public const int ItemNode = 8;

			// Token: 0x0402EF76 RID: 192374
			public const int ItemMidLineDashed = 9;

			// Token: 0x0402EF77 RID: 192375
			public const int ItemMidLineSolid = 10;

			// Token: 0x0402EF78 RID: 192376
			public const int ItemLevelUpIcon = 11;

			// Token: 0x0402EF79 RID: 192377
			public const int ItemLoopAnim = 12;
		}
	}
}
