using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006784 RID: 26500
	public class IFadeBackgroundType_UnionUnion
	{
		// Token: 0x1700C4B1 RID: 50353
		// (get) Token: 0x0602E1A3 RID: 188835 RVA: 0x0064C489 File Offset: 0x0064A689
		// (set) Token: 0x0602E1A4 RID: 188836 RVA: 0x0064C491 File Offset: 0x0064A691
		public IFadeBackgroundType_Union Type { get; set; }

		// Token: 0x1700C4B2 RID: 50354
		// (get) Token: 0x0602E1A5 RID: 188837 RVA: 0x0064C49A File Offset: 0x0064A69A
		// (set) Token: 0x0602E1A6 RID: 188838 RVA: 0x0064C4A2 File Offset: 0x0064A6A2
		public object Value { get; set; }

		// Token: 0x0602E1A7 RID: 188839 RVA: 0x0064C4AB File Offset: 0x0064A6AB
		public IFadeBackgroundType_UnionUnion()
		{
			this.Type = IFadeBackgroundType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E1A8 RID: 188840 RVA: 0x0064C4C1 File Offset: 0x0064A6C1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E1A9 RID: 188841 RVA: 0x0064C4D3 File Offset: 0x0064A6D3
		public IFadeBackgroundTypeT AsIFadeBackgroundType()
		{
			return this.As<IFadeBackgroundTypeT>();
		}

		// Token: 0x0602E1AA RID: 188842 RVA: 0x0064C4DB File Offset: 0x0064A6DB
		public static IFadeBackgroundType_UnionUnion FromIFadeBackgroundType(IFadeBackgroundTypeT _ifadebackgroundtype)
		{
			return new IFadeBackgroundType_UnionUnion
			{
				Type = IFadeBackgroundType_Union.IFadeBackgroundType,
				Value = _ifadebackgroundtype
			};
		}

		// Token: 0x0602E1AB RID: 188843 RVA: 0x0064C4F0 File Offset: 0x0064A6F0
		public IFadeBackgroundSpineT AsIFadeBackgroundSpine()
		{
			return this.As<IFadeBackgroundSpineT>();
		}

		// Token: 0x0602E1AC RID: 188844 RVA: 0x0064C4F8 File Offset: 0x0064A6F8
		public static IFadeBackgroundType_UnionUnion FromIFadeBackgroundSpine(IFadeBackgroundSpineT _ifadebackgroundspine)
		{
			return new IFadeBackgroundType_UnionUnion
			{
				Type = IFadeBackgroundType_Union.IFadeBackgroundSpine,
				Value = _ifadebackgroundspine
			};
		}

		// Token: 0x0602E1AD RID: 188845 RVA: 0x0064C50D File Offset: 0x0064A70D
		public IFadeBackgroundImageT AsIFadeBackgroundImage()
		{
			return this.As<IFadeBackgroundImageT>();
		}

		// Token: 0x0602E1AE RID: 188846 RVA: 0x0064C515 File Offset: 0x0064A715
		public static IFadeBackgroundType_UnionUnion FromIFadeBackgroundImage(IFadeBackgroundImageT _ifadebackgroundimage)
		{
			return new IFadeBackgroundType_UnionUnion
			{
				Type = IFadeBackgroundType_Union.IFadeBackgroundImage,
				Value = _ifadebackgroundimage
			};
		}

		// Token: 0x0602E1AF RID: 188847 RVA: 0x0064C52A File Offset: 0x0064A72A
		public IFadeBackgroundUiPrefabT AsIFadeBackgroundUiPrefab()
		{
			return this.As<IFadeBackgroundUiPrefabT>();
		}

		// Token: 0x0602E1B0 RID: 188848 RVA: 0x0064C532 File Offset: 0x0064A732
		public static IFadeBackgroundType_UnionUnion FromIFadeBackgroundUiPrefab(IFadeBackgroundUiPrefabT _ifadebackgrounduiprefab)
		{
			return new IFadeBackgroundType_UnionUnion
			{
				Type = IFadeBackgroundType_Union.IFadeBackgroundUiPrefab,
				Value = _ifadebackgrounduiprefab
			};
		}

		// Token: 0x0602E1B1 RID: 188849 RVA: 0x0064C548 File Offset: 0x0064A748
		public static int Pack(FlatBufferBuilder builder, IFadeBackgroundType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFadeBackgroundType_Union.IFadeBackgroundType:
				return IFadeBackgroundType.Pack(builder, _o.AsIFadeBackgroundType()).Value;
			case IFadeBackgroundType_Union.IFadeBackgroundSpine:
				return IFadeBackgroundSpine.Pack(builder, _o.AsIFadeBackgroundSpine()).Value;
			case IFadeBackgroundType_Union.IFadeBackgroundImage:
				return IFadeBackgroundImage.Pack(builder, _o.AsIFadeBackgroundImage()).Value;
			case IFadeBackgroundType_Union.IFadeBackgroundUiPrefab:
				return IFadeBackgroundUiPrefab.Pack(builder, _o.AsIFadeBackgroundUiPrefab()).Value;
			default:
				return 0;
			}
		}
	}
}
