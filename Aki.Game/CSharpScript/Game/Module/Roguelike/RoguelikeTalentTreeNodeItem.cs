using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E43 RID: 20035
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeTalentTreeNodeItem : UiPanelBase
	{
		// Token: 0x06033A62 RID: 211554 RVA: 0x00C16F78 File Offset: 0x00C15178
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033A63 RID: 211555 RVA: 0x00C171B0 File Offset: 0x00C153B0
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(2).SetUIActive(true);
			base.GetItem(0).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(1).SetUIActive(false);
			base.GetItem(10).SetUIActive(true);
			base.GetItem(9).SetUIActive(false);
		}

		// Token: 0x06033A64 RID: 211556 RVA: 0x00C1721E File Offset: 0x00C1541E
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<int>(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnSkillLevelUp));
		}

		// Token: 0x06033A65 RID: 211557 RVA: 0x00C1723C File Offset: 0x00C1543C
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnSkillLevelUp));
		}

		// Token: 0x06033A66 RID: 211558 RVA: 0x00C1725A File Offset: 0x00C1545A
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data.SetNodeToggleState = null;
			}
		}

		// Token: 0x06033A67 RID: 211559 RVA: 0x00C17270 File Offset: 0x00C15470
		private void OnSkillLevelUp(int skillId)
		{
			if (this.Data != null)
			{
				this.Refresh(this.Data);
			}
		}

		// Token: 0x06033A68 RID: 211560 RVA: 0x00C17288 File Offset: 0x00C15488
		public void Refresh(RoguelikeTalentTreeNodeData data)
		{
			this.Data = data;
			this.Data.SetNodeToggleState = new Action<bool, bool>(this.SetToggleState);
			bool isLock = data.State == ETalentTreeNodeState.Lock;
			bool flag = data.State == ETalentTreeNodeState.Unlock;
			bool flag2 = data.State == ETalentTreeNodeState.Active;
			bool flag3 = data.CanAfford();
			this.RefreshIsLock(isLock);
			base.GetItem(11).SetUIActive(flag && flag3);
			base.GetItem(12).SetUIActive(flag && flag3);
			string talentIcon = data.DescConfig.TalentIcon;
			bool flag4 = talentIcon.Contains("Atlas");
			UUITexture texture = base.GetTexture(13);
			texture.SetUIActive(!flag4);
			UUISprite sprite = base.GetSprite(7);
			sprite.SetUIActive(flag4);
			if (flag4)
			{
				UUIItem uuiitem = sprite;
				bool bUseChangeColor = !flag2;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
				this.SetSpriteByPath(talentIcon, sprite, false, null, null);
			}
			else
			{
				UUIItem uuiitem2 = texture;
				bool bUseChangeColor2 = !flag2;
				FColor? fcolor = new FColor?(texture.changeColor);
				uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
				base.SetTextureByPath(talentIcon, texture, null, null);
			}
			string sequenceName = flag2 ? "Loop" : "Start1";
			this.SequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
			if (flag2 && !this.NodeUnlockStateCache)
			{
				this.SequencePlayer.PlayLevelSequenceByName("Start2", false, null, false);
			}
			this.NodeUnlockStateCache = flag2;
		}

		// Token: 0x06033A69 RID: 211561 RVA: 0x00C17405 File Offset: 0x00C15605
		private void RefreshIsLock(bool isLock)
		{
			base.GetItem(5).SetUIActive(isLock);
			base.GetItem(6).SetUIActive(!isLock);
		}

		// Token: 0x06033A6A RID: 211562 RVA: 0x00C17424 File Offset: 0x00C15624
		public UUIItem GetUpLine()
		{
			return base.GetItem(2);
		}

		// Token: 0x06033A6B RID: 211563 RVA: 0x00C1742D File Offset: 0x00C1562D
		public UUIItem GetDownLine()
		{
			return base.GetItem(3);
		}

		// Token: 0x06033A6C RID: 211564 RVA: 0x00C17436 File Offset: 0x00C15636
		public UUIItem GetMidLine()
		{
			return base.GetItem(10);
		}

		// Token: 0x06033A6D RID: 211565 RVA: 0x00C17440 File Offset: 0x00C15640
		public unsafe List<UUIItem> GetAllLines()
		{
			int num = 3;
			List<UUIItem> list = new List<UUIItem>(num);
			CollectionsMarshal.SetCount<UUIItem>(list, num);
			Span<UUIItem> span = CollectionsMarshal.AsSpan<UUIItem>(list);
			int num2 = 0;
			*span[num2] = base.GetItem(2);
			num2++;
			*span[num2] = base.GetItem(3);
			num2++;
			*span[num2] = base.GetItem(10);
			return list;
		}

		// Token: 0x06033A6E RID: 211566 RVA: 0x00C1749E File Offset: 0x00C1569E
		public void SetNodeActive(bool isActive)
		{
			base.GetItem(8).SetUIActive(isActive);
		}

		// Token: 0x06033A6F RID: 211567 RVA: 0x00C174AD File Offset: 0x00C156AD
		private void OnClick(EToggleState toggleState)
		{
			if (this.Data != null)
			{
				Action<bool, RoguelikeTalentTreeNodeData> onClickNode = RoguelikeModel.Instance.GetTalentTreeViewModel().OnClickNode;
				if (onClickNode == null)
				{
					return;
				}
				onClickNode(toggleState == EToggleState.ETT_Checked, this.Data);
			}
		}

		// Token: 0x06033A70 RID: 211568 RVA: 0x00C174DA File Offset: 0x00C156DA
		private void SetToggleState(bool isSelected, bool bFireEvent)
		{
			base.GetExtendToggle(4).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		}

		// Token: 0x0401B62E RID: 112174
		[Nullable(2)]
		private RoguelikeTalentTreeNodeData Data;

		// Token: 0x0401B62F RID: 112175
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401B630 RID: 112176
		private bool NodeUnlockStateCache = true;

		// Token: 0x0200B000 RID: 45056
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040356F9 RID: 218873
			public const int ItemDashedLineUp = 0;

			// Token: 0x040356FA RID: 218874
			public const int ItemDashedLineDown = 1;

			// Token: 0x040356FB RID: 218875
			public const int ItemSolidLineUp = 2;

			// Token: 0x040356FC RID: 218876
			public const int ItemSolidLineDown = 3;

			// Token: 0x040356FD RID: 218877
			public const int Toggle = 4;

			// Token: 0x040356FE RID: 218878
			public const int ItemLock = 5;

			// Token: 0x040356FF RID: 218879
			public const int ItemUnlock = 6;

			// Token: 0x04035700 RID: 218880
			public const int SpriteIcon = 7;

			// Token: 0x04035701 RID: 218881
			public const int ItemNode = 8;

			// Token: 0x04035702 RID: 218882
			public const int ItemMidLineDashed = 9;

			// Token: 0x04035703 RID: 218883
			public const int ItemMidLineSolid = 10;

			// Token: 0x04035704 RID: 218884
			public const int ItemLevelUpIcon = 11;

			// Token: 0x04035705 RID: 218885
			public const int ItemLoopAnim = 12;

			// Token: 0x04035706 RID: 218886
			public const int TexIcon = 13;
		}
	}
}
