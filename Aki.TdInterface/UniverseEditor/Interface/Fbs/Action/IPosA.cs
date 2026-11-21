using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074DD RID: 29917
	public struct IPosA : IFlatbufferObject
	{
		// Token: 0x1700DC18 RID: 56344
		// (get) Token: 0x0603470C RID: 214796 RVA: 0x0070F898 File Offset: 0x0070DA98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603470D RID: 214797 RVA: 0x0070F8A5 File Offset: 0x0070DAA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603470E RID: 214798 RVA: 0x0070F8AC File Offset: 0x0070DAAC
		public static IPosA GetRootAsIPosA(ByteBuffer _bb)
		{
			return IPosA.GetRootAsIPosA(_bb, default(IPosA));
		}

		// Token: 0x0603470F RID: 214799 RVA: 0x0070F8C8 File Offset: 0x0070DAC8
		public static IPosA GetRootAsIPosA(ByteBuffer _bb, IPosA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034710 RID: 214800 RVA: 0x0070F8E5 File Offset: 0x0070DAE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034711 RID: 214801 RVA: 0x0070F8F4 File Offset: 0x0070DAF4
		public IPosA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC19 RID: 56345
		// (get) Token: 0x06034712 RID: 214802 RVA: 0x0070F904 File Offset: 0x0070DB04
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

		// Token: 0x1700DC1A RID: 56346
		// (get) Token: 0x06034713 RID: 214803 RVA: 0x0070F944 File Offset: 0x0070DB44
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

		// Token: 0x1700DC1B RID: 56347
		// (get) Token: 0x06034714 RID: 214804 RVA: 0x0070F984 File Offset: 0x0070DB84
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

		// Token: 0x1700DC1C RID: 56348
		// (get) Token: 0x06034715 RID: 214805 RVA: 0x0070F9C4 File Offset: 0x0070DBC4
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

		// Token: 0x1700DC1D RID: 56349
		// (get) Token: 0x06034716 RID: 214806 RVA: 0x0070FA08 File Offset: 0x0070DC08
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

		// Token: 0x06034717 RID: 214807 RVA: 0x0070FA45 File Offset: 0x0070DC45
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

		// Token: 0x06034718 RID: 214808 RVA: 0x0070FA79 File Offset: 0x0070DC79
		public static void StartIPosA(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06034719 RID: 214809 RVA: 0x0070FA82 File Offset: 0x0070DC82
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x0603471A RID: 214810 RVA: 0x0070FA95 File Offset: 0x0070DC95
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x0603471B RID: 214811 RVA: 0x0070FAA8 File Offset: 0x0070DCA8
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x0603471C RID: 214812 RVA: 0x0070FABB File Offset: 0x0070DCBB
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x0603471D RID: 214813 RVA: 0x0070FACE File Offset: 0x0070DCCE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603471E RID: 214814 RVA: 0x0070FAD9 File Offset: 0x0070DCD9
		public static Offset<IPosA> EndIPosA(FlatBufferBuilder builder)
		{
			return new Offset<IPosA>(builder.EndTable());
		}

		// Token: 0x0603471F RID: 214815 RVA: 0x0070FAE8 File Offset: 0x0070DCE8
		public IPosAT UnPack()
		{
			IPosAT posAT = new IPosAT();
			this.UnPackTo(posAT);
			return posAT;
		}

		// Token: 0x06034720 RID: 214816 RVA: 0x0070FB03 File Offset: 0x0070DD03
		public void UnPackTo(IPosAT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.A = this.A;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034721 RID: 214817 RVA: 0x0070FB44 File Offset: 0x0070DD44
		public static Offset<IPosA> Pack(FlatBufferBuilder builder, IPosAT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosA>);
			}
			return IPosA.CreateIPosA(builder, _o.X, _o.Y, _o.Z, _o.A, _o.NullMask);
		}

		// Token: 0x04012693 RID: 75411
		private Table __p;
	}
}
