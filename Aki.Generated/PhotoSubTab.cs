using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFE RID: 4094
	public struct PhotoSubTab : IFlatbufferObject
	{
		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x0600B373 RID: 45939 RVA: 0x002DAC69 File Offset: 0x002D8E69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x002DAC76 File Offset: 0x002D8E76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B375 RID: 45941 RVA: 0x002DAC80 File Offset: 0x002D8E80
		public static PhotoSubTab GetRootAsPhotoSubTab(ByteBuffer _bb)
		{
			return PhotoSubTab.GetRootAsPhotoSubTab(_bb, default(PhotoSubTab));
		}

		// Token: 0x0600B376 RID: 45942 RVA: 0x002DAC9C File Offset: 0x002D8E9C
		public static PhotoSubTab GetRootAsPhotoSubTab(ByteBuffer _bb, PhotoSubTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B377 RID: 45943 RVA: 0x002DACB9 File Offset: 0x002D8EB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B378 RID: 45944 RVA: 0x002DACC8 File Offset: 0x002D8EC8
		public PhotoSubTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x0600B379 RID: 45945 RVA: 0x002DACD8 File Offset: 0x002D8ED8
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

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x0600B37A RID: 45946 RVA: 0x002DAD14 File Offset: 0x002D8F14
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

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x0600B37B RID: 45947 RVA: 0x002DAD50 File Offset: 0x002D8F50
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

		// Token: 0x0600B37C RID: 45948 RVA: 0x002DAD87 File Offset: 0x002D8F87
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B37D RID: 45949 RVA: 0x002DAD96 File Offset: 0x002D8F96
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040055C7 RID: 21959
		private Table __p;
	}
}
