using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1B RID: 3867
	public struct PhotoTemplate : IFlatbufferObject
	{
		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x0600AD72 RID: 44402 RVA: 0x002BE465 File Offset: 0x002BC665
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD73 RID: 44403 RVA: 0x002BE472 File Offset: 0x002BC672
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD74 RID: 44404 RVA: 0x002BE47C File Offset: 0x002BC67C
		public static PhotoTemplate GetRootAsPhotoTemplate(ByteBuffer _bb)
		{
			return PhotoTemplate.GetRootAsPhotoTemplate(_bb, default(PhotoTemplate));
		}

		// Token: 0x0600AD75 RID: 44405 RVA: 0x002BE498 File Offset: 0x002BC698
		public static PhotoTemplate GetRootAsPhotoTemplate(ByteBuffer _bb, PhotoTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD76 RID: 44406 RVA: 0x002BE4B5 File Offset: 0x002BC6B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD77 RID: 44407 RVA: 0x002BE4C4 File Offset: 0x002BC6C4
		public PhotoTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x0600AD78 RID: 44408 RVA: 0x002BE4D4 File Offset: 0x002BC6D4
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

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x0600AD79 RID: 44409 RVA: 0x002BE510 File Offset: 0x002BC710
		public int GroupId
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

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x0600AD7A RID: 44410 RVA: 0x002BE54C File Offset: 0x002BC74C
		public string DAPath
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

		// Token: 0x0600AD7B RID: 44411 RVA: 0x002BE583 File Offset: 0x002BC783
		public Span<byte> GetDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AD7C RID: 44412 RVA: 0x002BE592 File Offset: 0x002BC792
		public byte[] GetDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x0600AD7D RID: 44413 RVA: 0x002BE5AC File Offset: 0x002BC7AC
		public string TextureMale
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

		// Token: 0x0600AD7E RID: 44414 RVA: 0x002BE5E4 File Offset: 0x002BC7E4
		public Span<byte> GetTextureMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AD7F RID: 44415 RVA: 0x002BE5F4 File Offset: 0x002BC7F4
		public byte[] GetTextureMaleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x0600AD80 RID: 44416 RVA: 0x002BE60C File Offset: 0x002BC80C
		public string TextureFemale
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

		// Token: 0x0600AD81 RID: 44417 RVA: 0x002BE644 File Offset: 0x002BC844
		public Span<byte> GetTextureFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AD82 RID: 44418 RVA: 0x002BE654 File Offset: 0x002BC854
		public byte[] GetTextureFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x0600AD83 RID: 44419 RVA: 0x002BE66C File Offset: 0x002BC86C
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004FE4 RID: 20452
		private Table __p;
	}
}
