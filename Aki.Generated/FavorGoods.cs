using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5F RID: 3167
	public struct FavorGoods : IFlatbufferObject
	{
		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06006CC3 RID: 27843 RVA: 0x0022B4F9 File Offset: 0x002296F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x0022B506 File Offset: 0x00229706
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x0022B510 File Offset: 0x00229710
		public static FavorGoods GetRootAsFavorGoods(ByteBuffer _bb)
		{
			return FavorGoods.GetRootAsFavorGoods(_bb, default(FavorGoods));
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x0022B52C File Offset: 0x0022972C
		public static FavorGoods GetRootAsFavorGoods(ByteBuffer _bb, FavorGoods obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x0022B549 File Offset: 0x00229749
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x0022B558 File Offset: 0x00229758
		public FavorGoods __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06006CC9 RID: 27849 RVA: 0x0022B568 File Offset: 0x00229768
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

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06006CCA RID: 27850 RVA: 0x0022B5A4 File Offset: 0x002297A4
		public int RoleId
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

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06006CCB RID: 27851 RVA: 0x0022B5E0 File Offset: 0x002297E0
		public int Sort
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

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06006CCC RID: 27852 RVA: 0x0022B61C File Offset: 0x0022981C
		public string Title
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

		// Token: 0x06006CCD RID: 27853 RVA: 0x0022B654 File Offset: 0x00229854
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x0022B664 File Offset: 0x00229864
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06006CCF RID: 27855 RVA: 0x0022B67C File Offset: 0x0022987C
		public string Content
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

		// Token: 0x06006CD0 RID: 27856 RVA: 0x0022B6B4 File Offset: 0x002298B4
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006CD1 RID: 27857 RVA: 0x0022B6C4 File Offset: 0x002298C4
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06006CD2 RID: 27858 RVA: 0x0022B6DC File Offset: 0x002298DC
		public string Pic
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x0022B714 File Offset: 0x00229914
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x0022B724 File Offset: 0x00229924
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06006CD5 RID: 27861 RVA: 0x0022B73C File Offset: 0x0022993C
		public int CondGroupId
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

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06006CD6 RID: 27862 RVA: 0x0022B77C File Offset: 0x0022997C
		public int Type
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06006CD7 RID: 27863 RVA: 0x0022B7BC File Offset: 0x002299BC
		public string MotionImg
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x0022B7F4 File Offset: 0x002299F4
		public Span<byte> GetMotionImgBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x0022B804 File Offset: 0x00229A04
		public byte[] GetMotionImgArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06006CDA RID: 27866 RVA: 0x0022B81C File Offset: 0x00229A1C
		public string AniBlueprint
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x0022B854 File Offset: 0x00229A54
		public Span<byte> GetAniBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x0022B864 File Offset: 0x00229A64
		public byte[] GetAniBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06006CDD RID: 27869 RVA: 0x0022B87C File Offset: 0x00229A7C
		public string AniMontage
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x0022B8B4 File Offset: 0x00229AB4
		public Span<byte> GetAniMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x0022B8C4 File Offset: 0x00229AC4
		public byte[] GetAniMontageArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CAA RID: 19626
		private Table __p;
	}
}
