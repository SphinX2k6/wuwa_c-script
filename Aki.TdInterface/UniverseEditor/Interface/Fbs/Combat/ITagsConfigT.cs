using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02006537 RID: 25911
	public class ITagsConfigT
	{
		// Token: 0x1700BF26 RID: 48934
		// (get) Token: 0x0602C2B4 RID: 180916 RVA: 0x00603F95 File Offset: 0x00602195
		// (set) Token: 0x0602C2B5 RID: 180917 RVA: 0x00603F9D File Offset: 0x0060219D
		public List<ITagConfigT> Tags { get; set; }

		// Token: 0x0602C2B6 RID: 180918 RVA: 0x00603FA6 File Offset: 0x006021A6
		public ITagsConfigT()
		{
			this.Tags = null;
		}
	}
}
