using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004263 RID: 16995
	public class IFastReturnPosBase_UnionUnion
	{
		// Token: 0x170073EB RID: 29675
		// (get) Token: 0x06017AEA RID: 97002 RVA: 0x00360E8D File Offset: 0x0035F08D
		// (set) Token: 0x06017AEB RID: 97003 RVA: 0x00360E95 File Offset: 0x0035F095
		public IFastReturnPosBase_Union Type { get; set; }

		// Token: 0x170073EC RID: 29676
		// (get) Token: 0x06017AEC RID: 97004 RVA: 0x00360E9E File Offset: 0x0035F09E
		// (set) Token: 0x06017AED RID: 97005 RVA: 0x00360EA6 File Offset: 0x0035F0A6
		public object Value { get; set; }

		// Token: 0x06017AEE RID: 97006 RVA: 0x00360EAF File Offset: 0x0035F0AF
		public IFastReturnPosBase_UnionUnion()
		{
			this.Type = IFastReturnPosBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017AEF RID: 97007 RVA: 0x00360EC5 File Offset: 0x0035F0C5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017AF0 RID: 97008 RVA: 0x00360ED7 File Offset: 0x0035F0D7
		public IFastReturnPosBaseT AsIFastReturnPosBase()
		{
			return this.As<IFastReturnPosBaseT>();
		}

		// Token: 0x06017AF1 RID: 97009 RVA: 0x00360EDF File Offset: 0x0035F0DF
		public static IFastReturnPosBase_UnionUnion FromIFastReturnPosBase(IFastReturnPosBaseT _ifastreturnposbase)
		{
			return new IFastReturnPosBase_UnionUnion
			{
				Type = IFastReturnPosBase_Union.IFastReturnPosBase,
				Value = _ifastreturnposbase
			};
		}

		// Token: 0x06017AF2 RID: 97010 RVA: 0x00360EF4 File Offset: 0x0035F0F4
		public IFastReturnEntityPosT AsIFastReturnEntityPos()
		{
			return this.As<IFastReturnEntityPosT>();
		}

		// Token: 0x06017AF3 RID: 97011 RVA: 0x00360EFC File Offset: 0x0035F0FC
		public static IFastReturnPosBase_UnionUnion FromIFastReturnEntityPos(IFastReturnEntityPosT _ifastreturnentitypos)
		{
			return new IFastReturnPosBase_UnionUnion
			{
				Type = IFastReturnPosBase_Union.IFastReturnEntityPos,
				Value = _ifastreturnentitypos
			};
		}

		// Token: 0x06017AF4 RID: 97012 RVA: 0x00360F11 File Offset: 0x0035F111
		public IFastReturnGravityEntityPosT AsIFastReturnGravityEntityPos()
		{
			return this.As<IFastReturnGravityEntityPosT>();
		}

		// Token: 0x06017AF5 RID: 97013 RVA: 0x00360F19 File Offset: 0x0035F119
		public static IFastReturnPosBase_UnionUnion FromIFastReturnGravityEntityPos(IFastReturnGravityEntityPosT _ifastreturngravityentitypos)
		{
			return new IFastReturnPosBase_UnionUnion
			{
				Type = IFastReturnPosBase_Union.IFastReturnGravityEntityPos,
				Value = _ifastreturngravityentitypos
			};
		}

		// Token: 0x06017AF6 RID: 97014 RVA: 0x00360F30 File Offset: 0x0035F130
		public static int Pack(FlatBufferBuilder builder, IFastReturnPosBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFastReturnPosBase_Union.IFastReturnPosBase:
				return IFastReturnPosBase.Pack(builder, _o.AsIFastReturnPosBase()).Value;
			case IFastReturnPosBase_Union.IFastReturnEntityPos:
				return IFastReturnEntityPos.Pack(builder, _o.AsIFastReturnEntityPos()).Value;
			case IFastReturnPosBase_Union.IFastReturnGravityEntityPos:
				return IFastReturnGravityEntityPos.Pack(builder, _o.AsIFastReturnGravityEntityPos()).Value;
			default:
				return 0;
			}
		}
	}
}
