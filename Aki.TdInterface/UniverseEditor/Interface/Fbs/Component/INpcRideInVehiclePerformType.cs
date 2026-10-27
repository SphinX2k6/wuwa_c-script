using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005647 RID: 22087
	public struct INpcRideInVehiclePerformType : IFlatbufferObject
	{
		// Token: 0x1700A3A0 RID: 41888
		// (get) Token: 0x06024B7B RID: 150395 RVA: 0x0051139D File Offset: 0x0050F59D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024B7C RID: 150396 RVA: 0x005113AA File Offset: 0x0050F5AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024B7D RID: 150397 RVA: 0x005113B4 File Offset: 0x0050F5B4
		public static INpcRideInVehiclePerformType GetRootAsINpcRideInVehiclePerformType(ByteBuffer _bb)
		{
			return INpcRideInVehiclePerformType.GetRootAsINpcRideInVehiclePerformType(_bb, default(INpcRideInVehiclePerformType));
		}

		// Token: 0x06024B7E RID: 150398 RVA: 0x005113D0 File Offset: 0x0050F5D0
		public static INpcRideInVehiclePerformType GetRootAsINpcRideInVehiclePerformType(ByteBuffer _bb, INpcRideInVehiclePerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024B7F RID: 150399 RVA: 0x005113ED File Offset: 0x0050F5ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024B80 RID: 150400 RVA: 0x005113FC File Offset: 0x0050F5FC
		public INpcRideInVehiclePerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3A1 RID: 41889
		// (get) Token: 0x06024B81 RID: 150401 RVA: 0x0051140C File Offset: 0x0050F60C
		public EVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleType.Gongduola;
				}
				return (EVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A3A2 RID: 41890
		// (get) Token: 0x06024B82 RID: 150402 RVA: 0x00511448 File Offset: 0x0050F648
		public string Montage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024B83 RID: 150403 RVA: 0x0051147F File Offset: 0x0050F67F
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024B84 RID: 150404 RVA: 0x0051148E File Offset: 0x0050F68E
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06024B85 RID: 150405 RVA: 0x0051149C File Offset: 0x0050F69C
		public static Offset<INpcRideInVehiclePerformType> CreateINpcRideInVehiclePerformType(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola, StringOffset MontageOffset = default(StringOffset))
		{
			builder.StartTable(2);
			INpcRideInVehiclePerformType.AddMontage(builder, MontageOffset);
			INpcRideInVehiclePerformType.AddType(builder, Type);
			return INpcRideInVehiclePerformType.EndINpcRideInVehiclePerformType(builder);
		}

		// Token: 0x06024B86 RID: 150406 RVA: 0x005114B9 File Offset: 0x0050F6B9
		public static void StartINpcRideInVehiclePerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024B87 RID: 150407 RVA: 0x005114C2 File Offset: 0x0050F6C2
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024B88 RID: 150408 RVA: 0x005114CD File Offset: 0x0050F6CD
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x06024B89 RID: 150409 RVA: 0x005114DD File Offset: 0x0050F6DD
		public static Offset<INpcRideInVehiclePerformType> EndINpcRideInVehiclePerformType(FlatBufferBuilder builder)
		{
			return new Offset<INpcRideInVehiclePerformType>(builder.EndTable());
		}

		// Token: 0x06024B8A RID: 150410 RVA: 0x005114EC File Offset: 0x0050F6EC
		public INpcRideInVehiclePerformTypeT UnPack()
		{
			INpcRideInVehiclePerformTypeT npcRideInVehiclePerformTypeT = new INpcRideInVehiclePerformTypeT();
			this.UnPackTo(npcRideInVehiclePerformTypeT);
			return npcRideInVehiclePerformTypeT;
		}

		// Token: 0x06024B8B RID: 150411 RVA: 0x00511507 File Offset: 0x0050F707
		public void UnPackTo(INpcRideInVehiclePerformTypeT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
		}

		// Token: 0x06024B8C RID: 150412 RVA: 0x00511524 File Offset: 0x0050F724
		public static Offset<INpcRideInVehiclePerformType> Pack(FlatBufferBuilder builder, INpcRideInVehiclePerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcRideInVehiclePerformType>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return INpcRideInVehiclePerformType.CreateINpcRideInVehiclePerformType(builder, _o.Type, montageOffset);
		}

		// Token: 0x0400E9EE RID: 59886
		private Table __p;
	}
}
