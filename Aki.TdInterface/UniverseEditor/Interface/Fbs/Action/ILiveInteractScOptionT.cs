using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200710D RID: 28941
	public class ILiveInteractScOptionT
	{
		// Token: 0x1700D3F2 RID: 54258
		// (get) Token: 0x06032455 RID: 205909 RVA: 0x006CC5A4 File Offset: 0x006CA7A4
		// (set) Token: 0x06032456 RID: 205910 RVA: 0x006CC5AC File Offset: 0x006CA7AC
		public ESystemOptionType Type { get; set; }

		// Token: 0x1700D3F3 RID: 54259
		// (get) Token: 0x06032457 RID: 205911 RVA: 0x006CC5B5 File Offset: 0x006CA7B5
		// (set) Token: 0x06032458 RID: 205912 RVA: 0x006CC5BD File Offset: 0x006CA7BD
		public List<ISystemOptionT> SystemOptions { get; set; }

		// Token: 0x1700D3F4 RID: 54260
		// (get) Token: 0x06032459 RID: 205913 RVA: 0x006CC5C6 File Offset: 0x006CA7C6
		// (set) Token: 0x0603245A RID: 205914 RVA: 0x006CC5CE File Offset: 0x006CA7CE
		public bool KeepPreTalkItem { get; set; }

		// Token: 0x1700D3F5 RID: 54261
		// (get) Token: 0x0603245B RID: 205915 RVA: 0x006CC5D7 File Offset: 0x006CA7D7
		// (set) Token: 0x0603245C RID: 205916 RVA: 0x006CC5DF File Offset: 0x006CA7DF
		public List<int> ScIds { get; set; }

		// Token: 0x1700D3F6 RID: 54262
		// (get) Token: 0x0603245D RID: 205917 RVA: 0x006CC5E8 File Offset: 0x006CA7E8
		// (set) Token: 0x0603245E RID: 205918 RVA: 0x006CC5F0 File Offset: 0x006CA7F0
		public byte NullMask { get; set; }

		// Token: 0x0603245F RID: 205919 RVA: 0x006CC5F9 File Offset: 0x006CA7F9
		public ILiveInteractScOptionT()
		{
			this.Type = ESystemOptionType.RogueRandomEvent;
			this.SystemOptions = null;
			this.KeepPreTalkItem = false;
			this.ScIds = null;
			this.NullMask = 0;
		}
	}
}
