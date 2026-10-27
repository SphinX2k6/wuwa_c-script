using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B24 RID: 2852
	public struct BabelTowerTask : IFlatbufferObject
	{
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06004B59 RID: 19289 RVA: 0x001DE385 File Offset: 0x001DC585
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x001DE392 File Offset: 0x001DC592
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x001DE39C File Offset: 0x001DC59C
		public static BabelTowerTask GetRootAsBabelTowerTask(ByteBuffer _bb)
		{
			return BabelTowerTask.GetRootAsBabelTowerTask(_bb, default(BabelTowerTask));
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x001DE3B8 File Offset: 0x001DC5B8
		public static BabelTowerTask GetRootAsBabelTowerTask(ByteBuffer _bb, BabelTowerTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x001DE3D5 File Offset: 0x001DC5D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x001DE3E4 File Offset: 0x001DC5E4
		public BabelTowerTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06004B5F RID: 19295 RVA: 0x001DE3F4 File Offset: 0x001DC5F4
		public int TaskId
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06004B60 RID: 19296 RVA: 0x001DE430 File Offset: 0x001DC630
		public int ActivityId
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

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06004B61 RID: 19297 RVA: 0x001DE46C File Offset: 0x001DC66C
		public int DropId
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

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06004B62 RID: 19298 RVA: 0x001DE4A8 File Offset: 0x001DC6A8
		public int LevelId
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

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06004B63 RID: 19299 RVA: 0x001DE4E8 File Offset: 0x001DC6E8
		public string Title
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x001DE520 File Offset: 0x001DC720
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x001DE530 File Offset: 0x001DC730
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B16 RID: 19222
		private Table __p;
	}
}
