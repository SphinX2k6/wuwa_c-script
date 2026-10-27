using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E70 RID: 24176
	public class TConstraintValueUnion
	{
		// Token: 0x1700B4BC RID: 46268
		// (get) Token: 0x0602968F RID: 169615 RVA: 0x005ACE02 File Offset: 0x005AB002
		// (set) Token: 0x06029690 RID: 169616 RVA: 0x005ACE0A File Offset: 0x005AB00A
		public TConstraintValue Type { get; set; }

		// Token: 0x1700B4BD RID: 46269
		// (get) Token: 0x06029691 RID: 169617 RVA: 0x005ACE13 File Offset: 0x005AB013
		// (set) Token: 0x06029692 RID: 169618 RVA: 0x005ACE1B File Offset: 0x005AB01B
		public object Value { get; set; }

		// Token: 0x06029693 RID: 169619 RVA: 0x005ACE24 File Offset: 0x005AB024
		public TConstraintValueUnion()
		{
			this.Type = TConstraintValue.NONE;
			this.Value = null;
		}

		// Token: 0x06029694 RID: 169620 RVA: 0x005ACE3A File Offset: 0x005AB03A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029695 RID: 169621 RVA: 0x005ACE4C File Offset: 0x005AB04C
		public IConstraintValueClampT AsIConstraintValueClamp()
		{
			return this.As<IConstraintValueClampT>();
		}

		// Token: 0x06029696 RID: 169622 RVA: 0x005ACE54 File Offset: 0x005AB054
		public static TConstraintValueUnion FromIConstraintValueClamp(IConstraintValueClampT _iconstraintvalueclamp)
		{
			return new TConstraintValueUnion
			{
				Type = TConstraintValue.IConstraintValueClamp,
				Value = _iconstraintvalueclamp
			};
		}

		// Token: 0x06029697 RID: 169623 RVA: 0x005ACE69 File Offset: 0x005AB069
		public IConstraintValueMaxT AsIConstraintValueMax()
		{
			return this.As<IConstraintValueMaxT>();
		}

		// Token: 0x06029698 RID: 169624 RVA: 0x005ACE71 File Offset: 0x005AB071
		public static TConstraintValueUnion FromIConstraintValueMax(IConstraintValueMaxT _iconstraintvaluemax)
		{
			return new TConstraintValueUnion
			{
				Type = TConstraintValue.IConstraintValueMax,
				Value = _iconstraintvaluemax
			};
		}

		// Token: 0x06029699 RID: 169625 RVA: 0x005ACE86 File Offset: 0x005AB086
		public IConstraintValueMinT AsIConstraintValueMin()
		{
			return this.As<IConstraintValueMinT>();
		}

		// Token: 0x0602969A RID: 169626 RVA: 0x005ACE8E File Offset: 0x005AB08E
		public static TConstraintValueUnion FromIConstraintValueMin(IConstraintValueMinT _iconstraintvaluemin)
		{
			return new TConstraintValueUnion
			{
				Type = TConstraintValue.IConstraintValueMin,
				Value = _iconstraintvaluemin
			};
		}

		// Token: 0x0602969B RID: 169627 RVA: 0x005ACEA4 File Offset: 0x005AB0A4
		public static int Pack(FlatBufferBuilder builder, TConstraintValueUnion _o)
		{
			switch (_o.Type)
			{
			case TConstraintValue.IConstraintValueClamp:
				return IConstraintValueClamp.Pack(builder, _o.AsIConstraintValueClamp()).Value;
			case TConstraintValue.IConstraintValueMax:
				return IConstraintValueMax.Pack(builder, _o.AsIConstraintValueMax()).Value;
			case TConstraintValue.IConstraintValueMin:
				return IConstraintValueMin.Pack(builder, _o.AsIConstraintValueMin()).Value;
			default:
				return 0;
			}
		}
	}
}
