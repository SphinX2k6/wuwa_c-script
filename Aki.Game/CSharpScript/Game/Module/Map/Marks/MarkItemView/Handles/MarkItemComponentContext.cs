using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004501 RID: 17665
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkItemComponentContext : IMarkItemComponentContext
	{
		// Token: 0x1700594E RID: 22862
		// (get) Token: 0x0602C986 RID: 182662 RVA: 0x00C845EC File Offset: 0x00C827EC
		// (set) Token: 0x0602C987 RID: 182663 RVA: 0x00C845F4 File Offset: 0x00C827F4
		public UUISprite TopRightIconSprite { get; set; }

		// Token: 0x1700594F RID: 22863
		// (get) Token: 0x0602C988 RID: 182664 RVA: 0x00C845FD File Offset: 0x00C827FD
		// (set) Token: 0x0602C989 RID: 182665 RVA: 0x00C84605 File Offset: 0x00C82805
		public TSetSpriteByPathAction SetSpriteByPathAction { get; set; }

		// Token: 0x17005950 RID: 22864
		// (get) Token: 0x0602C98A RID: 182666 RVA: 0x00C8460E File Offset: 0x00C8280E
		// (set) Token: 0x0602C98B RID: 182667 RVA: 0x00C84616 File Offset: 0x00C82816
		public UUIItem MarkComponentContainer { get; set; }

		// Token: 0x17005951 RID: 22865
		// (get) Token: 0x0602C98C RID: 182668 RVA: 0x00C8461F File Offset: 0x00C8281F
		// (set) Token: 0x0602C98D RID: 182669 RVA: 0x00C84627 File Offset: 0x00C82827
		public UUIItem MarkParentItem { get; set; }

		// Token: 0x17005952 RID: 22866
		// (get) Token: 0x0602C98E RID: 182670 RVA: 0x00C84630 File Offset: 0x00C82830
		// (set) Token: 0x0602C98F RID: 182671 RVA: 0x00C84638 File Offset: 0x00C82838
		public UUIItem MarkRootItem { get; set; }

		// Token: 0x17005953 RID: 22867
		// (get) Token: 0x0602C990 RID: 182672 RVA: 0x00C84641 File Offset: 0x00C82841
		// (set) Token: 0x0602C991 RID: 182673 RVA: 0x00C84649 File Offset: 0x00C82849
		public MarkItem MarkItem { get; set; }

		// Token: 0x0602C992 RID: 182674 RVA: 0x00C84652 File Offset: 0x00C82852
		public bool CanExecuteComponentLogic()
		{
			return !this.MarkItem.IsDestroy || MapDefine.HasSingleComponentMarkType.Contains(this.MarkItem.MarkType);
		}
	}
}
