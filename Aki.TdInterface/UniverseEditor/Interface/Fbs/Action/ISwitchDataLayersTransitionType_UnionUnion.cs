using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007254 RID: 29268
	public class ISwitchDataLayersTransitionType_UnionUnion
	{
		// Token: 0x1700D929 RID: 55593
		// (get) Token: 0x06033EA6 RID: 212646 RVA: 0x006FBB05 File Offset: 0x006F9D05
		// (set) Token: 0x06033EA7 RID: 212647 RVA: 0x006FBB0D File Offset: 0x006F9D0D
		public ISwitchDataLayersTransitionType_Union Type { get; set; }

		// Token: 0x1700D92A RID: 55594
		// (get) Token: 0x06033EA8 RID: 212648 RVA: 0x006FBB16 File Offset: 0x006F9D16
		// (set) Token: 0x06033EA9 RID: 212649 RVA: 0x006FBB1E File Offset: 0x006F9D1E
		public object Value { get; set; }

		// Token: 0x06033EAA RID: 212650 RVA: 0x006FBB27 File Offset: 0x006F9D27
		public ISwitchDataLayersTransitionType_UnionUnion()
		{
			this.Type = ISwitchDataLayersTransitionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033EAB RID: 212651 RVA: 0x006FBB3D File Offset: 0x006F9D3D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033EAC RID: 212652 RVA: 0x006FBB4F File Offset: 0x006F9D4F
		public ISwitchDataLayersTransitionTypeT AsISwitchDataLayersTransitionType()
		{
			return this.As<ISwitchDataLayersTransitionTypeT>();
		}

		// Token: 0x06033EAD RID: 212653 RVA: 0x006FBB57 File Offset: 0x006F9D57
		public static ISwitchDataLayersTransitionType_UnionUnion FromISwitchDataLayersTransitionType(ISwitchDataLayersTransitionTypeT _iswitchdatalayerstransitiontype)
		{
			return new ISwitchDataLayersTransitionType_UnionUnion
			{
				Type = ISwitchDataLayersTransitionType_Union.ISwitchDataLayersTransitionType,
				Value = _iswitchdatalayerstransitiontype
			};
		}

		// Token: 0x06033EAE RID: 212654 RVA: 0x006FBB6C File Offset: 0x006F9D6C
		public ISwitchDataLayersTransitionWithSequenceT AsISwitchDataLayersTransitionWithSequence()
		{
			return this.As<ISwitchDataLayersTransitionWithSequenceT>();
		}

		// Token: 0x06033EAF RID: 212655 RVA: 0x006FBB74 File Offset: 0x006F9D74
		public static ISwitchDataLayersTransitionType_UnionUnion FromISwitchDataLayersTransitionWithSequence(ISwitchDataLayersTransitionWithSequenceT _iswitchdatalayerstransitionwithsequence)
		{
			return new ISwitchDataLayersTransitionType_UnionUnion
			{
				Type = ISwitchDataLayersTransitionType_Union.ISwitchDataLayersTransitionWithSequence,
				Value = _iswitchdatalayerstransitionwithsequence
			};
		}

		// Token: 0x06033EB0 RID: 212656 RVA: 0x006FBB8C File Offset: 0x006F9D8C
		public static int Pack(FlatBufferBuilder builder, ISwitchDataLayersTransitionType_UnionUnion _o)
		{
			ISwitchDataLayersTransitionType_Union type = _o.Type;
			if (type == ISwitchDataLayersTransitionType_Union.ISwitchDataLayersTransitionType)
			{
				return ISwitchDataLayersTransitionType.Pack(builder, _o.AsISwitchDataLayersTransitionType()).Value;
			}
			if (type != ISwitchDataLayersTransitionType_Union.ISwitchDataLayersTransitionWithSequence)
			{
				return 0;
			}
			return ISwitchDataLayersTransitionWithSequence.Pack(builder, _o.AsISwitchDataLayersTransitionWithSequence()).Value;
		}
	}
}
