using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B76 RID: 23414
	public struct IMovementPerformConfig : IFlatbufferObject
	{
		// Token: 0x1700AB1A RID: 43802
		// (get) Token: 0x06026912 RID: 157970 RVA: 0x00548034 File Offset: 0x00546234
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026913 RID: 157971 RVA: 0x00548041 File Offset: 0x00546241
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026914 RID: 157972 RVA: 0x00548048 File Offset: 0x00546248
		public static IMovementPerformConfig GetRootAsIMovementPerformConfig(ByteBuffer _bb)
		{
			return IMovementPerformConfig.GetRootAsIMovementPerformConfig(_bb, default(IMovementPerformConfig));
		}

		// Token: 0x06026915 RID: 157973 RVA: 0x00548064 File Offset: 0x00546264
		public static IMovementPerformConfig GetRootAsIMovementPerformConfig(ByteBuffer _bb, IMovementPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026916 RID: 157974 RVA: 0x00548081 File Offset: 0x00546281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026917 RID: 157975 RVA: 0x00548090 File Offset: 0x00546290
		public IMovementPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06026918 RID: 157976 RVA: 0x005480A0 File Offset: 0x005462A0
		public IVehicleMontagePlayConfig? VehicleMontagePlayConfigs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IVehicleMontagePlayConfig?(default(IVehicleMontagePlayConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB1B RID: 43803
		// (get) Token: 0x06026919 RID: 157977 RVA: 0x00548100 File Offset: 0x00546300
		public int VehicleMontagePlayConfigsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602691A RID: 157978 RVA: 0x0054812C File Offset: 0x0054632C
		public ISpeedEffectConfig? PlayerSpeedEffectConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISpeedEffectConfig?(default(ISpeedEffectConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB1C RID: 43804
		// (get) Token: 0x0602691B RID: 157979 RVA: 0x0054818C File Offset: 0x0054638C
		public int PlayerSpeedEffectConfigsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AB1D RID: 43805
		// (get) Token: 0x0602691C RID: 157980 RVA: 0x005481B8 File Offset: 0x005463B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602691D RID: 157981 RVA: 0x005481F4 File Offset: 0x005463F4
		public static Offset<IMovementPerformConfig> CreateIMovementPerformConfig(FlatBufferBuilder builder, VectorOffset VehicleMontagePlayConfigsOffset = default(VectorOffset), VectorOffset PlayerSpeedEffectConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IMovementPerformConfig.AddPlayerSpeedEffectConfigs(builder, PlayerSpeedEffectConfigsOffset);
			IMovementPerformConfig.AddVehicleMontagePlayConfigs(builder, VehicleMontagePlayConfigsOffset);
			IMovementPerformConfig.AddNullMask(builder, NullMask);
			return IMovementPerformConfig.EndIMovementPerformConfig(builder);
		}

		// Token: 0x0602691E RID: 157982 RVA: 0x00548218 File Offset: 0x00546418
		public static void StartIMovementPerformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602691F RID: 157983 RVA: 0x00548221 File Offset: 0x00546421
		public static void AddVehicleMontagePlayConfigs(FlatBufferBuilder builder, VectorOffset vehicleMontagePlayConfigsOffset)
		{
			builder.AddOffset(0, vehicleMontagePlayConfigsOffset.Value, 0);
		}

		// Token: 0x06026920 RID: 157984 RVA: 0x00548234 File Offset: 0x00546434
		public static VectorOffset CreateVehicleMontagePlayConfigsVector(FlatBufferBuilder builder, Offset<IVehicleMontagePlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026921 RID: 157985 RVA: 0x00548274 File Offset: 0x00546474
		public static VectorOffset CreateVehicleMontagePlayConfigsVectorBlock(FlatBufferBuilder builder, Offset<IVehicleMontagePlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVehicleMontagePlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026922 RID: 157986 RVA: 0x0054828E File Offset: 0x0054648E
		public static VectorOffset CreateVehicleMontagePlayConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVehicleMontagePlayConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVehicleMontagePlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026923 RID: 157987 RVA: 0x005482AC File Offset: 0x005464AC
		public static VectorOffset CreateVehicleMontagePlayConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVehicleMontagePlayConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026924 RID: 157988 RVA: 0x005482C5 File Offset: 0x005464C5
		public static void StartVehicleMontagePlayConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026925 RID: 157989 RVA: 0x005482D0 File Offset: 0x005464D0
		public static void AddPlayerSpeedEffectConfigs(FlatBufferBuilder builder, VectorOffset playerSpeedEffectConfigsOffset)
		{
			builder.AddOffset(1, playerSpeedEffectConfigsOffset.Value, 0);
		}

		// Token: 0x06026926 RID: 157990 RVA: 0x005482E0 File Offset: 0x005464E0
		public static VectorOffset CreatePlayerSpeedEffectConfigsVector(FlatBufferBuilder builder, Offset<ISpeedEffectConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026927 RID: 157991 RVA: 0x00548320 File Offset: 0x00546520
		public static VectorOffset CreatePlayerSpeedEffectConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISpeedEffectConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISpeedEffectConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026928 RID: 157992 RVA: 0x0054833A File Offset: 0x0054653A
		public static VectorOffset CreatePlayerSpeedEffectConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISpeedEffectConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISpeedEffectConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026929 RID: 157993 RVA: 0x00548358 File Offset: 0x00546558
		public static VectorOffset CreatePlayerSpeedEffectConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISpeedEffectConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602692A RID: 157994 RVA: 0x00548371 File Offset: 0x00546571
		public static void StartPlayerSpeedEffectConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602692B RID: 157995 RVA: 0x0054837C File Offset: 0x0054657C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602692C RID: 157996 RVA: 0x00548387 File Offset: 0x00546587
		public static Offset<IMovementPerformConfig> EndIMovementPerformConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMovementPerformConfig>(builder.EndTable());
		}

		// Token: 0x0602692D RID: 157997 RVA: 0x00548394 File Offset: 0x00546594
		public IMovementPerformConfigT UnPack()
		{
			IMovementPerformConfigT movementPerformConfigT = new IMovementPerformConfigT();
			this.UnPackTo(movementPerformConfigT);
			return movementPerformConfigT;
		}

		// Token: 0x0602692E RID: 157998 RVA: 0x005483B0 File Offset: 0x005465B0
		public void UnPackTo(IMovementPerformConfigT _o)
		{
			_o.VehicleMontagePlayConfigs = new List<IVehicleMontagePlayConfigT>();
			for (int i = 0; i < this.VehicleMontagePlayConfigsLength; i++)
			{
				_o.VehicleMontagePlayConfigs.Add((this.VehicleMontagePlayConfigs(i) != null) ? this.VehicleMontagePlayConfigs(i).Value.UnPack() : null);
			}
			_o.PlayerSpeedEffectConfigs = new List<ISpeedEffectConfigT>();
			for (int j = 0; j < this.PlayerSpeedEffectConfigsLength; j++)
			{
				_o.PlayerSpeedEffectConfigs.Add((this.PlayerSpeedEffectConfigs(j) != null) ? this.PlayerSpeedEffectConfigs(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602692F RID: 157999 RVA: 0x00548470 File Offset: 0x00546670
		public static Offset<IMovementPerformConfig> Pack(FlatBufferBuilder builder, IMovementPerformConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovementPerformConfig>);
			}
			VectorOffset vehicleMontagePlayConfigsOffset = default(VectorOffset);
			if (_o.VehicleMontagePlayConfigs != null)
			{
				Offset<IVehicleMontagePlayConfig>[] array = new Offset<IVehicleMontagePlayConfig>[_o.VehicleMontagePlayConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVehicleMontagePlayConfig.Pack(builder, _o.VehicleMontagePlayConfigs[i]);
				}
				vehicleMontagePlayConfigsOffset = IMovementPerformConfig.CreateVehicleMontagePlayConfigsVector(builder, array);
			}
			VectorOffset playerSpeedEffectConfigsOffset = default(VectorOffset);
			if (_o.PlayerSpeedEffectConfigs != null)
			{
				Offset<ISpeedEffectConfig>[] array2 = new Offset<ISpeedEffectConfig>[_o.PlayerSpeedEffectConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ISpeedEffectConfig.Pack(builder, _o.PlayerSpeedEffectConfigs[j]);
				}
				playerSpeedEffectConfigsOffset = IMovementPerformConfig.CreatePlayerSpeedEffectConfigsVector(builder, array2);
			}
			return IMovementPerformConfig.CreateIMovementPerformConfig(builder, vehicleMontagePlayConfigsOffset, playerSpeedEffectConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400F59C RID: 62876
		private Table __p;
	}
}
