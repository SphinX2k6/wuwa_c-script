using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE5 RID: 23525
	public struct INpcRideInVehiclePerformType : IFlatbufferObject
	{
		// Token: 0x1700AC2A RID: 44074
		// (get) Token: 0x06026D9A RID: 159130 RVA: 0x00551CC1 File Offset: 0x0054FEC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026D9B RID: 159131 RVA: 0x00551CCE File Offset: 0x0054FECE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026D9C RID: 159132 RVA: 0x00551CD8 File Offset: 0x0054FED8
		public static INpcRideInVehiclePerformType GetRootAsINpcRideInVehiclePerformType(ByteBuffer _bb)
		{
			return INpcRideInVehiclePerformType.GetRootAsINpcRideInVehiclePerformType(_bb, default(INpcRideInVehiclePerformType));
		}

		// Token: 0x06026D9D RID: 159133 RVA: 0x00551CF4 File Offset: 0x0054FEF4
		public static INpcRideInVehiclePerformType GetRootAsINpcRideInVehiclePerformType(ByteBuffer _bb, INpcRideInVehiclePerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026D9E RID: 159134 RVA: 0x00551D11 File Offset: 0x0054FF11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026D9F RID: 159135 RVA: 0x00551D20 File Offset: 0x0054FF20
		public INpcRideInVehiclePerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC2B RID: 44075
		// (get) Token: 0x06026DA0 RID: 159136 RVA: 0x00551D30 File Offset: 0x0054FF30
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

		// Token: 0x1700AC2C RID: 44076
		// (get) Token: 0x06026DA1 RID: 159137 RVA: 0x00551D6C File Offset: 0x0054FF6C
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

		// Token: 0x06026DA2 RID: 159138 RVA: 0x00551DA3 File Offset: 0x0054FFA3
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026DA3 RID: 159139 RVA: 0x00551DB2 File Offset: 0x0054FFB2
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026DA4 RID: 159140 RVA: 0x00551DC0 File Offset: 0x0054FFC0
		public static Offset<INpcRideInVehiclePerformType> CreateINpcRideInVehiclePerformType(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola, StringOffset MontageOffset = default(StringOffset))
		{
			builder.StartTable(2);
			INpcRideInVehiclePerformType.AddMontage(builder, MontageOffset);
			INpcRideInVehiclePerformType.AddType(builder, Type);
			return INpcRideInVehiclePerformType.EndINpcRideInVehiclePerformType(builder);
		}

		// Token: 0x06026DA5 RID: 159141 RVA: 0x00551DDD File Offset: 0x0054FFDD
		public static void StartINpcRideInVehiclePerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026DA6 RID: 159142 RVA: 0x00551DE6 File Offset: 0x0054FFE6
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026DA7 RID: 159143 RVA: 0x00551DF1 File Offset: 0x0054FFF1
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x06026DA8 RID: 159144 RVA: 0x00551E01 File Offset: 0x00550001
		public static Offset<INpcRideInVehiclePerformType> EndINpcRideInVehiclePerformType(FlatBufferBuilder builder)
		{
			return new Offset<INpcRideInVehiclePerformType>(builder.EndTable());
		}

		// Token: 0x06026DA9 RID: 159145 RVA: 0x00551E10 File Offset: 0x00550010
		public INpcRideInVehiclePerformTypeT UnPack()
		{
			INpcRideInVehiclePerformTypeT npcRideInVehiclePerformTypeT = new INpcRideInVehiclePerformTypeT();
			this.UnPackTo(npcRideInVehiclePerformTypeT);
			return npcRideInVehiclePerformTypeT;
		}

		// Token: 0x06026DAA RID: 159146 RVA: 0x00551E2B File Offset: 0x0055002B
		public void UnPackTo(INpcRideInVehiclePerformTypeT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
		}

		// Token: 0x06026DAB RID: 159147 RVA: 0x00551E48 File Offset: 0x00550048
		public static Offset<INpcRideInVehiclePerformType> Pack(FlatBufferBuilder builder, INpcRideInVehiclePerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcRideInVehiclePerformType>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return INpcRideInVehiclePerformType.CreateINpcRideInVehiclePerformType(builder, _o.Type, montageOffset);
		}

		// Token: 0x0400F653 RID: 63059
		private Table __p;
	}
}
