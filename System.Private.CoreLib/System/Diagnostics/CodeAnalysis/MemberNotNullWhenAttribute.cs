using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008B4 RID: 2228
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	public sealed class MemberNotNullWhenAttribute : Attribute
	{
		// Token: 0x060089FF RID: 35327 RVA: 0x0014EA21 File Offset: 0x0014CC21
		public MemberNotNullWhenAttribute(bool returnValue, string member)
		{
			this.ReturnValue = returnValue;
			this.Members = new string[]
			{
				member
			};
		}

		// Token: 0x06008A00 RID: 35328 RVA: 0x0014EA40 File Offset: 0x0014CC40
		public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
		{
			this.ReturnValue = returnValue;
			this.Members = members;
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06008A01 RID: 35329 RVA: 0x0014EA56 File Offset: 0x0014CC56
		public bool ReturnValue { get; }

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06008A02 RID: 35330 RVA: 0x0014EA5E File Offset: 0x0014CC5E
		public string[] Members { get; }
	}
}
