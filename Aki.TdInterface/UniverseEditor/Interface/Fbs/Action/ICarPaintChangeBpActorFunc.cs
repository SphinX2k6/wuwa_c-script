using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062B1 RID: 25265
	public struct ICarPaintChangeBpActorFunc : IFlatbufferObject
	{
		// Token: 0x1700BC9A RID: 48282
		// (get) Token: 0x0602BA89 RID: 178825 RVA: 0x006026DF File Offset: 0x006008DF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BA8A RID: 178826 RVA: 0x006026EC File Offset: 0x006008EC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BA8B RID: 178827 RVA: 0x006026F4 File Offset: 0x006008F4
		public static ICarPaintChangeBpActorFunc GetRootAsICarPaintChangeBpActorFunc(ByteBuffer _bb)
		{
			return ICarPaintChangeBpActorFunc.GetRootAsICarPaintChangeBpActorFunc(_bb, default(ICarPaintChangeBpActorFunc));
		}

		// Token: 0x0602BA8C RID: 178828 RVA: 0x00602710 File Offset: 0x00600910
		public static ICarPaintChangeBpActorFunc GetRootAsICarPaintChangeBpActorFunc(ByteBuffer _bb, ICarPaintChangeBpActorFunc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BA8D RID: 178829 RVA: 0x0060272D File Offset: 0x0060092D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BA8E RID: 178830 RVA: 0x0060273C File Offset: 0x0060093C
		public ICarPaintChangeBpActorFunc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC9B RID: 48283
		// (get) Token: 0x0602BA8F RID: 178831 RVA: 0x0060274C File Offset: 0x0060094C
		public EBpActorFuncType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBpActorFuncType.CarPaintChange;
				}
				return (EBpActorFuncType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC9C RID: 48284
		// (get) Token: 0x0602BA90 RID: 178832 RVA: 0x00602788 File Offset: 0x00600988
		public IActorRef? BpActor
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602BA91 RID: 178833 RVA: 0x006027E5 File Offset: 0x006009E5
		public static Offset<ICarPaintChangeBpActorFunc> CreateICarPaintChangeBpActorFunc(FlatBufferBuilder builder, EBpActorFuncType Type = EBpActorFuncType.CarPaintChange, Offset<IActorRef> BpActorOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(2);
			ICarPaintChangeBpActorFunc.AddBpActor(builder, BpActorOffset);
			ICarPaintChangeBpActorFunc.AddType(builder, Type);
			return ICarPaintChangeBpActorFunc.EndICarPaintChangeBpActorFunc(builder);
		}

		// Token: 0x0602BA92 RID: 178834 RVA: 0x00602802 File Offset: 0x00600A02
		public static void StartICarPaintChangeBpActorFunc(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BA93 RID: 178835 RVA: 0x0060280B File Offset: 0x00600A0B
		public static void AddType(FlatBufferBuilder builder, EBpActorFuncType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BA94 RID: 178836 RVA: 0x00602816 File Offset: 0x00600A16
		public static void AddBpActor(FlatBufferBuilder builder, Offset<IActorRef> bpActorOffset)
		{
			builder.AddOffset(1, bpActorOffset.Value, 0);
		}

		// Token: 0x0602BA95 RID: 178837 RVA: 0x00602826 File Offset: 0x00600A26
		public static Offset<ICarPaintChangeBpActorFunc> EndICarPaintChangeBpActorFunc(FlatBufferBuilder builder)
		{
			return new Offset<ICarPaintChangeBpActorFunc>(builder.EndTable());
		}

		// Token: 0x0602BA96 RID: 178838 RVA: 0x00602834 File Offset: 0x00600A34
		public ICarPaintChangeBpActorFuncT UnPack()
		{
			ICarPaintChangeBpActorFuncT carPaintChangeBpActorFuncT = new ICarPaintChangeBpActorFuncT();
			this.UnPackTo(carPaintChangeBpActorFuncT);
			return carPaintChangeBpActorFuncT;
		}

		// Token: 0x0602BA97 RID: 178839 RVA: 0x00602850 File Offset: 0x00600A50
		public void UnPackTo(ICarPaintChangeBpActorFuncT _o)
		{
			_o.Type = this.Type;
			_o.BpActor = ((this.BpActor != null) ? this.BpActor.Value.UnPack() : null);
		}

		// Token: 0x0602BA98 RID: 178840 RVA: 0x00602898 File Offset: 0x00600A98
		public static Offset<ICarPaintChangeBpActorFunc> Pack(FlatBufferBuilder builder, ICarPaintChangeBpActorFuncT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICarPaintChangeBpActorFunc>);
			}
			Offset<IActorRef> bpActorOffset = (_o.BpActor == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.BpActor);
			return ICarPaintChangeBpActorFunc.CreateICarPaintChangeBpActorFunc(builder, _o.Type, bpActorOffset);
		}

		// Token: 0x0401084F RID: 67663
		private Table __p;
	}
}
