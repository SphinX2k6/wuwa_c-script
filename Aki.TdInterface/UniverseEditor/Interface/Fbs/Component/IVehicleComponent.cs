using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B0B RID: 23307
	public struct IVehicleComponent : IFlatbufferObject
	{
		// Token: 0x1700AFD8 RID: 45016
		// (get) Token: 0x06027CC8 RID: 163016 RVA: 0x005793A6 File Offset: 0x005775A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027CC9 RID: 163017 RVA: 0x005793B3 File Offset: 0x005775B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027CCA RID: 163018 RVA: 0x005793BC File Offset: 0x005775BC
		public static IVehicleComponent GetRootAsIVehicleComponent(ByteBuffer _bb)
		{
			return IVehicleComponent.GetRootAsIVehicleComponent(_bb, default(IVehicleComponent));
		}

		// Token: 0x06027CCB RID: 163019 RVA: 0x005793D8 File Offset: 0x005775D8
		public static IVehicleComponent GetRootAsIVehicleComponent(ByteBuffer _bb, IVehicleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027CCC RID: 163020 RVA: 0x005793F5 File Offset: 0x005775F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027CCD RID: 163021 RVA: 0x00579404 File Offset: 0x00577604
		public IVehicleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFD9 RID: 45017
		// (get) Token: 0x06027CCE RID: 163022 RVA: 0x00579414 File Offset: 0x00577614
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AFDA RID: 45018
		// (get) Token: 0x06027CCF RID: 163023 RVA: 0x00579454 File Offset: 0x00577654
		public string Config
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

		// Token: 0x06027CD0 RID: 163024 RVA: 0x0057948B File Offset: 0x0057768B
		public Span<byte> GetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027CD1 RID: 163025 RVA: 0x0057949A File Offset: 0x0057769A
		public byte[] GetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AFDB RID: 45019
		// (get) Token: 0x06027CD2 RID: 163026 RVA: 0x005794A8 File Offset: 0x005776A8
		public IVehicleTypedMotorConfig? VehicleTypedConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVehicleTypedMotorConfig?(default(IVehicleTypedMotorConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027CD3 RID: 163027 RVA: 0x00579508 File Offset: 0x00577708
		public int VehicleBornTag(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AFDC RID: 45020
		// (get) Token: 0x06027CD4 RID: 163028 RVA: 0x00579548 File Offset: 0x00577748
		public int VehicleBornTagLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06027CD5 RID: 163029 RVA: 0x00579574 File Offset: 0x00577774
		public Span<int> GetVehicleBornTagBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06027CD6 RID: 163030 RVA: 0x00579584 File Offset: 0x00577784
		public int[] GetVehicleBornTagArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06027CD7 RID: 163031 RVA: 0x00579594 File Offset: 0x00577794
		public int VehicleRiddenTag(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AFDD RID: 45021
		// (get) Token: 0x06027CD8 RID: 163032 RVA: 0x005795D4 File Offset: 0x005777D4
		public int VehicleRiddenTagLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06027CD9 RID: 163033 RVA: 0x00579600 File Offset: 0x00577800
		public Span<int> GetVehicleRiddenTagBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06027CDA RID: 163034 RVA: 0x00579610 File Offset: 0x00577810
		public int[] GetVehicleRiddenTagArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x06027CDB RID: 163035 RVA: 0x00579620 File Offset: 0x00577820
		public int RoleRiddingTag(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AFDE RID: 45022
		// (get) Token: 0x06027CDC RID: 163036 RVA: 0x00579660 File Offset: 0x00577860
		public int RoleRiddingTagLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06027CDD RID: 163037 RVA: 0x0057968C File Offset: 0x0057788C
		public Span<int> GetRoleRiddingTagBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06027CDE RID: 163038 RVA: 0x0057969C File Offset: 0x0057789C
		public int[] GetRoleRiddingTagArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x1700AFDF RID: 45023
		// (get) Token: 0x06027CDF RID: 163039 RVA: 0x005796AC File Offset: 0x005778AC
		public IPassengerTeleportConfig? TeleportPlayersWhenDestroyed
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IPassengerTeleportConfig?(default(IPassengerTeleportConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027CE0 RID: 163040 RVA: 0x0057970C File Offset: 0x0057790C
		public TVehicleFeature VehicleFeaturesType(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return TVehicleFeature.NONE;
			}
			return (TVehicleFeature)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AFE0 RID: 45024
		// (get) Token: 0x06027CE1 RID: 163041 RVA: 0x0057974C File Offset: 0x0057794C
		public int VehicleFeaturesTypeLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06027CE2 RID: 163042 RVA: 0x00579778 File Offset: 0x00577978
		public Span<TVehicleFeature> GetVehicleFeaturesTypeBytes()
		{
			return this.__p.__vector_as_span<TVehicleFeature>(18, 1);
		}

		// Token: 0x06027CE3 RID: 163043 RVA: 0x00579788 File Offset: 0x00577988
		public TVehicleFeature[] GetVehicleFeaturesTypeArray()
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TVehicleFeature[] array = new TVehicleFeature[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TVehicleFeature)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06027CE4 RID: 163044 RVA: 0x005797F4 File Offset: 0x005779F4
		public TTable? VehicleFeatures<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700AFE1 RID: 45025
		// (get) Token: 0x06027CE5 RID: 163045 RVA: 0x0057983C File Offset: 0x00577A3C
		public int VehicleFeaturesLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AFE2 RID: 45026
		// (get) Token: 0x06027CE6 RID: 163046 RVA: 0x00579868 File Offset: 0x00577A68
		public EVehicleSeatCount SeatCount
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return EVehicleSeatCount.None;
				}
				return (EVehicleSeatCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AFE3 RID: 45027
		// (get) Token: 0x06027CE7 RID: 163047 RVA: 0x005798A8 File Offset: 0x00577AA8
		public EVehicleSeat DriverSeat
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return EVehicleSeat.Seat0;
				}
				return (EVehicleSeat)this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027CE8 RID: 163048 RVA: 0x005798E8 File Offset: 0x00577AE8
		public IVehiclePassengerConfig? DefaultPassengers(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IVehiclePassengerConfig?(default(IVehiclePassengerConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AFE4 RID: 45028
		// (get) Token: 0x06027CE9 RID: 163049 RVA: 0x0057994C File Offset: 0x00577B4C
		public int DefaultPassengersLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AFE5 RID: 45029
		// (get) Token: 0x06027CEA RID: 163050 RVA: 0x00579978 File Offset: 0x00577B78
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027CEB RID: 163051 RVA: 0x005799B8 File Offset: 0x00577BB8
		public static Offset<IVehicleComponent> CreateIVehicleComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset ConfigOffset = default(StringOffset), Offset<IVehicleTypedMotorConfig> VehicleTypedConfigOffset = default(Offset<IVehicleTypedMotorConfig>), VectorOffset VehicleBornTagOffset = default(VectorOffset), VectorOffset VehicleRiddenTagOffset = default(VectorOffset), VectorOffset RoleRiddingTagOffset = default(VectorOffset), Offset<IPassengerTeleportConfig> TeleportPlayersWhenDestroyedOffset = default(Offset<IPassengerTeleportConfig>), VectorOffset VehicleFeatures_typeOffset = default(VectorOffset), VectorOffset VehicleFeaturesOffset = default(VectorOffset), EVehicleSeatCount SeatCount = EVehicleSeatCount.None, EVehicleSeat DriverSeat = EVehicleSeat.Seat0, VectorOffset DefaultPassengersOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(13);
			IVehicleComponent.AddDefaultPassengers(builder, DefaultPassengersOffset);
			IVehicleComponent.AddVehicleFeatures(builder, VehicleFeaturesOffset);
			IVehicleComponent.AddVehicleFeaturesType(builder, VehicleFeatures_typeOffset);
			IVehicleComponent.AddTeleportPlayersWhenDestroyed(builder, TeleportPlayersWhenDestroyedOffset);
			IVehicleComponent.AddRoleRiddingTag(builder, RoleRiddingTagOffset);
			IVehicleComponent.AddVehicleRiddenTag(builder, VehicleRiddenTagOffset);
			IVehicleComponent.AddVehicleBornTag(builder, VehicleBornTagOffset);
			IVehicleComponent.AddVehicleTypedConfig(builder, VehicleTypedConfigOffset);
			IVehicleComponent.AddConfig(builder, ConfigOffset);
			IVehicleComponent.AddDriverSeat(builder, DriverSeat);
			IVehicleComponent.AddNullMask(builder, NullMask);
			IVehicleComponent.AddSeatCount(builder, SeatCount);
			IVehicleComponent.AddDisabled(builder, Disabled);
			return IVehicleComponent.EndIVehicleComponent(builder);
		}

		// Token: 0x06027CEC RID: 163052 RVA: 0x00579A38 File Offset: 0x00577C38
		public static void StartIVehicleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06027CED RID: 163053 RVA: 0x00579A42 File Offset: 0x00577C42
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027CEE RID: 163054 RVA: 0x00579A4D File Offset: 0x00577C4D
		public static void AddConfig(FlatBufferBuilder builder, StringOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06027CEF RID: 163055 RVA: 0x00579A5D File Offset: 0x00577C5D
		public static void AddVehicleTypedConfig(FlatBufferBuilder builder, Offset<IVehicleTypedMotorConfig> vehicleTypedConfigOffset)
		{
			builder.AddOffset(2, vehicleTypedConfigOffset.Value, 0);
		}

		// Token: 0x06027CF0 RID: 163056 RVA: 0x00579A6D File Offset: 0x00577C6D
		public static void AddVehicleBornTag(FlatBufferBuilder builder, VectorOffset vehicleBornTagOffset)
		{
			builder.AddOffset(3, vehicleBornTagOffset.Value, 0);
		}

		// Token: 0x06027CF1 RID: 163057 RVA: 0x00579A80 File Offset: 0x00577C80
		public static VectorOffset CreateVehicleBornTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027CF2 RID: 163058 RVA: 0x00579AB7 File Offset: 0x00577CB7
		public static VectorOffset CreateVehicleBornTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027CF3 RID: 163059 RVA: 0x00579AD1 File Offset: 0x00577CD1
		public static VectorOffset CreateVehicleBornTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027CF4 RID: 163060 RVA: 0x00579AEF File Offset: 0x00577CEF
		public static VectorOffset CreateVehicleBornTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027CF5 RID: 163061 RVA: 0x00579B08 File Offset: 0x00577D08
		public static void StartVehicleBornTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027CF6 RID: 163062 RVA: 0x00579B13 File Offset: 0x00577D13
		public static void AddVehicleRiddenTag(FlatBufferBuilder builder, VectorOffset vehicleRiddenTagOffset)
		{
			builder.AddOffset(4, vehicleRiddenTagOffset.Value, 0);
		}

		// Token: 0x06027CF7 RID: 163063 RVA: 0x00579B24 File Offset: 0x00577D24
		public static VectorOffset CreateVehicleRiddenTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027CF8 RID: 163064 RVA: 0x00579B5B File Offset: 0x00577D5B
		public static VectorOffset CreateVehicleRiddenTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027CF9 RID: 163065 RVA: 0x00579B75 File Offset: 0x00577D75
		public static VectorOffset CreateVehicleRiddenTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027CFA RID: 163066 RVA: 0x00579B93 File Offset: 0x00577D93
		public static VectorOffset CreateVehicleRiddenTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027CFB RID: 163067 RVA: 0x00579BAC File Offset: 0x00577DAC
		public static void StartVehicleRiddenTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027CFC RID: 163068 RVA: 0x00579BB7 File Offset: 0x00577DB7
		public static void AddRoleRiddingTag(FlatBufferBuilder builder, VectorOffset roleRiddingTagOffset)
		{
			builder.AddOffset(5, roleRiddingTagOffset.Value, 0);
		}

		// Token: 0x06027CFD RID: 163069 RVA: 0x00579BC8 File Offset: 0x00577DC8
		public static VectorOffset CreateRoleRiddingTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027CFE RID: 163070 RVA: 0x00579BFF File Offset: 0x00577DFF
		public static VectorOffset CreateRoleRiddingTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027CFF RID: 163071 RVA: 0x00579C19 File Offset: 0x00577E19
		public static VectorOffset CreateRoleRiddingTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027D00 RID: 163072 RVA: 0x00579C37 File Offset: 0x00577E37
		public static VectorOffset CreateRoleRiddingTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027D01 RID: 163073 RVA: 0x00579C50 File Offset: 0x00577E50
		public static void StartRoleRiddingTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027D02 RID: 163074 RVA: 0x00579C5B File Offset: 0x00577E5B
		public static void AddTeleportPlayersWhenDestroyed(FlatBufferBuilder builder, Offset<IPassengerTeleportConfig> teleportPlayersWhenDestroyedOffset)
		{
			builder.AddOffset(6, teleportPlayersWhenDestroyedOffset.Value, 0);
		}

		// Token: 0x06027D03 RID: 163075 RVA: 0x00579C6B File Offset: 0x00577E6B
		public static void AddVehicleFeaturesType(FlatBufferBuilder builder, VectorOffset vehicleFeaturesTypeOffset)
		{
			builder.AddOffset(7, vehicleFeaturesTypeOffset.Value, 0);
		}

		// Token: 0x06027D04 RID: 163076 RVA: 0x00579C7C File Offset: 0x00577E7C
		public static VectorOffset CreateVehicleFeaturesTypeVector(FlatBufferBuilder builder, TVehicleFeature[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027D05 RID: 163077 RVA: 0x00579CB3 File Offset: 0x00577EB3
		public static VectorOffset CreateVehicleFeaturesTypeVectorBlock(FlatBufferBuilder builder, TVehicleFeature[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVehicleFeature>(data);
			return builder.EndVector();
		}

		// Token: 0x06027D06 RID: 163078 RVA: 0x00579CCD File Offset: 0x00577ECD
		public static VectorOffset CreateVehicleFeaturesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVehicleFeature> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVehicleFeature>(data);
			return builder.EndVector();
		}

		// Token: 0x06027D07 RID: 163079 RVA: 0x00579CEB File Offset: 0x00577EEB
		public static VectorOffset CreateVehicleFeaturesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVehicleFeature>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027D08 RID: 163080 RVA: 0x00579D04 File Offset: 0x00577F04
		public static void StartVehicleFeaturesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06027D09 RID: 163081 RVA: 0x00579D0F File Offset: 0x00577F0F
		public static void AddVehicleFeatures(FlatBufferBuilder builder, VectorOffset vehicleFeaturesOffset)
		{
			builder.AddOffset(8, vehicleFeaturesOffset.Value, 0);
		}

		// Token: 0x06027D0A RID: 163082 RVA: 0x00579D20 File Offset: 0x00577F20
		public static VectorOffset CreateVehicleFeaturesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027D0B RID: 163083 RVA: 0x00579D57 File Offset: 0x00577F57
		public static VectorOffset CreateVehicleFeaturesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027D0C RID: 163084 RVA: 0x00579D71 File Offset: 0x00577F71
		public static VectorOffset CreateVehicleFeaturesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027D0D RID: 163085 RVA: 0x00579D8F File Offset: 0x00577F8F
		public static VectorOffset CreateVehicleFeaturesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027D0E RID: 163086 RVA: 0x00579DA8 File Offset: 0x00577FA8
		public static void StartVehicleFeaturesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027D0F RID: 163087 RVA: 0x00579DB3 File Offset: 0x00577FB3
		public static void AddSeatCount(FlatBufferBuilder builder, EVehicleSeatCount seatCount)
		{
			builder.AddByte(9, (byte)seatCount, 0);
		}

		// Token: 0x06027D10 RID: 163088 RVA: 0x00579DBF File Offset: 0x00577FBF
		public static void AddDriverSeat(FlatBufferBuilder builder, EVehicleSeat driverSeat)
		{
			builder.AddUshort(10, (ushort)driverSeat, 0);
		}

		// Token: 0x06027D11 RID: 163089 RVA: 0x00579DCB File Offset: 0x00577FCB
		public static void AddDefaultPassengers(FlatBufferBuilder builder, VectorOffset defaultPassengersOffset)
		{
			builder.AddOffset(11, defaultPassengersOffset.Value, 0);
		}

		// Token: 0x06027D12 RID: 163090 RVA: 0x00579DDC File Offset: 0x00577FDC
		public static VectorOffset CreateDefaultPassengersVector(FlatBufferBuilder builder, Offset<IVehiclePassengerConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027D13 RID: 163091 RVA: 0x00579E1C File Offset: 0x0057801C
		public static VectorOffset CreateDefaultPassengersVectorBlock(FlatBufferBuilder builder, Offset<IVehiclePassengerConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVehiclePassengerConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027D14 RID: 163092 RVA: 0x00579E36 File Offset: 0x00578036
		public static VectorOffset CreateDefaultPassengersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVehiclePassengerConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVehiclePassengerConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027D15 RID: 163093 RVA: 0x00579E54 File Offset: 0x00578054
		public static VectorOffset CreateDefaultPassengersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVehiclePassengerConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027D16 RID: 163094 RVA: 0x00579E6D File Offset: 0x0057806D
		public static void StartDefaultPassengersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027D17 RID: 163095 RVA: 0x00579E78 File Offset: 0x00578078
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06027D18 RID: 163096 RVA: 0x00579E84 File Offset: 0x00578084
		public static Offset<IVehicleComponent> EndIVehicleComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleComponent>(builder.EndTable());
		}

		// Token: 0x06027D19 RID: 163097 RVA: 0x00579E94 File Offset: 0x00578094
		public IVehicleComponentT UnPack()
		{
			IVehicleComponentT vehicleComponentT = new IVehicleComponentT();
			this.UnPackTo(vehicleComponentT);
			return vehicleComponentT;
		}

		// Token: 0x06027D1A RID: 163098 RVA: 0x00579EB0 File Offset: 0x005780B0
		public void UnPackTo(IVehicleComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = this.Config;
			_o.VehicleTypedConfig = ((this.VehicleTypedConfig != null) ? this.VehicleTypedConfig.Value.UnPack() : null);
			_o.VehicleBornTag = new List<int>();
			for (int i = 0; i < this.VehicleBornTagLength; i++)
			{
				_o.VehicleBornTag.Add(this.VehicleBornTag(i));
			}
			_o.VehicleRiddenTag = new List<int>();
			for (int j = 0; j < this.VehicleRiddenTagLength; j++)
			{
				_o.VehicleRiddenTag.Add(this.VehicleRiddenTag(j));
			}
			_o.RoleRiddingTag = new List<int>();
			for (int k = 0; k < this.RoleRiddingTagLength; k++)
			{
				_o.RoleRiddingTag.Add(this.RoleRiddingTag(k));
			}
			_o.TeleportPlayersWhenDestroyed = ((this.TeleportPlayersWhenDestroyed != null) ? this.TeleportPlayersWhenDestroyed.Value.UnPack() : null);
			_o.VehicleFeatures = new List<TVehicleFeatureUnion>();
			for (int l = 0; l < this.VehicleFeaturesLength; l++)
			{
				TVehicleFeatureUnion tvehicleFeatureUnion = new TVehicleFeatureUnion();
				tvehicleFeatureUnion.Type = this.VehicleFeaturesType(l);
				switch (this.VehicleFeaturesType(l))
				{
				case TVehicleFeature.IAudioVehicleFeature:
					tvehicleFeatureUnion.Value = ((this.VehicleFeatures<IAudioVehicleFeature>(l) != null) ? this.VehicleFeatures<IAudioVehicleFeature>(l).Value.UnPack() : null);
					break;
				case TVehicleFeature.IBattleVehicleFeature:
					tvehicleFeatureUnion.Value = ((this.VehicleFeatures<IBattleVehicleFeature>(l) != null) ? this.VehicleFeatures<IBattleVehicleFeature>(l).Value.UnPack() : null);
					break;
				case TVehicleFeature.IMovablePlatformVehicleFeature:
					tvehicleFeatureUnion.Value = ((this.VehicleFeatures<IMovablePlatformVehicleFeature>(l) != null) ? this.VehicleFeatures<IMovablePlatformVehicleFeature>(l).Value.UnPack() : null);
					break;
				case TVehicleFeature.IMovementVehicleFeature:
					tvehicleFeatureUnion.Value = ((this.VehicleFeatures<IMovementVehicleFeature>(l) != null) ? this.VehicleFeatures<IMovementVehicleFeature>(l).Value.UnPack() : null);
					break;
				case TVehicleFeature.IPerformanceVehicleFeature:
					tvehicleFeatureUnion.Value = ((this.VehicleFeatures<IPerformanceVehicleFeature>(l) != null) ? this.VehicleFeatures<IPerformanceVehicleFeature>(l).Value.UnPack() : null);
					break;
				case TVehicleFeature.ISharingVehicleFeature:
					tvehicleFeatureUnion.Value = ((this.VehicleFeatures<ISharingVehicleFeature>(l) != null) ? this.VehicleFeatures<ISharingVehicleFeature>(l).Value.UnPack() : null);
					break;
				}
				_o.VehicleFeatures.Add(tvehicleFeatureUnion);
			}
			_o.SeatCount = this.SeatCount;
			_o.DriverSeat = this.DriverSeat;
			_o.DefaultPassengers = new List<IVehiclePassengerConfigT>();
			for (int m = 0; m < this.DefaultPassengersLength; m++)
			{
				_o.DefaultPassengers.Add((this.DefaultPassengers(m) != null) ? this.DefaultPassengers(m).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027D1B RID: 163099 RVA: 0x0057A21C File Offset: 0x0057841C
		public static Offset<IVehicleComponent> Pack(FlatBufferBuilder builder, IVehicleComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleComponent>);
			}
			StringOffset configOffset = (_o.Config == null) ? default(StringOffset) : builder.CreateString(_o.Config);
			Offset<IVehicleTypedMotorConfig> vehicleTypedConfigOffset = (_o.VehicleTypedConfig == null) ? default(Offset<IVehicleTypedMotorConfig>) : IVehicleTypedMotorConfig.Pack(builder, _o.VehicleTypedConfig);
			VectorOffset vehicleBornTagOffset = default(VectorOffset);
			if (_o.VehicleBornTag != null)
			{
				int[] data = _o.VehicleBornTag.ToArray();
				vehicleBornTagOffset = IVehicleComponent.CreateVehicleBornTagVector(builder, data);
			}
			VectorOffset vehicleRiddenTagOffset = default(VectorOffset);
			if (_o.VehicleRiddenTag != null)
			{
				int[] data2 = _o.VehicleRiddenTag.ToArray();
				vehicleRiddenTagOffset = IVehicleComponent.CreateVehicleRiddenTagVector(builder, data2);
			}
			VectorOffset roleRiddingTagOffset = default(VectorOffset);
			if (_o.RoleRiddingTag != null)
			{
				int[] data3 = _o.RoleRiddingTag.ToArray();
				roleRiddingTagOffset = IVehicleComponent.CreateRoleRiddingTagVector(builder, data3);
			}
			Offset<IPassengerTeleportConfig> teleportPlayersWhenDestroyedOffset = (_o.TeleportPlayersWhenDestroyed == null) ? default(Offset<IPassengerTeleportConfig>) : IPassengerTeleportConfig.Pack(builder, _o.TeleportPlayersWhenDestroyed);
			VectorOffset vehicleFeatures_typeOffset = default(VectorOffset);
			if (_o.VehicleFeatures != null)
			{
				TVehicleFeature[] array = new TVehicleFeature[_o.VehicleFeatures.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.VehicleFeatures[i].Type;
				}
				vehicleFeatures_typeOffset = IVehicleComponent.CreateVehicleFeaturesTypeVector(builder, array);
			}
			VectorOffset vehicleFeaturesOffset = default(VectorOffset);
			if (_o.VehicleFeatures != null)
			{
				int[] array2 = new int[_o.VehicleFeatures.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TVehicleFeatureUnion.Pack(builder, _o.VehicleFeatures[j]);
				}
				vehicleFeaturesOffset = IVehicleComponent.CreateVehicleFeaturesVector(builder, array2);
			}
			VectorOffset defaultPassengersOffset = default(VectorOffset);
			if (_o.DefaultPassengers != null)
			{
				Offset<IVehiclePassengerConfig>[] array3 = new Offset<IVehiclePassengerConfig>[_o.DefaultPassengers.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IVehiclePassengerConfig.Pack(builder, _o.DefaultPassengers[k]);
				}
				defaultPassengersOffset = IVehicleComponent.CreateDefaultPassengersVector(builder, array3);
			}
			return IVehicleComponent.CreateIVehicleComponent(builder, _o.Disabled, configOffset, vehicleTypedConfigOffset, vehicleBornTagOffset, vehicleRiddenTagOffset, roleRiddingTagOffset, teleportPlayersWhenDestroyedOffset, vehicleFeatures_typeOffset, vehicleFeaturesOffset, _o.SeatCount, _o.DriverSeat, defaultPassengersOffset, _o.NullMask);
		}

		// Token: 0x0400F210 RID: 61968
		private Table __p;
	}
}
