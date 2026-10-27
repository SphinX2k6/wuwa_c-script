using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006957 RID: 26967
	public struct IInfrastructureItemDeliveryObservatory : IFlatbufferObject
	{
		// Token: 0x1700C806 RID: 51206
		// (get) Token: 0x0602F156 RID: 192854 RVA: 0x0066A99D File Offset: 0x00668B9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F157 RID: 192855 RVA: 0x0066A9AA File Offset: 0x00668BAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F158 RID: 192856 RVA: 0x0066A9B4 File Offset: 0x00668BB4
		public static IInfrastructureItemDeliveryObservatory GetRootAsIInfrastructureItemDeliveryObservatory(ByteBuffer _bb)
		{
			return IInfrastructureItemDeliveryObservatory.GetRootAsIInfrastructureItemDeliveryObservatory(_bb, default(IInfrastructureItemDeliveryObservatory));
		}

		// Token: 0x0602F159 RID: 192857 RVA: 0x0066A9D0 File Offset: 0x00668BD0
		public static IInfrastructureItemDeliveryObservatory GetRootAsIInfrastructureItemDeliveryObservatory(ByteBuffer _bb, IInfrastructureItemDeliveryObservatory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F15A RID: 192858 RVA: 0x0066A9ED File Offset: 0x00668BED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F15B RID: 192859 RVA: 0x0066A9FC File Offset: 0x00668BFC
		public IInfrastructureItemDeliveryObservatory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C807 RID: 51207
		// (get) Token: 0x0602F15C RID: 192860 RVA: 0x0066AA0C File Offset: 0x00668C0C
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

		// Token: 0x1700C808 RID: 51208
		// (get) Token: 0x0602F15D RID: 192861 RVA: 0x0066AA48 File Offset: 0x00668C48
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

		// Token: 0x0602F15E RID: 192862 RVA: 0x0066AA84 File Offset: 0x00668C84
		public static Offset<IInfrastructureItemDeliveryObservatory> CreateIInfrastructureItemDeliveryObservatory(FlatBufferBuilder builder, EInfrastructureItemDeliveryType Type = EInfrastructureItemDeliveryType.Observatory, int Id = 0)
		{
			builder.StartTable(2);
			IInfrastructureItemDeliveryObservatory.AddId(builder, Id);
			IInfrastructureItemDeliveryObservatory.AddType(builder, Type);
			return IInfrastructureItemDeliveryObservatory.EndIInfrastructureItemDeliveryObservatory(builder);
		}

		// Token: 0x0602F15F RID: 192863 RVA: 0x0066AAA1 File Offset: 0x00668CA1
		public static void StartIInfrastructureItemDeliveryObservatory(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F160 RID: 192864 RVA: 0x0066AAAA File Offset: 0x00668CAA
		public static void AddType(FlatBufferBuilder builder, EInfrastructureItemDeliveryType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F161 RID: 192865 RVA: 0x0066AAB5 File Offset: 0x00668CB5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602F162 RID: 192866 RVA: 0x0066AAC0 File Offset: 0x00668CC0
		public static Offset<IInfrastructureItemDeliveryObservatory> EndIInfrastructureItemDeliveryObservatory(FlatBufferBuilder builder)
		{
			return new Offset<IInfrastructureItemDeliveryObservatory>(builder.EndTable());
		}

		// Token: 0x0602F163 RID: 192867 RVA: 0x0066AAD0 File Offset: 0x00668CD0
		public IInfrastructureItemDeliveryObservatoryT UnPack()
		{
			IInfrastructureItemDeliveryObservatoryT infrastructureItemDeliveryObservatoryT = new IInfrastructureItemDeliveryObservatoryT();
			this.UnPackTo(infrastructureItemDeliveryObservatoryT);
			return infrastructureItemDeliveryObservatoryT;
		}

		// Token: 0x0602F164 RID: 192868 RVA: 0x0066AAEB File Offset: 0x00668CEB
		public void UnPackTo(IInfrastructureItemDeliveryObservatoryT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602F165 RID: 192869 RVA: 0x0066AB08 File Offset: 0x00668D08
		public static Offset<IInfrastructureItemDeliveryObservatory> Pack(FlatBufferBuilder builder, IInfrastructureItemDeliveryObservatoryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrastructureItemDeliveryObservatory>);
			}
			return IInfrastructureItemDeliveryObservatory.CreateIInfrastructureItemDeliveryObservatory(builder, _o.Type, _o.Id);
		}

		// Token: 0x040110D7 RID: 69847
		private Table __p;
	}
}
