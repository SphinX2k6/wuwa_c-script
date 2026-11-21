using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008A5 RID: 2213
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	public sealed class DynamicDependencyAttribute : Attribute
	{
		// Token: 0x060089D8 RID: 35288 RVA: 0x0014E881 File Offset: 0x0014CA81
		[NullableContext(1)]
		public DynamicDependencyAttribute(string memberSignature)
		{
			this.MemberSignature = memberSignature;
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x0014E890 File Offset: 0x0014CA90
		[NullableContext(1)]
		public DynamicDependencyAttribute(string memberSignature, Type type)
		{
			this.MemberSignature = memberSignature;
			this.Type = type;
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x0014E8A6 File Offset: 0x0014CAA6
		[NullableContext(1)]
		public DynamicDependencyAttribute(string memberSignature, string typeName, string assemblyName)
		{
			this.MemberSignature = memberSignature;
			this.TypeName = typeName;
			this.AssemblyName = assemblyName;
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x0014E8C3 File Offset: 0x0014CAC3
		[NullableContext(1)]
		public DynamicDependencyAttribute(DynamicallyAccessedMemberTypes memberTypes, Type type)
		{
			this.MemberTypes = memberTypes;
			this.Type = type;
		}

		// Token: 0x060089DC RID: 35292 RVA: 0x0014E8D9 File Offset: 0x0014CAD9
		[NullableContext(1)]
		public DynamicDependencyAttribute(DynamicallyAccessedMemberTypes memberTypes, string typeName, string assemblyName)
		{
			this.MemberTypes = memberTypes;
			this.TypeName = typeName;
			this.AssemblyName = assemblyName;
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x060089DD RID: 35293 RVA: 0x0014E8F6 File Offset: 0x0014CAF6
		public string MemberSignature { get; }

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x060089DE RID: 35294 RVA: 0x0014E8FE File Offset: 0x0014CAFE
		public DynamicallyAccessedMemberTypes MemberTypes { get; }

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x060089DF RID: 35295 RVA: 0x0014E906 File Offset: 0x0014CB06
		public Type Type { get; }

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x060089E0 RID: 35296 RVA: 0x0014E90E File Offset: 0x0014CB0E
		public string TypeName { get; }

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x060089E1 RID: 35297 RVA: 0x0014E916 File Offset: 0x0014CB16
		public string AssemblyName { get; }

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x060089E2 RID: 35298 RVA: 0x0014E91E File Offset: 0x0014CB1E
		// (set) Token: 0x060089E3 RID: 35299 RVA: 0x0014E926 File Offset: 0x0014CB26
		public string Condition { get; set; }
	}
}
