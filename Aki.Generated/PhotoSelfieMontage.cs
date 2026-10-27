using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F16 RID: 3862
	public struct PhotoSelfieMontage : IFlatbufferObject
	{
		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x0600ACFB RID: 44283 RVA: 0x002BD29C File Offset: 0x002BB49C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ACFC RID: 44284 RVA: 0x002BD2A9 File Offset: 0x002BB4A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ACFD RID: 44285 RVA: 0x002BD2B0 File Offset: 0x002BB4B0
		public static PhotoSelfieMontage GetRootAsPhotoSelfieMontage(ByteBuffer _bb)
		{
			return PhotoSelfieMontage.GetRootAsPhotoSelfieMontage(_bb, default(PhotoSelfieMontage));
		}

		// Token: 0x0600ACFE RID: 44286 RVA: 0x002BD2CC File Offset: 0x002BB4CC
		public static PhotoSelfieMontage GetRootAsPhotoSelfieMontage(ByteBuffer _bb, PhotoSelfieMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ACFF RID: 44287 RVA: 0x002BD2E9 File Offset: 0x002BB4E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD00 RID: 44288 RVA: 0x002BD2F8 File Offset: 0x002BB4F8
		public PhotoSelfieMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x0600AD01 RID: 44289 RVA: 0x002BD308 File Offset: 0x002BB508
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

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x0600AD02 RID: 44290 RVA: 0x002BD344 File Offset: 0x002BB544
		public int Gender
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

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x0600AD03 RID: 44291 RVA: 0x002BD380 File Offset: 0x002BB580
		public int SortId
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

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x0600AD04 RID: 44292 RVA: 0x002BD3BC File Offset: 0x002BB5BC
		public string Icon
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

		// Token: 0x0600AD05 RID: 44293 RVA: 0x002BD3F4 File Offset: 0x002BB5F4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x002BD404 File Offset: 0x002BB604
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x0600AD07 RID: 44295 RVA: 0x002BD41C File Offset: 0x002BB61C
		public string Name
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

		// Token: 0x0600AD08 RID: 44296 RVA: 0x002BD454 File Offset: 0x002BB654
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AD09 RID: 44297 RVA: 0x002BD464 File Offset: 0x002BB664
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x0600AD0A RID: 44298 RVA: 0x002BD47C File Offset: 0x002BB67C
		public int RelativeItem
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x0600AD0B RID: 44299 RVA: 0x002BD4BC File Offset: 0x002BB6BC
		public int MontageConfigDtId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x0600AD0C RID: 44300 RVA: 0x002BD4FC File Offset: 0x002BB6FC
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004FDE RID: 20446
		private Table __p;
	}
}
