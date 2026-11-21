using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F87 RID: 24455
	public struct ISpeedEffectConfig : IFlatbufferObject
	{
		// Token: 0x1700B510 RID: 46352
		// (get) Token: 0x060291BD RID: 168381 RVA: 0x0059D04C File Offset: 0x0059B24C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060291BE RID: 168382 RVA: 0x0059D059 File Offset: 0x0059B259
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060291BF RID: 168383 RVA: 0x0059D060 File Offset: 0x0059B260
		public static ISpeedEffectConfig GetRootAsISpeedEffectConfig(ByteBuffer _bb)
		{
			return ISpeedEffectConfig.GetRootAsISpeedEffectConfig(_bb, default(ISpeedEffectConfig));
		}

		// Token: 0x060291C0 RID: 168384 RVA: 0x0059D07C File Offset: 0x0059B27C
		public static ISpeedEffectConfig GetRootAsISpeedEffectConfig(ByteBuffer _bb, ISpeedEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060291C1 RID: 168385 RVA: 0x0059D099 File Offset: 0x0059B299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060291C2 RID: 168386 RVA: 0x0059D0A8 File Offset: 0x0059B2A8
		public ISpeedEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B511 RID: 46353
		// (get) Token: 0x060291C3 RID: 168387 RVA: 0x0059D0B8 File Offset: 0x0059B2B8
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

		// Token: 0x1700B512 RID: 46354
		// (get) Token: 0x060291C4 RID: 168388 RVA: 0x0059D0F8 File Offset: 0x0059B2F8
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

		// Token: 0x060291C5 RID: 168389 RVA: 0x0059D138 File Offset: 0x0059B338
		public long GameplayCueIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700B513 RID: 46355
		// (get) Token: 0x060291C6 RID: 168390 RVA: 0x0059D178 File Offset: 0x0059B378
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

		// Token: 0x060291C7 RID: 168391 RVA: 0x0059D1A3 File Offset: 0x0059B3A3
		public Span<long> GetGameplayCueIdsBytes()
		{
			return this.__p.__vector_as_span<long>(8, 8);
		}

		// Token: 0x060291C8 RID: 168392 RVA: 0x0059D1B2 File Offset: 0x0059B3B2
		public long[] GetGameplayCueIdsArray()
		{
			return this.__p.__vector_as_array<long>(8);
		}

		// Token: 0x060291C9 RID: 168393 RVA: 0x0059D1C0 File Offset: 0x0059B3C0
		public static Offset<ISpeedEffectConfig> CreateISpeedEffectConfig(FlatBufferBuilder builder, float MinVehicleSpeed = 0f, float MaxVehicleSpeed = 0f, VectorOffset GameplayCueIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISpeedEffectConfig.AddGameplayCueIds(builder, GameplayCueIdsOffset);
			ISpeedEffectConfig.AddMaxVehicleSpeed(builder, MaxVehicleSpeed);
			ISpeedEffectConfig.AddMinVehicleSpeed(builder, MinVehicleSpeed);
			return ISpeedEffectConfig.EndISpeedEffectConfig(builder);
		}

		// Token: 0x060291CA RID: 168394 RVA: 0x0059D1E4 File Offset: 0x0059B3E4
		public static void StartISpeedEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060291CB RID: 168395 RVA: 0x0059D1ED File Offset: 0x0059B3ED
		public static void AddMinVehicleSpeed(FlatBufferBuilder builder, float minVehicleSpeed)
		{
			builder.AddFloat(0, minVehicleSpeed, 0.0);
		}

		// Token: 0x060291CC RID: 168396 RVA: 0x0059D200 File Offset: 0x0059B400
		public static void AddMaxVehicleSpeed(FlatBufferBuilder builder, float maxVehicleSpeed)
		{
			builder.AddFloat(1, maxVehicleSpeed, 0.0);
		}

		// Token: 0x060291CD RID: 168397 RVA: 0x0059D213 File Offset: 0x0059B413
		public static void AddGameplayCueIds(FlatBufferBuilder builder, VectorOffset gameplayCueIdsOffset)
		{
			builder.AddOffset(2, gameplayCueIdsOffset.Value, 0);
		}

		// Token: 0x060291CE RID: 168398 RVA: 0x0059D224 File Offset: 0x0059B424
		public static VectorOffset CreateGameplayCueIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060291CF RID: 168399 RVA: 0x0059D25B File Offset: 0x0059B45B
		public static VectorOffset CreateGameplayCueIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x060291D0 RID: 168400 RVA: 0x0059D275 File Offset: 0x0059B475
		public static VectorOffset CreateGameplayCueIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x060291D1 RID: 168401 RVA: 0x0059D293 File Offset: 0x0059B493
		public static VectorOffset CreateGameplayCueIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060291D2 RID: 168402 RVA: 0x0059D2AC File Offset: 0x0059B4AC
		public static void StartGameplayCueIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x060291D3 RID: 168403 RVA: 0x0059D2B7 File Offset: 0x0059B4B7
		public static Offset<ISpeedEffectConfig> EndISpeedEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpeedEffectConfig>(builder.EndTable());
		}

		// Token: 0x060291D4 RID: 168404 RVA: 0x0059D2C4 File Offset: 0x0059B4C4
		public ISpeedEffectConfigT UnPack()
		{
			ISpeedEffectConfigT speedEffectConfigT = new ISpeedEffectConfigT();
			this.UnPackTo(speedEffectConfigT);
			return speedEffectConfigT;
		}

		// Token: 0x060291D5 RID: 168405 RVA: 0x0059D2E0 File Offset: 0x0059B4E0
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

		// Token: 0x060291D6 RID: 168406 RVA: 0x0059D334 File Offset: 0x0059B534
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

		// Token: 0x0400FC5C RID: 64604
		private Table __p;
	}
}
