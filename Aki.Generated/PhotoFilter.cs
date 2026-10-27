using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0C RID: 3852
	public struct PhotoFilter : IFlatbufferObject
	{
		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x0600ABD7 RID: 43991 RVA: 0x002BA694 File Offset: 0x002B8894
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ABD8 RID: 43992 RVA: 0x002BA6A1 File Offset: 0x002B88A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x002BA6A8 File Offset: 0x002B88A8
		public static PhotoFilter GetRootAsPhotoFilter(ByteBuffer _bb)
		{
			return PhotoFilter.GetRootAsPhotoFilter(_bb, default(PhotoFilter));
		}

		// Token: 0x0600ABDA RID: 43994 RVA: 0x002BA6C4 File Offset: 0x002B88C4
		public static PhotoFilter GetRootAsPhotoFilter(ByteBuffer _bb, PhotoFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ABDB RID: 43995 RVA: 0x002BA6E1 File Offset: 0x002B88E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ABDC RID: 43996 RVA: 0x002BA6F0 File Offset: 0x002B88F0
		public PhotoFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x0600ABDD RID: 43997 RVA: 0x002BA700 File Offset: 0x002B8900
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

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x0600ABDE RID: 43998 RVA: 0x002BA73C File Offset: 0x002B893C
		public string Name
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

		// Token: 0x0600ABDF RID: 43999 RVA: 0x002BA773 File Offset: 0x002B8973
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600ABE0 RID: 44000 RVA: 0x002BA782 File Offset: 0x002B8982
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x0600ABE1 RID: 44001 RVA: 0x002BA79C File Offset: 0x002B899C
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

		// Token: 0x0600ABE2 RID: 44002 RVA: 0x002BA7D3 File Offset: 0x002B89D3
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600ABE3 RID: 44003 RVA: 0x002BA7E2 File Offset: 0x002B89E2
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x0600ABE4 RID: 44004 RVA: 0x002BA7FC File Offset: 0x002B89FC
		public string LUTPath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x002BA834 File Offset: 0x002B8A34
		public Span<byte> GetLUTPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x002BA844 File Offset: 0x002B8A44
		public byte[] GetLUTPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x0600ABE7 RID: 44007 RVA: 0x002BA85C File Offset: 0x002B8A5C
		public string PPVName
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

		// Token: 0x0600ABE8 RID: 44008 RVA: 0x002BA894 File Offset: 0x002B8A94
		public Span<byte> GetPPVNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600ABE9 RID: 44009 RVA: 0x002BA8A4 File Offset: 0x002B8AA4
		public byte[] GetPPVNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FD4 RID: 20436
		private Table __p;
	}
}
