using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC2 RID: 2754
	public struct ActivityFilter : IFlatbufferObject
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06004332 RID: 17202 RVA: 0x001CBC63 File Offset: 0x001C9E63
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x001CBC70 File Offset: 0x001C9E70
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x001CBC78 File Offset: 0x001C9E78
		public static ActivityFilter GetRootAsActivityFilter(ByteBuffer _bb)
		{
			return ActivityFilter.GetRootAsActivityFilter(_bb, default(ActivityFilter));
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x001CBC94 File Offset: 0x001C9E94
		public static ActivityFilter GetRootAsActivityFilter(ByteBuffer _bb, ActivityFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x001CBCB1 File Offset: 0x001C9EB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x001CBCC0 File Offset: 0x001C9EC0
		public ActivityFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06004338 RID: 17208 RVA: 0x001CBCD0 File Offset: 0x001C9ED0
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06004339 RID: 17209 RVA: 0x001CBD0C File Offset: 0x001C9F0C
		public string FilterIcon
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

		// Token: 0x0600433A RID: 17210 RVA: 0x001CBD43 File Offset: 0x001C9F43
		public Span<byte> GetFilterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x001CBD52 File Offset: 0x001C9F52
		public byte[] GetFilterIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600433C RID: 17212 RVA: 0x001CBD6C File Offset: 0x001C9F6C
		public string FilterName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x001CBDA3 File Offset: 0x001C9FA3
		public Span<byte> GetFilterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x001CBDB2 File Offset: 0x001C9FB2
		public byte[] GetFilterNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600433F RID: 17215 RVA: 0x001CBDCC File Offset: 0x001C9FCC
		public int SortId
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

		// Token: 0x04004A9E RID: 19102
		private Table __p;
	}
}
