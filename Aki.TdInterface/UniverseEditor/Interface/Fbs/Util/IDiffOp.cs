using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Util
{
	// Token: 0x02003F74 RID: 16244
	public struct IDiffOp : IFlatbufferObject
	{
		// Token: 0x17006DD1 RID: 28113
		// (get) Token: 0x060161BB RID: 90555 RVA: 0x0032C0A6 File Offset: 0x0032A2A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060161BC RID: 90556 RVA: 0x0032C0B3 File Offset: 0x0032A2B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060161BD RID: 90557 RVA: 0x0032C0BC File Offset: 0x0032A2BC
		public static IDiffOp GetRootAsIDiffOp(ByteBuffer _bb)
		{
			return IDiffOp.GetRootAsIDiffOp(_bb, default(IDiffOp));
		}

		// Token: 0x060161BE RID: 90558 RVA: 0x0032C0D8 File Offset: 0x0032A2D8
		public static IDiffOp GetRootAsIDiffOp(ByteBuffer _bb, IDiffOp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060161BF RID: 90559 RVA: 0x0032C0F5 File Offset: 0x0032A2F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060161C0 RID: 90560 RVA: 0x0032C104 File Offset: 0x0032A304
		public IDiffOp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DD2 RID: 28114
		// (get) Token: 0x060161C1 RID: 90561 RVA: 0x0032C114 File Offset: 0x0032A314
		public EDiffOp Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDiffOp.Same;
				}
				return (EDiffOp)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006DD3 RID: 28115
		// (get) Token: 0x060161C2 RID: 90562 RVA: 0x0032C150 File Offset: 0x0032A350
		public int Length
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006DD4 RID: 28116
		// (get) Token: 0x060161C3 RID: 90563 RVA: 0x0032C18C File Offset: 0x0032A38C
		public IDiffOp? PreOp
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IDiffOp?(default(IDiffOp).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060161C4 RID: 90564 RVA: 0x0032C1E9 File Offset: 0x0032A3E9
		public static Offset<IDiffOp> CreateIDiffOp(FlatBufferBuilder builder, EDiffOp Type = EDiffOp.Same, int Length = 0, Offset<IDiffOp> PreOpOffset = default(Offset<IDiffOp>))
		{
			builder.StartTable(3);
			IDiffOp.AddPreOp(builder, PreOpOffset);
			IDiffOp.AddLength(builder, Length);
			IDiffOp.AddType(builder, Type);
			return IDiffOp.EndIDiffOp(builder);
		}

		// Token: 0x060161C5 RID: 90565 RVA: 0x0032C20D File Offset: 0x0032A40D
		public static void StartIDiffOp(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060161C6 RID: 90566 RVA: 0x0032C216 File Offset: 0x0032A416
		public static void AddType(FlatBufferBuilder builder, EDiffOp type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060161C7 RID: 90567 RVA: 0x0032C221 File Offset: 0x0032A421
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(1, length, 0);
		}

		// Token: 0x060161C8 RID: 90568 RVA: 0x0032C22C File Offset: 0x0032A42C
		public static void AddPreOp(FlatBufferBuilder builder, Offset<IDiffOp> preOpOffset)
		{
			builder.AddOffset(2, preOpOffset.Value, 0);
		}

		// Token: 0x060161C9 RID: 90569 RVA: 0x0032C23C File Offset: 0x0032A43C
		public static Offset<IDiffOp> EndIDiffOp(FlatBufferBuilder builder)
		{
			return new Offset<IDiffOp>(builder.EndTable());
		}

		// Token: 0x060161CA RID: 90570 RVA: 0x0032C24C File Offset: 0x0032A44C
		public IDiffOpT UnPack()
		{
			IDiffOpT diffOpT = new IDiffOpT();
			this.UnPackTo(diffOpT);
			return diffOpT;
		}

		// Token: 0x060161CB RID: 90571 RVA: 0x0032C268 File Offset: 0x0032A468
		public void UnPackTo(IDiffOpT _o)
		{
			_o.Type = this.Type;
			_o.Length = this.Length;
			_o.PreOp = ((this.PreOp != null) ? this.PreOp.Value.UnPack() : null);
		}

		// Token: 0x060161CC RID: 90572 RVA: 0x0032C2BC File Offset: 0x0032A4BC
		public static Offset<IDiffOp> Pack(FlatBufferBuilder builder, IDiffOpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDiffOp>);
			}
			Offset<IDiffOp> preOpOffset = (_o.PreOp == null) ? default(Offset<IDiffOp>) : IDiffOp.Pack(builder, _o.PreOp);
			return IDiffOp.CreateIDiffOp(builder, _o.Type, _o.Length, preOpOffset);
		}

		// Token: 0x0400BA20 RID: 47648
		private Table __p;
	}
}
