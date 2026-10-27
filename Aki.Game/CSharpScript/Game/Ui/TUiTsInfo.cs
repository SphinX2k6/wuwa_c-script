using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046E7 RID: 18151
	[NullableContext(1)]
	[Nullable(0)]
	public class TUiTsInfo
	{
		// Token: 0x17007686 RID: 30342
		// (get) Token: 0x0602ECD7 RID: 191703 RVA: 0x00AD5DDC File Offset: 0x00AD3FDC
		[Nullable(2)]
		public TUiViewCtor CreateUiView { [NullableContext(2)] get; }

		// Token: 0x0602ECD8 RID: 191704 RVA: 0x00AD5DE4 File Offset: 0x00AD3FE4
		public TUiTsInfo(EUiViewName viewName, string resourceId, ESourceType sourceType = ESourceType.Normal)
		{
			this.ViewName = viewName;
			this.ResourceId = resourceId;
			this.SourceType = sourceType;
			TUiViewCtor tuiViewCtor;
			if ((tuiViewCtor = TUiTsInfo.<>O.<0>__Create) == null)
			{
				tuiViewCtor = (TUiTsInfo.<>O.<0>__Create = new TUiViewCtor(UiViewFactory.Create));
			}
			this.CreateUiView = tuiViewCtor;
		}

		// Token: 0x0602ECD9 RID: 191705 RVA: 0x00AD5E22 File Offset: 0x00AD4022
		public TUiTsInfo(EUiViewName viewName, Type viewType, string resourceId, ESourceType sourceType = ESourceType.Normal, [Nullable(2)] TUiViewCtor ctor = null)
		{
			this.ViewName = viewName;
			this.ResourceId = resourceId;
			this.SourceType = sourceType;
			this.CreateUiView = (ctor ?? UiViewFactory.ResolveLegacyFactory(viewType));
		}

		// Token: 0x04019769 RID: 104297
		public readonly EUiViewName ViewName;

		// Token: 0x0401976B RID: 104299
		public readonly string ResourceId;

		// Token: 0x0401976C RID: 104300
		public readonly ESourceType SourceType;

		// Token: 0x0200A949 RID: 43337
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403388B RID: 211083
			[Nullable(0)]
			public static TUiViewCtor <0>__Create;
		}
	}
}
