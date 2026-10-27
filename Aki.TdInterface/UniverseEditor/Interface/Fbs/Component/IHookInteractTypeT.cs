using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C3 RID: 21443
	public class IHookInteractTypeT
	{
		// Token: 0x17009DA1 RID: 40353
		// (get) Token: 0x0602326E RID: 143982 RVA: 0x004DDD00 File Offset: 0x004DBF00
		// (set) Token: 0x0602326F RID: 143983 RVA: 0x004DDD08 File Offset: 0x004DBF08
		public EHookInteractType Type { get; set; }

		// Token: 0x17009DA2 RID: 40354
		// (get) Token: 0x06023270 RID: 143984 RVA: 0x004DDD11 File Offset: 0x004DBF11
		// (set) Token: 0x06023271 RID: 143985 RVA: 0x004DDD19 File Offset: 0x004DBF19
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009DA3 RID: 40355
		// (get) Token: 0x06023272 RID: 143986 RVA: 0x004DDD22 File Offset: 0x004DBF22
		// (set) Token: 0x06023273 RID: 143987 RVA: 0x004DDD2A File Offset: 0x004DBF2A
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009DA4 RID: 40356
		// (get) Token: 0x06023274 RID: 143988 RVA: 0x004DDD33 File Offset: 0x004DBF33
		// (set) Token: 0x06023275 RID: 143989 RVA: 0x004DDD3B File Offset: 0x004DBF3B
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009DA5 RID: 40357
		// (get) Token: 0x06023276 RID: 143990 RVA: 0x004DDD44 File Offset: 0x004DBF44
		// (set) Token: 0x06023277 RID: 143991 RVA: 0x004DDD4C File Offset: 0x004DBF4C
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009DA6 RID: 40358
		// (get) Token: 0x06023278 RID: 143992 RVA: 0x004DDD55 File Offset: 0x004DBF55
		// (set) Token: 0x06023279 RID: 143993 RVA: 0x004DDD5D File Offset: 0x004DBF5D
		public byte NullMask { get; set; }

		// Token: 0x0602327A RID: 143994 RVA: 0x004DDD66 File Offset: 0x004DBF66
		public IHookInteractTypeT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.NullMask = 0;
		}
	}
}
