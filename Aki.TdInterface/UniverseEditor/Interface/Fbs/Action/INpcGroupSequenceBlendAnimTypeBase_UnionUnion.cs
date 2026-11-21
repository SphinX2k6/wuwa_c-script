using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007317 RID: 29463
	public class INpcGroupSequenceBlendAnimTypeBase_UnionUnion
	{
		// Token: 0x1700D7F5 RID: 55285
		// (get) Token: 0x060335F7 RID: 210423 RVA: 0x006ED5B5 File Offset: 0x006EB7B5
		// (set) Token: 0x060335F8 RID: 210424 RVA: 0x006ED5BD File Offset: 0x006EB7BD
		public INpcGroupSequenceBlendAnimTypeBase_Union Type { get; set; }

		// Token: 0x1700D7F6 RID: 55286
		// (get) Token: 0x060335F9 RID: 210425 RVA: 0x006ED5C6 File Offset: 0x006EB7C6
		// (set) Token: 0x060335FA RID: 210426 RVA: 0x006ED5CE File Offset: 0x006EB7CE
		public object Value { get; set; }

		// Token: 0x060335FB RID: 210427 RVA: 0x006ED5D7 File Offset: 0x006EB7D7
		public INpcGroupSequenceBlendAnimTypeBase_UnionUnion()
		{
			this.Type = INpcGroupSequenceBlendAnimTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060335FC RID: 210428 RVA: 0x006ED5ED File Offset: 0x006EB7ED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060335FD RID: 210429 RVA: 0x006ED5FF File Offset: 0x006EB7FF
		public INpcGroupSequenceBlendAnimTypeBaseT AsINpcGroupSequenceBlendAnimTypeBase()
		{
			return this.As<INpcGroupSequenceBlendAnimTypeBaseT>();
		}

		// Token: 0x060335FE RID: 210430 RVA: 0x006ED607 File Offset: 0x006EB807
		public static INpcGroupSequenceBlendAnimTypeBase_UnionUnion FromINpcGroupSequenceBlendAnimTypeBase(INpcGroupSequenceBlendAnimTypeBaseT _inpcgroupsequenceblendanimtypebase)
		{
			return new INpcGroupSequenceBlendAnimTypeBase_UnionUnion
			{
				Type = INpcGroupSequenceBlendAnimTypeBase_Union.INpcGroupSequenceBlendAnimTypeBase,
				Value = _inpcgroupsequenceblendanimtypebase
			};
		}

		// Token: 0x060335FF RID: 210431 RVA: 0x006ED61C File Offset: 0x006EB81C
		public INpcGroupSequenceMontageBlendAnimTypeT AsINpcGroupSequenceMontageBlendAnimType()
		{
			return this.As<INpcGroupSequenceMontageBlendAnimTypeT>();
		}

		// Token: 0x06033600 RID: 210432 RVA: 0x006ED624 File Offset: 0x006EB824
		public static INpcGroupSequenceBlendAnimTypeBase_UnionUnion FromINpcGroupSequenceMontageBlendAnimType(INpcGroupSequenceMontageBlendAnimTypeT _inpcgroupsequencemontageblendanimtype)
		{
			return new INpcGroupSequenceBlendAnimTypeBase_UnionUnion
			{
				Type = INpcGroupSequenceBlendAnimTypeBase_Union.INpcGroupSequenceMontageBlendAnimType,
				Value = _inpcgroupsequencemontageblendanimtype
			};
		}

		// Token: 0x06033601 RID: 210433 RVA: 0x006ED63C File Offset: 0x006EB83C
		public static int Pack(FlatBufferBuilder builder, INpcGroupSequenceBlendAnimTypeBase_UnionUnion _o)
		{
			INpcGroupSequenceBlendAnimTypeBase_Union type = _o.Type;
			if (type == INpcGroupSequenceBlendAnimTypeBase_Union.INpcGroupSequenceBlendAnimTypeBase)
			{
				return INpcGroupSequenceBlendAnimTypeBase.Pack(builder, _o.AsINpcGroupSequenceBlendAnimTypeBase()).Value;
			}
			if (type != INpcGroupSequenceBlendAnimTypeBase_Union.INpcGroupSequenceMontageBlendAnimType)
			{
				return 0;
			}
			return INpcGroupSequenceMontageBlendAnimType.Pack(builder, _o.AsINpcGroupSequenceMontageBlendAnimType()).Value;
		}
	}
}
