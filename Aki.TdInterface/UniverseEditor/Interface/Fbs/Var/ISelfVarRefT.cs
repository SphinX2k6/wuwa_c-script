using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ED2 RID: 16082
	public class ISelfVarRefT
	{
		// Token: 0x17006CE4 RID: 27876
		// (get) Token: 0x06015C67 RID: 89191 RVA: 0x003220E5 File Offset: 0x003202E5
		// (set) Token: 0x06015C68 RID: 89192 RVA: 0x003220ED File Offset: 0x003202ED
		public EVar Type { get; set; }

		// Token: 0x17006CE5 RID: 27877
		// (get) Token: 0x06015C69 RID: 89193 RVA: 0x003220F6 File Offset: 0x003202F6
		// (set) Token: 0x06015C6A RID: 89194 RVA: 0x003220FE File Offset: 0x003202FE
		public EVarRefSource Source { get; set; }

		// Token: 0x17006CE6 RID: 27878
		// (get) Token: 0x06015C6B RID: 89195 RVA: 0x00322107 File Offset: 0x00320307
		// (set) Token: 0x06015C6C RID: 89196 RVA: 0x0032210F File Offset: 0x0032030F
		public string Name { get; set; }

		// Token: 0x06015C6D RID: 89197 RVA: 0x00322118 File Offset: 0x00320318
		public ISelfVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
			this.Name = null;
		}
	}
}
