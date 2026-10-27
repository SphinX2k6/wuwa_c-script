using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C52 RID: 27730
	public class IOverrideAbpAnimSchemeConfigT
	{
		// Token: 0x1700CE87 RID: 52871
		// (get) Token: 0x06030DB5 RID: 200117 RVA: 0x006A2F18 File Offset: 0x006A1118
		// (set) Token: 0x06030DB6 RID: 200118 RVA: 0x006A2F20 File Offset: 0x006A1120
		public int EntityId { get; set; }

		// Token: 0x1700CE88 RID: 52872
		// (get) Token: 0x06030DB7 RID: 200119 RVA: 0x006A2F29 File Offset: 0x006A1129
		// (set) Token: 0x06030DB8 RID: 200120 RVA: 0x006A2F31 File Offset: 0x006A1131
		public EAbpAnimScheme AnimScheme { get; set; }

		// Token: 0x06030DB9 RID: 200121 RVA: 0x006A2F3A File Offset: 0x006A113A
		public IOverrideAbpAnimSchemeConfigT()
		{
			this.EntityId = 0;
			this.AnimScheme = EAbpAnimScheme.Scheme1;
		}
	}
}
