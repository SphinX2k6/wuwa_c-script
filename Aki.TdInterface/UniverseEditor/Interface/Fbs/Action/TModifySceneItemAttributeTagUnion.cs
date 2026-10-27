using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200771A RID: 30490
	public class TModifySceneItemAttributeTagUnion
	{
		// Token: 0x1700E655 RID: 58965
		// (get) Token: 0x060376D0 RID: 227024 RVA: 0x00781566 File Offset: 0x0077F766
		// (set) Token: 0x060376D1 RID: 227025 RVA: 0x0078156E File Offset: 0x0077F76E
		public TModifySceneItemAttributeTag Type { get; set; }

		// Token: 0x1700E656 RID: 58966
		// (get) Token: 0x060376D2 RID: 227026 RVA: 0x00781577 File Offset: 0x0077F777
		// (set) Token: 0x060376D3 RID: 227027 RVA: 0x0078157F File Offset: 0x0077F77F
		public object Value { get; set; }

		// Token: 0x060376D4 RID: 227028 RVA: 0x00781588 File Offset: 0x0077F788
		public TModifySceneItemAttributeTagUnion()
		{
			this.Type = TModifySceneItemAttributeTag.NONE;
			this.Value = null;
		}

		// Token: 0x060376D5 RID: 227029 RVA: 0x0078159E File Offset: 0x0077F79E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060376D6 RID: 227030 RVA: 0x007815B0 File Offset: 0x0077F7B0
		public IModifySelfSceneItemAttributeTagT AsIModifySelfSceneItemAttributeTag()
		{
			return this.As<IModifySelfSceneItemAttributeTagT>();
		}

		// Token: 0x060376D7 RID: 227031 RVA: 0x007815B8 File Offset: 0x0077F7B8
		public static TModifySceneItemAttributeTagUnion FromIModifySelfSceneItemAttributeTag(IModifySelfSceneItemAttributeTagT _imodifyselfsceneitemattributetag)
		{
			return new TModifySceneItemAttributeTagUnion
			{
				Type = TModifySceneItemAttributeTag.IModifySelfSceneItemAttributeTag,
				Value = _imodifyselfsceneitemattributetag
			};
		}

		// Token: 0x060376D8 RID: 227032 RVA: 0x007815CD File Offset: 0x0077F7CD
		public IModifyTargetSceneItemAttributeTagT AsIModifyTargetSceneItemAttributeTag()
		{
			return this.As<IModifyTargetSceneItemAttributeTagT>();
		}

		// Token: 0x060376D9 RID: 227033 RVA: 0x007815D5 File Offset: 0x0077F7D5
		public static TModifySceneItemAttributeTagUnion FromIModifyTargetSceneItemAttributeTag(IModifyTargetSceneItemAttributeTagT _imodifytargetsceneitemattributetag)
		{
			return new TModifySceneItemAttributeTagUnion
			{
				Type = TModifySceneItemAttributeTag.IModifyTargetSceneItemAttributeTag,
				Value = _imodifytargetsceneitemattributetag
			};
		}

		// Token: 0x060376DA RID: 227034 RVA: 0x007815EC File Offset: 0x0077F7EC
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
