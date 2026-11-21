using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED6 RID: 28374
	public class IFoldableT
	{
		// Token: 0x1700D01C RID: 53276
		// (get) Token: 0x0603117F RID: 201087 RVA: 0x006A8148 File Offset: 0x006A6348
		// (set) Token: 0x06031180 RID: 201088 RVA: 0x006A8150 File Offset: 0x006A6350
		public bool _Folded { get; set; }

		// Token: 0x1700D01D RID: 53277
		// (get) Token: 0x06031181 RID: 201089 RVA: 0x006A8159 File Offset: 0x006A6359
		// (set) Token: 0x06031182 RID: 201090 RVA: 0x006A8161 File Offset: 0x006A6361
		public byte NullMask { get; set; }

		// Token: 0x06031183 RID: 201091 RVA: 0x006A816A File Offset: 0x006A636A
		public IFoldableT()
		{
			this._Folded = false;
			this.NullMask = 0;
		}
	}
}
