using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000187 RID: 391
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	public sealed class ObsoleteAttribute : Attribute
	{
		// Token: 0x060019C9 RID: 6601 RVA: 0x00022817 File Offset: 0x00020A17
		public ObsoleteAttribute()
		{
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00054AF9 File Offset: 0x00052CF9
		public ObsoleteAttribute(string message)
		{
			this.Message = message;
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00054B08 File Offset: 0x00052D08
		public ObsoleteAttribute(string message, bool error)
		{
			this.Message = message;
			this.IsError = error;
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00054B1E File Offset: 0x00052D1E
		public string Message { get; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x00054B26 File Offset: 0x00052D26
		public bool IsError { get; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x00054B2E File Offset: 0x00052D2E
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x00054B36 File Offset: 0x00052D36
		public string DiagnosticId { get; set; }

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00054B3F File Offset: 0x00052D3F
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x00054B47 File Offset: 0x00052D47
		public string UrlFormat { get; set; }
	}
}
