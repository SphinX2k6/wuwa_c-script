using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020061A6 RID: 24998
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentTreeNodeItem : UiPanelBase
	{
		// Token: 0x17009207 RID: 37383
		// (get) Token: 0x0603F223 RID: 258595 RVA: 0x00F404AE File Offset: 0x00F3E6AE
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

		// Token: 0x0603F224 RID: 258596 RVA: 0x00F404C8 File Offset: 0x00F3E6C8
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

		// Token: 0x0603F225 RID: 258597 RVA: 0x00F40768 File Offset: 0x00F3E968
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(true);
			base.GetItem(0).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(1).SetUIActive(false);
			base.GetItem(10).SetUIActive(true);
			base.GetItem(9).SetUIActive(false);
		}

		// Token: 0x0603F226 RID: 258598 RVA: 0x00F407C5 File Offset: 0x00F3E9C5
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data.SetNodeToggleState = null;
			}
		}

		// Token: 0x0603F227 RID: 258599 RVA: 0x00F407DC File Offset: 0x00F3E9DC
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

		// Token: 0x0603F228 RID: 258600 RVA: 0x00F40914 File Offset: 0x00F3EB14
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

		// Token: 0x0603F229 RID: 258601 RVA: 0x00F40978 File Offset: 0x00F3EB78
		public UUIItem GetUpSolidLine()
		{
			return base.GetItem(2);
		}

		// Token: 0x0603F22A RID: 258602 RVA: 0x00F40981 File Offset: 0x00F3EB81
		public UUIItem GetUpDashedLine()
		{
			return base.GetItem(0);
		}

		// Token: 0x0603F22B RID: 258603 RVA: 0x00F4098A File Offset: 0x00F3EB8A
		public UUIItem GetDownSolidLine()
		{
			return base.GetItem(3);
		}

		// Token: 0x0603F22C RID: 258604 RVA: 0x00F40993 File Offset: 0x00F3EB93
		public UUIItem GetDownDashedLine()
		{
			return base.GetItem(1);
		}

		// Token: 0x0603F22D RID: 258605 RVA: 0x00F4099C File Offset: 0x00F3EB9C
		public UUIItem GetMidSolidLine()
		{
			return base.GetItem(10);
		}

		// Token: 0x0603F22E RID: 258606 RVA: 0x00F409A6 File Offset: 0x00F3EBA6
		public UUIItem GetMidDashedLine()
		{
			return base.GetItem(9);
		}

		// Token: 0x0603F22F RID: 258607 RVA: 0x00F409B0 File Offset: 0x00F3EBB0
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

		// Token: 0x0603F230 RID: 258608 RVA: 0x00F40A12 File Offset: 0x00F3EC12
		public void SetNodeActive(bool isActive)
		{
			base.GetItem(8).SetUIActive(isActive);
		}

		// Token: 0x0603F231 RID: 258609 RVA: 0x00F40A21 File Offset: 0x00F3EC21
		public void SetItemVisible(bool visible)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(visible);
		}

		// Token: 0x0603F232 RID: 258610 RVA: 0x00F40A34 File Offset: 0x00F3EC34
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

		// Token: 0x0603F233 RID: 258611 RVA: 0x00F40A62 File Offset: 0x00F3EC62
		private void SetToggleState(bool isSelected, bool bFireEvent)
		{
			base.GetExtendToggle(4).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		}

		// Token: 0x04020E9F RID: 134815
		[Nullable(2)]
		private RoverlikeTalentNodeData Data;

		// Token: 0x0200C3F4 RID: 50164
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403B234 RID: 242228
			public const int SprDashedLineUp = 0;

			// Token: 0x0403B235 RID: 242229
			public const int SprDashedLineDown = 1;

			// Token: 0x0403B236 RID: 242230
			public const int SprSolidLineUp = 2;

			// Token: 0x0403B237 RID: 242231
			public const int SprSolidLineDown = 3;

			// Token: 0x0403B238 RID: 242232
			public const int TogSkill = 4;

			// Token: 0x0403B239 RID: 242233
			public const int PnlLock = 5;

			// Token: 0x0403B23A RID: 242234
			public const int SprUnlock = 6;

			// Token: 0x0403B23B RID: 242235
			public const int SprIcon = 7;

			// Token: 0x0403B23C RID: 242236
			public const int PnlTog = 8;

			// Token: 0x0403B23D RID: 242237
			public const int SprMidLineDashed = 9;

			// Token: 0x0403B23E RID: 242238
			public const int SprMidLineSolid = 10;

			// Token: 0x0403B23F RID: 242239
			public const int SprUpgradeHint = 11;

			// Token: 0x0403B240 RID: 242240
			public const int PnlAni = 12;

			// Token: 0x0403B241 RID: 242241
			public const int TexIcon = 13;

			// Token: 0x0403B242 RID: 242242
			public const int TxtLevel = 14;

			// Token: 0x0403B243 RID: 242243
			public const int TexIcon1 = 15;

			// Token: 0x0403B244 RID: 242244
			public const int SprIcon1 = 16;
		}
	}
}
