using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006121 RID: 24865
	public struct IVehicleComponent : IFlatbufferObject
	{
		// Token: 0x1700B920 RID: 47392
		// (get) Token: 0x0602A28C RID: 172684 RVA: 0x005C0DFA File Offset: 0x005BEFFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A28D RID: 172685 RVA: 0x005C0E07 File Offset: 0x005BF007
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A28E RID: 172686 RVA: 0x005C0E10 File Offset: 0x005BF010
		public static IVehicleComponent GetRootAsIVehicleComponent(ByteBuffer _bb)
		{
			return IVehicleComponent.GetRootAsIVehicleComponent(_bb, default(IVehicleComponent));
		}

		// Token: 0x0602A28F RID: 172687 RVA: 0x005C0E2C File Offset: 0x005BF02C
		public static IVehicleComponent GetRootAsIVehicleComponent(ByteBuffer _bb, IVehicleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A290 RID: 172688 RVA: 0x005C0E49 File Offset: 0x005BF049
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A291 RID: 172689 RVA: 0x005C0E58 File Offset: 0x005BF058
		public IVehicleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B921 RID: 47393
		// (get) Token: 0x0602A292 RID: 172690 RVA: 0x005C0E68 File Offset: 0x005BF068
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B922 RID: 47394
		// (get) Token: 0x0602A293 RID: 172691 RVA: 0x005C0EA8 File Offset: 0x005BF0A8
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

		// Token: 0x0602A294 RID: 172692 RVA: 0x005C0EDF File Offset: 0x005BF0DF
		public Span<byte> GetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602A295 RID: 172693 RVA: 0x005C0EEE File Offset: 0x005BF0EE
		public byte[] GetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B923 RID: 47395
		// (get) Token: 0x0602A296 RID: 172694 RVA: 0x005C0EFC File Offset: 0x005BF0FC
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

		// Token: 0x0602A297 RID: 172695 RVA: 0x005C0F5C File Offset: 0x005BF15C
		public int VehicleBornTag(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B924 RID: 47396
		// (get) Token: 0x0602A298 RID: 172696 RVA: 0x005C0F9C File Offset: 0x005BF19C
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

		// Token: 0x0602A299 RID: 172697 RVA: 0x005C0FC8 File Offset: 0x005BF1C8
		public Span<int> GetVehicleBornTagBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602A29A RID: 172698 RVA: 0x005C0FD8 File Offset: 0x005BF1D8
		public int[] GetVehicleBornTagArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0602A29B RID: 172699 RVA: 0x005C0FE8 File Offset: 0x005BF1E8
		public int VehicleRiddenTag(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B925 RID: 47397
		// (get) Token: 0x0602A29C RID: 172700 RVA: 0x005C1028 File Offset: 0x005BF228
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

		// Token: 0x0602A29D RID: 172701 RVA: 0x005C1054 File Offset: 0x005BF254
		public Span<int> GetVehicleRiddenTagBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0602A29E RID: 172702 RVA: 0x005C1064 File Offset: 0x005BF264
		public int[] GetVehicleRiddenTagArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x0602A29F RID: 172703 RVA: 0x005C1074 File Offset: 0x005BF274
		public int RoleRiddingTag(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B926 RID: 47398
		// (get) Token: 0x0602A2A0 RID: 172704 RVA: 0x005C10B4 File Offset: 0x005BF2B4
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

		// Token: 0x0602A2A1 RID: 172705 RVA: 0x005C10E0 File Offset: 0x005BF2E0
		public Span<int> GetRoleRiddingTagBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0602A2A2 RID: 172706 RVA: 0x005C10F0 File Offset: 0x005BF2F0
		public int[] GetRoleRiddingTagArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x1700B927 RID: 47399
		// (get) Token: 0x0602A2A3 RID: 172707 RVA: 0x005C1100 File Offset: 0x005BF300
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

		// Token: 0x0602A2A4 RID: 172708 RVA: 0x005C1160 File Offset: 0x005BF360
		public TVehicleFeature VehicleFeaturesType(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return TVehicleFeature.NONE;
			}
			return (TVehicleFeature)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B928 RID: 47400
		// (get) Token: 0x0602A2A5 RID: 172709 RVA: 0x005C11A0 File Offset: 0x005BF3A0
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

		// Token: 0x0602A2A6 RID: 172710 RVA: 0x005C11CC File Offset: 0x005BF3CC
		public Span<TVehicleFeature> GetVehicleFeaturesTypeBytes()
		{
			return this.__p.__vector_as_span<TVehicleFeature>(18, 1);
		}

		// Token: 0x0602A2A7 RID: 172711 RVA: 0x005C11DC File Offset: 0x005BF3DC
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

		// Token: 0x0602A2A8 RID: 172712 RVA: 0x005C1248 File Offset: 0x005BF448
		public TTable? VehicleFeatures<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B929 RID: 47401
		// (get) Token: 0x0602A2A9 RID: 172713 RVA: 0x005C1290 File Offset: 0x005BF490
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

		// Token: 0x1700B92A RID: 47402
		// (get) Token: 0x0602A2AA RID: 172714 RVA: 0x005C12BC File Offset: 0x005BF4BC
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

		// Token: 0x1700B92B RID: 47403
		// (get) Token: 0x0602A2AB RID: 172715 RVA: 0x005C12FC File Offset: 0x005BF4FC
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

		// Token: 0x0602A2AC RID: 172716 RVA: 0x005C133C File Offset: 0x005BF53C
		public IVehiclePassengerConfig? DefaultPassengers(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IVehiclePassengerConfig?(default(IVehiclePassengerConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B92C RID: 47404
		// (get) Token: 0x0602A2AD RID: 172717 RVA: 0x005C13A0 File Offset: 0x005BF5A0
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

		// Token: 0x1700B92D RID: 47405
		// (get) Token: 0x0602A2AE RID: 172718 RVA: 0x005C13CC File Offset: 0x005BF5CC
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

		// Token: 0x0602A2AF RID: 172719 RVA: 0x005C140C File Offset: 0x005BF60C
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

		// Token: 0x0602A2B0 RID: 172720 RVA: 0x005C148C File Offset: 0x005BF68C
		public static void StartIVehicleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0602A2B1 RID: 172721 RVA: 0x005C1496 File Offset: 0x005BF696
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A2B2 RID: 172722 RVA: 0x005C14A1 File Offset: 0x005BF6A1
		public static void AddConfig(FlatBufferBuilder builder, StringOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x0602A2B3 RID: 172723 RVA: 0x005C14B1 File Offset: 0x005BF6B1
		public static void AddVehicleTypedConfig(FlatBufferBuilder builder, Offset<IVehicleTypedMotorConfig> vehicleTypedConfigOffset)
		{
			builder.AddOffset(2, vehicleTypedConfigOffset.Value, 0);
		}

		// Token: 0x0602A2B4 RID: 172724 RVA: 0x005C14C1 File Offset: 0x005BF6C1
		public static void AddVehicleBornTag(FlatBufferBuilder builder, VectorOffset vehicleBornTagOffset)
		{
			builder.AddOffset(3, vehicleBornTagOffset.Value, 0);
		}

		// Token: 0x0602A2B5 RID: 172725 RVA: 0x005C14D4 File Offset: 0x005BF6D4
		public static VectorOffset CreateVehicleBornTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A2B6 RID: 172726 RVA: 0x005C150B File Offset: 0x005BF70B
		public static VectorOffset CreateVehicleBornTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2B7 RID: 172727 RVA: 0x005C1525 File Offset: 0x005BF725
		public static VectorOffset CreateVehicleBornTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2B8 RID: 172728 RVA: 0x005C1543 File Offset: 0x005BF743
		public static VectorOffset CreateVehicleBornTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A2B9 RID: 172729 RVA: 0x005C155C File Offset: 0x005BF75C
		public static void StartVehicleBornTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A2BA RID: 172730 RVA: 0x005C1567 File Offset: 0x005BF767
		public static void AddVehicleRiddenTag(FlatBufferBuilder builder, VectorOffset vehicleRiddenTagOffset)
		{
			builder.AddOffset(4, vehicleRiddenTagOffset.Value, 0);
		}

		// Token: 0x0602A2BB RID: 172731 RVA: 0x005C1578 File Offset: 0x005BF778
		public static VectorOffset CreateVehicleRiddenTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A2BC RID: 172732 RVA: 0x005C15AF File Offset: 0x005BF7AF
		public static VectorOffset CreateVehicleRiddenTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2BD RID: 172733 RVA: 0x005C15C9 File Offset: 0x005BF7C9
		public static VectorOffset CreateVehicleRiddenTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2BE RID: 172734 RVA: 0x005C15E7 File Offset: 0x005BF7E7
		public static VectorOffset CreateVehicleRiddenTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A2BF RID: 172735 RVA: 0x005C1600 File Offset: 0x005BF800
		public static void StartVehicleRiddenTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A2C0 RID: 172736 RVA: 0x005C160B File Offset: 0x005BF80B
		public static void AddRoleRiddingTag(FlatBufferBuilder builder, VectorOffset roleRiddingTagOffset)
		{
			builder.AddOffset(5, roleRiddingTagOffset.Value, 0);
		}

		// Token: 0x0602A2C1 RID: 172737 RVA: 0x005C161C File Offset: 0x005BF81C
		public static VectorOffset CreateRoleRiddingTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A2C2 RID: 172738 RVA: 0x005C1653 File Offset: 0x005BF853
		public static VectorOffset CreateRoleRiddingTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2C3 RID: 172739 RVA: 0x005C166D File Offset: 0x005BF86D
		public static VectorOffset CreateRoleRiddingTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2C4 RID: 172740 RVA: 0x005C168B File Offset: 0x005BF88B
		public static VectorOffset CreateRoleRiddingTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A2C5 RID: 172741 RVA: 0x005C16A4 File Offset: 0x005BF8A4
		public static void StartRoleRiddingTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A2C6 RID: 172742 RVA: 0x005C16AF File Offset: 0x005BF8AF
		public static void AddTeleportPlayersWhenDestroyed(FlatBufferBuilder builder, Offset<IPassengerTeleportConfig> teleportPlayersWhenDestroyedOffset)
		{
			builder.AddOffset(6, teleportPlayersWhenDestroyedOffset.Value, 0);
		}

		// Token: 0x0602A2C7 RID: 172743 RVA: 0x005C16BF File Offset: 0x005BF8BF
		public static void AddVehicleFeaturesType(FlatBufferBuilder builder, VectorOffset vehicleFeaturesTypeOffset)
		{
			builder.AddOffset(7, vehicleFeaturesTypeOffset.Value, 0);
		}

		// Token: 0x0602A2C8 RID: 172744 RVA: 0x005C16D0 File Offset: 0x005BF8D0
		public static VectorOffset CreateVehicleFeaturesTypeVector(FlatBufferBuilder builder, TVehicleFeature[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A2C9 RID: 172745 RVA: 0x005C1707 File Offset: 0x005BF907
		public static VectorOffset CreateVehicleFeaturesTypeVectorBlock(FlatBufferBuilder builder, TVehicleFeature[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVehicleFeature>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2CA RID: 172746 RVA: 0x005C1721 File Offset: 0x005BF921
		public static VectorOffset CreateVehicleFeaturesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVehicleFeature> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVehicleFeature>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2CB RID: 172747 RVA: 0x005C173F File Offset: 0x005BF93F
		public static VectorOffset CreateVehicleFeaturesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVehicleFeature>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A2CC RID: 172748 RVA: 0x005C1758 File Offset: 0x005BF958
		public static void StartVehicleFeaturesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602A2CD RID: 172749 RVA: 0x005C1763 File Offset: 0x005BF963
		public static void AddVehicleFeatures(FlatBufferBuilder builder, VectorOffset vehicleFeaturesOffset)
		{
			builder.AddOffset(8, vehicleFeaturesOffset.Value, 0);
		}

		// Token: 0x0602A2CE RID: 172750 RVA: 0x005C1774 File Offset: 0x005BF974
		public static VectorOffset CreateVehicleFeaturesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A2CF RID: 172751 RVA: 0x005C17AB File Offset: 0x005BF9AB
		public static VectorOffset CreateVehicleFeaturesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2D0 RID: 172752 RVA: 0x005C17C5 File Offset: 0x005BF9C5
		public static VectorOffset CreateVehicleFeaturesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2D1 RID: 172753 RVA: 0x005C17E3 File Offset: 0x005BF9E3
		public static VectorOffset CreateVehicleFeaturesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A2D2 RID: 172754 RVA: 0x005C17FC File Offset: 0x005BF9FC
		public static void StartVehicleFeaturesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A2D3 RID: 172755 RVA: 0x005C1807 File Offset: 0x005BFA07
		public static void AddSeatCount(FlatBufferBuilder builder, EVehicleSeatCount seatCount)
		{
			builder.AddByte(9, (byte)seatCount, 0);
		}

		// Token: 0x0602A2D4 RID: 172756 RVA: 0x005C1813 File Offset: 0x005BFA13
		public static void AddDriverSeat(FlatBufferBuilder builder, EVehicleSeat driverSeat)
		{
			builder.AddUshort(10, (ushort)driverSeat, 0);
		}

		// Token: 0x0602A2D5 RID: 172757 RVA: 0x005C181F File Offset: 0x005BFA1F
		public static void AddDefaultPassengers(FlatBufferBuilder builder, VectorOffset defaultPassengersOffset)
		{
			builder.AddOffset(11, defaultPassengersOffset.Value, 0);
		}

		// Token: 0x0602A2D6 RID: 172758 RVA: 0x005C1830 File Offset: 0x005BFA30
		public static VectorOffset CreateDefaultPassengersVector(FlatBufferBuilder builder, Offset<IVehiclePassengerConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A2D7 RID: 172759 RVA: 0x005C1870 File Offset: 0x005BFA70
		public static VectorOffset CreateDefaultPassengersVectorBlock(FlatBufferBuilder builder, Offset<IVehiclePassengerConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVehiclePassengerConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2D8 RID: 172760 RVA: 0x005C188A File Offset: 0x005BFA8A
		public static VectorOffset CreateDefaultPassengersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVehiclePassengerConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVehiclePassengerConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A2D9 RID: 172761 RVA: 0x005C18A8 File Offset: 0x005BFAA8
		public static VectorOffset CreateDefaultPassengersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVehiclePassengerConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A2DA RID: 172762 RVA: 0x005C18C1 File Offset: 0x005BFAC1
		public static void StartDefaultPassengersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A2DB RID: 172763 RVA: 0x005C18CC File Offset: 0x005BFACC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x0602A2DC RID: 172764 RVA: 0x005C18D8 File Offset: 0x005BFAD8
		public static Offset<IVehicleComponent> EndIVehicleComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleComponent>(builder.EndTable());
		}

		// Token: 0x0602A2DD RID: 172765 RVA: 0x005C18E8 File Offset: 0x005BFAE8
		public IVehicleComponentT UnPack()
		{
			IVehicleComponentT vehicleComponentT = new IVehicleComponentT();
			this.UnPackTo(vehicleComponentT);
			return vehicleComponentT;
		}

		// Token: 0x0602A2DE RID: 172766 RVA: 0x005C1904 File Offset: 0x005BFB04
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

		// Token: 0x0602A2DF RID: 172767 RVA: 0x005C1C70 File Offset: 0x005BFE70
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

		// Token: 0x0400FF16 RID: 65302
		private Table __p;
	}
}
