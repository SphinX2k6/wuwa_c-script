using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200730E RID: 29454
	public class INpcGroupSequenceBindingBase_UnionUnion
	{
		// Token: 0x1700D7EB RID: 55275
		// (get) Token: 0x060335C3 RID: 210371 RVA: 0x006ED0B5 File Offset: 0x006EB2B5
		// (set) Token: 0x060335C4 RID: 210372 RVA: 0x006ED0BD File Offset: 0x006EB2BD
		public INpcGroupSequenceBindingBase_Union Type { get; set; }

		// Token: 0x1700D7EC RID: 55276
		// (get) Token: 0x060335C5 RID: 210373 RVA: 0x006ED0C6 File Offset: 0x006EB2C6
		// (set) Token: 0x060335C6 RID: 210374 RVA: 0x006ED0CE File Offset: 0x006EB2CE
		public object Value { get; set; }

		// Token: 0x060335C7 RID: 210375 RVA: 0x006ED0D7 File Offset: 0x006EB2D7
		public INpcGroupSequenceBindingBase_UnionUnion()
		{
			this.Type = INpcGroupSequenceBindingBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060335C8 RID: 210376 RVA: 0x006ED0ED File Offset: 0x006EB2ED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060335C9 RID: 210377 RVA: 0x006ED0FF File Offset: 0x006EB2FF
		public INpcGroupSequenceBindingBaseT AsINpcGroupSequenceBindingBase()
		{
			return this.As<INpcGroupSequenceBindingBaseT>();
		}

		// Token: 0x060335CA RID: 210378 RVA: 0x006ED107 File Offset: 0x006EB307
		public static INpcGroupSequenceBindingBase_UnionUnion FromINpcGroupSequenceBindingBase(INpcGroupSequenceBindingBaseT _inpcgroupsequencebindingbase)
		{
			return new INpcGroupSequenceBindingBase_UnionUnion
			{
				Type = INpcGroupSequenceBindingBase_Union.INpcGroupSequenceBindingBase,
				Value = _inpcgroupsequencebindingbase
			};
		}

		// Token: 0x060335CB RID: 210379 RVA: 0x006ED11C File Offset: 0x006EB31C
		public INpcGroupSequenceStaticEntityBindingT AsINpcGroupSequenceStaticEntityBinding()
		{
			return this.As<INpcGroupSequenceStaticEntityBindingT>();
		}

		// Token: 0x060335CC RID: 210380 RVA: 0x006ED124 File Offset: 0x006EB324
		public static INpcGroupSequenceBindingBase_UnionUnion FromINpcGroupSequenceStaticEntityBinding(INpcGroupSequenceStaticEntityBindingT _inpcgroupsequencestaticentitybinding)
		{
			return new INpcGroupSequenceBindingBase_UnionUnion
			{
				Type = INpcGroupSequenceBindingBase_Union.INpcGroupSequenceStaticEntityBinding,
				Value = _inpcgroupsequencestaticentitybinding
			};
		}

		// Token: 0x060335CD RID: 210381 RVA: 0x006ED13C File Offset: 0x006EB33C
		public static int Pack(FlatBufferBuilder builder, INpcGroupSequenceBindingBase_UnionUnion _o)
		{
			INpcGroupSequenceBindingBase_Union type = _o.Type;
			if (type == INpcGroupSequenceBindingBase_Union.INpcGroupSequenceBindingBase)
			{
				return INpcGroupSequenceBindingBase.Pack(builder, _o.AsINpcGroupSequenceBindingBase()).Value;
			}
			if (type != INpcGroupSequenceBindingBase_Union.INpcGroupSequenceStaticEntityBinding)
			{
				return 0;
			}
			return INpcGroupSequenceStaticEntityBinding.Pack(builder, _o.AsINpcGroupSequenceStaticEntityBinding()).Value;
		}
	}
}
