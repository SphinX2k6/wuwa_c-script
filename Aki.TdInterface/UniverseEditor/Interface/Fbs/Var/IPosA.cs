using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EB3 RID: 16051
	public struct IPosA : IFlatbufferObject
	{
		// Token: 0x17006C9F RID: 27807
		// (get) Token: 0x06015B56 RID: 88918 RVA: 0x003201AA File Offset: 0x0031E3AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015B57 RID: 88919 RVA: 0x003201B7 File Offset: 0x0031E3B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015B58 RID: 88920 RVA: 0x003201C0 File Offset: 0x0031E3C0
		public static IPosA GetRootAsIPosA(ByteBuffer _bb)
		{
			return IPosA.GetRootAsIPosA(_bb, default(IPosA));
		}

		// Token: 0x06015B59 RID: 88921 RVA: 0x003201DC File Offset: 0x0031E3DC
		public static IPosA GetRootAsIPosA(ByteBuffer _bb, IPosA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015B5A RID: 88922 RVA: 0x003201F9 File Offset: 0x0031E3F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015B5B RID: 88923 RVA: 0x00320208 File Offset: 0x0031E408
		public IPosA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CA0 RID: 27808
		// (get) Token: 0x06015B5C RID: 88924 RVA: 0x00320218 File Offset: 0x0031E418
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

		// Token: 0x17006CA1 RID: 27809
		// (get) Token: 0x06015B5D RID: 88925 RVA: 0x00320258 File Offset: 0x0031E458
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

		// Token: 0x17006CA2 RID: 27810
		// (get) Token: 0x06015B5E RID: 88926 RVA: 0x00320298 File Offset: 0x0031E498
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

		// Token: 0x17006CA3 RID: 27811
		// (get) Token: 0x06015B5F RID: 88927 RVA: 0x003202D8 File Offset: 0x0031E4D8
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

		// Token: 0x17006CA4 RID: 27812
		// (get) Token: 0x06015B60 RID: 88928 RVA: 0x0032031C File Offset: 0x0031E51C
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

		// Token: 0x06015B61 RID: 88929 RVA: 0x00320359 File Offset: 0x0031E559
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

		// Token: 0x06015B62 RID: 88930 RVA: 0x0032038D File Offset: 0x0031E58D
		public static void StartIPosA(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015B63 RID: 88931 RVA: 0x00320396 File Offset: 0x0031E596
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x06015B64 RID: 88932 RVA: 0x003203A9 File Offset: 0x0031E5A9
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x06015B65 RID: 88933 RVA: 0x003203BC File Offset: 0x0031E5BC
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x06015B66 RID: 88934 RVA: 0x003203CF File Offset: 0x0031E5CF
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x06015B67 RID: 88935 RVA: 0x003203E2 File Offset: 0x0031E5E2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06015B68 RID: 88936 RVA: 0x003203ED File Offset: 0x0031E5ED
		public static Offset<IPosA> EndIPosA(FlatBufferBuilder builder)
		{
			return new Offset<IPosA>(builder.EndTable());
		}

		// Token: 0x06015B69 RID: 88937 RVA: 0x003203FC File Offset: 0x0031E5FC
		public IPosAT UnPack()
		{
			IPosAT posAT = new IPosAT();
			this.UnPackTo(posAT);
			return posAT;
		}

		// Token: 0x06015B6A RID: 88938 RVA: 0x00320417 File Offset: 0x0031E617
		public void UnPackTo(IPosAT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.A = this.A;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015B6B RID: 88939 RVA: 0x00320458 File Offset: 0x0031E658
		public static Offset<IPosA> Pack(FlatBufferBuilder builder, IPosAT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosA>);
			}
			return IPosA.CreateIPosA(builder, _o.X, _o.Y, _o.Z, _o.A, _o.NullMask);
		}

		// Token: 0x0400B8B4 RID: 47284
		private Table __p;
	}
}
