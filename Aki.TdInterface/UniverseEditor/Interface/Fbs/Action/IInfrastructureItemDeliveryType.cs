using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200695D RID: 26973
	public struct IInfrastructureItemDeliveryType : IFlatbufferObject
	{
		// Token: 0x1700C810 RID: 51216
		// (get) Token: 0x0602F182 RID: 192898 RVA: 0x0066AD9E File Offset: 0x00668F9E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F183 RID: 192899 RVA: 0x0066ADAB File Offset: 0x00668FAB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F184 RID: 192900 RVA: 0x0066ADB4 File Offset: 0x00668FB4
		public static IInfrastructureItemDeliveryType GetRootAsIInfrastructureItemDeliveryType(ByteBuffer _bb)
		{
			return IInfrastructureItemDeliveryType.GetRootAsIInfrastructureItemDeliveryType(_bb, default(IInfrastructureItemDeliveryType));
		}

		// Token: 0x0602F185 RID: 192901 RVA: 0x0066ADD0 File Offset: 0x00668FD0
		public static IInfrastructureItemDeliveryType GetRootAsIInfrastructureItemDeliveryType(ByteBuffer _bb, IInfrastructureItemDeliveryType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F186 RID: 192902 RVA: 0x0066ADED File Offset: 0x00668FED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F187 RID: 192903 RVA: 0x0066ADFC File Offset: 0x00668FFC
		public IInfrastructureItemDeliveryType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C811 RID: 51217
		// (get) Token: 0x0602F188 RID: 192904 RVA: 0x0066AE0C File Offset: 0x0066900C
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

		// Token: 0x0602F189 RID: 192905 RVA: 0x0066AE48 File Offset: 0x00669048
		public static Offset<IInfrastructureItemDeliveryType> CreateIInfrastructureItemDeliveryType(FlatBufferBuilder builder, EInfrastructureItemDeliveryType Type = EInfrastructureItemDeliveryType.Observatory)
		{
			builder.StartTable(1);
			IInfrastructureItemDeliveryType.AddType(builder, Type);
			return IInfrastructureItemDeliveryType.EndIInfrastructureItemDeliveryType(builder);
		}

		// Token: 0x0602F18A RID: 192906 RVA: 0x0066AE5E File Offset: 0x0066905E
		public static void StartIInfrastructureItemDeliveryType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F18B RID: 192907 RVA: 0x0066AE67 File Offset: 0x00669067
		public static void AddType(FlatBufferBuilder builder, EInfrastructureItemDeliveryType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F18C RID: 192908 RVA: 0x0066AE72 File Offset: 0x00669072
		public static Offset<IInfrastructureItemDeliveryType> EndIInfrastructureItemDeliveryType(FlatBufferBuilder builder)
		{
			return new Offset<IInfrastructureItemDeliveryType>(builder.EndTable());
		}

		// Token: 0x0602F18D RID: 192909 RVA: 0x0066AE80 File Offset: 0x00669080
		public IInfrastructureItemDeliveryTypeT UnPack()
		{
			IInfrastructureItemDeliveryTypeT infrastructureItemDeliveryTypeT = new IInfrastructureItemDeliveryTypeT();
			this.UnPackTo(infrastructureItemDeliveryTypeT);
			return infrastructureItemDeliveryTypeT;
		}

		// Token: 0x0602F18E RID: 192910 RVA: 0x0066AE9B File Offset: 0x0066909B
		public void UnPackTo(IInfrastructureItemDeliveryTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F18F RID: 192911 RVA: 0x0066AEAC File Offset: 0x006690AC
		public static Offset<IInfrastructureItemDeliveryType> Pack(FlatBufferBuilder builder, IInfrastructureItemDeliveryTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrastructureItemDeliveryType>);
			}
			return IInfrastructureItemDeliveryType.CreateIInfrastructureItemDeliveryType(builder, _o.Type);
		}

		// Token: 0x040110DD RID: 69853
		private Table __p;
	}
}
