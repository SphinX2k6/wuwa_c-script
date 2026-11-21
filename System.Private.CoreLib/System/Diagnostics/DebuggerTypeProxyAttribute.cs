using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x02000889 RID: 2185
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
	public sealed class DebuggerTypeProxyAttribute : Attribute
	{
		// Token: 0x0600894A RID: 35146 RVA: 0x0014DB78 File Offset: 0x0014BD78
		[NullableContext(1)]
		public DebuggerTypeProxyAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			this.ProxyTypeName = type.AssemblyQualifiedName;
		}

		// Token: 0x0600894B RID: 35147 RVA: 0x0014DB97 File Offset: 0x0014BD97
		[NullableContext(1)]
		public DebuggerTypeProxyAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] string typeName)
		{
			this.ProxyTypeName = typeName;
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x0600894C RID: 35148 RVA: 0x0014DBA6 File Offset: 0x0014BDA6
		[Nullable(1)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public string ProxyTypeName { [NullableContext(1)] get; }

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x0600894D RID: 35149 RVA: 0x0014DBAE File Offset: 0x0014BDAE
		// (set) Token: 0x0600894E RID: 35150 RVA: 0x0014DBB6 File Offset: 0x0014BDB6
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

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x0600894F RID: 35151 RVA: 0x0014DBD6 File Offset: 0x0014BDD6
		// (set) Token: 0x06008950 RID: 35152 RVA: 0x0014DBDE File Offset: 0x0014BDDE
		public string TargetTypeName { get; set; }

		// Token: 0x04001E37 RID: 7735
		private Type _target;
	}
}
