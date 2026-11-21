using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFE RID: 3838
	public struct MonsterPerch : IFlatbufferObject
	{
		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06009B76 RID: 39798 RVA: 0x002A5F86 File Offset: 0x002A4186
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B77 RID: 39799 RVA: 0x002A5F93 File Offset: 0x002A4193
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B78 RID: 39800 RVA: 0x002A5F9C File Offset: 0x002A419C
		public static MonsterPerch GetRootAsMonsterPerch(ByteBuffer _bb)
		{
			return MonsterPerch.GetRootAsMonsterPerch(_bb, default(MonsterPerch));
		}

		// Token: 0x06009B79 RID: 39801 RVA: 0x002A5FB8 File Offset: 0x002A41B8
		public static MonsterPerch GetRootAsMonsterPerch(ByteBuffer _bb, MonsterPerch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B7A RID: 39802 RVA: 0x002A5FD5 File Offset: 0x002A41D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B7B RID: 39803 RVA: 0x002A5FE4 File Offset: 0x002A41E4
		public MonsterPerch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06009B7C RID: 39804 RVA: 0x002A5FF4 File Offset: 0x002A41F4
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

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06009B7D RID: 39805 RVA: 0x002A6030 File Offset: 0x002A4230
		public string PerchDes
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009B7E RID: 39806 RVA: 0x002A6067 File Offset: 0x002A4267
		public Span<byte> GetPerchDesBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009B7F RID: 39807 RVA: 0x002A6076 File Offset: 0x002A4276
		public byte[] GetPerchDesArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040054A3 RID: 21667
		private Table __p;
	}
}
