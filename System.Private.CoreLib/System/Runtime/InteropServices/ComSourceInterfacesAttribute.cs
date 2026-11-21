using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005BA RID: 1466
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class ComSourceInterfacesAttribute : Attribute
	{
		// Token: 0x06006FE3 RID: 28643 RVA: 0x0010D709 File Offset: 0x0010B909
		public ComSourceInterfacesAttribute(string sourceInterfaces)
		{
			this.Value = sourceInterfaces;
		}

		// Token: 0x06006FE4 RID: 28644 RVA: 0x0010D718 File Offset: 0x0010B918
		public ComSourceInterfacesAttribute(Type sourceInterface)
		{
			this.Value = sourceInterface.FullName;
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x0010D72C File Offset: 0x0010B92C
		public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2)
		{
			this.Value = sourceInterface1.FullName + "\0" + sourceInterface2.FullName;
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x0010D750 File Offset: 0x0010B950
		public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3)
		{
			this.Value = string.Concat(new string[]
			{
				sourceInterface1.FullName,
				"\0",
				sourceInterface2.FullName,
				"\0",
				sourceInterface3.FullName
			});
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x0010D7A0 File Offset: 0x0010B9A0
		public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3, Type sourceInterface4)
		{
			this.Value = string.Concat(new string[]
			{
				sourceInterface1.FullName,
				"\0",
				sourceInterface2.FullName,
				"\0",
				sourceInterface3.FullName,
				"\0",
				sourceInterface4.FullName
			});
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06006FE8 RID: 28648 RVA: 0x0010D801 File Offset: 0x0010BA01
		public string Value { get; }
	}
}
