using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006139 RID: 24889
	public struct IVehicleMontagePlayConfig : IFlatbufferObject
	{
		// Token: 0x1700B962 RID: 47458
		// (get) Token: 0x0602A3B6 RID: 172982 RVA: 0x005C3774 File Offset: 0x005C1974
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A3B7 RID: 172983 RVA: 0x005C3781 File Offset: 0x005C1981
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A3B8 RID: 172984 RVA: 0x005C3788 File Offset: 0x005C1988
		public static IVehicleMontagePlayConfig GetRootAsIVehicleMontagePlayConfig(ByteBuffer _bb)
		{
			return IVehicleMontagePlayConfig.GetRootAsIVehicleMontagePlayConfig(_bb, default(IVehicleMontagePlayConfig));
		}

		// Token: 0x0602A3B9 RID: 172985 RVA: 0x005C37A4 File Offset: 0x005C19A4
		public static IVehicleMontagePlayConfig GetRootAsIVehicleMontagePlayConfig(ByteBuffer _bb, IVehicleMontagePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A3BA RID: 172986 RVA: 0x005C37C1 File Offset: 0x005C19C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A3BB RID: 172987 RVA: 0x005C37D0 File Offset: 0x005C19D0
		public IVehicleMontagePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B963 RID: 47459
		// (get) Token: 0x0602A3BC RID: 172988 RVA: 0x005C37E0 File Offset: 0x005C19E0
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

		// Token: 0x1700B964 RID: 47460
		// (get) Token: 0x0602A3BD RID: 172989 RVA: 0x005C3820 File Offset: 0x005C1A20
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

		// Token: 0x1700B965 RID: 47461
		// (get) Token: 0x0602A3BE RID: 172990 RVA: 0x005C3860 File Offset: 0x005C1A60
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

		// Token: 0x1700B966 RID: 47462
		// (get) Token: 0x0602A3BF RID: 172991 RVA: 0x005C38A0 File Offset: 0x005C1AA0
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

		// Token: 0x1700B967 RID: 47463
		// (get) Token: 0x0602A3C0 RID: 172992 RVA: 0x005C38E4 File Offset: 0x005C1AE4
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

		// Token: 0x0602A3C1 RID: 172993 RVA: 0x005C391C File Offset: 0x005C1B1C
		public Span<byte> GetTargetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602A3C2 RID: 172994 RVA: 0x005C392C File Offset: 0x005C1B2C
		public byte[] GetTargetStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0602A3C3 RID: 172995 RVA: 0x005C393B File Offset: 0x005C1B3B
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

		// Token: 0x0602A3C4 RID: 172996 RVA: 0x005C396F File Offset: 0x005C1B6F
		public static void StartIVehicleMontagePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602A3C5 RID: 172997 RVA: 0x005C3978 File Offset: 0x005C1B78
		public static void AddMinMontageSpeedFactor(FlatBufferBuilder builder, float minMontageSpeedFactor)
		{
			builder.AddFloat(0, minMontageSpeedFactor, 0.0);
		}

		// Token: 0x0602A3C6 RID: 172998 RVA: 0x005C398B File Offset: 0x005C1B8B
		public static void AddMaxMontageSpeedFactor(FlatBufferBuilder builder, float maxMontageSpeedFactor)
		{
			builder.AddFloat(1, maxMontageSpeedFactor, 0.0);
		}

		// Token: 0x0602A3C7 RID: 172999 RVA: 0x005C399E File Offset: 0x005C1B9E
		public static void AddMinVehicleSpeed(FlatBufferBuilder builder, float minVehicleSpeed)
		{
			builder.AddFloat(2, minVehicleSpeed, 0.0);
		}

		// Token: 0x0602A3C8 RID: 173000 RVA: 0x005C39B1 File Offset: 0x005C1BB1
		public static void AddMaxVehicleSpeed(FlatBufferBuilder builder, float maxVehicleSpeed)
		{
			builder.AddFloat(3, maxVehicleSpeed, 0.0);
		}

		// Token: 0x0602A3C9 RID: 173001 RVA: 0x005C39C4 File Offset: 0x005C1BC4
		public static void AddTargetState(FlatBufferBuilder builder, StringOffset targetStateOffset)
		{
			builder.AddOffset(4, targetStateOffset.Value, 0);
		}

		// Token: 0x0602A3CA RID: 173002 RVA: 0x005C39D4 File Offset: 0x005C1BD4
		public static Offset<IVehicleMontagePlayConfig> EndIVehicleMontagePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleMontagePlayConfig>(builder.EndTable());
		}

		// Token: 0x0602A3CB RID: 173003 RVA: 0x005C39E4 File Offset: 0x005C1BE4
		public IVehicleMontagePlayConfigT UnPack()
		{
			IVehicleMontagePlayConfigT vehicleMontagePlayConfigT = new IVehicleMontagePlayConfigT();
			this.UnPackTo(vehicleMontagePlayConfigT);
			return vehicleMontagePlayConfigT;
		}

		// Token: 0x0602A3CC RID: 173004 RVA: 0x005C39FF File Offset: 0x005C1BFF
		public void UnPackTo(IVehicleMontagePlayConfigT _o)
		{
			_o.MinMontageSpeedFactor = this.MinMontageSpeedFactor;
			_o.MaxMontageSpeedFactor = this.MaxMontageSpeedFactor;
			_o.MinVehicleSpeed = this.MinVehicleSpeed;
			_o.MaxVehicleSpeed = this.MaxVehicleSpeed;
			_o.TargetState = this.TargetState;
		}

		// Token: 0x0602A3CD RID: 173005 RVA: 0x005C3A40 File Offset: 0x005C1C40
		public static Offset<IVehicleMontagePlayConfig> Pack(FlatBufferBuilder builder, IVehicleMontagePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleMontagePlayConfig>);
			}
			StringOffset targetStateOffset = (_o.TargetState == null) ? default(StringOffset) : builder.CreateString(_o.TargetState);
			return IVehicleMontagePlayConfig.CreateIVehicleMontagePlayConfig(builder, _o.MinMontageSpeedFactor, _o.MaxMontageSpeedFactor, _o.MinVehicleSpeed, _o.MaxVehicleSpeed, targetStateOffset);
		}

		// Token: 0x0400FF49 RID: 65353
		private Table __p;
	}
}
