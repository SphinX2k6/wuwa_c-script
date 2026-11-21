using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x02000884 RID: 2180
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Delegate, AllowMultiple = true)]
	public sealed class DebuggerDisplayAttribute : Attribute
	{
		// Token: 0x0600893C RID: 35132 RVA: 0x0014DAE7 File Offset: 0x0014BCE7
		public DebuggerDisplayAttribute(string value)
		{
			this.Value = (value ?? "");
			this.Name = "";
			this.Type = "";
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x0600893D RID: 35133 RVA: 0x0014DB15 File Offset: 0x0014BD15
		[Nullable(1)]
		public string Value { [NullableContext(1)] get; }

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x0600893E RID: 35134 RVA: 0x0014DB1D File Offset: 0x0014BD1D
		// (set) Token: 0x0600893F RID: 35135 RVA: 0x0014DB25 File Offset: 0x0014BD25
		public string Name { get; set; }

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06008940 RID: 35136 RVA: 0x0014DB2E File Offset: 0x0014BD2E
		// (set) Token: 0x06008941 RID: 35137 RVA: 0x0014DB36 File Offset: 0x0014BD36
		public string Type { get; set; }

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06008942 RID: 35138 RVA: 0x0014DB3F File Offset: 0x0014BD3F
		// (set) Token: 0x06008943 RID: 35139 RVA: 0x0014DB47 File Offset: 0x0014BD47
		public Type Target
		{
			get
			{
				return this._target;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.TargetTypeName = value.AssemblyQualifiedName;
				this._target = value;
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06008944 RID: 35140 RVA: 0x0014DB67 File Offset: 0x0014BD67
		// (set) Token: 0x06008945 RID: 35141 RVA: 0x0014DB6F File Offset: 0x0014BD6F
		public string TargetTypeName { get; set; }

		// Token: 0x04001E32 RID: 7730
		private Type _target;
	}
}
