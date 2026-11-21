using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003616 RID: 13846
	[NullableContext(2)]
	[Nullable(0)]
	public class UiTsInfo
	{
		// Token: 0x04013E03 RID: 81411
		public TUiViewCtor Ctor;

		// Token: 0x04013E04 RID: 81412
		[Nullable(1)]
		public string ResourceId = string.Empty;

		// Token: 0x04013E05 RID: 81413
		public ESourceType SourceType;

		// Token: 0x04013E06 RID: 81414
		public TViewInfoDynamicData DynamicDataCtor;
	}
}
