using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C2C RID: 15404
	public class IRangeT
	{
		// Token: 0x17006A10 RID: 27152
		// (get) Token: 0x06015435 RID: 87093 RVA: 0x00313FF2 File Offset: 0x003121F2
		// (set) Token: 0x06015436 RID: 87094 RVA: 0x00313FFA File Offset: 0x003121FA
		public ERangeType Type { get; set; }

		// Token: 0x06015437 RID: 87095 RVA: 0x00314003 File Offset: 0x00312203
		public IRangeT()
		{
			this.Type = ERangeType.CircleRange;
		}
	}
}
