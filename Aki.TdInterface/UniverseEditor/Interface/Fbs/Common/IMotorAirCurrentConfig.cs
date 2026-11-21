using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006446 RID: 25670
	public struct IMotorAirCurrentConfig : IFlatbufferObject
	{
		// Token: 0x1700BD81 RID: 48513
		// (get) Token: 0x0602B9D6 RID: 178646 RVA: 0x005EFDDC File Offset: 0x005EDFDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B9D7 RID: 178647 RVA: 0x005EFDE9 File Offset: 0x005EDFE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B9D8 RID: 178648 RVA: 0x005EFDF0 File Offset: 0x005EDFF0
		public static IMotorAirCurrentConfig GetRootAsIMotorAirCurrentConfig(ByteBuffer _bb)
		{
			return IMotorAirCurrentConfig.GetRootAsIMotorAirCurrentConfig(_bb, default(IMotorAirCurrentConfig));
		}

		// Token: 0x0602B9D9 RID: 178649 RVA: 0x005EFE0C File Offset: 0x005EE00C
		public static IMotorAirCurrentConfig GetRootAsIMotorAirCurrentConfig(ByteBuffer _bb, IMotorAirCurrentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B9DA RID: 178650 RVA: 0x005EFE29 File Offset: 0x005EE029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B9DB RID: 178651 RVA: 0x005EFE38 File Offset: 0x005EE038
		public IMotorAirCurrentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD82 RID: 48514
		// (get) Token: 0x0602B9DC RID: 178652 RVA: 0x005EFE48 File Offset: 0x005EE048
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

		// Token: 0x1700BD83 RID: 48515
		// (get) Token: 0x0602B9DD RID: 178653 RVA: 0x005EFEA8 File Offset: 0x005EE0A8
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

		// Token: 0x1700BD84 RID: 48516
		// (get) Token: 0x0602B9DE RID: 178654 RVA: 0x005EFF08 File Offset: 0x005EE108
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

		// Token: 0x1700BD85 RID: 48517
		// (get) Token: 0x0602B9DF RID: 178655 RVA: 0x005EFF48 File Offset: 0x005EE148
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

		// Token: 0x1700BD86 RID: 48518
		// (get) Token: 0x0602B9E0 RID: 178656 RVA: 0x005EFF8C File Offset: 0x005EE18C
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

		// Token: 0x0602B9E1 RID: 178657 RVA: 0x005EFFC4 File Offset: 0x005EE1C4
		public Span<byte> GetSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602B9E2 RID: 178658 RVA: 0x005EFFD4 File Offset: 0x005EE1D4
		public byte[] GetSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700BD87 RID: 48519
		// (get) Token: 0x0602B9E3 RID: 178659 RVA: 0x005EFFE4 File Offset: 0x005EE1E4
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

		// Token: 0x0602B9E4 RID: 178660 RVA: 0x005F0025 File Offset: 0x005EE225
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

		// Token: 0x0602B9E5 RID: 178661 RVA: 0x005F0061 File Offset: 0x005EE261
		public static void StartIMotorAirCurrentConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602B9E6 RID: 178662 RVA: 0x005F006A File Offset: 0x005EE26A
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(0, directionOffset.Value, 0);
		}

		// Token: 0x0602B9E7 RID: 178663 RVA: 0x005F007A File Offset: 0x005EE27A
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x0602B9E8 RID: 178664 RVA: 0x005F008A File Offset: 0x005EE28A
		public static void AddWindFieldDepth(FlatBufferBuilder builder, float windFieldDepth)
		{
			builder.AddFloat(2, windFieldDepth, 0.0);
		}

		// Token: 0x0602B9E9 RID: 178665 RVA: 0x005F009D File Offset: 0x005EE29D
		public static void AddMaxAdditionalSpeed(FlatBufferBuilder builder, float maxAdditionalSpeed)
		{
			builder.AddFloat(3, maxAdditionalSpeed, 0.0);
		}

		// Token: 0x0602B9EA RID: 178666 RVA: 0x005F00B0 File Offset: 0x005EE2B0
		public static void AddSpeedCurve(FlatBufferBuilder builder, StringOffset speedCurveOffset)
		{
			builder.AddOffset(4, speedCurveOffset.Value, 0);
		}

		// Token: 0x0602B9EB RID: 178667 RVA: 0x005F00C0 File Offset: 0x005EE2C0
		public static void AddSpeedTolerance(FlatBufferBuilder builder, float speedTolerance)
		{
			builder.AddFloat(5, speedTolerance, 0.0);
		}

		// Token: 0x0602B9EC RID: 178668 RVA: 0x005F00D3 File Offset: 0x005EE2D3
		public static Offset<IMotorAirCurrentConfig> EndIMotorAirCurrentConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorAirCurrentConfig>(builder.EndTable());
		}

		// Token: 0x0602B9ED RID: 178669 RVA: 0x005F00E0 File Offset: 0x005EE2E0
		public IMotorAirCurrentConfigT UnPack()
		{
			IMotorAirCurrentConfigT motorAirCurrentConfigT = new IMotorAirCurrentConfigT();
			this.UnPackTo(motorAirCurrentConfigT);
			return motorAirCurrentConfigT;
		}

		// Token: 0x0602B9EE RID: 178670 RVA: 0x005F00FC File Offset: 0x005EE2FC
		public void UnPackTo(IMotorAirCurrentConfigT _o)
		{
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.WindFieldDepth = this.WindFieldDepth;
			_o.MaxAdditionalSpeed = this.MaxAdditionalSpeed;
			_o.SpeedCurve = this.SpeedCurve;
			_o.SpeedTolerance = this.SpeedTolerance;
		}

		// Token: 0x0602B9EF RID: 178671 RVA: 0x005F0198 File Offset: 0x005EE398
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

		// Token: 0x04010556 RID: 66902
		private Table __p;
	}
}
