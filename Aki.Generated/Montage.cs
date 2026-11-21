using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F03 RID: 3843
	public struct Montage : IFlatbufferObject
	{
		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x06009BB9 RID: 39865 RVA: 0x002A6861 File Offset: 0x002A4A61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009BBA RID: 39866 RVA: 0x002A686E File Offset: 0x002A4A6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009BBB RID: 39867 RVA: 0x002A6878 File Offset: 0x002A4A78
		public static Montage GetRootAsMontage(ByteBuffer _bb)
		{
			return Montage.GetRootAsMontage(_bb, default(Montage));
		}

		// Token: 0x06009BBC RID: 39868 RVA: 0x002A6894 File Offset: 0x002A4A94
		public static Montage GetRootAsMontage(ByteBuffer _bb, Montage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009BBD RID: 39869 RVA: 0x002A68B1 File Offset: 0x002A4AB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009BBE RID: 39870 RVA: 0x002A68C0 File Offset: 0x002A4AC0
		public Montage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06009BBF RID: 39871 RVA: 0x002A68D0 File Offset: 0x002A4AD0
		public int Id
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

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06009BC0 RID: 39872 RVA: 0x002A690C File Offset: 0x002A4B0C
		public int MontageId
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

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06009BC1 RID: 39873 RVA: 0x002A6948 File Offset: 0x002A4B48
		public int StartTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x06009BC2 RID: 39874 RVA: 0x002A6984 File Offset: 0x002A4B84
		public int EndTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06009BC3 RID: 39875 RVA: 0x002A69C4 File Offset: 0x002A4BC4
		public int Type
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06009BC4 RID: 39876 RVA: 0x002A6A04 File Offset: 0x002A4C04
		public string Params
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009BC5 RID: 39877 RVA: 0x002A6A3C File Offset: 0x002A4C3C
		public Span<byte> GetParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009BC6 RID: 39878 RVA: 0x002A6A4C File Offset: 0x002A4C4C
		public byte[] GetParamsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040054A8 RID: 21672
		private Table __p;
	}
}
