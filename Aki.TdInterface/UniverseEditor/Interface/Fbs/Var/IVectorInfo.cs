using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F2B RID: 16171
	public struct IVectorInfo : IFlatbufferObject
	{
		// Token: 0x17006D7C RID: 28028
		// (get) Token: 0x06015F97 RID: 90007 RVA: 0x0032865C File Offset: 0x0032685C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015F98 RID: 90008 RVA: 0x00328669 File Offset: 0x00326869
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015F99 RID: 90009 RVA: 0x00328670 File Offset: 0x00326870
		public static IVectorInfo GetRootAsIVectorInfo(ByteBuffer _bb)
		{
			return IVectorInfo.GetRootAsIVectorInfo(_bb, default(IVectorInfo));
		}

		// Token: 0x06015F9A RID: 90010 RVA: 0x0032868C File Offset: 0x0032688C
		public static IVectorInfo GetRootAsIVectorInfo(ByteBuffer _bb, IVectorInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015F9B RID: 90011 RVA: 0x003286A9 File Offset: 0x003268A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015F9C RID: 90012 RVA: 0x003286B8 File Offset: 0x003268B8
		public IVectorInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D7D RID: 28029
		// (get) Token: 0x06015F9D RID: 90013 RVA: 0x003286C8 File Offset: 0x003268C8
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

		// Token: 0x17006D7E RID: 28030
		// (get) Token: 0x06015F9E RID: 90014 RVA: 0x00328708 File Offset: 0x00326908
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

		// Token: 0x17006D7F RID: 28031
		// (get) Token: 0x06015F9F RID: 90015 RVA: 0x00328748 File Offset: 0x00326948
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

		// Token: 0x17006D80 RID: 28032
		// (get) Token: 0x06015FA0 RID: 90016 RVA: 0x00328788 File Offset: 0x00326988
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015FA1 RID: 90017 RVA: 0x003287C5 File Offset: 0x003269C5
		public static Offset<IVectorInfo> CreateIVectorInfo(FlatBufferBuilder builder, float X = 0f, float Y = 0f, float Z = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVectorInfo.AddZ(builder, Z);
			IVectorInfo.AddY(builder, Y);
			IVectorInfo.AddX(builder, X);
			IVectorInfo.AddNullMask(builder, NullMask);
			return IVectorInfo.EndIVectorInfo(builder);
		}

		// Token: 0x06015FA2 RID: 90018 RVA: 0x003287F1 File Offset: 0x003269F1
		public static void StartIVectorInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015FA3 RID: 90019 RVA: 0x003287FA File Offset: 0x003269FA
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x06015FA4 RID: 90020 RVA: 0x0032880D File Offset: 0x00326A0D
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x06015FA5 RID: 90021 RVA: 0x00328820 File Offset: 0x00326A20
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x06015FA6 RID: 90022 RVA: 0x00328833 File Offset: 0x00326A33
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06015FA7 RID: 90023 RVA: 0x0032883E File Offset: 0x00326A3E
		public static Offset<IVectorInfo> EndIVectorInfo(FlatBufferBuilder builder)
		{
			return new Offset<IVectorInfo>(builder.EndTable());
		}

		// Token: 0x06015FA8 RID: 90024 RVA: 0x0032884C File Offset: 0x00326A4C
		public IVectorInfoT UnPack()
		{
			IVectorInfoT vectorInfoT = new IVectorInfoT();
			this.UnPackTo(vectorInfoT);
			return vectorInfoT;
		}

		// Token: 0x06015FA9 RID: 90025 RVA: 0x00328867 File Offset: 0x00326A67
		public void UnPackTo(IVectorInfoT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015FAA RID: 90026 RVA: 0x0032889C File Offset: 0x00326A9C
		public static Offset<IVectorInfo> Pack(FlatBufferBuilder builder, IVectorInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVectorInfo>);
			}
			return IVectorInfo.CreateIVectorInfo(builder, _o.X, _o.Y, _o.Z, _o.NullMask);
		}

		// Token: 0x0400B96F RID: 47471
		private Table __p;
	}
}
