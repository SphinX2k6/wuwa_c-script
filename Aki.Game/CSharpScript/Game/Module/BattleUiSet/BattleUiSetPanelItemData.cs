using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUiSet
{
	// Token: 0x02004E48 RID: 20040
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiSetPanelItemData
	{
		// Token: 0x06032664 RID: 206436 RVA: 0x00E225F4 File Offset: 0x00E207F4
		public BattleUiSetPanelItemData(int index, in MobileBattleUiSet config)
		{
			MobileBattleUiSet mobileBattleUiSet = config;
			this.PanelIndex = mobileBattleUiSet.PanelIndex;
			this.PanelItemIndex = index;
			mobileBattleUiSet = config;
			this.ConfigId = mobileBattleUiSet.Id;
			mobileBattleUiSet = config;
			this.Size = mobileBattleUiSet.SourceSize;
			this.EditSize = this.Size;
			this.SourceSize = this.Size;
			mobileBattleUiSet = config;
			this.Alpha = mobileBattleUiSet.SourceAlpha;
			this.EditAlpha = this.Alpha;
			this.SourceAlpha = this.Alpha;
			mobileBattleUiSet = config;
			this.OffsetX = mobileBattleUiSet.SourceOffsetX;
			this.EditOffsetX = this.OffsetX;
			this.SourceOffsetX = this.OffsetX;
			mobileBattleUiSet = config;
			this.OffsetY = mobileBattleUiSet.SourceOffsetY;
			this.EditOffsetY = this.OffsetY;
			this.SourceOffsetY = this.OffsetY;
			mobileBattleUiSet = config;
			this.Name = mobileBattleUiSet.Name;
			mobileBattleUiSet = config;
			this.CanEdit = mobileBattleUiSet.CanEdit;
			mobileBattleUiSet = config;
			this.IsDefaultSelected = mobileBattleUiSet.IsDefaultSelected;
			mobileBattleUiSet = config;
			this.IsCheckOverlap = mobileBattleUiSet.IsCheckOverlap;
			mobileBattleUiSet = config;
			this.HierarchyIndex = mobileBattleUiSet.SourceHierarchyIndex;
			this.EditorHierarchyIndex = this.HierarchyIndex;
			this.SourceHierarchyIndex = this.HierarchyIndex;
		}

		// Token: 0x06032665 RID: 206437 RVA: 0x00E22762 File Offset: 0x00E20962
		public void ReInit()
		{
			this.EditSize = this.Size;
			this.EditAlpha = this.Alpha;
			this.EditOffsetX = this.OffsetX;
			this.EditOffsetY = this.OffsetY;
		}

		// Token: 0x06032666 RID: 206438 RVA: 0x00E22794 File Offset: 0x00E20994
		public bool IsEdited()
		{
			return this.EditSize != this.Size || this.EditAlpha != this.Alpha || this.EditOffsetY != this.OffsetY || this.EditOffsetX != this.OffsetX;
		}

		// Token: 0x06032667 RID: 206439 RVA: 0x00E227D3 File Offset: 0x00E209D3
		public bool IsInitialized()
		{
			return this.Size != 0f || this.Alpha != 0f || this.OffsetX != 0f || this.OffsetY != 0f;
		}

		// Token: 0x06032668 RID: 206440 RVA: 0x00E22810 File Offset: 0x00E20A10
		public string GetDebugString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 5);
			defaultInterpolatedStringHandler.AppendLiteral("按键名称：");
			defaultInterpolatedStringHandler.AppendFormatted(this.Name);
			defaultInterpolatedStringHandler.AppendLiteral("，尺寸：");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Size);
			defaultInterpolatedStringHandler.AppendLiteral("，透明度：");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Alpha);
			defaultInterpolatedStringHandler.AppendLiteral("，位置：");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.OffsetX);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.OffsetY);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0401ABA4 RID: 109476
		public readonly int PanelIndex;

		// Token: 0x0401ABA5 RID: 109477
		public readonly int PanelItemIndex;

		// Token: 0x0401ABA6 RID: 109478
		public readonly int ConfigId;

		// Token: 0x0401ABA7 RID: 109479
		public float Size;

		// Token: 0x0401ABA8 RID: 109480
		public float EditSize;

		// Token: 0x0401ABA9 RID: 109481
		public readonly float SourceSize;

		// Token: 0x0401ABAA RID: 109482
		public float Alpha;

		// Token: 0x0401ABAB RID: 109483
		public float EditAlpha;

		// Token: 0x0401ABAC RID: 109484
		public readonly float SourceAlpha;

		// Token: 0x0401ABAD RID: 109485
		public float OffsetX;

		// Token: 0x0401ABAE RID: 109486
		public float EditOffsetX;

		// Token: 0x0401ABAF RID: 109487
		public readonly float SourceOffsetX;

		// Token: 0x0401ABB0 RID: 109488
		public float OffsetY;

		// Token: 0x0401ABB1 RID: 109489
		public float EditOffsetY;

		// Token: 0x0401ABB2 RID: 109490
		public readonly float SourceOffsetY;

		// Token: 0x0401ABB3 RID: 109491
		private readonly string Name;

		// Token: 0x0401ABB4 RID: 109492
		public int HierarchyIndex;

		// Token: 0x0401ABB5 RID: 109493
		public int EditorHierarchyIndex;

		// Token: 0x0401ABB6 RID: 109494
		public int SourceHierarchyIndex;

		// Token: 0x0401ABB7 RID: 109495
		public readonly bool CanEdit;

		// Token: 0x0401ABB8 RID: 109496
		public readonly bool IsDefaultSelected;

		// Token: 0x0401ABB9 RID: 109497
		public readonly bool IsCheckOverlap;
	}
}
