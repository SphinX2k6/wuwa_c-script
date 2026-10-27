using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B23 RID: 23331
	public struct IVehicleMontagePlayConfig : IFlatbufferObject
	{
		// Token: 0x1700B01A RID: 45082
		// (get) Token: 0x06027DF2 RID: 163314 RVA: 0x0057BD20 File Offset: 0x00579F20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027DF3 RID: 163315 RVA: 0x0057BD2D File Offset: 0x00579F2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027DF4 RID: 163316 RVA: 0x0057BD34 File Offset: 0x00579F34
		public static IVehicleMontagePlayConfig GetRootAsIVehicleMontagePlayConfig(ByteBuffer _bb)
		{
			return IVehicleMontagePlayConfig.GetRootAsIVehicleMontagePlayConfig(_bb, default(IVehicleMontagePlayConfig));
		}

		// Token: 0x06027DF5 RID: 163317 RVA: 0x0057BD50 File Offset: 0x00579F50
		public static IVehicleMontagePlayConfig GetRootAsIVehicleMontagePlayConfig(ByteBuffer _bb, IVehicleMontagePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027DF6 RID: 163318 RVA: 0x0057BD6D File Offset: 0x00579F6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027DF7 RID: 163319 RVA: 0x0057BD7C File Offset: 0x00579F7C
		public IVehicleMontagePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B01B RID: 45083
		// (get) Token: 0x06027DF8 RID: 163320 RVA: 0x0057BD8C File Offset: 0x00579F8C
		public float MinMontageSpeedFactor
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

		// Token: 0x1700B01C RID: 45084
		// (get) Token: 0x06027DF9 RID: 163321 RVA: 0x0057BDCC File Offset: 0x00579FCC
		public float MaxMontageSpeedFactor
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

		// Token: 0x1700B01D RID: 45085
		// (get) Token: 0x06027DFA RID: 163322 RVA: 0x0057BE0C File Offset: 0x0057A00C
		public float MinVehicleSpeed
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B01E RID: 45086
		// (get) Token: 0x06027DFB RID: 163323 RVA: 0x0057BE4C File Offset: 0x0057A04C
		public float MaxVehicleSpeed
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B01F RID: 45087
		// (get) Token: 0x06027DFC RID: 163324 RVA: 0x0057BE90 File Offset: 0x0057A090
		public string TargetState
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027DFD RID: 163325 RVA: 0x0057BEC8 File Offset: 0x0057A0C8
		public Span<byte> GetTargetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06027DFE RID: 163326 RVA: 0x0057BED8 File Offset: 0x0057A0D8
		public byte[] GetTargetStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06027DFF RID: 163327 RVA: 0x0057BEE7 File Offset: 0x0057A0E7
		public static Offset<IVehicleMontagePlayConfig> CreateIVehicleMontagePlayConfig(FlatBufferBuilder builder, float MinMontageSpeedFactor = 0f, float MaxMontageSpeedFactor = 0f, float MinVehicleSpeed = 0f, float MaxVehicleSpeed = 0f, StringOffset TargetStateOffset = default(StringOffset))
		{
			builder.StartTable(5);
			IVehicleMontagePlayConfig.AddTargetState(builder, TargetStateOffset);
			IVehicleMontagePlayConfig.AddMaxVehicleSpeed(builder, MaxVehicleSpeed);
			IVehicleMontagePlayConfig.AddMinVehicleSpeed(builder, MinVehicleSpeed);
			IVehicleMontagePlayConfig.AddMaxMontageSpeedFactor(builder, MaxMontageSpeedFactor);
			IVehicleMontagePlayConfig.AddMinMontageSpeedFactor(builder, MinMontageSpeedFactor);
			return IVehicleMontagePlayConfig.EndIVehicleMontagePlayConfig(builder);
		}

		// Token: 0x06027E00 RID: 163328 RVA: 0x0057BF1B File Offset: 0x0057A11B
		public static void StartIVehicleMontagePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027E01 RID: 163329 RVA: 0x0057BF24 File Offset: 0x0057A124
		public static void AddMinMontageSpeedFactor(FlatBufferBuilder builder, float minMontageSpeedFactor)
		{
			builder.AddFloat(0, minMontageSpeedFactor, 0.0);
		}

		// Token: 0x06027E02 RID: 163330 RVA: 0x0057BF37 File Offset: 0x0057A137
		public static void AddMaxMontageSpeedFactor(FlatBufferBuilder builder, float maxMontageSpeedFactor)
		{
			builder.AddFloat(1, maxMontageSpeedFactor, 0.0);
		}

		// Token: 0x06027E03 RID: 163331 RVA: 0x0057BF4A File Offset: 0x0057A14A
		public static void AddMinVehicleSpeed(FlatBufferBuilder builder, float minVehicleSpeed)
		{
			builder.AddFloat(2, minVehicleSpeed, 0.0);
		}

		// Token: 0x06027E04 RID: 163332 RVA: 0x0057BF5D File Offset: 0x0057A15D
		public static void AddMaxVehicleSpeed(FlatBufferBuilder builder, float maxVehicleSpeed)
		{
			builder.AddFloat(3, maxVehicleSpeed, 0.0);
		}

		// Token: 0x06027E05 RID: 163333 RVA: 0x0057BF70 File Offset: 0x0057A170
		public static void AddTargetState(FlatBufferBuilder builder, StringOffset targetStateOffset)
		{
			builder.AddOffset(4, targetStateOffset.Value, 0);
		}

		// Token: 0x06027E06 RID: 163334 RVA: 0x0057BF80 File Offset: 0x0057A180
		public static Offset<IVehicleMontagePlayConfig> EndIVehicleMontagePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleMontagePlayConfig>(builder.EndTable());
		}

		// Token: 0x06027E07 RID: 163335 RVA: 0x0057BF90 File Offset: 0x0057A190
		public IVehicleMontagePlayConfigT UnPack()
		{
			IVehicleMontagePlayConfigT vehicleMontagePlayConfigT = new IVehicleMontagePlayConfigT();
			this.UnPackTo(vehicleMontagePlayConfigT);
			return vehicleMontagePlayConfigT;
		}

		// Token: 0x06027E08 RID: 163336 RVA: 0x0057BFAB File Offset: 0x0057A1AB
		public void UnPackTo(IVehicleMontagePlayConfigT _o)
		{
			_o.MinMontageSpeedFactor = this.MinMontageSpeedFactor;
			_o.MaxMontageSpeedFactor = this.MaxMontageSpeedFactor;
			_o.MinVehicleSpeed = this.MinVehicleSpeed;
			_o.MaxVehicleSpeed = this.MaxVehicleSpeed;
			_o.TargetState = this.TargetState;
		}

		// Token: 0x06027E09 RID: 163337 RVA: 0x0057BFEC File Offset: 0x0057A1EC
		public static Offset<IVehicleMontagePlayConfig> Pack(FlatBufferBuilder builder, IVehicleMontagePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleMontagePlayConfig>);
			}
			StringOffset targetStateOffset = (_o.TargetState == null) ? default(StringOffset) : builder.CreateString(_o.TargetState);
			return IVehicleMontagePlayConfig.CreateIVehicleMontagePlayConfig(builder, _o.MinMontageSpeedFactor, _o.MaxMontageSpeedFactor, _o.MinVehicleSpeed, _o.MaxVehicleSpeed, targetStateOffset);
		}

		// Token: 0x0400F243 RID: 62019
		private Table __p;
	}
}
