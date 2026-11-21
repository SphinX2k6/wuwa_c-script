using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E6C RID: 15980
	public class IConstVarRefT
	{
		// Token: 0x17006BE6 RID: 27622
		// (get) Token: 0x06015898 RID: 88216 RVA: 0x0031AFED File Offset: 0x003191ED
		// (set) Token: 0x06015899 RID: 88217 RVA: 0x0031AFF5 File Offset: 0x003191F5
		public EVar Type { get; set; }

		// Token: 0x17006BE7 RID: 27623
		// (get) Token: 0x0601589A RID: 88218 RVA: 0x0031AFFE File Offset: 0x003191FE
		// (set) Token: 0x0601589B RID: 88219 RVA: 0x0031B006 File Offset: 0x00319206
		public EVarRefSource Source { get; set; }

		// Token: 0x17006BE8 RID: 27624
		// (get) Token: 0x0601589C RID: 88220 RVA: 0x0031B00F File Offset: 0x0031920F
		// (set) Token: 0x0601589D RID: 88221 RVA: 0x0031B017 File Offset: 0x00319217
		public TVarValueUnion Value { get; set; }

		// Token: 0x0601589E RID: 88222 RVA: 0x0031B020 File Offset: 0x00319220
		public IConstVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
			this.Value = null;
		}
	}
}
