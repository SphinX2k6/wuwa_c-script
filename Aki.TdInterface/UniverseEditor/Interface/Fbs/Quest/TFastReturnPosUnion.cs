using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004732 RID: 18226
	public class TFastReturnPosUnion
	{
		// Token: 0x17007F77 RID: 32631
		// (get) Token: 0x0601AD7F RID: 109951 RVA: 0x003CF87A File Offset: 0x003CDA7A
		// (set) Token: 0x0601AD80 RID: 109952 RVA: 0x003CF882 File Offset: 0x003CDA82
		public TFastReturnPos Type { get; set; }

		// Token: 0x17007F78 RID: 32632
		// (get) Token: 0x0601AD81 RID: 109953 RVA: 0x003CF88B File Offset: 0x003CDA8B
		// (set) Token: 0x0601AD82 RID: 109954 RVA: 0x003CF893 File Offset: 0x003CDA93
		public object Value { get; set; }

		// Token: 0x0601AD83 RID: 109955 RVA: 0x003CF89C File Offset: 0x003CDA9C
		public TFastReturnPosUnion()
		{
			this.Type = TFastReturnPos.NONE;
			this.Value = null;
		}

		// Token: 0x0601AD84 RID: 109956 RVA: 0x003CF8B2 File Offset: 0x003CDAB2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AD85 RID: 109957 RVA: 0x003CF8C4 File Offset: 0x003CDAC4
		public IFastReturnEntityPosT AsIFastReturnEntityPos()
		{
			return this.As<IFastReturnEntityPosT>();
		}

		// Token: 0x0601AD86 RID: 109958 RVA: 0x003CF8CC File Offset: 0x003CDACC
		public static TFastReturnPosUnion FromIFastReturnEntityPos(IFastReturnEntityPosT _ifastreturnentitypos)
		{
			return new TFastReturnPosUnion
			{
				Type = TFastReturnPos.IFastReturnEntityPos,
				Value = _ifastreturnentitypos
			};
		}

		// Token: 0x0601AD87 RID: 109959 RVA: 0x003CF8E1 File Offset: 0x003CDAE1
		public IFastReturnGravityEntityPosT AsIFastReturnGravityEntityPos()
		{
			return this.As<IFastReturnGravityEntityPosT>();
		}

		// Token: 0x0601AD88 RID: 109960 RVA: 0x003CF8E9 File Offset: 0x003CDAE9
		public static TFastReturnPosUnion FromIFastReturnGravityEntityPos(IFastReturnGravityEntityPosT _ifastreturngravityentitypos)
		{
			return new TFastReturnPosUnion
			{
				Type = TFastReturnPos.IFastReturnGravityEntityPos,
				Value = _ifastreturngravityentitypos
			};
		}

		// Token: 0x0601AD89 RID: 109961 RVA: 0x003CF900 File Offset: 0x003CDB00
		public static int Pack(FlatBufferBuilder builder, TFastReturnPosUnion _o)
		{
			TFastReturnPos type = _o.Type;
			if (type == TFastReturnPos.IFastReturnEntityPos)
			{
				return IFastReturnEntityPos.Pack(builder, _o.AsIFastReturnEntityPos()).Value;
			}
			if (type != TFastReturnPos.IFastReturnGravityEntityPos)
			{
				return 0;
			}
			return IFastReturnGravityEntityPos.Pack(builder, _o.AsIFastReturnGravityEntityPos()).Value;
		}
	}
}
