using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A8C RID: 23180
	public struct ILiftMoveCurve : IFlatbufferObject
	{
		// Token: 0x1700A8EC RID: 43244
		// (get) Token: 0x06025FDF RID: 155615 RVA: 0x005353E0 File Offset: 0x005335E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025FE0 RID: 155616 RVA: 0x005353ED File Offset: 0x005335ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025FE1 RID: 155617 RVA: 0x005353F4 File Offset: 0x005335F4
		public static ILiftMoveCurve GetRootAsILiftMoveCurve(ByteBuffer _bb)
		{
			return ILiftMoveCurve.GetRootAsILiftMoveCurve(_bb, default(ILiftMoveCurve));
		}

		// Token: 0x06025FE2 RID: 155618 RVA: 0x00535410 File Offset: 0x00533610
		public static ILiftMoveCurve GetRootAsILiftMoveCurve(ByteBuffer _bb, ILiftMoveCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025FE3 RID: 155619 RVA: 0x0053542D File Offset: 0x0053362D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025FE4 RID: 155620 RVA: 0x0053543C File Offset: 0x0053363C
		public ILiftMoveCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8ED RID: 43245
		// (get) Token: 0x06025FE5 RID: 155621 RVA: 0x0053544C File Offset: 0x0053364C
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

		// Token: 0x06025FE6 RID: 155622 RVA: 0x00535483 File Offset: 0x00533683
		public Span<byte> GetCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06025FE7 RID: 155623 RVA: 0x00535492 File Offset: 0x00533692
		public byte[] GetCurveArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A8EE RID: 43246
		// (get) Token: 0x06025FE8 RID: 155624 RVA: 0x005354A0 File Offset: 0x005336A0
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

		// Token: 0x06025FE9 RID: 155625 RVA: 0x005354E0 File Offset: 0x005336E0
		public static Offset<ILiftMoveCurve> CreateILiftMoveCurve(FlatBufferBuilder builder, StringOffset CurveOffset = default(StringOffset), float Time = 0f)
		{
			builder.StartTable(2);
			ILiftMoveCurve.AddTime(builder, Time);
			ILiftMoveCurve.AddCurve(builder, CurveOffset);
			return ILiftMoveCurve.EndILiftMoveCurve(builder);
		}

		// Token: 0x06025FEA RID: 155626 RVA: 0x005354FD File Offset: 0x005336FD
		public static void StartILiftMoveCurve(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025FEB RID: 155627 RVA: 0x00535506 File Offset: 0x00533706
		public static void AddCurve(FlatBufferBuilder builder, StringOffset curveOffset)
		{
			builder.AddOffset(0, curveOffset.Value, 0);
		}

		// Token: 0x06025FEC RID: 155628 RVA: 0x00535516 File Offset: 0x00533716
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06025FED RID: 155629 RVA: 0x00535529 File Offset: 0x00533729
		public static Offset<ILiftMoveCurve> EndILiftMoveCurve(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveCurve>(builder.EndTable());
		}

		// Token: 0x06025FEE RID: 155630 RVA: 0x00535538 File Offset: 0x00533738
		public ILiftMoveCurveT UnPack()
		{
			ILiftMoveCurveT liftMoveCurveT = new ILiftMoveCurveT();
			this.UnPackTo(liftMoveCurveT);
			return liftMoveCurveT;
		}

		// Token: 0x06025FEF RID: 155631 RVA: 0x00535553 File Offset: 0x00533753
		public void UnPackTo(ILiftMoveCurveT _o)
		{
			_o.Curve = this.Curve;
			_o.Time = this.Time;
		}

		// Token: 0x06025FF0 RID: 155632 RVA: 0x00535570 File Offset: 0x00533770
		public static Offset<ILiftMoveCurve> Pack(FlatBufferBuilder builder, ILiftMoveCurveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveCurve>);
			}
			StringOffset curveOffset = (_o.Curve == null) ? default(StringOffset) : builder.CreateString(_o.Curve);
			return ILiftMoveCurve.CreateILiftMoveCurve(builder, curveOffset, _o.Time);
		}

		// Token: 0x0400F426 RID: 62502
		private Table __p;
	}
}
