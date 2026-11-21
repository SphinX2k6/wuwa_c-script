using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200700A RID: 28682
	public struct IInfrastructureItemDeliveryObservatory : IFlatbufferObject
	{
		// Token: 0x1700D209 RID: 53769
		// (get) Token: 0x06031B26 RID: 203558 RVA: 0x006BAE85 File Offset: 0x006B9085
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B27 RID: 203559 RVA: 0x006BAE92 File Offset: 0x006B9092
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B28 RID: 203560 RVA: 0x006BAE9C File Offset: 0x006B909C
		public static IInfrastructureItemDeliveryObservatory GetRootAsIInfrastructureItemDeliveryObservatory(ByteBuffer _bb)
		{
			return IInfrastructureItemDeliveryObservatory.GetRootAsIInfrastructureItemDeliveryObservatory(_bb, default(IInfrastructureItemDeliveryObservatory));
		}

		// Token: 0x06031B29 RID: 203561 RVA: 0x006BAEB8 File Offset: 0x006B90B8
		public static IInfrastructureItemDeliveryObservatory GetRootAsIInfrastructureItemDeliveryObservatory(ByteBuffer _bb, IInfrastructureItemDeliveryObservatory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B2A RID: 203562 RVA: 0x006BAED5 File Offset: 0x006B90D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B2B RID: 203563 RVA: 0x006BAEE4 File Offset: 0x006B90E4
		public IInfrastructureItemDeliveryObservatory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D20A RID: 53770
		// (get) Token: 0x06031B2C RID: 203564 RVA: 0x006BAEF4 File Offset: 0x006B90F4
		public EInfrastructureItemDeliveryType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInfrastructureItemDeliveryType.Observatory;
				}
				return (EInfrastructureItemDeliveryType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D20B RID: 53771
		// (get) Token: 0x06031B2D RID: 203565 RVA: 0x006BAF30 File Offset: 0x006B9130
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031B2E RID: 203566 RVA: 0x006BAF6C File Offset: 0x006B916C
		public static Offset<IInfrastructureItemDeliveryObservatory> CreateIInfrastructureItemDeliveryObservatory(FlatBufferBuilder builder, EInfrastructureItemDeliveryType Type = EInfrastructureItemDeliveryType.Observatory, int Id = 0)
		{
			builder.StartTable(2);
			IInfrastructureItemDeliveryObservatory.AddId(builder, Id);
			IInfrastructureItemDeliveryObservatory.AddType(builder, Type);
			return IInfrastructureItemDeliveryObservatory.EndIInfrastructureItemDeliveryObservatory(builder);
		}

		// Token: 0x06031B2F RID: 203567 RVA: 0x006BAF89 File Offset: 0x006B9189
		public static void StartIInfrastructureItemDeliveryObservatory(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031B30 RID: 203568 RVA: 0x006BAF92 File Offset: 0x006B9192
		public static void AddType(FlatBufferBuilder builder, EInfrastructureItemDeliveryType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031B31 RID: 203569 RVA: 0x006BAF9D File Offset: 0x006B919D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06031B32 RID: 203570 RVA: 0x006BAFA8 File Offset: 0x006B91A8
		public static Offset<IInfrastructureItemDeliveryObservatory> EndIInfrastructureItemDeliveryObservatory(FlatBufferBuilder builder)
		{
			return new Offset<IInfrastructureItemDeliveryObservatory>(builder.EndTable());
		}

		// Token: 0x06031B33 RID: 203571 RVA: 0x006BAFB8 File Offset: 0x006B91B8
		public IInfrastructureItemDeliveryObservatoryT UnPack()
		{
			IInfrastructureItemDeliveryObservatoryT infrastructureItemDeliveryObservatoryT = new IInfrastructureItemDeliveryObservatoryT();
			this.UnPackTo(infrastructureItemDeliveryObservatoryT);
			return infrastructureItemDeliveryObservatoryT;
		}

		// Token: 0x06031B34 RID: 203572 RVA: 0x006BAFD3 File Offset: 0x006B91D3
		public void UnPackTo(IInfrastructureItemDeliveryObservatoryT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06031B35 RID: 203573 RVA: 0x006BAFF0 File Offset: 0x006B91F0
		public static Offset<IInfrastructureItemDeliveryObservatory> Pack(FlatBufferBuilder builder, IInfrastructureItemDeliveryObservatoryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrastructureItemDeliveryObservatory>);
			}
			return IInfrastructureItemDeliveryObservatory.CreateIInfrastructureItemDeliveryObservatory(builder, _o.Type, _o.Id);
		}

		// Token: 0x04011F43 RID: 73539
		private Table __p;
	}
}
