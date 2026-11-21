using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A7A RID: 31354
	public class ITalkBackground_UnionUnion
	{
		// Token: 0x1700E5A6 RID: 58790
		// (get) Token: 0x06037427 RID: 226343 RVA: 0x007611AC File Offset: 0x0075F3AC
		// (set) Token: 0x06037428 RID: 226344 RVA: 0x007611B4 File Offset: 0x0075F3B4
		public ITalkBackground_Union Type { get; set; }

		// Token: 0x1700E5A7 RID: 58791
		// (get) Token: 0x06037429 RID: 226345 RVA: 0x007611BD File Offset: 0x0075F3BD
		// (set) Token: 0x0603742A RID: 226346 RVA: 0x007611C5 File Offset: 0x0075F3C5
		public object Value { get; set; }

		// Token: 0x0603742B RID: 226347 RVA: 0x007611CE File Offset: 0x0075F3CE
		public ITalkBackground_UnionUnion()
		{
			this.Type = ITalkBackground_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603742C RID: 226348 RVA: 0x007611E4 File Offset: 0x0075F3E4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603742D RID: 226349 RVA: 0x007611F6 File Offset: 0x0075F3F6
		public ITalkBackgroundT AsITalkBackground()
		{
			return this.As<ITalkBackgroundT>();
		}

		// Token: 0x0603742E RID: 226350 RVA: 0x007611FE File Offset: 0x0075F3FE
		public static ITalkBackground_UnionUnion FromITalkBackground(ITalkBackgroundT _italkbackground)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackground,
				Value = _italkbackground
			};
		}

		// Token: 0x0603742F RID: 226351 RVA: 0x00761213 File Offset: 0x0075F413
		public ITalkBackgroundCleanT AsITalkBackgroundClean()
		{
			return this.As<ITalkBackgroundCleanT>();
		}

		// Token: 0x06037430 RID: 226352 RVA: 0x0076121B File Offset: 0x0075F41B
		public static ITalkBackground_UnionUnion FromITalkBackgroundClean(ITalkBackgroundCleanT _italkbackgroundclean)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackgroundClean,
				Value = _italkbackgroundclean
			};
		}

		// Token: 0x06037431 RID: 226353 RVA: 0x00761230 File Offset: 0x0075F430
		public ITalkBackgroundImageT AsITalkBackgroundImage()
		{
			return this.As<ITalkBackgroundImageT>();
		}

		// Token: 0x06037432 RID: 226354 RVA: 0x00761238 File Offset: 0x0075F438
		public static ITalkBackground_UnionUnion FromITalkBackgroundImage(ITalkBackgroundImageT _italkbackgroundimage)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackgroundImage,
				Value = _italkbackgroundimage
			};
		}

		// Token: 0x06037433 RID: 226355 RVA: 0x0076124D File Offset: 0x0075F44D
		public ITalkBackgroundImageByMcGenderT AsITalkBackgroundImageByMcGender()
		{
			return this.As<ITalkBackgroundImageByMcGenderT>();
		}

		// Token: 0x06037434 RID: 226356 RVA: 0x00761255 File Offset: 0x0075F455
		public static ITalkBackground_UnionUnion FromITalkBackgroundImageByMcGender(ITalkBackgroundImageByMcGenderT _italkbackgroundimagebymcgender)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackgroundImageByMcGender,
				Value = _italkbackgroundimagebymcgender
			};
		}

		// Token: 0x06037435 RID: 226357 RVA: 0x0076126A File Offset: 0x0075F46A
		public ITalkBackgroundSpineImageT AsITalkBackgroundSpineImage()
		{
			return this.As<ITalkBackgroundSpineImageT>();
		}

		// Token: 0x06037436 RID: 226358 RVA: 0x00761272 File Offset: 0x0075F472
		public static ITalkBackground_UnionUnion FromITalkBackgroundSpineImage(ITalkBackgroundSpineImageT _italkbackgroundspineimage)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackgroundSpineImage,
				Value = _italkbackgroundspineimage
			};
		}

		// Token: 0x06037437 RID: 226359 RVA: 0x00761287 File Offset: 0x0075F487
		public ITalkBackgroundIconT AsITalkBackgroundIcon()
		{
			return this.As<ITalkBackgroundIconT>();
		}

		// Token: 0x06037438 RID: 226360 RVA: 0x0076128F File Offset: 0x0075F48F
		public static ITalkBackground_UnionUnion FromITalkBackgroundIcon(ITalkBackgroundIconT _italkbackgroundicon)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackgroundIcon,
				Value = _italkbackgroundicon
			};
		}

		// Token: 0x06037439 RID: 226361 RVA: 0x007612A4 File Offset: 0x0075F4A4
		public static int Pack(FlatBufferBuilder builder, ITalkBackground_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITalkBackground_Union.ITalkBackground:
				return ITalkBackground.Pack(builder, _o.AsITalkBackground()).Value;
			case ITalkBackground_Union.ITalkBackgroundClean:
				return ITalkBackgroundClean.Pack(builder, _o.AsITalkBackgroundClean()).Value;
			case ITalkBackground_Union.ITalkBackgroundImage:
				return ITalkBackgroundImage.Pack(builder, _o.AsITalkBackgroundImage()).Value;
			case ITalkBackground_Union.ITalkBackgroundImageByMcGender:
				return ITalkBackgroundImageByMcGender.Pack(builder, _o.AsITalkBackgroundImageByMcGender()).Value;
			case ITalkBackground_Union.ITalkBackgroundSpineImage:
				return ITalkBackgroundSpineImage.Pack(builder, _o.AsITalkBackgroundSpineImage()).Value;
			case ITalkBackground_Union.ITalkBackgroundIcon:
				return ITalkBackgroundIcon.Pack(builder, _o.AsITalkBackgroundIcon()).Value;
			default:
				return 0;
			}
		}
	}
}
