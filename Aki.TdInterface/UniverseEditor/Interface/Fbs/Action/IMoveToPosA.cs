using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B63 RID: 27491
	public struct IMoveToPosA : IFlatbufferObject
	{
		// Token: 0x1700CC41 RID: 52289
		// (get) Token: 0x06030425 RID: 197669 RVA: 0x0068EAA3 File Offset: 0x0068CCA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030426 RID: 197670 RVA: 0x0068EAB0 File Offset: 0x0068CCB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030427 RID: 197671 RVA: 0x0068EAB8 File Offset: 0x0068CCB8
		public static IMoveToPosA GetRootAsIMoveToPosA(ByteBuffer _bb)
		{
			return IMoveToPosA.GetRootAsIMoveToPosA(_bb, default(IMoveToPosA));
		}

		// Token: 0x06030428 RID: 197672 RVA: 0x0068EAD4 File Offset: 0x0068CCD4
		public static IMoveToPosA GetRootAsIMoveToPosA(ByteBuffer _bb, IMoveToPosA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030429 RID: 197673 RVA: 0x0068EAF1 File Offset: 0x0068CCF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603042A RID: 197674 RVA: 0x0068EB00 File Offset: 0x0068CD00
		public IMoveToPosA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC42 RID: 52290
		// (get) Token: 0x0603042B RID: 197675 RVA: 0x0068EB10 File Offset: 0x0068CD10
		public float Timeout
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

		// Token: 0x1700CC43 RID: 52291
		// (get) Token: 0x0603042C RID: 197676 RVA: 0x0068EB50 File Offset: 0x0068CD50
		public IPosA? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603042D RID: 197677 RVA: 0x0068EBAD File Offset: 0x0068CDAD
		public static Offset<IMoveToPosA> CreateIMoveToPosA(FlatBufferBuilder builder, float Timeout = 0f, Offset<IPosA> PosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(2);
			IMoveToPosA.AddPos(builder, PosOffset);
			IMoveToPosA.AddTimeout(builder, Timeout);
			return IMoveToPosA.EndIMoveToPosA(builder);
		}

		// Token: 0x0603042E RID: 197678 RVA: 0x0068EBCA File Offset: 0x0068CDCA
		public static void StartIMoveToPosA(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603042F RID: 197679 RVA: 0x0068EBD3 File Offset: 0x0068CDD3
		public static void AddTimeout(FlatBufferBuilder builder, float timeout)
		{
			builder.AddFloat(0, timeout, 0.0);
		}

		// Token: 0x06030430 RID: 197680 RVA: 0x0068EBE6 File Offset: 0x0068CDE6
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06030431 RID: 197681 RVA: 0x0068EBF6 File Offset: 0x0068CDF6
		public static Offset<IMoveToPosA> EndIMoveToPosA(FlatBufferBuilder builder)
		{
			return new Offset<IMoveToPosA>(builder.EndTable());
		}

		// Token: 0x06030432 RID: 197682 RVA: 0x0068EC04 File Offset: 0x0068CE04
		public IMoveToPosAT UnPack()
		{
			IMoveToPosAT moveToPosAT = new IMoveToPosAT();
			this.UnPackTo(moveToPosAT);
			return moveToPosAT;
		}

		// Token: 0x06030433 RID: 197683 RVA: 0x0068EC20 File Offset: 0x0068CE20
		public void UnPackTo(IMoveToPosAT _o)
		{
			_o.Timeout = this.Timeout;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x06030434 RID: 197684 RVA: 0x0068EC68 File Offset: 0x0068CE68
		public static Offset<IMoveToPosA> Pack(FlatBufferBuilder builder, IMoveToPosAT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveToPosA>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return IMoveToPosA.CreateIMoveToPosA(builder, _o.Timeout, posOffset);
		}

		// Token: 0x04011410 RID: 70672
		private Table __p;
	}
}
