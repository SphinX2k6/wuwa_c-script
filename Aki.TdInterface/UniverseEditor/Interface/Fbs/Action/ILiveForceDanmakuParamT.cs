using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F5 RID: 28917
	public class ILiveForceDanmakuParamT
	{
		// Token: 0x1700D3C4 RID: 54212
		// (get) Token: 0x06032386 RID: 205702 RVA: 0x006CAE9C File Offset: 0x006C909C
		// (set) Token: 0x06032387 RID: 205703 RVA: 0x006CAEA4 File Offset: 0x006C90A4
		public ELiveParamType Type { get; set; }

		// Token: 0x1700D3C5 RID: 54213
		// (get) Token: 0x06032388 RID: 205704 RVA: 0x006CAEAD File Offset: 0x006C90AD
		// (set) Token: 0x06032389 RID: 205705 RVA: 0x006CAEB5 File Offset: 0x006C90B5
		public ELiveForceDanmakuState State { get; set; }

		// Token: 0x0603238A RID: 205706 RVA: 0x006CAEBE File Offset: 0x006C90BE
		public ILiveForceDanmakuParamT()
		{
			this.Type = ELiveParamType.Heat;
			this.State = ELiveForceDanmakuState.Force;
		}
	}
}
