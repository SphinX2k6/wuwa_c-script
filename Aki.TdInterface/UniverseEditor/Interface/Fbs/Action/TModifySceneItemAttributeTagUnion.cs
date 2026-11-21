using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F40 RID: 32576
	public class TModifySceneItemAttributeTagUnion
	{
		// Token: 0x1700F2A3 RID: 62115
		// (get) Token: 0x0603ABF9 RID: 240633 RVA: 0x007E631A File Offset: 0x007E451A
		// (set) Token: 0x0603ABFA RID: 240634 RVA: 0x007E6322 File Offset: 0x007E4522
		public TModifySceneItemAttributeTag Type { get; set; }

		// Token: 0x1700F2A4 RID: 62116
		// (get) Token: 0x0603ABFB RID: 240635 RVA: 0x007E632B File Offset: 0x007E452B
		// (set) Token: 0x0603ABFC RID: 240636 RVA: 0x007E6333 File Offset: 0x007E4533
		public object Value { get; set; }

		// Token: 0x0603ABFD RID: 240637 RVA: 0x007E633C File Offset: 0x007E453C
		public TModifySceneItemAttributeTagUnion()
		{
			this.Type = TModifySceneItemAttributeTag.NONE;
			this.Value = null;
		}

		// Token: 0x0603ABFE RID: 240638 RVA: 0x007E6352 File Offset: 0x007E4552
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ABFF RID: 240639 RVA: 0x007E6364 File Offset: 0x007E4564
		public IModifySelfSceneItemAttributeTagT AsIModifySelfSceneItemAttributeTag()
		{
			return this.As<IModifySelfSceneItemAttributeTagT>();
		}

		// Token: 0x0603AC00 RID: 240640 RVA: 0x007E636C File Offset: 0x007E456C
		public static TModifySceneItemAttributeTagUnion FromIModifySelfSceneItemAttributeTag(IModifySelfSceneItemAttributeTagT _imodifyselfsceneitemattributetag)
		{
			return new TModifySceneItemAttributeTagUnion
			{
				Type = TModifySceneItemAttributeTag.IModifySelfSceneItemAttributeTag,
				Value = _imodifyselfsceneitemattributetag
			};
		}

		// Token: 0x0603AC01 RID: 240641 RVA: 0x007E6381 File Offset: 0x007E4581
		public IModifyTargetSceneItemAttributeTagT AsIModifyTargetSceneItemAttributeTag()
		{
			return this.As<IModifyTargetSceneItemAttributeTagT>();
		}

		// Token: 0x0603AC02 RID: 240642 RVA: 0x007E6389 File Offset: 0x007E4589
		public static TModifySceneItemAttributeTagUnion FromIModifyTargetSceneItemAttributeTag(IModifyTargetSceneItemAttributeTagT _imodifytargetsceneitemattributetag)
		{
			return new TModifySceneItemAttributeTagUnion
			{
				Type = TModifySceneItemAttributeTag.IModifyTargetSceneItemAttributeTag,
				Value = _imodifytargetsceneitemattributetag
			};
		}

		// Token: 0x0603AC03 RID: 240643 RVA: 0x007E63A0 File Offset: 0x007E45A0
		public static int Pack(FlatBufferBuilder builder, TModifySceneItemAttributeTagUnion _o)
		{
			TModifySceneItemAttributeTag type = _o.Type;
			if (type == TModifySceneItemAttributeTag.IModifySelfSceneItemAttributeTag)
			{
				return IModifySelfSceneItemAttributeTag.Pack(builder, _o.AsIModifySelfSceneItemAttributeTag()).Value;
			}
			if (type != TModifySceneItemAttributeTag.IModifyTargetSceneItemAttributeTag)
			{
				return 0;
			}
			return IModifyTargetSceneItemAttributeTag.Pack(builder, _o.AsIModifyTargetSceneItemAttributeTag()).Value;
		}
	}
}
