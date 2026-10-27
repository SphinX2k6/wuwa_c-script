using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D62 RID: 28002
	public struct IPosA : IFlatbufferObject
	{
		// Token: 0x1700D0D0 RID: 53456
		// (get) Token: 0x06031710 RID: 202512 RVA: 0x006B41B0 File Offset: 0x006B23B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031711 RID: 202513 RVA: 0x006B41BD File Offset: 0x006B23BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031712 RID: 202514 RVA: 0x006B41C4 File Offset: 0x006B23C4
		public static IPosA GetRootAsIPosA(ByteBuffer _bb)
		{
			return IPosA.GetRootAsIPosA(_bb, default(IPosA));
		}

		// Token: 0x06031713 RID: 202515 RVA: 0x006B41E0 File Offset: 0x006B23E0
		public static IPosA GetRootAsIPosA(ByteBuffer _bb, IPosA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031714 RID: 202516 RVA: 0x006B41FD File Offset: 0x006B23FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031715 RID: 202517 RVA: 0x006B420C File Offset: 0x006B240C
		public IPosA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0D1 RID: 53457
		// (get) Token: 0x06031716 RID: 202518 RVA: 0x006B421C File Offset: 0x006B241C
		public float X
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

		// Token: 0x1700D0D2 RID: 53458
		// (get) Token: 0x06031717 RID: 202519 RVA: 0x006B425C File Offset: 0x006B245C
		public float Y
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

		// Token: 0x1700D0D3 RID: 53459
		// (get) Token: 0x06031718 RID: 202520 RVA: 0x006B429C File Offset: 0x006B249C
		public float Z
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

		// Token: 0x1700D0D4 RID: 53460
		// (get) Token: 0x06031719 RID: 202521 RVA: 0x006B42DC File Offset: 0x006B24DC
		public float A
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

		// Token: 0x1700D0D5 RID: 53461
		// (get) Token: 0x0603171A RID: 202522 RVA: 0x006B4320 File Offset: 0x006B2520
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603171B RID: 202523 RVA: 0x006B435D File Offset: 0x006B255D
		public static Offset<IPosA> CreateIPosA(FlatBufferBuilder builder, float X = 0f, float Y = 0f, float Z = 0f, float A = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPosA.AddA(builder, A);
			IPosA.AddZ(builder, Z);
			IPosA.AddY(builder, Y);
			IPosA.AddX(builder, X);
			IPosA.AddNullMask(builder, NullMask);
			return IPosA.EndIPosA(builder);
		}

		// Token: 0x0603171C RID: 202524 RVA: 0x006B4391 File Offset: 0x006B2591
		public static void StartIPosA(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603171D RID: 202525 RVA: 0x006B439A File Offset: 0x006B259A
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x0603171E RID: 202526 RVA: 0x006B43AD File Offset: 0x006B25AD
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x0603171F RID: 202527 RVA: 0x006B43C0 File Offset: 0x006B25C0
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x06031720 RID: 202528 RVA: 0x006B43D3 File Offset: 0x006B25D3
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x06031721 RID: 202529 RVA: 0x006B43E6 File Offset: 0x006B25E6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06031722 RID: 202530 RVA: 0x006B43F1 File Offset: 0x006B25F1
		public static Offset<IPosA> EndIPosA(FlatBufferBuilder builder)
		{
			return new Offset<IPosA>(builder.EndTable());
		}

		// Token: 0x06031723 RID: 202531 RVA: 0x006B4400 File Offset: 0x006B2600
		public IPosAT UnPack()
		{
			IPosAT posAT = new IPosAT();
			this.UnPackTo(posAT);
			return posAT;
		}

		// Token: 0x06031724 RID: 202532 RVA: 0x006B441B File Offset: 0x006B261B
		public void UnPackTo(IPosAT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.A = this.A;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031725 RID: 202533 RVA: 0x006B445C File Offset: 0x006B265C
		public static Offset<IPosA> Pack(FlatBufferBuilder builder, IPosAT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosA>);
			}
			return IPosA.CreateIPosA(builder, _o.X, _o.Y, _o.Z, _o.A, _o.NullMask);
		}

		// Token: 0x04011717 RID: 71447
		private Table __p;
	}
}
