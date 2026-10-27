using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D8 RID: 21976
	public struct IMovementPerformConfig : IFlatbufferObject
	{
		// Token: 0x1700A292 RID: 41618
		// (get) Token: 0x06024705 RID: 149253 RVA: 0x00507ABC File Offset: 0x00505CBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024706 RID: 149254 RVA: 0x00507AC9 File Offset: 0x00505CC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024707 RID: 149255 RVA: 0x00507AD0 File Offset: 0x00505CD0
		public static IMovementPerformConfig GetRootAsIMovementPerformConfig(ByteBuffer _bb)
		{
			return IMovementPerformConfig.GetRootAsIMovementPerformConfig(_bb, default(IMovementPerformConfig));
		}

		// Token: 0x06024708 RID: 149256 RVA: 0x00507AEC File Offset: 0x00505CEC
		public static IMovementPerformConfig GetRootAsIMovementPerformConfig(ByteBuffer _bb, IMovementPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024709 RID: 149257 RVA: 0x00507B09 File Offset: 0x00505D09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602470A RID: 149258 RVA: 0x00507B18 File Offset: 0x00505D18
		public IMovementPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602470B RID: 149259 RVA: 0x00507B28 File Offset: 0x00505D28
		public IVehicleMontagePlayConfig? VehicleMontagePlayConfigs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IVehicleMontagePlayConfig?(default(IVehicleMontagePlayConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A293 RID: 41619
		// (get) Token: 0x0602470C RID: 149260 RVA: 0x00507B88 File Offset: 0x00505D88
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

		// Token: 0x0602470D RID: 149261 RVA: 0x00507BB4 File Offset: 0x00505DB4
		public ISpeedEffectConfig? PlayerSpeedEffectConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISpeedEffectConfig?(default(ISpeedEffectConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A294 RID: 41620
		// (get) Token: 0x0602470E RID: 149262 RVA: 0x00507C14 File Offset: 0x00505E14
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

		// Token: 0x1700A295 RID: 41621
		// (get) Token: 0x0602470F RID: 149263 RVA: 0x00507C40 File Offset: 0x00505E40
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

		// Token: 0x06024710 RID: 149264 RVA: 0x00507C7C File Offset: 0x00505E7C
		public static Offset<IMovementPerformConfig> CreateIMovementPerformConfig(FlatBufferBuilder builder, VectorOffset VehicleMontagePlayConfigsOffset = default(VectorOffset), VectorOffset PlayerSpeedEffectConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IMovementPerformConfig.AddPlayerSpeedEffectConfigs(builder, PlayerSpeedEffectConfigsOffset);
			IMovementPerformConfig.AddVehicleMontagePlayConfigs(builder, VehicleMontagePlayConfigsOffset);
			IMovementPerformConfig.AddNullMask(builder, NullMask);
			return IMovementPerformConfig.EndIMovementPerformConfig(builder);
		}

		// Token: 0x06024711 RID: 149265 RVA: 0x00507CA0 File Offset: 0x00505EA0
		public static void StartIMovementPerformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024712 RID: 149266 RVA: 0x00507CA9 File Offset: 0x00505EA9
		public static void AddVehicleMontagePlayConfigs(FlatBufferBuilder builder, VectorOffset vehicleMontagePlayConfigsOffset)
		{
			builder.AddOffset(0, vehicleMontagePlayConfigsOffset.Value, 0);
		}

		// Token: 0x06024713 RID: 149267 RVA: 0x00507CBC File Offset: 0x00505EBC
		public static VectorOffset CreateVehicleMontagePlayConfigsVector(FlatBufferBuilder builder, Offset<IVehicleMontagePlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024714 RID: 149268 RVA: 0x00507CFC File Offset: 0x00505EFC
		public static VectorOffset CreateVehicleMontagePlayConfigsVectorBlock(FlatBufferBuilder builder, Offset<IVehicleMontagePlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVehicleMontagePlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024715 RID: 149269 RVA: 0x00507D16 File Offset: 0x00505F16
		public static VectorOffset CreateVehicleMontagePlayConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVehicleMontagePlayConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVehicleMontagePlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024716 RID: 149270 RVA: 0x00507D34 File Offset: 0x00505F34
		public static VectorOffset CreateVehicleMontagePlayConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVehicleMontagePlayConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024717 RID: 149271 RVA: 0x00507D4D File Offset: 0x00505F4D
		public static void StartVehicleMontagePlayConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024718 RID: 149272 RVA: 0x00507D58 File Offset: 0x00505F58
		public static void AddPlayerSpeedEffectConfigs(FlatBufferBuilder builder, VectorOffset playerSpeedEffectConfigsOffset)
		{
			builder.AddOffset(1, playerSpeedEffectConfigsOffset.Value, 0);
		}

		// Token: 0x06024719 RID: 149273 RVA: 0x00507D68 File Offset: 0x00505F68
		public static VectorOffset CreatePlayerSpeedEffectConfigsVector(FlatBufferBuilder builder, Offset<ISpeedEffectConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602471A RID: 149274 RVA: 0x00507DA8 File Offset: 0x00505FA8
		public static VectorOffset CreatePlayerSpeedEffectConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISpeedEffectConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISpeedEffectConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602471B RID: 149275 RVA: 0x00507DC2 File Offset: 0x00505FC2
		public static VectorOffset CreatePlayerSpeedEffectConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISpeedEffectConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISpeedEffectConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602471C RID: 149276 RVA: 0x00507DE0 File Offset: 0x00505FE0
		public static VectorOffset CreatePlayerSpeedEffectConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISpeedEffectConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602471D RID: 149277 RVA: 0x00507DF9 File Offset: 0x00505FF9
		public static void StartPlayerSpeedEffectConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602471E RID: 149278 RVA: 0x00507E04 File Offset: 0x00506004
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602471F RID: 149279 RVA: 0x00507E0F File Offset: 0x0050600F
		public static Offset<IMovementPerformConfig> EndIMovementPerformConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMovementPerformConfig>(builder.EndTable());
		}

		// Token: 0x06024720 RID: 149280 RVA: 0x00507E1C File Offset: 0x0050601C
		public IMovementPerformConfigT UnPack()
		{
			IMovementPerformConfigT movementPerformConfigT = new IMovementPerformConfigT();
			this.UnPackTo(movementPerformConfigT);
			return movementPerformConfigT;
		}

		// Token: 0x06024721 RID: 149281 RVA: 0x00507E38 File Offset: 0x00506038
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

		// Token: 0x06024722 RID: 149282 RVA: 0x00507EF8 File Offset: 0x005060F8
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

		// Token: 0x0400E93A RID: 59706
		private Table __p;
	}
}
