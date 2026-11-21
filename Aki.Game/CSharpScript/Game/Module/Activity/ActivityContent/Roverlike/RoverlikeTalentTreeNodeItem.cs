using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005124 RID: 20772
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentTreeNodeItem : UiPanelBase
	{
		// Token: 0x17006569 RID: 25961
		// (get) Token: 0x06033EE3 RID: 212707 RVA: 0x00E87376 File Offset: 0x00E85576
		[Nullable(2)]
		private RoverlikeTalentTreeData TreeData
		{
			[NullableContext(2)]
			get
			{
				RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
				if (currentActivityData == null)
				{
					return null;
				}
				return currentActivityData.TalentTreeData;
			}
		}

		// Token: 0x06033EE4 RID: 212708 RVA: 0x00E87390 File Offset: 0x00E85590
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033EE5 RID: 212709 RVA: 0x00E87630 File Offset: 0x00E85830
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(true);
			base.GetItem(0).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(1).SetUIActive(false);
			base.GetItem(10).SetUIActive(true);
			base.GetItem(9).SetUIActive(false);
		}

		// Token: 0x06033EE6 RID: 212710 RVA: 0x00E8768D File Offset: 0x00E8588D
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data.SetNodeToggleState = null;
			}
		}

		// Token: 0x06033EE7 RID: 212711 RVA: 0x00E876A4 File Offset: 0x00E858A4
		public void Refresh(RoverlikeTalentNodeData data)
		{
			this.Data = data;
			this.Data.SetNodeToggleState = new Action<bool, bool>(this.SetToggleState);
			bool flag = data.State == ERoverlikeTalentNodeState.Lock;
			RoverlikeTalentTreeData treeData = this.TreeData;
			bool uiactive = treeData != null && treeData.IsTalentCanUnlock(data);
			base.GetItem(5).SetUIActive(flag);
			base.GetItem(6).SetUIActive(!flag);
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUIItem item2 = base.GetItem(12);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive);
			}
			UUIText text = base.GetText(14);
			if (text != null)
			{
				text.SetUIActive(!flag);
			}
			if (!flag && text != null)
			{
				UUIText uuitext = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.CurLevel);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.MaxLevel);
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			RoverRogueTalentTree? roverRogueTalentTree;
			string iconPath = ((data.CurrentLevelConfig != null) ? roverRogueTalentTree.GetValueOrDefault().Icon : null) ?? data.HeadConfig.Icon;
			this.RefreshIcon(iconPath, flag, 13, 7);
			this.RefreshIcon(iconPath, flag, 15, 16);
		}

		// Token: 0x06033EE8 RID: 212712 RVA: 0x00E877DC File Offset: 0x00E859DC
		private void RefreshIcon(string iconPath, bool isLock, int texIndex, int sprIndex)
		{
			bool flag = iconPath.Contains("Atlas");
			UUITexture texture = base.GetTexture(texIndex);
			texture.SetUIActive(!flag);
			UUISprite sprite = base.GetSprite(sprIndex);
			sprite.SetUIActive(flag);
			if (flag)
			{
				this.SetSpriteByPath(iconPath, sprite, false, null, null);
				return;
			}
			base.SetTextureByPath(iconPath, texture, null, null);
		}

		// Token: 0x06033EE9 RID: 212713 RVA: 0x00E87840 File Offset: 0x00E85A40
		public UUIItem GetUpSolidLine()
		{
			return base.GetItem(2);
		}

		// Token: 0x06033EEA RID: 212714 RVA: 0x00E87849 File Offset: 0x00E85A49
		public UUIItem GetUpDashedLine()
		{
			return base.GetItem(0);
		}

		// Token: 0x06033EEB RID: 212715 RVA: 0x00E87852 File Offset: 0x00E85A52
		public UUIItem GetDownSolidLine()
		{
			return base.GetItem(3);
		}

		// Token: 0x06033EEC RID: 212716 RVA: 0x00E8785B File Offset: 0x00E85A5B
		public UUIItem GetDownDashedLine()
		{
			return base.GetItem(1);
		}

		// Token: 0x06033EED RID: 212717 RVA: 0x00E87864 File Offset: 0x00E85A64
		public UUIItem GetMidSolidLine()
		{
			return base.GetItem(10);
		}

		// Token: 0x06033EEE RID: 212718 RVA: 0x00E8786E File Offset: 0x00E85A6E
		public UUIItem GetMidDashedLine()
		{
			return base.GetItem(9);
		}

		// Token: 0x06033EEF RID: 212719 RVA: 0x00E87878 File Offset: 0x00E85A78
		public List<UUIItem> GetAllLines()
		{
			return new List<UUIItem>
			{
				base.GetItem(2),
				base.GetItem(0),
				base.GetItem(3),
				base.GetItem(1),
				base.GetItem(10),
				base.GetItem(9)
			};
		}

		// Token: 0x06033EF0 RID: 212720 RVA: 0x00E878DA File Offset: 0x00E85ADA
		public void SetNodeActive(bool isActive)
		{
			base.GetItem(8).SetUIActive(isActive);
		}

		// Token: 0x06033EF1 RID: 212721 RVA: 0x00E878E9 File Offset: 0x00E85AE9
		public void SetItemVisible(bool visible)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(visible);
		}

		// Token: 0x06033EF2 RID: 212722 RVA: 0x00E878FC File Offset: 0x00E85AFC
		private void OnClick(EToggleState toggleState)
		{
			if (this.Data != null)
			{
				RoverlikeTalentTreeData treeData = this.TreeData;
				if (treeData == null)
				{
					return;
				}
				Action<bool, RoverlikeTalentNodeData> onClickNode = treeData.OnClickNode;
				if (onClickNode == null)
				{
					return;
				}
				onClickNode(toggleState == EToggleState.ETT_Checked, this.Data);
			}
		}

		// Token: 0x06033EF3 RID: 212723 RVA: 0x00E8792A File Offset: 0x00E85B2A
		private void SetToggleState(bool isSelected, bool bFireEvent)
		{
			base.GetExtendToggle(4).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		}

		// Token: 0x0401B7CC RID: 112588
		[Nullable(2)]
		private RoverlikeTalentNodeData Data;

		// Token: 0x0200ADDB RID: 44507
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04035B95 RID: 220053
			public const int SprDashedLineUp = 0;

			// Token: 0x04035B96 RID: 220054
			public const int SprDashedLineDown = 1;

			// Token: 0x04035B97 RID: 220055
			public const int SprSolidLineUp = 2;

			// Token: 0x04035B98 RID: 220056
			public const int SprSolidLineDown = 3;

			// Token: 0x04035B99 RID: 220057
			public const int TogSkill = 4;

			// Token: 0x04035B9A RID: 220058
			public const int PnlLock = 5;

			// Token: 0x04035B9B RID: 220059
			public const int SprUnlock = 6;

			// Token: 0x04035B9C RID: 220060
			public const int SprIcon = 7;

			// Token: 0x04035B9D RID: 220061
			public const int PnlTog = 8;

			// Token: 0x04035B9E RID: 220062
			public const int SprMidLineDashed = 9;

			// Token: 0x04035B9F RID: 220063
			public const int SprMidLineSolid = 10;

			// Token: 0x04035BA0 RID: 220064
			public const int SprUpgradeHint = 11;

			// Token: 0x04035BA1 RID: 220065
			public const int PnlAni = 12;

			// Token: 0x04035BA2 RID: 220066
			public const int TexIcon = 13;

			// Token: 0x04035BA3 RID: 220067
			public const int TxtLevel = 14;

			// Token: 0x04035BA4 RID: 220068
			public const int TexIcon1 = 15;

			// Token: 0x04035BA5 RID: 220069
			public const int SprIcon1 = 16;
		}
	}
}
