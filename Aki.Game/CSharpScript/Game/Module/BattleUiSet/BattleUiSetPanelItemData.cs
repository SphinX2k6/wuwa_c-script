using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUiSet
{
	// Token: 0x02005E63 RID: 24163
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiSetPanelItemData
	{
		// Token: 0x0603D6D4 RID: 251604 RVA: 0x00ED1084 File Offset: 0x00ECF284
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

		// Token: 0x0603D6D5 RID: 251605 RVA: 0x00ED11F2 File Offset: 0x00ECF3F2
		public void ReInit()
		{
			this.EditSize = this.Size;
			this.EditAlpha = this.Alpha;
			this.EditOffsetX = this.OffsetX;
			this.EditOffsetY = this.OffsetY;
		}

		// Token: 0x0603D6D6 RID: 251606 RVA: 0x00ED1224 File Offset: 0x00ECF424
		public bool IsEdited()
		{
			return this.EditSize != this.Size || this.EditAlpha != this.Alpha || this.EditOffsetY != this.OffsetY || this.EditOffsetX != this.OffsetX;
		}

		// Token: 0x0603D6D7 RID: 251607 RVA: 0x00ED1263 File Offset: 0x00ECF463
		public bool IsInitialized()
		{
			return this.Size != 0f || this.Alpha != 0f || this.OffsetX != 0f || this.OffsetY != 0f;
		}

		// Token: 0x0603D6D8 RID: 251608 RVA: 0x00ED12A0 File Offset: 0x00ECF4A0
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

		// Token: 0x040200DD RID: 131293
		public readonly int PanelIndex;

		// Token: 0x040200DE RID: 131294
		public readonly int PanelItemIndex;

		// Token: 0x040200DF RID: 131295
		public readonly int ConfigId;

		// Token: 0x040200E0 RID: 131296
		public float Size;

		// Token: 0x040200E1 RID: 131297
		public float EditSize;

		// Token: 0x040200E2 RID: 131298
		public readonly float SourceSize;

		// Token: 0x040200E3 RID: 131299
		public float Alpha;

		// Token: 0x040200E4 RID: 131300
		public float EditAlpha;

		// Token: 0x040200E5 RID: 131301
		public readonly float SourceAlpha;

		// Token: 0x040200E6 RID: 131302
		public float OffsetX;

		// Token: 0x040200E7 RID: 131303
		public float EditOffsetX;

		// Token: 0x040200E8 RID: 131304
		public readonly float SourceOffsetX;

		// Token: 0x040200E9 RID: 131305
		public float OffsetY;

		// Token: 0x040200EA RID: 131306
		public float EditOffsetY;

		// Token: 0x040200EB RID: 131307
		public readonly float SourceOffsetY;

		// Token: 0x040200EC RID: 131308
		private readonly string Name;

		// Token: 0x040200ED RID: 131309
		public int HierarchyIndex;

		// Token: 0x040200EE RID: 131310
		public int EditorHierarchyIndex;

		// Token: 0x040200EF RID: 131311
		public int SourceHierarchyIndex;

		// Token: 0x040200F0 RID: 131312
		public readonly bool CanEdit;

		// Token: 0x040200F1 RID: 131313
		public readonly bool IsDefaultSelected;

		// Token: 0x040200F2 RID: 131314
		public readonly bool IsCheckOverlap;
	}
}
