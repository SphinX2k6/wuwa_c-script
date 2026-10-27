using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B57 RID: 23383
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class MediumItemGridBase : IMediumItemGridBase
	{
		// Token: 0x17008CAD RID: 36013
		// (get) Token: 0x0603B37C RID: 242556
		public abstract EMediumItemGridType Type { get; }

		// Token: 0x0401ED92 RID: 126354
		public object Data;

		// Token: 0x0401ED93 RID: 126355
		public int? ItemConfigId;

		// Token: 0x0401ED94 RID: 126356
		public string BottomTextId;

		// Token: 0x0401ED95 RID: 126357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] BottomTextParameter;

		// Token: 0x0401ED96 RID: 126358
		public string BottomText;

		// Token: 0x0401ED97 RID: 126359
		public bool? IsOmitBottomText;

		// Token: 0x0401ED98 RID: 126360
		public string IconPath;

		// Token: 0x0401ED99 RID: 126361
		public int? QualityId;

		// Token: 0x0401ED9A RID: 126362
		public string QualityIcon;

		// Token: 0x0401ED9B RID: 126363
		public CommonDefine.EQualityIconType? QualityType;

		// Token: 0x0401ED9C RID: 126364
		public bool? IsQualityHidden;

		// Token: 0x0401ED9D RID: 126365
		public string SpriteIconPath;

		// Token: 0x0401ED9E RID: 126366
		public string LeftUpperIconPath;
	}
}
