using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F07 RID: 3847
	public struct PhotoExpression : IFlatbufferObject
	{
		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x0600AB56 RID: 43862 RVA: 0x002B9526 File Offset: 0x002B7726
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x002B9533 File Offset: 0x002B7733
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AB58 RID: 43864 RVA: 0x002B953C File Offset: 0x002B773C
		public static PhotoExpression GetRootAsPhotoExpression(ByteBuffer _bb)
		{
			return PhotoExpression.GetRootAsPhotoExpression(_bb, default(PhotoExpression));
		}

		// Token: 0x0600AB59 RID: 43865 RVA: 0x002B9558 File Offset: 0x002B7758
		public static PhotoExpression GetRootAsPhotoExpression(ByteBuffer _bb, PhotoExpression obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AB5A RID: 43866 RVA: 0x002B9575 File Offset: 0x002B7775
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AB5B RID: 43867 RVA: 0x002B9584 File Offset: 0x002B7784
		public PhotoExpression __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x002B9594 File Offset: 0x002B7794
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

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x0600AB5D RID: 43869 RVA: 0x002B95D0 File Offset: 0x002B77D0
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

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x0600AB5E RID: 43870 RVA: 0x002B960C File Offset: 0x002B780C
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

		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x0600AB5F RID: 43871 RVA: 0x002B9648 File Offset: 0x002B7848
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

		// Token: 0x0600AB60 RID: 43872 RVA: 0x002B9680 File Offset: 0x002B7880
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AB61 RID: 43873 RVA: 0x002B9690 File Offset: 0x002B7890
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x0600AB62 RID: 43874 RVA: 0x002B96A8 File Offset: 0x002B78A8
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

		// Token: 0x0600AB63 RID: 43875 RVA: 0x002B96E0 File Offset: 0x002B78E0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AB64 RID: 43876 RVA: 0x002B96F0 File Offset: 0x002B78F0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x0600AB65 RID: 43877 RVA: 0x002B9708 File Offset: 0x002B7908
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

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x0600AB66 RID: 43878 RVA: 0x002B9748 File Offset: 0x002B7948
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

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x0600AB67 RID: 43879 RVA: 0x002B9788 File Offset: 0x002B7988
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004FCF RID: 20431
		private Table __p;
	}
}
