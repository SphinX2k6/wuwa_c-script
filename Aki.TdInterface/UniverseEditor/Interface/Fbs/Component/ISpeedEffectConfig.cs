using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200597A RID: 22906
	public struct ISpeedEffectConfig : IFlatbufferObject
	{
		// Token: 0x1700ABDC RID: 43996
		// (get) Token: 0x06026C53 RID: 158803 RVA: 0x005563E0 File Offset: 0x005545E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026C54 RID: 158804 RVA: 0x005563ED File Offset: 0x005545ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026C55 RID: 158805 RVA: 0x005563F4 File Offset: 0x005545F4
		public static ISpeedEffectConfig GetRootAsISpeedEffectConfig(ByteBuffer _bb)
		{
			return ISpeedEffectConfig.GetRootAsISpeedEffectConfig(_bb, default(ISpeedEffectConfig));
		}

		// Token: 0x06026C56 RID: 158806 RVA: 0x00556410 File Offset: 0x00554610
		public static ISpeedEffectConfig GetRootAsISpeedEffectConfig(ByteBuffer _bb, ISpeedEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026C57 RID: 158807 RVA: 0x0055642D File Offset: 0x0055462D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026C58 RID: 158808 RVA: 0x0055643C File Offset: 0x0055463C
		public ISpeedEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABDD RID: 43997
		// (get) Token: 0x06026C59 RID: 158809 RVA: 0x0055644C File Offset: 0x0055464C
		public float MinVehicleSpeed
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ABDE RID: 43998
		// (get) Token: 0x06026C5A RID: 158810 RVA: 0x0055648C File Offset: 0x0055468C
		public float MaxVehicleSpeed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026C5B RID: 158811 RVA: 0x005564CC File Offset: 0x005546CC
		public long GameplayCueIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700ABDF RID: 43999
		// (get) Token: 0x06026C5C RID: 158812 RVA: 0x0055650C File Offset: 0x0055470C
		public int GameplayCueIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06026C5D RID: 158813 RVA: 0x00556537 File Offset: 0x00554737
		public Span<long> GetGameplayCueIdsBytes()
		{
			return this.__p.__vector_as_span<long>(8, 8);
		}

		// Token: 0x06026C5E RID: 158814 RVA: 0x00556546 File Offset: 0x00554746
		public long[] GetGameplayCueIdsArray()
		{
			return this.__p.__vector_as_array<long>(8);
		}

		// Token: 0x06026C5F RID: 158815 RVA: 0x00556554 File Offset: 0x00554754
		public static Offset<ISpeedEffectConfig> CreateISpeedEffectConfig(FlatBufferBuilder builder, float MinVehicleSpeed = 0f, float MaxVehicleSpeed = 0f, VectorOffset GameplayCueIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISpeedEffectConfig.AddGameplayCueIds(builder, GameplayCueIdsOffset);
			ISpeedEffectConfig.AddMaxVehicleSpeed(builder, MaxVehicleSpeed);
			ISpeedEffectConfig.AddMinVehicleSpeed(builder, MinVehicleSpeed);
			return ISpeedEffectConfig.EndISpeedEffectConfig(builder);
		}

		// Token: 0x06026C60 RID: 158816 RVA: 0x00556578 File Offset: 0x00554778
		public static void StartISpeedEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026C61 RID: 158817 RVA: 0x00556581 File Offset: 0x00554781
		public static void AddMinVehicleSpeed(FlatBufferBuilder builder, float minVehicleSpeed)
		{
			builder.AddFloat(0, minVehicleSpeed, 0.0);
		}

		// Token: 0x06026C62 RID: 158818 RVA: 0x00556594 File Offset: 0x00554794
		public static void AddMaxVehicleSpeed(FlatBufferBuilder builder, float maxVehicleSpeed)
		{
			builder.AddFloat(1, maxVehicleSpeed, 0.0);
		}

		// Token: 0x06026C63 RID: 158819 RVA: 0x005565A7 File Offset: 0x005547A7
		public static void AddGameplayCueIds(FlatBufferBuilder builder, VectorOffset gameplayCueIdsOffset)
		{
			builder.AddOffset(2, gameplayCueIdsOffset.Value, 0);
		}

		// Token: 0x06026C64 RID: 158820 RVA: 0x005565B8 File Offset: 0x005547B8
		public static VectorOffset CreateGameplayCueIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026C65 RID: 158821 RVA: 0x005565EF File Offset: 0x005547EF
		public static VectorOffset CreateGameplayCueIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06026C66 RID: 158822 RVA: 0x00556609 File Offset: 0x00554809
		public static VectorOffset CreateGameplayCueIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06026C67 RID: 158823 RVA: 0x00556627 File Offset: 0x00554827
		public static VectorOffset CreateGameplayCueIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026C68 RID: 158824 RVA: 0x00556640 File Offset: 0x00554840
		public static void StartGameplayCueIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06026C69 RID: 158825 RVA: 0x0055664B File Offset: 0x0055484B
		public static Offset<ISpeedEffectConfig> EndISpeedEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpeedEffectConfig>(builder.EndTable());
		}

		// Token: 0x06026C6A RID: 158826 RVA: 0x00556658 File Offset: 0x00554858
		public ISpeedEffectConfigT UnPack()
		{
			ISpeedEffectConfigT speedEffectConfigT = new ISpeedEffectConfigT();
			this.UnPackTo(speedEffectConfigT);
			return speedEffectConfigT;
		}

		// Token: 0x06026C6B RID: 158827 RVA: 0x00556674 File Offset: 0x00554874
		public void UnPackTo(ISpeedEffectConfigT _o)
		{
			_o.MinVehicleSpeed = this.MinVehicleSpeed;
			_o.MaxVehicleSpeed = this.MaxVehicleSpeed;
			_o.GameplayCueIds = new List<long>();
			for (int i = 0; i < this.GameplayCueIdsLength; i++)
			{
				_o.GameplayCueIds.Add(this.GameplayCueIds(i));
			}
		}

		// Token: 0x06026C6C RID: 158828 RVA: 0x005566C8 File Offset: 0x005548C8
		public static Offset<ISpeedEffectConfig> Pack(FlatBufferBuilder builder, ISpeedEffectConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpeedEffectConfig>);
			}
			VectorOffset gameplayCueIdsOffset = default(VectorOffset);
			if (_o.GameplayCueIds != null)
			{
				long[] data = _o.GameplayCueIds.ToArray();
				gameplayCueIdsOffset = ISpeedEffectConfig.CreateGameplayCueIdsVector(builder, data);
			}
			return ISpeedEffectConfig.CreateISpeedEffectConfig(builder, _o.MinVehicleSpeed, _o.MaxVehicleSpeed, gameplayCueIdsOffset);
		}

		// Token: 0x0400EF67 RID: 61287
		private Table __p;
	}
}
