using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A5 RID: 29349
	public class ITalkBackground_UnionUnion
	{
		// Token: 0x1700D9AD RID: 55725
		// (get) Token: 0x06034123 RID: 213283 RVA: 0x006FFE10 File Offset: 0x006FE010
		// (set) Token: 0x06034124 RID: 213284 RVA: 0x006FFE18 File Offset: 0x006FE018
		public ITalkBackground_Union Type { get; set; }

		// Token: 0x1700D9AE RID: 55726
		// (get) Token: 0x06034125 RID: 213285 RVA: 0x006FFE21 File Offset: 0x006FE021
		// (set) Token: 0x06034126 RID: 213286 RVA: 0x006FFE29 File Offset: 0x006FE029
		public object Value { get; set; }

		// Token: 0x06034127 RID: 213287 RVA: 0x006FFE32 File Offset: 0x006FE032
		public ITalkBackground_UnionUnion()
		{
			this.Type = ITalkBackground_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06034128 RID: 213288 RVA: 0x006FFE48 File Offset: 0x006FE048
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06034129 RID: 213289 RVA: 0x006FFE5A File Offset: 0x006FE05A
		public ITalkBackgroundT AsITalkBackground()
		{
			return this.As<ITalkBackgroundT>();
		}

		// Token: 0x0603412A RID: 213290 RVA: 0x006FFE62 File Offset: 0x006FE062
		public static ITalkBackground_UnionUnion FromITalkBackground(ITalkBackgroundT _italkbackground)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackground,
				Value = _italkbackground
			};
		}

		// Token: 0x0603412B RID: 213291 RVA: 0x006FFE77 File Offset: 0x006FE077
		public ITalkBackgroundCleanT AsITalkBackgroundClean()
		{
			return this.As<ITalkBackgroundCleanT>();
		}

		// Token: 0x0603412C RID: 213292 RVA: 0x006FFE7F File Offset: 0x006FE07F
		public static ITalkBackground_UnionUnion FromITalkBackgroundClean(ITalkBackgroundCleanT _italkbackgroundclean)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackgroundClean,
				Value = _italkbackgroundclean
			};
		}

		// Token: 0x0603412D RID: 213293 RVA: 0x006FFE94 File Offset: 0x006FE094
		public ITalkBackgroundImageT AsITalkBackgroundImage()
		{
			return this.As<ITalkBackgroundImageT>();
		}

		// Token: 0x0603412E RID: 213294 RVA: 0x006FFE9C File Offset: 0x006FE09C
		public static ITalkBackground_UnionUnion FromITalkBackgroundImage(ITalkBackgroundImageT _italkbackgroundimage)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackgroundImage,
				Value = _italkbackgroundimage
			};
		}

		// Token: 0x0603412F RID: 213295 RVA: 0x006FFEB1 File Offset: 0x006FE0B1
		public ITalkBackgroundImageByMcGenderT AsITalkBackgroundImageByMcGender()
		{
			return this.As<ITalkBackgroundImageByMcGenderT>();
		}

		// Token: 0x06034130 RID: 213296 RVA: 0x006FFEB9 File Offset: 0x006FE0B9
		public static ITalkBackground_UnionUnion FromITalkBackgroundImageByMcGender(ITalkBackgroundImageByMcGenderT _italkbackgroundimagebymcgender)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackgroundImageByMcGender,
				Value = _italkbackgroundimagebymcgender
			};
		}

		// Token: 0x06034131 RID: 213297 RVA: 0x006FFECE File Offset: 0x006FE0CE
		public ITalkBackgroundSpineImageT AsITalkBackgroundSpineImage()
		{
			return this.As<ITalkBackgroundSpineImageT>();
		}

		// Token: 0x06034132 RID: 213298 RVA: 0x006FFED6 File Offset: 0x006FE0D6
		public static ITalkBackground_UnionUnion FromITalkBackgroundSpineImage(ITalkBackgroundSpineImageT _italkbackgroundspineimage)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackgroundSpineImage,
				Value = _italkbackgroundspineimage
			};
		}

		// Token: 0x06034133 RID: 213299 RVA: 0x006FFEEB File Offset: 0x006FE0EB
		public ITalkBackgroundIconT AsITalkBackgroundIcon()
		{
			return this.As<ITalkBackgroundIconT>();
		}

		// Token: 0x06034134 RID: 213300 RVA: 0x006FFEF3 File Offset: 0x006FE0F3
		public static ITalkBackground_UnionUnion FromITalkBackgroundIcon(ITalkBackgroundIconT _italkbackgroundicon)
		{
			return new ITalkBackground_UnionUnion
			{
				Type = ITalkBackground_Union.ITalkBackgroundIcon,
				Value = _italkbackgroundicon
			};
		}

		// Token: 0x06034135 RID: 213301 RVA: 0x006FFF08 File Offset: 0x006FE108
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
