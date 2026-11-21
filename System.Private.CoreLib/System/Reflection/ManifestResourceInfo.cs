using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000754 RID: 1876
	[NullableContext(2)]
	[Nullable(0)]
	public class ManifestResourceInfo
	{
		// Token: 0x06007938 RID: 31032 RVA: 0x0011FF43 File Offset: 0x0011E143
		public ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
		{
			this.ReferencedAssembly = containingAssembly;
			this.FileName = containingFileName;
			this.ResourceLocation = resourceLocation;
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06007939 RID: 31033 RVA: 0x0011FF60 File Offset: 0x0011E160
		public virtual Assembly ReferencedAssembly { get; }

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x0600793A RID: 31034 RVA: 0x0011FF68 File Offset: 0x0011E168
		public virtual string FileName { get; }

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x0600793B RID: 31035 RVA: 0x0011FF70 File Offset: 0x0011E170
		public virtual ResourceLocation ResourceLocation { get; }
	}
}
