using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FA0 RID: 16288
	public struct IPosA : IFlatbufferObject
	{
		// Token: 0x17006E28 RID: 28200
		// (get) Token: 0x06016320 RID: 90912 RVA: 0x0032E87A File Offset: 0x0032CA7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016321 RID: 90913 RVA: 0x0032E887 File Offset: 0x0032CA87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016322 RID: 90914 RVA: 0x0032E890 File Offset: 0x0032CA90
		public static IPosA GetRootAsIPosA(ByteBuffer _bb)
		{
			return IPosA.GetRootAsIPosA(_bb, default(IPosA));
		}

		// Token: 0x06016323 RID: 90915 RVA: 0x0032E8AC File Offset: 0x0032CAAC
		public static IPosA GetRootAsIPosA(ByteBuffer _bb, IPosA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016324 RID: 90916 RVA: 0x0032E8C9 File Offset: 0x0032CAC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016325 RID: 90917 RVA: 0x0032E8D8 File Offset: 0x0032CAD8
		public IPosA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E29 RID: 28201
		// (get) Token: 0x06016326 RID: 90918 RVA: 0x0032E8E8 File Offset: 0x0032CAE8
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

		// Token: 0x17006E2A RID: 28202
		// (get) Token: 0x06016327 RID: 90919 RVA: 0x0032E928 File Offset: 0x0032CB28
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

		// Token: 0x17006E2B RID: 28203
		// (get) Token: 0x06016328 RID: 90920 RVA: 0x0032E968 File Offset: 0x0032CB68
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

		// Token: 0x17006E2C RID: 28204
		// (get) Token: 0x06016329 RID: 90921 RVA: 0x0032E9A8 File Offset: 0x0032CBA8
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

		// Token: 0x17006E2D RID: 28205
		// (get) Token: 0x0601632A RID: 90922 RVA: 0x0032E9EC File Offset: 0x0032CBEC
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

		// Token: 0x0601632B RID: 90923 RVA: 0x0032EA29 File Offset: 0x0032CC29
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

		// Token: 0x0601632C RID: 90924 RVA: 0x0032EA5D File Offset: 0x0032CC5D
		public static void StartIPosA(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601632D RID: 90925 RVA: 0x0032EA66 File Offset: 0x0032CC66
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x0601632E RID: 90926 RVA: 0x0032EA79 File Offset: 0x0032CC79
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x0601632F RID: 90927 RVA: 0x0032EA8C File Offset: 0x0032CC8C
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x06016330 RID: 90928 RVA: 0x0032EA9F File Offset: 0x0032CC9F
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x06016331 RID: 90929 RVA: 0x0032EAB2 File Offset: 0x0032CCB2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06016332 RID: 90930 RVA: 0x0032EABD File Offset: 0x0032CCBD
		public static Offset<IPosA> EndIPosA(FlatBufferBuilder builder)
		{
			return new Offset<IPosA>(builder.EndTable());
		}

		// Token: 0x06016333 RID: 90931 RVA: 0x0032EACC File Offset: 0x0032CCCC
		public IPosAT UnPack()
		{
			IPosAT posAT = new IPosAT();
			this.UnPackTo(posAT);
			return posAT;
		}

		// Token: 0x06016334 RID: 90932 RVA: 0x0032EAE7 File Offset: 0x0032CCE7
		public void UnPackTo(IPosAT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.A = this.A;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016335 RID: 90933 RVA: 0x0032EB28 File Offset: 0x0032CD28
		public static Offset<IPosA> Pack(FlatBufferBuilder builder, IPosAT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosA>);
			}
			return IPosA.CreateIPosA(builder, _o.X, _o.Y, _o.Z, _o.A, _o.NullMask);
		}

		// Token: 0x0400BA7F RID: 47743
		private Table __p;
	}
}
