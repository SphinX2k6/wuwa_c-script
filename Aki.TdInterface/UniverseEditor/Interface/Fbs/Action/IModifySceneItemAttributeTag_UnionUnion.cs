using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007202 RID: 29186
	public class IModifySceneItemAttributeTag_UnionUnion
	{
		// Token: 0x1700D59D RID: 54685
		// (get) Token: 0x06032C56 RID: 207958 RVA: 0x006DB814 File Offset: 0x006D9A14
		// (set) Token: 0x06032C57 RID: 207959 RVA: 0x006DB81C File Offset: 0x006D9A1C
		public IModifySceneItemAttributeTag_Union Type { get; set; }

		// Token: 0x1700D59E RID: 54686
		// (get) Token: 0x06032C58 RID: 207960 RVA: 0x006DB825 File Offset: 0x006D9A25
		// (set) Token: 0x06032C59 RID: 207961 RVA: 0x006DB82D File Offset: 0x006D9A2D
		public object Value { get; set; }

		// Token: 0x06032C5A RID: 207962 RVA: 0x006DB836 File Offset: 0x006D9A36
		public IModifySceneItemAttributeTag_UnionUnion()
		{
			this.Type = IModifySceneItemAttributeTag_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032C5B RID: 207963 RVA: 0x006DB84C File Offset: 0x006D9A4C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032C5C RID: 207964 RVA: 0x006DB85E File Offset: 0x006D9A5E
		public IModifySceneItemAttributeTagT AsIModifySceneItemAttributeTag()
		{
			return this.As<IModifySceneItemAttributeTagT>();
		}

		// Token: 0x06032C5D RID: 207965 RVA: 0x006DB866 File Offset: 0x006D9A66
		public static IModifySceneItemAttributeTag_UnionUnion FromIModifySceneItemAttributeTag(IModifySceneItemAttributeTagT _imodifysceneitemattributetag)
		{
			return new IModifySceneItemAttributeTag_UnionUnion
			{
				Type = IModifySceneItemAttributeTag_Union.IModifySceneItemAttributeTag,
				Value = _imodifysceneitemattributetag
			};
		}

		// Token: 0x06032C5E RID: 207966 RVA: 0x006DB87B File Offset: 0x006D9A7B
		public IModifySelfSceneItemAttributeTagT AsIModifySelfSceneItemAttributeTag()
		{
			return this.As<IModifySelfSceneItemAttributeTagT>();
		}

		// Token: 0x06032C5F RID: 207967 RVA: 0x006DB883 File Offset: 0x006D9A83
		public static IModifySceneItemAttributeTag_UnionUnion FromIModifySelfSceneItemAttributeTag(IModifySelfSceneItemAttributeTagT _imodifyselfsceneitemattributetag)
		{
			return new IModifySceneItemAttributeTag_UnionUnion
			{
				Type = IModifySceneItemAttributeTag_Union.IModifySelfSceneItemAttributeTag,
				Value = _imodifyselfsceneitemattributetag
			};
		}

		// Token: 0x06032C60 RID: 207968 RVA: 0x006DB898 File Offset: 0x006D9A98
		public IModifyTargetSceneItemAttributeTagT AsIModifyTargetSceneItemAttributeTag()
		{
			return this.As<IModifyTargetSceneItemAttributeTagT>();
		}

		// Token: 0x06032C61 RID: 207969 RVA: 0x006DB8A0 File Offset: 0x006D9AA0
		public static IModifySceneItemAttributeTag_UnionUnion FromIModifyTargetSceneItemAttributeTag(IModifyTargetSceneItemAttributeTagT _imodifytargetsceneitemattributetag)
		{
			return new IModifySceneItemAttributeTag_UnionUnion
			{
				Type = IModifySceneItemAttributeTag_Union.IModifyTargetSceneItemAttributeTag,
				Value = _imodifytargetsceneitemattributetag
			};
		}

		// Token: 0x06032C62 RID: 207970 RVA: 0x006DB8B8 File Offset: 0x006D9AB8
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
