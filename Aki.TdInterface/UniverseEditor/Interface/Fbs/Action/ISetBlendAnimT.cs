using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FCF RID: 28623
	public class ISetBlendAnimT
	{
		// Token: 0x1700D47E RID: 54398
		// (get) Token: 0x06032977 RID: 207223 RVA: 0x006D392F File Offset: 0x006D1B2F
		// (set) Token: 0x06032978 RID: 207224 RVA: 0x006D3937 File Offset: 0x006D1B37
		public IPlayerBlendAnimTargetT Target { get; set; }

		// Token: 0x1700D47F RID: 54399
		// (get) Token: 0x06032979 RID: 207225 RVA: 0x006D3940 File Offset: 0x006D1B40
		// (set) Token: 0x0603297A RID: 207226 RVA: 0x006D3948 File Offset: 0x006D1B48
		public TBlendAnimTypeUnion BlendType { get; set; }

		// Token: 0x0603297B RID: 207227 RVA: 0x006D3951 File Offset: 0x006D1B51
		public ISetBlendAnimT()
		{
			this.Target = null;
			this.BlendType = null;
		}
	}
}
