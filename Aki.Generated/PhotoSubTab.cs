using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F19 RID: 3865
	public struct PhotoSubTab : IFlatbufferObject
	{
		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x0600AD52 RID: 44370 RVA: 0x002BE071 File Offset: 0x002BC271
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD53 RID: 44371 RVA: 0x002BE07E File Offset: 0x002BC27E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD54 RID: 44372 RVA: 0x002BE088 File Offset: 0x002BC288
		public static PhotoSubTab GetRootAsPhotoSubTab(ByteBuffer _bb)
		{
			return PhotoSubTab.GetRootAsPhotoSubTab(_bb, default(PhotoSubTab));
		}

		// Token: 0x0600AD55 RID: 44373 RVA: 0x002BE0A4 File Offset: 0x002BC2A4
		public static PhotoSubTab GetRootAsPhotoSubTab(ByteBuffer _bb, PhotoSubTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD56 RID: 44374 RVA: 0x002BE0C1 File Offset: 0x002BC2C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD57 RID: 44375 RVA: 0x002BE0D0 File Offset: 0x002BC2D0
		public PhotoSubTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x0600AD58 RID: 44376 RVA: 0x002BE0E0 File Offset: 0x002BC2E0
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

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x0600AD59 RID: 44377 RVA: 0x002BE11C File Offset: 0x002BC31C
		public int Type
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

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x0600AD5A RID: 44378 RVA: 0x002BE158 File Offset: 0x002BC358
		public string Icon
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

		// Token: 0x0600AD5B RID: 44379 RVA: 0x002BE18F File Offset: 0x002BC38F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AD5C RID: 44380 RVA: 0x002BE19E File Offset: 0x002BC39E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FE2 RID: 20450
		private Table __p;
	}
}
