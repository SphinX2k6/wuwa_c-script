using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045CF RID: 17871
	public class ITakePhoto2ModeBaseT
	{
		// Token: 0x17007CFF RID: 31999
		// (get) Token: 0x0601A19F RID: 106911 RVA: 0x003B83FE File Offset: 0x003B65FE
		// (set) Token: 0x0601A1A0 RID: 106912 RVA: 0x003B8406 File Offset: 0x003B6606
		public ETakePhoto2Mode Type { get; set; }

		// Token: 0x0601A1A1 RID: 106913 RVA: 0x003B840F File Offset: 0x003B660F
		public ITakePhoto2ModeBaseT()
		{
			this.Type = ETakePhoto2Mode.BeforeYourEyes;
		}
	}
}
