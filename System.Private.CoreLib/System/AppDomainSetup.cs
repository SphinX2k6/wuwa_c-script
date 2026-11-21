using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000C8 RID: 200
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class AppDomainSetup
	{
		// Token: 0x060009B5 RID: 2485 RVA: 0x00005ACC File Offset: 0x00003CCC
		internal AppDomainSetup()
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0001DAB6 File Offset: 0x0001BCB6
		public string ApplicationBase
		{
			get
			{
				return AppContext.BaseDirectory;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0001E0E1 File Offset: 0x0001C2E1
		public string TargetFrameworkName
		{
			get
			{
				return AppContext.TargetFrameworkName;
			}
		}
	}
}
