using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFB RID: 4091
	public struct PhotoSelfieMontage : IFlatbufferObject
	{
		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x0600B31C RID: 45852 RVA: 0x002D9EB4 File Offset: 0x002D80B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B31D RID: 45853 RVA: 0x002D9EC1 File Offset: 0x002D80C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x002D9EC8 File Offset: 0x002D80C8
		public static PhotoSelfieMontage GetRootAsPhotoSelfieMontage(ByteBuffer _bb)
		{
			return PhotoSelfieMontage.GetRootAsPhotoSelfieMontage(_bb, default(PhotoSelfieMontage));
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x002D9EE4 File Offset: 0x002D80E4
		public static PhotoSelfieMontage GetRootAsPhotoSelfieMontage(ByteBuffer _bb, PhotoSelfieMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B320 RID: 45856 RVA: 0x002D9F01 File Offset: 0x002D8101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B321 RID: 45857 RVA: 0x002D9F10 File Offset: 0x002D8110
		public PhotoSelfieMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x0600B322 RID: 45858 RVA: 0x002D9F20 File Offset: 0x002D8120
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

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x0600B323 RID: 45859 RVA: 0x002D9F5C File Offset: 0x002D815C
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

		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x0600B324 RID: 45860 RVA: 0x002D9F98 File Offset: 0x002D8198
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

		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x0600B325 RID: 45861 RVA: 0x002D9FD4 File Offset: 0x002D81D4
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

		// Token: 0x0600B326 RID: 45862 RVA: 0x002DA00C File Offset: 0x002D820C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B327 RID: 45863 RVA: 0x002DA01C File Offset: 0x002D821C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x0600B328 RID: 45864 RVA: 0x002DA034 File Offset: 0x002D8234
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

		// Token: 0x0600B329 RID: 45865 RVA: 0x002DA06C File Offset: 0x002D826C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B32A RID: 45866 RVA: 0x002DA07C File Offset: 0x002D827C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x0600B32B RID: 45867 RVA: 0x002DA094 File Offset: 0x002D8294
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

		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x0600B32C RID: 45868 RVA: 0x002DA0D4 File Offset: 0x002D82D4
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

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x0600B32D RID: 45869 RVA: 0x002DA114 File Offset: 0x002D8314
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040055C3 RID: 21955
		private Table __p;
	}
}
