using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EA1 RID: 16033
	public struct IIntVector2 : IFlatbufferObject
	{
		// Token: 0x17006C6A RID: 27754
		// (get) Token: 0x06015A8E RID: 88718 RVA: 0x0031EB66 File Offset: 0x0031CD66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015A8F RID: 88719 RVA: 0x0031EB73 File Offset: 0x0031CD73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015A90 RID: 88720 RVA: 0x0031EB7C File Offset: 0x0031CD7C
		public static IIntVector2 GetRootAsIIntVector2(ByteBuffer _bb)
		{
			return IIntVector2.GetRootAsIIntVector2(_bb, default(IIntVector2));
		}

		// Token: 0x06015A91 RID: 88721 RVA: 0x0031EB98 File Offset: 0x0031CD98
		public static IIntVector2 GetRootAsIIntVector2(ByteBuffer _bb, IIntVector2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015A92 RID: 88722 RVA: 0x0031EBB5 File Offset: 0x0031CDB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015A93 RID: 88723 RVA: 0x0031EBC4 File Offset: 0x0031CDC4
		public IIntVector2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C6B RID: 27755
		// (get) Token: 0x06015A94 RID: 88724 RVA: 0x0031EBD4 File Offset: 0x0031CDD4
		public int X
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C6C RID: 27756
		// (get) Token: 0x06015A95 RID: 88725 RVA: 0x0031EC10 File Offset: 0x0031CE10
		public int Y
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

		// Token: 0x17006C6D RID: 27757
		// (get) Token: 0x06015A96 RID: 88726 RVA: 0x0031EC4C File Offset: 0x0031CE4C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015A97 RID: 88727 RVA: 0x0031EC88 File Offset: 0x0031CE88
		public static Offset<IIntVector2> CreateIIntVector2(FlatBufferBuilder builder, int X = 0, int Y = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IIntVector2.AddY(builder, Y);
			IIntVector2.AddX(builder, X);
			IIntVector2.AddNullMask(builder, NullMask);
			return IIntVector2.EndIIntVector2(builder);
		}

		// Token: 0x06015A98 RID: 88728 RVA: 0x0031ECAC File Offset: 0x0031CEAC
		public static void StartIIntVector2(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015A99 RID: 88729 RVA: 0x0031ECB5 File Offset: 0x0031CEB5
		public static void AddX(FlatBufferBuilder builder, int x)
		{
			builder.AddInt(0, x, 0);
		}

		// Token: 0x06015A9A RID: 88730 RVA: 0x0031ECC0 File Offset: 0x0031CEC0
		public static void AddY(FlatBufferBuilder builder, int y)
		{
			builder.AddInt(1, y, 0);
		}

		// Token: 0x06015A9B RID: 88731 RVA: 0x0031ECCB File Offset: 0x0031CECB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06015A9C RID: 88732 RVA: 0x0031ECD6 File Offset: 0x0031CED6
		public static Offset<IIntVector2> EndIIntVector2(FlatBufferBuilder builder)
		{
			return new Offset<IIntVector2>(builder.EndTable());
		}

		// Token: 0x06015A9D RID: 88733 RVA: 0x0031ECE4 File Offset: 0x0031CEE4
		public IIntVector2T UnPack()
		{
			IIntVector2T intVector2T = new IIntVector2T();
			this.UnPackTo(intVector2T);
			return intVector2T;
		}

		// Token: 0x06015A9E RID: 88734 RVA: 0x0031ECFF File Offset: 0x0031CEFF
		public void UnPackTo(IIntVector2T _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015A9F RID: 88735 RVA: 0x0031ED28 File Offset: 0x0031CF28
		public static Offset<IIntVector2> Pack(FlatBufferBuilder builder, IIntVector2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IIntVector2>);
			}
			return IIntVector2.CreateIIntVector2(builder, _o.X, _o.Y, _o.NullMask);
		}

		// Token: 0x0400B88A RID: 47242
		private Table __p;
	}
}
