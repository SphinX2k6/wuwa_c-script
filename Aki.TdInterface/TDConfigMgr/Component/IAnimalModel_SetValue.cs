using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001C8 RID: 456
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnimalModel_SetValue
	{
		// Token: 0x0400088F RID: 2191
		public EModelType Type;

		// Token: 0x04000890 RID: 2192
		public string BlueprintPath;

		// Token: 0x04000891 RID: 2193
		[Nullable(2)]
		public IMeshAnimalModel AnimalModel;

		// Token: 0x04000892 RID: 2194
		public string Abp;
	}
}
