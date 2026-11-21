using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B4 RID: 21940
	public class ICustomAoizRadiusT
	{
		// Token: 0x17009D18 RID: 40216
		// (get) Token: 0x06022E73 RID: 142963 RVA: 0x004CE59E File Offset: 0x004CC79E
		// (set) Token: 0x06022E74 RID: 142964 RVA: 0x004CE5A6 File Offset: 0x004CC7A6
		public int Up { get; set; }

		// Token: 0x17009D19 RID: 40217
		// (get) Token: 0x06022E75 RID: 142965 RVA: 0x004CE5AF File Offset: 0x004CC7AF
		// (set) Token: 0x06022E76 RID: 142966 RVA: 0x004CE5B7 File Offset: 0x004CC7B7
		public int Down { get; set; }

		// Token: 0x17009D1A RID: 40218
		// (get) Token: 0x06022E77 RID: 142967 RVA: 0x004CE5C0 File Offset: 0x004CC7C0
		// (set) Token: 0x06022E78 RID: 142968 RVA: 0x004CE5C8 File Offset: 0x004CC7C8
		public byte NullMask { get; set; }

		// Token: 0x06022E79 RID: 142969 RVA: 0x004CE5D1 File Offset: 0x004CC7D1
		public ICustomAoizRadiusT()
		{
			this.Up = 0;
			this.Down = 0;
			this.NullMask = 0;
		}
	}
}
