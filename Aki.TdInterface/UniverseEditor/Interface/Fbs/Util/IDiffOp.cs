using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Util
{
	// Token: 0x02003B6C RID: 15212
	public struct IDiffOp : IFlatbufferObject
	{
		// Token: 0x17006832 RID: 26674
		// (get) Token: 0x06014CF1 RID: 85233 RVA: 0x00305B0E File Offset: 0x00303D0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014CF2 RID: 85234 RVA: 0x00305B1B File Offset: 0x00303D1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014CF3 RID: 85235 RVA: 0x00305B24 File Offset: 0x00303D24
		public static IDiffOp GetRootAsIDiffOp(ByteBuffer _bb)
		{
			return IDiffOp.GetRootAsIDiffOp(_bb, default(IDiffOp));
		}

		// Token: 0x06014CF4 RID: 85236 RVA: 0x00305B40 File Offset: 0x00303D40
		public static IDiffOp GetRootAsIDiffOp(ByteBuffer _bb, IDiffOp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014CF5 RID: 85237 RVA: 0x00305B5D File Offset: 0x00303D5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014CF6 RID: 85238 RVA: 0x00305B6C File Offset: 0x00303D6C
		public IDiffOp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006833 RID: 26675
		// (get) Token: 0x06014CF7 RID: 85239 RVA: 0x00305B7C File Offset: 0x00303D7C
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

		// Token: 0x17006834 RID: 26676
		// (get) Token: 0x06014CF8 RID: 85240 RVA: 0x00305BB8 File Offset: 0x00303DB8
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

		// Token: 0x17006835 RID: 26677
		// (get) Token: 0x06014CF9 RID: 85241 RVA: 0x00305BF4 File Offset: 0x00303DF4
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

		// Token: 0x06014CFA RID: 85242 RVA: 0x00305C51 File Offset: 0x00303E51
		public static Offset<IDiffOp> CreateIDiffOp(FlatBufferBuilder builder, EDiffOp Type = EDiffOp.Same, int Length = 0, Offset<IDiffOp> PreOpOffset = default(Offset<IDiffOp>))
		{
			builder.StartTable(3);
			IDiffOp.AddPreOp(builder, PreOpOffset);
			IDiffOp.AddLength(builder, Length);
			IDiffOp.AddType(builder, Type);
			return IDiffOp.EndIDiffOp(builder);
		}

		// Token: 0x06014CFB RID: 85243 RVA: 0x00305C75 File Offset: 0x00303E75
		public static void StartIDiffOp(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014CFC RID: 85244 RVA: 0x00305C7E File Offset: 0x00303E7E
		public static void AddType(FlatBufferBuilder builder, EDiffOp type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014CFD RID: 85245 RVA: 0x00305C89 File Offset: 0x00303E89
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(1, length, 0);
		}

		// Token: 0x06014CFE RID: 85246 RVA: 0x00305C94 File Offset: 0x00303E94
		public static void AddPreOp(FlatBufferBuilder builder, Offset<IDiffOp> preOpOffset)
		{
			builder.AddOffset(2, preOpOffset.Value, 0);
		}

		// Token: 0x06014CFF RID: 85247 RVA: 0x00305CA4 File Offset: 0x00303EA4
		public static Offset<IDiffOp> EndIDiffOp(FlatBufferBuilder builder)
		{
			return new Offset<IDiffOp>(builder.EndTable());
		}

		// Token: 0x06014D00 RID: 85248 RVA: 0x00305CB4 File Offset: 0x00303EB4
		public IDiffOpT UnPack()
		{
			IDiffOpT diffOpT = new IDiffOpT();
			this.UnPackTo(diffOpT);
			return diffOpT;
		}

		// Token: 0x06014D01 RID: 85249 RVA: 0x00305CD0 File Offset: 0x00303ED0
		public void UnPackTo(IDiffOpT _o)
		{
			_o.Type = this.Type;
			_o.Length = this.Length;
			_o.PreOp = ((this.PreOp != null) ? this.PreOp.Value.UnPack() : null);
		}

		// Token: 0x06014D02 RID: 85250 RVA: 0x00305D24 File Offset: 0x00303F24
		public static Offset<IDiffOp> Pack(FlatBufferBuilder builder, IDiffOpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDiffOp>);
			}
			Offset<IDiffOp> preOpOffset = (_o.PreOp == null) ? default(Offset<IDiffOp>) : IDiffOp.Pack(builder, _o.PreOp);
			return IDiffOp.CreateIDiffOp(builder, _o.Type, _o.Length, preOpOffset);
		}

		// Token: 0x0400B0A3 RID: 45219
		private Table __p;
	}
}
