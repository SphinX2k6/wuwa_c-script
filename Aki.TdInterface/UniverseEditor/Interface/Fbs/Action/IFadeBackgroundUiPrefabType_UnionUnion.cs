using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006790 RID: 26512
	public class IFadeBackgroundUiPrefabType_UnionUnion
	{
		// Token: 0x1700C4C4 RID: 50372
		// (get) Token: 0x0602E1FD RID: 188925 RVA: 0x0064CD9D File Offset: 0x0064AF9D
		// (set) Token: 0x0602E1FE RID: 188926 RVA: 0x0064CDA5 File Offset: 0x0064AFA5
		public IFadeBackgroundUiPrefabType_Union Type { get; set; }

		// Token: 0x1700C4C5 RID: 50373
		// (get) Token: 0x0602E1FF RID: 188927 RVA: 0x0064CDAE File Offset: 0x0064AFAE
		// (set) Token: 0x0602E200 RID: 188928 RVA: 0x0064CDB6 File Offset: 0x0064AFB6
		public object Value { get; set; }

		// Token: 0x0602E201 RID: 188929 RVA: 0x0064CDBF File Offset: 0x0064AFBF
		public IFadeBackgroundUiPrefabType_UnionUnion()
		{
			this.Type = IFadeBackgroundUiPrefabType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E202 RID: 188930 RVA: 0x0064CDD5 File Offset: 0x0064AFD5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E203 RID: 188931 RVA: 0x0064CDE7 File Offset: 0x0064AFE7
		public IFadeBackgroundUiPrefabTypeT AsIFadeBackgroundUiPrefabType()
		{
			return this.As<IFadeBackgroundUiPrefabTypeT>();
		}

		// Token: 0x0602E204 RID: 188932 RVA: 0x0064CDEF File Offset: 0x0064AFEF
		public static IFadeBackgroundUiPrefabType_UnionUnion FromIFadeBackgroundUiPrefabType(IFadeBackgroundUiPrefabTypeT _ifadebackgrounduiprefabtype)
		{
			return new IFadeBackgroundUiPrefabType_UnionUnion
			{
				Type = IFadeBackgroundUiPrefabType_Union.IFadeBackgroundUiPrefabType,
				Value = _ifadebackgrounduiprefabtype
			};
		}

		// Token: 0x0602E205 RID: 188933 RVA: 0x0064CE04 File Offset: 0x0064B004
		public IFadeBackgroundUiPrefabBlackScreenWhiteTextT AsIFadeBackgroundUiPrefabBlackScreenWhiteText()
		{
			return this.As<IFadeBackgroundUiPrefabBlackScreenWhiteTextT>();
		}

		// Token: 0x0602E206 RID: 188934 RVA: 0x0064CE0C File Offset: 0x0064B00C
		public static IFadeBackgroundUiPrefabType_UnionUnion FromIFadeBackgroundUiPrefabBlackScreenWhiteText(IFadeBackgroundUiPrefabBlackScreenWhiteTextT _ifadebackgrounduiprefabblackscreenwhitetext)
		{
			return new IFadeBackgroundUiPrefabType_UnionUnion
			{
				Type = IFadeBackgroundUiPrefabType_Union.IFadeBackgroundUiPrefabBlackScreenWhiteText,
				Value = _ifadebackgrounduiprefabblackscreenwhitetext
			};
		}

		// Token: 0x0602E207 RID: 188935 RVA: 0x0064CE24 File Offset: 0x0064B024
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
