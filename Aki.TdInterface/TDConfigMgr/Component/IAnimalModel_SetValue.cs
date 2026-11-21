using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001EB RID: 491
	public class IAnimalModel_SetValue
	{
		// Token: 0x04000903 RID: 2307
		public EModelType Type;

		// Token: 0x04000904 RID: 2308
		public string BlueprintPath;

		// Token: 0x04000905 RID: 2309
		[Nullable(2)]
		public IMeshAnimalModel AnimalModel;

		// Token: 0x04000906 RID: 2310
		public string Abp;
	}
}
