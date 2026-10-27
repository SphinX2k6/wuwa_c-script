using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005178 RID: 20856
	public class IEntityGravityConfigT
	{
		// Token: 0x1700985B RID: 39003
		// (get) Token: 0x06021B6F RID: 138095 RVA: 0x004ADB83 File Offset: 0x004ABD83
		// (set) Token: 0x06021B70 RID: 138096 RVA: 0x004ADB8B File Offset: 0x004ABD8B
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700985C RID: 39004
		// (get) Token: 0x06021B71 RID: 138097 RVA: 0x004ADB94 File Offset: 0x004ABD94
		// (set) Token: 0x06021B72 RID: 138098 RVA: 0x004ADB9C File Offset: 0x004ABD9C
		public bool SpecifyGravityLoad { get; set; }

		// Token: 0x1700985D RID: 39005
		// (get) Token: 0x06021B73 RID: 138099 RVA: 0x004ADBA5 File Offset: 0x004ABDA5
		// (set) Token: 0x06021B74 RID: 138100 RVA: 0x004ADBAD File Offset: 0x004ABDAD
		public bool SpecifyGravityLock { get; set; }

		// Token: 0x1700985E RID: 39006
		// (get) Token: 0x06021B75 RID: 138101 RVA: 0x004ADBB6 File Offset: 0x004ABDB6
		// (set) Token: 0x06021B76 RID: 138102 RVA: 0x004ADBBE File Offset: 0x004ABDBE
		public byte NullMask { get; set; }

		// Token: 0x06021B77 RID: 138103 RVA: 0x004ADBC7 File Offset: 0x004ABDC7
		public IEntityGravityConfigT()
		{
			this.GravityDirection = null;
			this.SpecifyGravityLoad = false;
			this.SpecifyGravityLock = false;
			this.NullMask = 0;
		}
	}
}
