using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000730 RID: 1840
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
	public sealed class AssemblySignatureKeyAttribute : Attribute
	{
		// Token: 0x06007883 RID: 30851 RVA: 0x0011E945 File Offset: 0x0011CB45
		public AssemblySignatureKeyAttribute(string publicKey, string countersignature)
		{
			this.PublicKey = publicKey;
			this.Countersignature = countersignature;
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06007884 RID: 30852 RVA: 0x0011E95B File Offset: 0x0011CB5B
		public string PublicKey { get; }

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06007885 RID: 30853 RVA: 0x0011E963 File Offset: 0x0011CB63
		public string Countersignature { get; }
	}
}
