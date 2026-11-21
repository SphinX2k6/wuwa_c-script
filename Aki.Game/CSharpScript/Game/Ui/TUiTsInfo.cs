using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003617 RID: 13847
	[NullableContext(1)]
	[Nullable(0)]
	public class TUiTsInfo
	{
		// Token: 0x17004942 RID: 18754
		// (get) Token: 0x06023412 RID: 144402 RVA: 0x00A038B4 File Offset: 0x00A01AB4
		[Nullable(2)]
		public TUiViewCtor CreateUiView { [NullableContext(2)] get; }

		// Token: 0x06023413 RID: 144403 RVA: 0x00A038BC File Offset: 0x00A01ABC
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

		// Token: 0x06023414 RID: 144404 RVA: 0x00A038FA File Offset: 0x00A01AFA
		public TUiTsInfo(EUiViewName viewName, Type viewType, string resourceId, ESourceType sourceType = ESourceType.Normal, [Nullable(2)] TUiViewCtor ctor = null)
		{
			this.ViewName = viewName;
			this.ResourceId = resourceId;
			this.SourceType = sourceType;
			this.CreateUiView = (ctor ?? UiViewFactory.ResolveLegacyFactory(viewType));
		}

		// Token: 0x04013E07 RID: 81415
		public readonly EUiViewName ViewName;

		// Token: 0x04013E09 RID: 81417
		public readonly string ResourceId;

		// Token: 0x04013E0A RID: 81418
		public readonly ESourceType SourceType;

		// Token: 0x02009304 RID: 37636
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402E01E RID: 188446
			[Nullable(0)]
			public static TUiViewCtor <0>__Create;
		}
	}
}
