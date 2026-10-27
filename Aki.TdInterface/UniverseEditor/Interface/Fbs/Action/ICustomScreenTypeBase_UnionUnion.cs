using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006514 RID: 25876
	public class ICustomScreenTypeBase_UnionUnion
	{
		// Token: 0x1700C066 RID: 49254
		// (get) Token: 0x0602CE25 RID: 183845 RVA: 0x0062A1AD File Offset: 0x006283AD
		// (set) Token: 0x0602CE26 RID: 183846 RVA: 0x0062A1B5 File Offset: 0x006283B5
		public ICustomScreenTypeBase_Union Type { get; set; }

		// Token: 0x1700C067 RID: 49255
		// (get) Token: 0x0602CE27 RID: 183847 RVA: 0x0062A1BE File Offset: 0x006283BE
		// (set) Token: 0x0602CE28 RID: 183848 RVA: 0x0062A1C6 File Offset: 0x006283C6
		public object Value { get; set; }

		// Token: 0x0602CE29 RID: 183849 RVA: 0x0062A1CF File Offset: 0x006283CF
		public ICustomScreenTypeBase_UnionUnion()
		{
			this.Type = ICustomScreenTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CE2A RID: 183850 RVA: 0x0062A1E5 File Offset: 0x006283E5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CE2B RID: 183851 RVA: 0x0062A1F7 File Offset: 0x006283F7
		public ICustomScreenTypeBaseT AsICustomScreenTypeBase()
		{
			return this.As<ICustomScreenTypeBaseT>();
		}

		// Token: 0x0602CE2C RID: 183852 RVA: 0x0062A1FF File Offset: 0x006283FF
		public static ICustomScreenTypeBase_UnionUnion FromICustomScreenTypeBase(ICustomScreenTypeBaseT _icustomscreentypebase)
		{
			return new ICustomScreenTypeBase_UnionUnion
			{
				Type = ICustomScreenTypeBase_Union.ICustomScreenTypeBase,
				Value = _icustomscreentypebase
			};
		}

		// Token: 0x0602CE2D RID: 183853 RVA: 0x0062A214 File Offset: 0x00628414
		public ICustomScreenSpineT AsICustomScreenSpine()
		{
			return this.As<ICustomScreenSpineT>();
		}

		// Token: 0x0602CE2E RID: 183854 RVA: 0x0062A21C File Offset: 0x0062841C
		public static ICustomScreenTypeBase_UnionUnion FromICustomScreenSpine(ICustomScreenSpineT _icustomscreenspine)
		{
			return new ICustomScreenTypeBase_UnionUnion
			{
				Type = ICustomScreenTypeBase_Union.ICustomScreenSpine,
				Value = _icustomscreenspine
			};
		}

		// Token: 0x0602CE2F RID: 183855 RVA: 0x0062A231 File Offset: 0x00628431
		public ICustomScreenBackgroundImageT AsICustomScreenBackgroundImage()
		{
			return this.As<ICustomScreenBackgroundImageT>();
		}

		// Token: 0x0602CE30 RID: 183856 RVA: 0x0062A239 File Offset: 0x00628439
		public static ICustomScreenTypeBase_UnionUnion FromICustomScreenBackgroundImage(ICustomScreenBackgroundImageT _icustomscreenbackgroundimage)
		{
			return new ICustomScreenTypeBase_UnionUnion
			{
				Type = ICustomScreenTypeBase_Union.ICustomScreenBackgroundImage,
				Value = _icustomscreenbackgroundimage
			};
		}

		// Token: 0x0602CE31 RID: 183857 RVA: 0x0062A24E File Offset: 0x0062844E
		public ICustomScreenLoadingT AsICustomScreenLoading()
		{
			return this.As<ICustomScreenLoadingT>();
		}

		// Token: 0x0602CE32 RID: 183858 RVA: 0x0062A256 File Offset: 0x00628456
		public static ICustomScreenTypeBase_UnionUnion FromICustomScreenLoading(ICustomScreenLoadingT _icustomscreenloading)
		{
			return new ICustomScreenTypeBase_UnionUnion
			{
				Type = ICustomScreenTypeBase_Union.ICustomScreenLoading,
				Value = _icustomscreenloading
			};
		}

		// Token: 0x0602CE33 RID: 183859 RVA: 0x0062A26C File Offset: 0x0062846C
		public static int Pack(FlatBufferBuilder builder, ICustomScreenTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICustomScreenTypeBase_Union.ICustomScreenTypeBase:
				return ICustomScreenTypeBase.Pack(builder, _o.AsICustomScreenTypeBase()).Value;
			case ICustomScreenTypeBase_Union.ICustomScreenSpine:
				return ICustomScreenSpine.Pack(builder, _o.AsICustomScreenSpine()).Value;
			case ICustomScreenTypeBase_Union.ICustomScreenBackgroundImage:
				return ICustomScreenBackgroundImage.Pack(builder, _o.AsICustomScreenBackgroundImage()).Value;
			case ICustomScreenTypeBase_Union.ICustomScreenLoading:
				return ICustomScreenLoading.Pack(builder, _o.AsICustomScreenLoading()).Value;
			default:
				return 0;
			}
		}
	}
}
