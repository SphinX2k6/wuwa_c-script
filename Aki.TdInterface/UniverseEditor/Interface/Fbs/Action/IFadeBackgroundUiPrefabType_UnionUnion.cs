using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E10 RID: 28176
	public class IFadeBackgroundUiPrefabType_UnionUnion
	{
		// Token: 0x1700CE7A RID: 52858
		// (get) Token: 0x06030A43 RID: 199235 RVA: 0x0069A4E1 File Offset: 0x006986E1
		// (set) Token: 0x06030A44 RID: 199236 RVA: 0x0069A4E9 File Offset: 0x006986E9
		public IFadeBackgroundUiPrefabType_Union Type { get; set; }

		// Token: 0x1700CE7B RID: 52859
		// (get) Token: 0x06030A45 RID: 199237 RVA: 0x0069A4F2 File Offset: 0x006986F2
		// (set) Token: 0x06030A46 RID: 199238 RVA: 0x0069A4FA File Offset: 0x006986FA
		public object Value { get; set; }

		// Token: 0x06030A47 RID: 199239 RVA: 0x0069A503 File Offset: 0x00698703
		public IFadeBackgroundUiPrefabType_UnionUnion()
		{
			this.Type = IFadeBackgroundUiPrefabType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030A48 RID: 199240 RVA: 0x0069A519 File Offset: 0x00698719
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030A49 RID: 199241 RVA: 0x0069A52B File Offset: 0x0069872B
		public IFadeBackgroundUiPrefabTypeT AsIFadeBackgroundUiPrefabType()
		{
			return this.As<IFadeBackgroundUiPrefabTypeT>();
		}

		// Token: 0x06030A4A RID: 199242 RVA: 0x0069A533 File Offset: 0x00698733
		public static IFadeBackgroundUiPrefabType_UnionUnion FromIFadeBackgroundUiPrefabType(IFadeBackgroundUiPrefabTypeT _ifadebackgrounduiprefabtype)
		{
			return new IFadeBackgroundUiPrefabType_UnionUnion
			{
				Type = IFadeBackgroundUiPrefabType_Union.IFadeBackgroundUiPrefabType,
				Value = _ifadebackgrounduiprefabtype
			};
		}

		// Token: 0x06030A4B RID: 199243 RVA: 0x0069A548 File Offset: 0x00698748
		public IFadeBackgroundUiPrefabBlackScreenWhiteTextT AsIFadeBackgroundUiPrefabBlackScreenWhiteText()
		{
			return this.As<IFadeBackgroundUiPrefabBlackScreenWhiteTextT>();
		}

		// Token: 0x06030A4C RID: 199244 RVA: 0x0069A550 File Offset: 0x00698750
		public static IFadeBackgroundUiPrefabType_UnionUnion FromIFadeBackgroundUiPrefabBlackScreenWhiteText(IFadeBackgroundUiPrefabBlackScreenWhiteTextT _ifadebackgrounduiprefabblackscreenwhitetext)
		{
			return new IFadeBackgroundUiPrefabType_UnionUnion
			{
				Type = IFadeBackgroundUiPrefabType_Union.IFadeBackgroundUiPrefabBlackScreenWhiteText,
				Value = _ifadebackgrounduiprefabblackscreenwhitetext
			};
		}

		// Token: 0x06030A4D RID: 199245 RVA: 0x0069A568 File Offset: 0x00698768
		public static int Pack(FlatBufferBuilder builder, IFadeBackgroundUiPrefabType_UnionUnion _o)
		{
			IFadeBackgroundUiPrefabType_Union type = _o.Type;
			if (type == IFadeBackgroundUiPrefabType_Union.IFadeBackgroundUiPrefabType)
			{
				return IFadeBackgroundUiPrefabType.Pack(builder, _o.AsIFadeBackgroundUiPrefabType()).Value;
			}
			if (type != IFadeBackgroundUiPrefabType_Union.IFadeBackgroundUiPrefabBlackScreenWhiteText)
			{
				return 0;
			}
			return IFadeBackgroundUiPrefabBlackScreenWhiteText.Pack(builder, _o.AsIFadeBackgroundUiPrefabBlackScreenWhiteText()).Value;
		}
	}
}
