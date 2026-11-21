using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003E0C RID: 15884
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeTalentTreeNodeItem : UiPanelBase
	{
		// Token: 0x060288CD RID: 166093 RVA: 0x00B604A0 File Offset: 0x00B5E6A0
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

		// Token: 0x060288CE RID: 166094 RVA: 0x00B606D8 File Offset: 0x00B5E8D8
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

		// Token: 0x060288CF RID: 166095 RVA: 0x00B60746 File Offset: 0x00B5E946
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add<int>(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnSkillLevelUp));
		}

		// Token: 0x060288D0 RID: 166096 RVA: 0x00B60764 File Offset: 0x00B5E964
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnSkillLevelUp));
		}

		// Token: 0x060288D1 RID: 166097 RVA: 0x00B60782 File Offset: 0x00B5E982
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data.SetNodeToggleState = null;
			}
		}

		// Token: 0x060288D2 RID: 166098 RVA: 0x00B60798 File Offset: 0x00B5E998
		private void OnSkillLevelUp(int skillId)
		{
			if (this.Data != null)
			{
				this.Refresh(this.Data);
			}
		}

		// Token: 0x060288D3 RID: 166099 RVA: 0x00B607B0 File Offset: 0x00B5E9B0
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

		// Token: 0x060288D4 RID: 166100 RVA: 0x00B6092D File Offset: 0x00B5EB2D
		private void RefreshIsLock(bool isLock)
		{
			base.GetItem(5).SetUIActive(isLock);
			base.GetItem(6).SetUIActive(!isLock);
		}

		// Token: 0x060288D5 RID: 166101 RVA: 0x00B6094C File Offset: 0x00B5EB4C
		public UUIItem GetUpLine()
		{
			return base.GetItem(2);
		}

		// Token: 0x060288D6 RID: 166102 RVA: 0x00B60955 File Offset: 0x00B5EB55
		public UUIItem GetDownLine()
		{
			return base.GetItem(3);
		}

		// Token: 0x060288D7 RID: 166103 RVA: 0x00B6095E File Offset: 0x00B5EB5E
		public UUIItem GetMidLine()
		{
			return base.GetItem(10);
		}

		// Token: 0x060288D8 RID: 166104 RVA: 0x00B60968 File Offset: 0x00B5EB68
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

		// Token: 0x060288D9 RID: 166105 RVA: 0x00B609C6 File Offset: 0x00B5EBC6
		public void SetNodeActive(bool isActive)
		{
			base.GetItem(8).SetUIActive(isActive);
		}

		// Token: 0x060288DA RID: 166106 RVA: 0x00B609D5 File Offset: 0x00B5EBD5
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

		// Token: 0x060288DB RID: 166107 RVA: 0x00B60A02 File Offset: 0x00B5EC02
		private void SetToggleState(bool isSelected, bool bFireEvent)
		{
			base.GetExtendToggle(4).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		}

		// Token: 0x04016001 RID: 90113
		[Nullable(2)]
		private RoguelikeTalentTreeNodeData Data;

		// Token: 0x04016002 RID: 90114
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x04016003 RID: 90115
		private bool NodeUnlockStateCache = true;

		// Token: 0x02009A32 RID: 39474
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04030129 RID: 196905
			public const int ItemDashedLineUp = 0;

			// Token: 0x0403012A RID: 196906
			public const int ItemDashedLineDown = 1;

			// Token: 0x0403012B RID: 196907
			public const int ItemSolidLineUp = 2;

			// Token: 0x0403012C RID: 196908
			public const int ItemSolidLineDown = 3;

			// Token: 0x0403012D RID: 196909
			public const int Toggle = 4;

			// Token: 0x0403012E RID: 196910
			public const int ItemLock = 5;

			// Token: 0x0403012F RID: 196911
			public const int ItemUnlock = 6;

			// Token: 0x04030130 RID: 196912
			public const int SpriteIcon = 7;

			// Token: 0x04030131 RID: 196913
			public const int ItemNode = 8;

			// Token: 0x04030132 RID: 196914
			public const int ItemMidLineDashed = 9;

			// Token: 0x04030133 RID: 196915
			public const int ItemMidLineSolid = 10;

			// Token: 0x04030134 RID: 196916
			public const int ItemLevelUpIcon = 11;

			// Token: 0x04030135 RID: 196917
			public const int ItemLoopAnim = 12;

			// Token: 0x04030136 RID: 196918
			public const int TexIcon = 13;
		}
	}
}
