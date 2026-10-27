using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005506 RID: 21766
	public struct ILiftMoveCurve : IFlatbufferObject
	{
		// Token: 0x1700A0B2 RID: 41138
		// (get) Token: 0x06023F25 RID: 147237 RVA: 0x004F82BC File Offset: 0x004F64BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023F26 RID: 147238 RVA: 0x004F82C9 File Offset: 0x004F64C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023F27 RID: 147239 RVA: 0x004F82D0 File Offset: 0x004F64D0
		public static ILiftMoveCurve GetRootAsILiftMoveCurve(ByteBuffer _bb)
		{
			return ILiftMoveCurve.GetRootAsILiftMoveCurve(_bb, default(ILiftMoveCurve));
		}

		// Token: 0x06023F28 RID: 147240 RVA: 0x004F82EC File Offset: 0x004F64EC
		public static ILiftMoveCurve GetRootAsILiftMoveCurve(ByteBuffer _bb, ILiftMoveCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023F29 RID: 147241 RVA: 0x004F8309 File Offset: 0x004F6509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023F2A RID: 147242 RVA: 0x004F8318 File Offset: 0x004F6518
		public ILiftMoveCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0B3 RID: 41139
		// (get) Token: 0x06023F2B RID: 147243 RVA: 0x004F8328 File Offset: 0x004F6528
		public string Curve
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023F2C RID: 147244 RVA: 0x004F835F File Offset: 0x004F655F
		public Span<byte> GetCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023F2D RID: 147245 RVA: 0x004F836E File Offset: 0x004F656E
		public byte[] GetCurveArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A0B4 RID: 41140
		// (get) Token: 0x06023F2E RID: 147246 RVA: 0x004F837C File Offset: 0x004F657C
		public float Time
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

		// Token: 0x06023F2F RID: 147247 RVA: 0x004F83BC File Offset: 0x004F65BC
		public static Offset<ILiftMoveCurve> CreateILiftMoveCurve(FlatBufferBuilder builder, StringOffset CurveOffset = default(StringOffset), float Time = 0f)
		{
			builder.StartTable(2);
			ILiftMoveCurve.AddTime(builder, Time);
			ILiftMoveCurve.AddCurve(builder, CurveOffset);
			return ILiftMoveCurve.EndILiftMoveCurve(builder);
		}

		// Token: 0x06023F30 RID: 147248 RVA: 0x004F83D9 File Offset: 0x004F65D9
		public static void StartILiftMoveCurve(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023F31 RID: 147249 RVA: 0x004F83E2 File Offset: 0x004F65E2
		public static void AddCurve(FlatBufferBuilder builder, StringOffset curveOffset)
		{
			builder.AddOffset(0, curveOffset.Value, 0);
		}

		// Token: 0x06023F32 RID: 147250 RVA: 0x004F83F2 File Offset: 0x004F65F2
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06023F33 RID: 147251 RVA: 0x004F8405 File Offset: 0x004F6605
		public static Offset<ILiftMoveCurve> EndILiftMoveCurve(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveCurve>(builder.EndTable());
		}

		// Token: 0x06023F34 RID: 147252 RVA: 0x004F8414 File Offset: 0x004F6614
		public ILiftMoveCurveT UnPack()
		{
			ILiftMoveCurveT liftMoveCurveT = new ILiftMoveCurveT();
			this.UnPackTo(liftMoveCurveT);
			return liftMoveCurveT;
		}

		// Token: 0x06023F35 RID: 147253 RVA: 0x004F842F File Offset: 0x004F662F
		public void UnPackTo(ILiftMoveCurveT _o)
		{
			_o.Curve = this.Curve;
			_o.Time = this.Time;
		}

		// Token: 0x06023F36 RID: 147254 RVA: 0x004F844C File Offset: 0x004F664C
		public static Offset<ILiftMoveCurve> Pack(FlatBufferBuilder builder, ILiftMoveCurveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveCurve>);
			}
			StringOffset curveOffset = (_o.Curve == null) ? default(StringOffset) : builder.CreateString(_o.Curve);
			return ILiftMoveCurve.CreateILiftMoveCurve(builder, curveOffset, _o.Time);
		}

		// Token: 0x0400E7F5 RID: 59381
		private Table __p;
	}
}
