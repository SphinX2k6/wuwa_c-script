using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ACE RID: 27342
	public class IModifySceneItemAttributeTag_UnionUnion
	{
		// Token: 0x1700CAD5 RID: 51925
		// (get) Token: 0x0602FEA0 RID: 196256 RVA: 0x00684570 File Offset: 0x00682770
		// (set) Token: 0x0602FEA1 RID: 196257 RVA: 0x00684578 File Offset: 0x00682778
		public IModifySceneItemAttributeTag_Union Type { get; set; }

		// Token: 0x1700CAD6 RID: 51926
		// (get) Token: 0x0602FEA2 RID: 196258 RVA: 0x00684581 File Offset: 0x00682781
		// (set) Token: 0x0602FEA3 RID: 196259 RVA: 0x00684589 File Offset: 0x00682789
		public object Value { get; set; }

		// Token: 0x0602FEA4 RID: 196260 RVA: 0x00684592 File Offset: 0x00682792
		public IModifySceneItemAttributeTag_UnionUnion()
		{
			this.Type = IModifySceneItemAttributeTag_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FEA5 RID: 196261 RVA: 0x006845A8 File Offset: 0x006827A8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FEA6 RID: 196262 RVA: 0x006845BA File Offset: 0x006827BA
		public IModifySceneItemAttributeTagT AsIModifySceneItemAttributeTag()
		{
			return this.As<IModifySceneItemAttributeTagT>();
		}

		// Token: 0x0602FEA7 RID: 196263 RVA: 0x006845C2 File Offset: 0x006827C2
		public static IModifySceneItemAttributeTag_UnionUnion FromIModifySceneItemAttributeTag(IModifySceneItemAttributeTagT _imodifysceneitemattributetag)
		{
			return new IModifySceneItemAttributeTag_UnionUnion
			{
				Type = IModifySceneItemAttributeTag_Union.IModifySceneItemAttributeTag,
				Value = _imodifysceneitemattributetag
			};
		}

		// Token: 0x0602FEA8 RID: 196264 RVA: 0x006845D7 File Offset: 0x006827D7
		public IModifySelfSceneItemAttributeTagT AsIModifySelfSceneItemAttributeTag()
		{
			return this.As<IModifySelfSceneItemAttributeTagT>();
		}

		// Token: 0x0602FEA9 RID: 196265 RVA: 0x006845DF File Offset: 0x006827DF
		public static IModifySceneItemAttributeTag_UnionUnion FromIModifySelfSceneItemAttributeTag(IModifySelfSceneItemAttributeTagT _imodifyselfsceneitemattributetag)
		{
			return new IModifySceneItemAttributeTag_UnionUnion
			{
				Type = IModifySceneItemAttributeTag_Union.IModifySelfSceneItemAttributeTag,
				Value = _imodifyselfsceneitemattributetag
			};
		}

		// Token: 0x0602FEAA RID: 196266 RVA: 0x006845F4 File Offset: 0x006827F4
		public IModifyTargetSceneItemAttributeTagT AsIModifyTargetSceneItemAttributeTag()
		{
			return this.As<IModifyTargetSceneItemAttributeTagT>();
		}

		// Token: 0x0602FEAB RID: 196267 RVA: 0x006845FC File Offset: 0x006827FC
		public static IModifySceneItemAttributeTag_UnionUnion FromIModifyTargetSceneItemAttributeTag(IModifyTargetSceneItemAttributeTagT _imodifytargetsceneitemattributetag)
		{
			return new IModifySceneItemAttributeTag_UnionUnion
			{
				Type = IModifySceneItemAttributeTag_Union.IModifyTargetSceneItemAttributeTag,
				Value = _imodifytargetsceneitemattributetag
			};
		}

		// Token: 0x0602FEAC RID: 196268 RVA: 0x00684614 File Offset: 0x00682814
		public static int Pack(FlatBufferBuilder builder, IModifySceneItemAttributeTag_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IModifySceneItemAttributeTag_Union.IModifySceneItemAttributeTag:
				return IModifySceneItemAttributeTag.Pack(builder, _o.AsIModifySceneItemAttributeTag()).Value;
			case IModifySceneItemAttributeTag_Union.IModifySelfSceneItemAttributeTag:
				return IModifySelfSceneItemAttributeTag.Pack(builder, _o.AsIModifySelfSceneItemAttributeTag()).Value;
			case IModifySceneItemAttributeTag_Union.IModifyTargetSceneItemAttributeTag:
				return IModifyTargetSceneItemAttributeTag.Pack(builder, _o.AsIModifyTargetSceneItemAttributeTag()).Value;
			default:
				return 0;
			}
		}
	}
}
