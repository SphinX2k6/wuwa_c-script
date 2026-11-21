using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007110 RID: 28944
	public class ILiveLikeParamT
	{
		// Token: 0x1700D3FA RID: 54266
		// (get) Token: 0x06032471 RID: 205937 RVA: 0x006CC83C File Offset: 0x006CAA3C
		// (set) Token: 0x06032472 RID: 205938 RVA: 0x006CC844 File Offset: 0x006CAA44
		public ELiveParamType Type { get; set; }

		// Token: 0x1700D3FB RID: 54267
		// (get) Token: 0x06032473 RID: 205939 RVA: 0x006CC84D File Offset: 0x006CAA4D
		// (set) Token: 0x06032474 RID: 205940 RVA: 0x006CC855 File Offset: 0x006CAA55
		public ELiveLikeState State { get; set; }

		// Token: 0x06032475 RID: 205941 RVA: 0x006CC85E File Offset: 0x006CAA5E
		public ILiveLikeParamT()
		{
			this.Type = ELiveParamType.Heat;
			this.State = ELiveLikeState.Enable;
		}
	}
}
