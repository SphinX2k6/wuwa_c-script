using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B36 RID: 19254
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class MediumItemGridBase : IMediumItemGridBase
	{
		// Token: 0x1700607F RID: 24703
		// (get) Token: 0x060302C8 RID: 197320
		public abstract EMediumItemGridType Type { get; }

		// Token: 0x0401983E RID: 104510
		public object Data;

		// Token: 0x0401983F RID: 104511
		public int? ItemConfigId;

		// Token: 0x04019840 RID: 104512
		public string BottomTextId;

		// Token: 0x04019841 RID: 104513
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] BottomTextParameter;

		// Token: 0x04019842 RID: 104514
		public string BottomText;

		// Token: 0x04019843 RID: 104515
		public bool? IsOmitBottomText;

		// Token: 0x04019844 RID: 104516
		public string IconPath;

		// Token: 0x04019845 RID: 104517
		public int? QualityId;

		// Token: 0x04019846 RID: 104518
		public string QualityIcon;

		// Token: 0x04019847 RID: 104519
		public CommonDefine.EQualityIconType? QualityType;

		// Token: 0x04019848 RID: 104520
		public bool? IsQualityHidden;

		// Token: 0x04019849 RID: 104521
		public string SpriteIconPath;

		// Token: 0x0401984A RID: 104522
		public string LeftUpperIconPath;
	}
}
