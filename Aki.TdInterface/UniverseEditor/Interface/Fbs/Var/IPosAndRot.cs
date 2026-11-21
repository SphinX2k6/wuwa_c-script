using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EB6 RID: 16054
	public struct IPosAndRot : IFlatbufferObject
	{
		// Token: 0x17006CAA RID: 27818
		// (get) Token: 0x06015B78 RID: 88952 RVA: 0x00320594 File Offset: 0x0031E794
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015B79 RID: 88953 RVA: 0x003205A1 File Offset: 0x0031E7A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015B7A RID: 88954 RVA: 0x003205A8 File Offset: 0x0031E7A8
		public static IPosAndRot GetRootAsIPosAndRot(ByteBuffer _bb)
		{
			return IPosAndRot.GetRootAsIPosAndRot(_bb, default(IPosAndRot));
		}

		// Token: 0x06015B7B RID: 88955 RVA: 0x003205C4 File Offset: 0x0031E7C4
		public static IPosAndRot GetRootAsIPosAndRot(ByteBuffer _bb, IPosAndRot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015B7C RID: 88956 RVA: 0x003205E1 File Offset: 0x0031E7E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015B7D RID: 88957 RVA: 0x003205F0 File Offset: 0x0031E7F0
		public IPosAndRot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CAB RID: 27819
		// (get) Token: 0x06015B7E RID: 88958 RVA: 0x00320600 File Offset: 0x0031E800
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

		// Token: 0x17006CAC RID: 27820
		// (get) Token: 0x06015B7F RID: 88959 RVA: 0x00320640 File Offset: 0x0031E840
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

		// Token: 0x17006CAD RID: 27821
		// (get) Token: 0x06015B80 RID: 88960 RVA: 0x00320680 File Offset: 0x0031E880
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

		// Token: 0x17006CAE RID: 27822
		// (get) Token: 0x06015B81 RID: 88961 RVA: 0x003206C0 File Offset: 0x0031E8C0
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

		// Token: 0x17006CAF RID: 27823
		// (get) Token: 0x06015B82 RID: 88962 RVA: 0x00320704 File Offset: 0x0031E904
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

		// Token: 0x17006CB0 RID: 27824
		// (get) Token: 0x06015B83 RID: 88963 RVA: 0x00320748 File Offset: 0x0031E948
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

		// Token: 0x17006CB1 RID: 27825
		// (get) Token: 0x06015B84 RID: 88964 RVA: 0x0032078C File Offset: 0x0031E98C
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

		// Token: 0x06015B85 RID: 88965 RVA: 0x003207CC File Offset: 0x0031E9CC
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

		// Token: 0x06015B86 RID: 88966 RVA: 0x0032081B File Offset: 0x0031EA1B
		public static void StartIPosAndRot(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06015B87 RID: 88967 RVA: 0x00320824 File Offset: 0x0031EA24
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x06015B88 RID: 88968 RVA: 0x00320837 File Offset: 0x0031EA37
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x06015B89 RID: 88969 RVA: 0x0032084A File Offset: 0x0031EA4A
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(2, z, 0.0);
		}

		// Token: 0x06015B8A RID: 88970 RVA: 0x0032085D File Offset: 0x0031EA5D
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x06015B8B RID: 88971 RVA: 0x00320870 File Offset: 0x0031EA70
		public static void AddRoll(FlatBufferBuilder builder, float roll)
		{
			builder.AddFloat(4, roll, 0.0);
		}

		// Token: 0x06015B8C RID: 88972 RVA: 0x00320883 File Offset: 0x0031EA83
		public static void AddPitch(FlatBufferBuilder builder, float pitch)
		{
			builder.AddFloat(5, pitch, 0.0);
		}

		// Token: 0x06015B8D RID: 88973 RVA: 0x00320896 File Offset: 0x0031EA96
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06015B8E RID: 88974 RVA: 0x003208A1 File Offset: 0x0031EAA1
		public static Offset<IPosAndRot> EndIPosAndRot(FlatBufferBuilder builder)
		{
			return new Offset<IPosAndRot>(builder.EndTable());
		}

		// Token: 0x06015B8F RID: 88975 RVA: 0x003208B0 File Offset: 0x0031EAB0
		public IPosAndRotT UnPack()
		{
			IPosAndRotT posAndRotT = new IPosAndRotT();
			this.UnPackTo(posAndRotT);
			return posAndRotT;
		}

		// Token: 0x06015B90 RID: 88976 RVA: 0x003208CC File Offset: 0x0031EACC
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

		// Token: 0x06015B91 RID: 88977 RVA: 0x00320930 File Offset: 0x0031EB30
		public static Offset<IPosAndRot> Pack(FlatBufferBuilder builder, IPosAndRotT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosAndRot>);
			}
			return IPosAndRot.CreateIPosAndRot(builder, _o.X, _o.Y, _o.Z, _o.A, _o.Roll, _o.Pitch, _o.NullMask);
		}

		// Token: 0x0400B8BA RID: 47290
		private Table __p;
	}
}
