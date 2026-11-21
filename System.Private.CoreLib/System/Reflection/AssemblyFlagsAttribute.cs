using System;

namespace System.Reflection
{
	// Token: 0x02000727 RID: 1831
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyFlagsAttribute : Attribute
	{
		// Token: 0x0600786C RID: 30828 RVA: 0x0011E755 File Offset: 0x0011C955
		[Obsolete("This constructor has been deprecated. Use AssemblyFlagsAttribute(AssemblyNameFlags) instead.")]
		[CLSCompliant(false)]
		public AssemblyFlagsAttribute(uint flags)
		{
			this._flags = (AssemblyNameFlags)flags;
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x0600786D RID: 30829 RVA: 0x0011E764 File Offset: 0x0011C964
		[Obsolete("AssemblyFlagsAttribute.Flags has been deprecated. Use AssemblyFlags instead.")]
		[CLSCompliant(false)]
		public uint Flags
		{
			get
			{
				return (uint)this._flags;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x0600786E RID: 30830 RVA: 0x0011E764 File Offset: 0x0011C964
		public int AssemblyFlags
		{
			get
			{
				return (int)this._flags;
			}
		}

		// Token: 0x0600786F RID: 30831 RVA: 0x0011E755 File Offset: 0x0011C955
		[Obsolete("This constructor has been deprecated. Use AssemblyFlagsAttribute(AssemblyNameFlags) instead.")]
		public AssemblyFlagsAttribute(int assemblyFlags)
		{
			this._flags = (AssemblyNameFlags)assemblyFlags;
		}

		// Token: 0x06007870 RID: 30832 RVA: 0x0011E755 File Offset: 0x0011C955
		public AssemblyFlagsAttribute(AssemblyNameFlags assemblyFlags)
		{
			this._flags = assemblyFlags;
		}

		// Token: 0x040015F2 RID: 5618
		private readonly AssemblyNameFlags _flags;
	}
}
