using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046E6 RID: 18150
	[NullableContext(2)]
	[Nullable(0)]
	public class UiTsInfo
	{
		// Token: 0x04019765 RID: 104293
		public TUiViewCtor Ctor;

		// Token: 0x04019766 RID: 104294
		[Nullable(1)]
		public string ResourceId = string.Empty;

		// Token: 0x04019767 RID: 104295
		public ESourceType SourceType;

		// Token: 0x04019768 RID: 104296
		public TViewInfoDynamicData DynamicDataCtor;
	}
}
