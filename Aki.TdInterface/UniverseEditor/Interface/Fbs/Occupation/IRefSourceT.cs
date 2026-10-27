using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043C0 RID: 17344
	public class IRefSourceT
	{
		// Token: 0x17007AAA RID: 31402
		// (get) Token: 0x06019DCC RID: 105932 RVA: 0x003B3B86 File Offset: 0x003B1D86
		// (set) Token: 0x06019DCD RID: 105933 RVA: 0x003B3B8E File Offset: 0x003B1D8E
		public ERefSourceType Type { get; set; }

		// Token: 0x06019DCE RID: 105934 RVA: 0x003B3B97 File Offset: 0x003B1D97
		public IRefSourceT()
		{
			this.Type = ERefSourceType.AwakeEntity;
		}
	}
}
