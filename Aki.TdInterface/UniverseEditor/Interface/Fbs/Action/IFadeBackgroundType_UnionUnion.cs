using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E04 RID: 28164
	public class IFadeBackgroundType_UnionUnion
	{
		// Token: 0x1700CE67 RID: 52839
		// (get) Token: 0x060309E9 RID: 199145 RVA: 0x00699BCD File Offset: 0x00697DCD
		// (set) Token: 0x060309EA RID: 199146 RVA: 0x00699BD5 File Offset: 0x00697DD5
		public IFadeBackgroundType_Union Type { get; set; }

		// Token: 0x1700CE68 RID: 52840
		// (get) Token: 0x060309EB RID: 199147 RVA: 0x00699BDE File Offset: 0x00697DDE
		// (set) Token: 0x060309EC RID: 199148 RVA: 0x00699BE6 File Offset: 0x00697DE6
		public object Value { get; set; }

		// Token: 0x060309ED RID: 199149 RVA: 0x00699BEF File Offset: 0x00697DEF
		public IFadeBackgroundType_UnionUnion()
		{
			this.Type = IFadeBackgroundType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060309EE RID: 199150 RVA: 0x00699C05 File Offset: 0x00697E05
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060309EF RID: 199151 RVA: 0x00699C17 File Offset: 0x00697E17
		public IFadeBackgroundTypeT AsIFadeBackgroundType()
		{
			return this.As<IFadeBackgroundTypeT>();
		}

		// Token: 0x060309F0 RID: 199152 RVA: 0x00699C1F File Offset: 0x00697E1F
		public static IFadeBackgroundType_UnionUnion FromIFadeBackgroundType(IFadeBackgroundTypeT _ifadebackgroundtype)
		{
			return new IFadeBackgroundType_UnionUnion
			{
				Type = IFadeBackgroundType_Union.IFadeBackgroundType,
				Value = _ifadebackgroundtype
			};
		}

		// Token: 0x060309F1 RID: 199153 RVA: 0x00699C34 File Offset: 0x00697E34
		public IFadeBackgroundSpineT AsIFadeBackgroundSpine()
		{
			return this.As<IFadeBackgroundSpineT>();
		}

		// Token: 0x060309F2 RID: 199154 RVA: 0x00699C3C File Offset: 0x00697E3C
		public static IFadeBackgroundType_UnionUnion FromIFadeBackgroundSpine(IFadeBackgroundSpineT _ifadebackgroundspine)
		{
			return new IFadeBackgroundType_UnionUnion
			{
				Type = IFadeBackgroundType_Union.IFadeBackgroundSpine,
				Value = _ifadebackgroundspine
			};
		}

		// Token: 0x060309F3 RID: 199155 RVA: 0x00699C51 File Offset: 0x00697E51
		public IFadeBackgroundImageT AsIFadeBackgroundImage()
		{
			return this.As<IFadeBackgroundImageT>();
		}

		// Token: 0x060309F4 RID: 199156 RVA: 0x00699C59 File Offset: 0x00697E59
		public static IFadeBackgroundType_UnionUnion FromIFadeBackgroundImage(IFadeBackgroundImageT _ifadebackgroundimage)
		{
			return new IFadeBackgroundType_UnionUnion
			{
				Type = IFadeBackgroundType_Union.IFadeBackgroundImage,
				Value = _ifadebackgroundimage
			};
		}

		// Token: 0x060309F5 RID: 199157 RVA: 0x00699C6E File Offset: 0x00697E6E
		public IFadeBackgroundUiPrefabT AsIFadeBackgroundUiPrefab()
		{
			return this.As<IFadeBackgroundUiPrefabT>();
		}

		// Token: 0x060309F6 RID: 199158 RVA: 0x00699C76 File Offset: 0x00697E76
		public static IFadeBackgroundType_UnionUnion FromIFadeBackgroundUiPrefab(IFadeBackgroundUiPrefabT _ifadebackgrounduiprefab)
		{
			return new IFadeBackgroundType_UnionUnion
			{
				Type = IFadeBackgroundType_Union.IFadeBackgroundUiPrefab,
				Value = _ifadebackgrounduiprefab
			};
		}

		// Token: 0x060309F7 RID: 199159 RVA: 0x00699C8C File Offset: 0x00697E8C
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
