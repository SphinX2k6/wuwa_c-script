using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AB1 RID: 15025
	public struct IPosA : IFlatbufferObject
	{
		// Token: 0x17006704 RID: 26372
		// (get) Token: 0x060146AC RID: 83628 RVA: 0x002F9F1A File Offset: 0x002F811A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060146AD RID: 83629 RVA: 0x002F9F27 File Offset: 0x002F8127
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060146AE RID: 83630 RVA: 0x002F9F30 File Offset: 0x002F8130
		public static IPosA GetRootAsIPosA(ByteBuffer _bb)
		{
			return IPosA.GetRootAsIPosA(_bb, default(IPosA));
		}

		// Token: 0x060146AF RID: 83631 RVA: 0x002F9F4C File Offset: 0x002F814C
		public static IPosA GetRootAsIPosA(ByteBuffer _bb, IPosA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060146B0 RID: 83632 RVA: 0x002F9F69 File Offset: 0x002F8169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060146B1 RID: 83633 RVA: 0x002F9F78 File Offset: 0x002F8178
		public IPosA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006705 RID: 26373
		// (get) Token: 0x060146B2 RID: 83634 RVA: 0x002F9F88 File Offset: 0x002F8188
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

		// Token: 0x17006706 RID: 26374
		// (get) Token: 0x060146B3 RID: 83635 RVA: 0x002F9FC8 File Offset: 0x002F81C8
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

		// Token: 0x17006707 RID: 26375
		// (get) Token: 0x060146B4 RID: 83636 RVA: 0x002FA008 File Offset: 0x002F8208
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

		// Token: 0x17006708 RID: 26376
		// (get) Token: 0x060146B5 RID: 83637 RVA: 0x002FA048 File Offset: 0x002F8248
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

		// Token: 0x17006709 RID: 26377
		// (get) Token: 0x060146B6 RID: 83638 RVA: 0x002FA08C File Offset: 0x002F828C
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

		// Token: 0x060146B7 RID: 83639 RVA: 0x002FA0C9 File Offset: 0x002F82C9
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

		// Token: 0x060146B8 RID: 83640 RVA: 0x002FA0FD File Offset: 0x002F82FD
		public static void StartIPosA(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060146B9 RID: 83641 RVA: 0x002FA106 File Offset: 0x002F8306
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x060146BA RID: 83642 RVA: 0x002FA119 File Offset: 0x002F8319
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x060146BB RID: 83643 RVA: 0x002FA12C File Offset: 0x002F832C
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x060146BC RID: 83644 RVA: 0x002FA13F File Offset: 0x002F833F
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x060146BD RID: 83645 RVA: 0x002FA152 File Offset: 0x002F8352
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060146BE RID: 83646 RVA: 0x002FA15D File Offset: 0x002F835D
		public static Offset<IPosA> EndIPosA(FlatBufferBuilder builder)
		{
			return new Offset<IPosA>(builder.EndTable());
		}

		// Token: 0x060146BF RID: 83647 RVA: 0x002FA16C File Offset: 0x002F836C
		public IPosAT UnPack()
		{
			IPosAT posAT = new IPosAT();
			this.UnPackTo(posAT);
			return posAT;
		}

		// Token: 0x060146C0 RID: 83648 RVA: 0x002FA187 File Offset: 0x002F8387
		public void UnPackTo(IPosAT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.A = this.A;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060146C1 RID: 83649 RVA: 0x002FA1C8 File Offset: 0x002F83C8
		public static Offset<IPosA> Pack(FlatBufferBuilder builder, IPosAT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosA>);
			}
			return IPosA.CreateIPosA(builder, _o.X, _o.Y, _o.Z, _o.A, _o.NullMask);
		}

		// Token: 0x0400AF47 RID: 44871
		private Table __p;
	}
}
