using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E09 RID: 24073
	public struct IMotorAirCurrentConfig : IFlatbufferObject
	{
		// Token: 0x1700B41B RID: 46107
		// (get) Token: 0x0602934C RID: 168780 RVA: 0x005A70AC File Offset: 0x005A52AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602934D RID: 168781 RVA: 0x005A70B9 File Offset: 0x005A52B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602934E RID: 168782 RVA: 0x005A70C0 File Offset: 0x005A52C0
		public static IMotorAirCurrentConfig GetRootAsIMotorAirCurrentConfig(ByteBuffer _bb)
		{
			return IMotorAirCurrentConfig.GetRootAsIMotorAirCurrentConfig(_bb, default(IMotorAirCurrentConfig));
		}

		// Token: 0x0602934F RID: 168783 RVA: 0x005A70DC File Offset: 0x005A52DC
		public static IMotorAirCurrentConfig GetRootAsIMotorAirCurrentConfig(ByteBuffer _bb, IMotorAirCurrentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029350 RID: 168784 RVA: 0x005A70F9 File Offset: 0x005A52F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029351 RID: 168785 RVA: 0x005A7108 File Offset: 0x005A5308
		public IMotorAirCurrentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B41C RID: 46108
		// (get) Token: 0x06029352 RID: 168786 RVA: 0x005A7118 File Offset: 0x005A5318
		public IVectorInfo? Direction
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B41D RID: 46109
		// (get) Token: 0x06029353 RID: 168787 RVA: 0x005A7178 File Offset: 0x005A5378
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B41E RID: 46110
		// (get) Token: 0x06029354 RID: 168788 RVA: 0x005A71D8 File Offset: 0x005A53D8
		public float WindFieldDepth
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

		// Token: 0x1700B41F RID: 46111
		// (get) Token: 0x06029355 RID: 168789 RVA: 0x005A7218 File Offset: 0x005A5418
		public float MaxAdditionalSpeed
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

		// Token: 0x1700B420 RID: 46112
		// (get) Token: 0x06029356 RID: 168790 RVA: 0x005A725C File Offset: 0x005A545C
		public string SpeedCurve
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

		// Token: 0x06029357 RID: 168791 RVA: 0x005A7294 File Offset: 0x005A5494
		public Span<byte> GetSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06029358 RID: 168792 RVA: 0x005A72A4 File Offset: 0x005A54A4
		public byte[] GetSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700B421 RID: 46113
		// (get) Token: 0x06029359 RID: 168793 RVA: 0x005A72B4 File Offset: 0x005A54B4
		public float SpeedTolerance
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602935A RID: 168794 RVA: 0x005A72F5 File Offset: 0x005A54F5
		public static Offset<IMotorAirCurrentConfig> CreateIMotorAirCurrentConfig(FlatBufferBuilder builder, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), float WindFieldDepth = 0f, float MaxAdditionalSpeed = 0f, StringOffset SpeedCurveOffset = default(StringOffset), float SpeedTolerance = 0f)
		{
			builder.StartTable(6);
			IMotorAirCurrentConfig.AddSpeedTolerance(builder, SpeedTolerance);
			IMotorAirCurrentConfig.AddSpeedCurve(builder, SpeedCurveOffset);
			IMotorAirCurrentConfig.AddMaxAdditionalSpeed(builder, MaxAdditionalSpeed);
			IMotorAirCurrentConfig.AddWindFieldDepth(builder, WindFieldDepth);
			IMotorAirCurrentConfig.AddOffset(builder, OffsetOffset);
			IMotorAirCurrentConfig.AddDirection(builder, DirectionOffset);
			return IMotorAirCurrentConfig.EndIMotorAirCurrentConfig(builder);
		}

		// Token: 0x0602935B RID: 168795 RVA: 0x005A7331 File Offset: 0x005A5531
		public static void StartIMotorAirCurrentConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602935C RID: 168796 RVA: 0x005A733A File Offset: 0x005A553A
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(0, directionOffset.Value, 0);
		}

		// Token: 0x0602935D RID: 168797 RVA: 0x005A734A File Offset: 0x005A554A
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x0602935E RID: 168798 RVA: 0x005A735A File Offset: 0x005A555A
		public static void AddWindFieldDepth(FlatBufferBuilder builder, float windFieldDepth)
		{
			builder.AddFloat(2, windFieldDepth, 0.0);
		}

		// Token: 0x0602935F RID: 168799 RVA: 0x005A736D File Offset: 0x005A556D
		public static void AddMaxAdditionalSpeed(FlatBufferBuilder builder, float maxAdditionalSpeed)
		{
			builder.AddFloat(3, maxAdditionalSpeed, 0.0);
		}

		// Token: 0x06029360 RID: 168800 RVA: 0x005A7380 File Offset: 0x005A5580
		public static void AddSpeedCurve(FlatBufferBuilder builder, StringOffset speedCurveOffset)
		{
			builder.AddOffset(4, speedCurveOffset.Value, 0);
		}

		// Token: 0x06029361 RID: 168801 RVA: 0x005A7390 File Offset: 0x005A5590
		public static void AddSpeedTolerance(FlatBufferBuilder builder, float speedTolerance)
		{
			builder.AddFloat(5, speedTolerance, 0.0);
		}

		// Token: 0x06029362 RID: 168802 RVA: 0x005A73A3 File Offset: 0x005A55A3
		public static Offset<IMotorAirCurrentConfig> EndIMotorAirCurrentConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorAirCurrentConfig>(builder.EndTable());
		}

		// Token: 0x06029363 RID: 168803 RVA: 0x005A73B0 File Offset: 0x005A55B0
		public IMotorAirCurrentConfigT UnPack()
		{
			IMotorAirCurrentConfigT motorAirCurrentConfigT = new IMotorAirCurrentConfigT();
			this.UnPackTo(motorAirCurrentConfigT);
			return motorAirCurrentConfigT;
		}

		// Token: 0x06029364 RID: 168804 RVA: 0x005A73CC File Offset: 0x005A55CC
		public void UnPackTo(IMotorAirCurrentConfigT _o)
		{
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.WindFieldDepth = this.WindFieldDepth;
			_o.MaxAdditionalSpeed = this.MaxAdditionalSpeed;
			_o.SpeedCurve = this.SpeedCurve;
			_o.SpeedTolerance = this.SpeedTolerance;
		}

		// Token: 0x06029365 RID: 168805 RVA: 0x005A7468 File Offset: 0x005A5668
		public static Offset<IMotorAirCurrentConfig> Pack(FlatBufferBuilder builder, IMotorAirCurrentConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorAirCurrentConfig>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			StringOffset speedCurveOffset = (_o.SpeedCurve == null) ? default(StringOffset) : builder.CreateString(_o.SpeedCurve);
			return IMotorAirCurrentConfig.CreateIMotorAirCurrentConfig(builder, directionOffset, offsetOffset, _o.WindFieldDepth, _o.MaxAdditionalSpeed, speedCurveOffset, _o.SpeedTolerance);
		}

		// Token: 0x0400F7FB RID: 63483
		private Table __p;
	}
}
