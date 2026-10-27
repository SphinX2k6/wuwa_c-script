using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AB4 RID: 15028
	public struct IPosAndRot : IFlatbufferObject
	{
		// Token: 0x1700670F RID: 26383
		// (get) Token: 0x060146CE RID: 83662 RVA: 0x002FA304 File Offset: 0x002F8504
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060146CF RID: 83663 RVA: 0x002FA311 File Offset: 0x002F8511
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060146D0 RID: 83664 RVA: 0x002FA318 File Offset: 0x002F8518
		public static IPosAndRot GetRootAsIPosAndRot(ByteBuffer _bb)
		{
			return IPosAndRot.GetRootAsIPosAndRot(_bb, default(IPosAndRot));
		}

		// Token: 0x060146D1 RID: 83665 RVA: 0x002FA334 File Offset: 0x002F8534
		public static IPosAndRot GetRootAsIPosAndRot(ByteBuffer _bb, IPosAndRot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060146D2 RID: 83666 RVA: 0x002FA351 File Offset: 0x002F8551
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060146D3 RID: 83667 RVA: 0x002FA360 File Offset: 0x002F8560
		public IPosAndRot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006710 RID: 26384
		// (get) Token: 0x060146D4 RID: 83668 RVA: 0x002FA370 File Offset: 0x002F8570
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

		// Token: 0x17006711 RID: 26385
		// (get) Token: 0x060146D5 RID: 83669 RVA: 0x002FA3B0 File Offset: 0x002F85B0
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

		// Token: 0x17006712 RID: 26386
		// (get) Token: 0x060146D6 RID: 83670 RVA: 0x002FA3F0 File Offset: 0x002F85F0
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

		// Token: 0x17006713 RID: 26387
		// (get) Token: 0x060146D7 RID: 83671 RVA: 0x002FA430 File Offset: 0x002F8630
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

		// Token: 0x17006714 RID: 26388
		// (get) Token: 0x060146D8 RID: 83672 RVA: 0x002FA474 File Offset: 0x002F8674
		public float Roll
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006715 RID: 26389
		// (get) Token: 0x060146D9 RID: 83673 RVA: 0x002FA4B8 File Offset: 0x002F86B8
		public float Pitch
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

		// Token: 0x17006716 RID: 26390
		// (get) Token: 0x060146DA RID: 83674 RVA: 0x002FA4FC File Offset: 0x002F86FC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060146DB RID: 83675 RVA: 0x002FA53C File Offset: 0x002F873C
		public static Offset<IPosAndRot> CreateIPosAndRot(FlatBufferBuilder builder, float X = 0f, float Y = 0f, float Z = 0f, float A = 0f, float Roll = 0f, float Pitch = 0f, byte NullMask = 0)
		{
			builder.StartTable(7);
			IPosAndRot.AddPitch(builder, Pitch);
			IPosAndRot.AddRoll(builder, Roll);
			IPosAndRot.AddA(builder, A);
			IPosAndRot.AddZ(builder, Z);
			IPosAndRot.AddY(builder, Y);
			IPosAndRot.AddX(builder, X);
			IPosAndRot.AddNullMask(builder, NullMask);
			return IPosAndRot.EndIPosAndRot(builder);
		}

		// Token: 0x060146DC RID: 83676 RVA: 0x002FA58B File Offset: 0x002F878B
		public static void StartIPosAndRot(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060146DD RID: 83677 RVA: 0x002FA594 File Offset: 0x002F8794
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x060146DE RID: 83678 RVA: 0x002FA5A7 File Offset: 0x002F87A7
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x060146DF RID: 83679 RVA: 0x002FA5BA File Offset: 0x002F87BA
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x060146E0 RID: 83680 RVA: 0x002FA5CD File Offset: 0x002F87CD
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x060146E1 RID: 83681 RVA: 0x002FA5E0 File Offset: 0x002F87E0
		public static void AddRoll(FlatBufferBuilder builder, float roll)
		{
			builder.AddFloat(4, roll, 0.0);
		}

		// Token: 0x060146E2 RID: 83682 RVA: 0x002FA5F3 File Offset: 0x002F87F3
		public static void AddPitch(FlatBufferBuilder builder, float pitch)
		{
			builder.AddFloat(5, pitch, 0.0);
		}

		// Token: 0x060146E3 RID: 83683 RVA: 0x002FA606 File Offset: 0x002F8806
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060146E4 RID: 83684 RVA: 0x002FA611 File Offset: 0x002F8811
		public static Offset<IPosAndRot> EndIPosAndRot(FlatBufferBuilder builder)
		{
			return new Offset<IPosAndRot>(builder.EndTable());
		}

		// Token: 0x060146E5 RID: 83685 RVA: 0x002FA620 File Offset: 0x002F8820
		public IPosAndRotT UnPack()
		{
			IPosAndRotT posAndRotT = new IPosAndRotT();
			this.UnPackTo(posAndRotT);
			return posAndRotT;
		}

		// Token: 0x060146E6 RID: 83686 RVA: 0x002FA63C File Offset: 0x002F883C
		public void UnPackTo(IPosAndRotT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.A = this.A;
			_o.Roll = this.Roll;
			_o.Pitch = this.Pitch;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060146E7 RID: 83687 RVA: 0x002FA6A0 File Offset: 0x002F88A0
		public static Offset<IPosAndRot> Pack(FlatBufferBuilder builder, IPosAndRotT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosAndRot>);
			}
			return IPosAndRot.CreateIPosAndRot(builder, _o.X, _o.Y, _o.Z, _o.A, _o.Roll, _o.Pitch, _o.NullMask);
		}

		// Token: 0x0400AF4D RID: 44877
		private Table __p;
	}
}
