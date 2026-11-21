using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B5 RID: 28853
	public struct ILiftMoveTypeCustomSpeed : IFlatbufferObject
	{
		// Token: 0x1700D35D RID: 54109
		// (get) Token: 0x0603219B RID: 205211 RVA: 0x006C7DA9 File Offset: 0x006C5FA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603219C RID: 205212 RVA: 0x006C7DB6 File Offset: 0x006C5FB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603219D RID: 205213 RVA: 0x006C7DC0 File Offset: 0x006C5FC0
		public static ILiftMoveTypeCustomSpeed GetRootAsILiftMoveTypeCustomSpeed(ByteBuffer _bb)
		{
			return ILiftMoveTypeCustomSpeed.GetRootAsILiftMoveTypeCustomSpeed(_bb, default(ILiftMoveTypeCustomSpeed));
		}

		// Token: 0x0603219E RID: 205214 RVA: 0x006C7DDC File Offset: 0x006C5FDC
		public static ILiftMoveTypeCustomSpeed GetRootAsILiftMoveTypeCustomSpeed(ByteBuffer _bb, ILiftMoveTypeCustomSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603219F RID: 205215 RVA: 0x006C7DF9 File Offset: 0x006C5FF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060321A0 RID: 205216 RVA: 0x006C7E08 File Offset: 0x006C6008
		public ILiftMoveTypeCustomSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D35E RID: 54110
		// (get) Token: 0x060321A1 RID: 205217 RVA: 0x006C7E18 File Offset: 0x006C6018
		public ELiftMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiftMoveType.Default;
				}
				return (ELiftMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D35F RID: 54111
		// (get) Token: 0x060321A2 RID: 205218 RVA: 0x006C7E54 File Offset: 0x006C6054
		public float TotalTime
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

		// Token: 0x1700D360 RID: 54112
		// (get) Token: 0x060321A3 RID: 205219 RVA: 0x006C7E94 File Offset: 0x006C6094
		public string TimePathCurve
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060321A4 RID: 205220 RVA: 0x006C7ECB File Offset: 0x006C60CB
		public Span<byte> GetTimePathCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060321A5 RID: 205221 RVA: 0x006C7EDA File Offset: 0x006C60DA
		public byte[] GetTimePathCurveArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060321A6 RID: 205222 RVA: 0x006C7EE8 File Offset: 0x006C60E8
		public static Offset<ILiftMoveTypeCustomSpeed> CreateILiftMoveTypeCustomSpeed(FlatBufferBuilder builder, ELiftMoveType Type = ELiftMoveType.Default, float TotalTime = 0f, StringOffset TimePathCurveOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ILiftMoveTypeCustomSpeed.AddTimePathCurve(builder, TimePathCurveOffset);
			ILiftMoveTypeCustomSpeed.AddTotalTime(builder, TotalTime);
			ILiftMoveTypeCustomSpeed.AddType(builder, Type);
			return ILiftMoveTypeCustomSpeed.EndILiftMoveTypeCustomSpeed(builder);
		}

		// Token: 0x060321A7 RID: 205223 RVA: 0x006C7F0C File Offset: 0x006C610C
		public static void StartILiftMoveTypeCustomSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060321A8 RID: 205224 RVA: 0x006C7F15 File Offset: 0x006C6115
		public static void AddType(FlatBufferBuilder builder, ELiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060321A9 RID: 205225 RVA: 0x006C7F20 File Offset: 0x006C6120
		public static void AddTotalTime(FlatBufferBuilder builder, float totalTime)
		{
			builder.AddFloat(1, totalTime, 0.0);
		}

		// Token: 0x060321AA RID: 205226 RVA: 0x006C7F33 File Offset: 0x006C6133
		public static void AddTimePathCurve(FlatBufferBuilder builder, StringOffset timePathCurveOffset)
		{
			builder.AddOffset(2, timePathCurveOffset.Value, 0);
		}

		// Token: 0x060321AB RID: 205227 RVA: 0x006C7F43 File Offset: 0x006C6143
		public static Offset<ILiftMoveTypeCustomSpeed> EndILiftMoveTypeCustomSpeed(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveTypeCustomSpeed>(builder.EndTable());
		}

		// Token: 0x060321AC RID: 205228 RVA: 0x006C7F50 File Offset: 0x006C6150
		public ILiftMoveTypeCustomSpeedT UnPack()
		{
			ILiftMoveTypeCustomSpeedT liftMoveTypeCustomSpeedT = new ILiftMoveTypeCustomSpeedT();
			this.UnPackTo(liftMoveTypeCustomSpeedT);
			return liftMoveTypeCustomSpeedT;
		}

		// Token: 0x060321AD RID: 205229 RVA: 0x006C7F6B File Offset: 0x006C616B
		public void UnPackTo(ILiftMoveTypeCustomSpeedT _o)
		{
			_o.Type = this.Type;
			_o.TotalTime = this.TotalTime;
			_o.TimePathCurve = this.TimePathCurve;
		}

		// Token: 0x060321AE RID: 205230 RVA: 0x006C7F94 File Offset: 0x006C6194
		public static Offset<ILiftMoveTypeCustomSpeed> Pack(FlatBufferBuilder builder, ILiftMoveTypeCustomSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveTypeCustomSpeed>);
			}
			StringOffset timePathCurveOffset = (_o.TimePathCurve == null) ? default(StringOffset) : builder.CreateString(_o.TimePathCurve);
			return ILiftMoveTypeCustomSpeed.CreateILiftMoveTypeCustomSpeed(builder, _o.Type, _o.TotalTime, timePathCurveOffset);
		}

		// Token: 0x0401206E RID: 73838
		private Table __p;
	}
}
