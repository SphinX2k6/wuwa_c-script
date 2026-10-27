using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AD4 RID: 19156
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeNodeItem : UiPanelBase
	{
		// Token: 0x060319DA RID: 203226 RVA: 0x00B82458 File Offset: 0x00B80658
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

		// Token: 0x060319DB RID: 203227 RVA: 0x00B8266E File Offset: 0x00B8086E
		protected override void OnStart()
		{
			TrapDefenseModel.Instance.ViewModelTalentTree.AddDelegateOnNodeSelect(new Action<TrapDefenseTalentTreeNodeData, bool>(this.OnSelectedNodeChange));
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060319DC RID: 203228 RVA: 0x00B8269C File Offset: 0x00B8089C
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelTalentTree.RemoveDelegateOnNodeSelect(new Action<TrapDefenseTalentTreeNodeData, bool>(this.OnSelectedNodeChange));
		}

		// Token: 0x060319DD RID: 203229 RVA: 0x00B826BC File Offset: 0x00B808BC
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

		// Token: 0x060319DE RID: 203230 RVA: 0x00B82808 File Offset: 0x00B80A08
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

		// Token: 0x060319DF RID: 203231 RVA: 0x00B8281D File Offset: 0x00B80A1D
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

		// Token: 0x060319E0 RID: 203232 RVA: 0x00B82832 File Offset: 0x00B80A32
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

		// Token: 0x060319E1 RID: 203233 RVA: 0x00B8284C File Offset: 0x00B80A4C
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

		// Token: 0x060319E2 RID: 203234 RVA: 0x00B8289D File Offset: 0x00B80A9D
		public void SetNodeActive(bool isActive)
		{
			base.GetItem(8).SetUIActive(isActive);
		}

		// Token: 0x060319E3 RID: 203235 RVA: 0x00B828AC File Offset: 0x00B80AAC
		private void OnClick(EToggleState state)
		{
			TrapDefenseModel.Instance.ViewModelTalentTree.SelectNode(this.Data, false);
		}

		// Token: 0x060319E4 RID: 203236 RVA: 0x00B828C4 File Offset: 0x00B80AC4
		private void OnSelectedNodeChange(TrapDefenseTalentTreeNodeData node, bool _)
		{
			if (node == this.Data)
			{
				base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401A813 RID: 108563
		private TrapDefenseTalentTreeNodeData Data;

		// Token: 0x0401A814 RID: 108564
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401A815 RID: 108565
		private bool NodeUnlockStateCache = true;

		// Token: 0x0200AC4E RID: 44110
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040345BC RID: 214460
			public const int ItemDashedLineUp = 0;

			// Token: 0x040345BD RID: 214461
			public const int ItemDashedLineDown = 1;

			// Token: 0x040345BE RID: 214462
			public const int ItemSolidLineUp = 2;

			// Token: 0x040345BF RID: 214463
			public const int ItemSolidLineDown = 3;

			// Token: 0x040345C0 RID: 214464
			public const int Toggle = 4;

			// Token: 0x040345C1 RID: 214465
			public const int ItemLock = 5;

			// Token: 0x040345C2 RID: 214466
			public const int ItemUnlock = 6;

			// Token: 0x040345C3 RID: 214467
			public const int SpriteIcon = 7;

			// Token: 0x040345C4 RID: 214468
			public const int ItemNode = 8;

			// Token: 0x040345C5 RID: 214469
			public const int ItemMidLineDashed = 9;

			// Token: 0x040345C6 RID: 214470
			public const int ItemMidLineSolid = 10;

			// Token: 0x040345C7 RID: 214471
			public const int ItemLevelUpIcon = 11;

			// Token: 0x040345C8 RID: 214472
			public const int ItemLoopAnim = 12;
		}
	}
}
