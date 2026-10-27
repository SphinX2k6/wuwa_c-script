using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AB8 RID: 19128
	public class ICheckJigsawTypeT
	{
		// Token: 0x17008AAB RID: 35499
		// (get) Token: 0x0601E078 RID: 123000 RVA: 0x00436EEE File Offset: 0x004350EE
		// (set) Token: 0x0601E079 RID: 123001 RVA: 0x00436EF6 File Offset: 0x004350F6
		public ECheckJigsawInfoType Type { get; set; }

		// Token: 0x0601E07A RID: 123002 RVA: 0x00436EFF File Offset: 0x004350FF
		public ICheckJigsawTypeT()
		{
			this.Type = ECheckJigsawInfoType.CheckJigsawItemPlaceIndex;
		}
	}
}
