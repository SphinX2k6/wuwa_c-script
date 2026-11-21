using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A29 RID: 31273
	public class ISwitchDataLayersTransitionType_UnionUnion
	{
		// Token: 0x1700E522 RID: 58658
		// (get) Token: 0x060371A8 RID: 225704 RVA: 0x0075CE65 File Offset: 0x0075B065
		// (set) Token: 0x060371A9 RID: 225705 RVA: 0x0075CE6D File Offset: 0x0075B06D
		public ISwitchDataLayersTransitionType_Union Type { get; set; }

		// Token: 0x1700E523 RID: 58659
		// (get) Token: 0x060371AA RID: 225706 RVA: 0x0075CE76 File Offset: 0x0075B076
		// (set) Token: 0x060371AB RID: 225707 RVA: 0x0075CE7E File Offset: 0x0075B07E
		public object Value { get; set; }

		// Token: 0x060371AC RID: 225708 RVA: 0x0075CE87 File Offset: 0x0075B087
		public ISwitchDataLayersTransitionType_UnionUnion()
		{
			this.Type = ISwitchDataLayersTransitionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060371AD RID: 225709 RVA: 0x0075CE9D File Offset: 0x0075B09D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060371AE RID: 225710 RVA: 0x0075CEAF File Offset: 0x0075B0AF
		public ISwitchDataLayersTransitionTypeT AsISwitchDataLayersTransitionType()
		{
			return this.As<ISwitchDataLayersTransitionTypeT>();
		}

		// Token: 0x060371AF RID: 225711 RVA: 0x0075CEB7 File Offset: 0x0075B0B7
		public static ISwitchDataLayersTransitionType_UnionUnion FromISwitchDataLayersTransitionType(ISwitchDataLayersTransitionTypeT _iswitchdatalayerstransitiontype)
		{
			return new ISwitchDataLayersTransitionType_UnionUnion
			{
				Type = ISwitchDataLayersTransitionType_Union.ISwitchDataLayersTransitionType,
				Value = _iswitchdatalayerstransitiontype
			};
		}

		// Token: 0x060371B0 RID: 225712 RVA: 0x0075CECC File Offset: 0x0075B0CC
		public ISwitchDataLayersTransitionWithSequenceT AsISwitchDataLayersTransitionWithSequence()
		{
			return this.As<ISwitchDataLayersTransitionWithSequenceT>();
		}

		// Token: 0x060371B1 RID: 225713 RVA: 0x0075CED4 File Offset: 0x0075B0D4
		public static ISwitchDataLayersTransitionType_UnionUnion FromISwitchDataLayersTransitionWithSequence(ISwitchDataLayersTransitionWithSequenceT _iswitchdatalayerstransitionwithsequence)
		{
			return new ISwitchDataLayersTransitionType_UnionUnion
			{
				Type = ISwitchDataLayersTransitionType_Union.ISwitchDataLayersTransitionWithSequence,
				Value = _iswitchdatalayerstransitionwithsequence
			};
		}

		// Token: 0x060371B2 RID: 225714 RVA: 0x0075CEEC File Offset: 0x0075B0EC
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
