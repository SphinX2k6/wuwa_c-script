using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012F5 RID: 4853
	public struct DicStringInt : IFlatbufferObject
	{
		// Token: 0x1700423D RID: 16957
		// (get) Token: 0x0600F7B4 RID: 63412 RVA: 0x003728C4 File Offset: 0x00370AC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F7B5 RID: 63413 RVA: 0x003728D1 File Offset: 0x00370AD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F7B6 RID: 63414 RVA: 0x003728D8 File Offset: 0x00370AD8
		public static DicStringInt GetRootAsDicStringInt(ByteBuffer _bb)
		{
			return DicStringInt.GetRootAsDicStringInt(_bb, default(DicStringInt));
		}

		// Token: 0x0600F7B7 RID: 63415 RVA: 0x003728F4 File Offset: 0x00370AF4
		public static DicStringInt GetRootAsDicStringInt(ByteBuffer _bb, DicStringInt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F7B8 RID: 63416 RVA: 0x00372911 File Offset: 0x00370B11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F7B9 RID: 63417 RVA: 0x00372920 File Offset: 0x00370B20
		public DicStringInt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700423E RID: 16958
		// (get) Token: 0x0600F7BA RID: 63418 RVA: 0x00372930 File Offset: 0x00370B30
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F7BB RID: 63419 RVA: 0x00372967 File Offset: 0x00370B67
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F7BC RID: 63420 RVA: 0x00372976 File Offset: 0x00370B76
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700423F RID: 16959
		// (get) Token: 0x0600F7BD RID: 63421 RVA: 0x00372990 File Offset: 0x00370B90
		public int Value
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

		// Token: 0x04005953 RID: 22867
		private Table __p;
	}
}
