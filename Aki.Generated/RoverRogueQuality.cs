using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117B RID: 4475
	public struct RoverRogueQuality : IFlatbufferObject
	{
		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x0600D64B RID: 54859 RVA: 0x00326EDB File Offset: 0x003250DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D64C RID: 54860 RVA: 0x00326EE8 File Offset: 0x003250E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D64D RID: 54861 RVA: 0x00326EF0 File Offset: 0x003250F0
		public static RoverRogueQuality GetRootAsRoverRogueQuality(ByteBuffer _bb)
		{
			return RoverRogueQuality.GetRootAsRoverRogueQuality(_bb, default(RoverRogueQuality));
		}

		// Token: 0x0600D64E RID: 54862 RVA: 0x00326F0C File Offset: 0x0032510C
		public static RoverRogueQuality GetRootAsRoverRogueQuality(ByteBuffer _bb, RoverRogueQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D64F RID: 54863 RVA: 0x00326F29 File Offset: 0x00325129
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D650 RID: 54864 RVA: 0x00326F38 File Offset: 0x00325138
		public RoverRogueQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x0600D651 RID: 54865 RVA: 0x00326F48 File Offset: 0x00325148
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

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x0600D652 RID: 54866 RVA: 0x00326F84 File Offset: 0x00325184
		public string Desc
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

		// Token: 0x0600D653 RID: 54867 RVA: 0x00326FBB File Offset: 0x003251BB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D654 RID: 54868 RVA: 0x00326FCA File Offset: 0x003251CA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x0600D655 RID: 54869 RVA: 0x00326FE4 File Offset: 0x003251E4
		public string BlessCardTop
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

		// Token: 0x0600D656 RID: 54870 RVA: 0x0032701B File Offset: 0x0032521B
		public Span<byte> GetBlessCardTopBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D657 RID: 54871 RVA: 0x0032702A File Offset: 0x0032522A
		public byte[] GetBlessCardTopArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0600D658 RID: 54872 RVA: 0x00327044 File Offset: 0x00325244
		public string BlessCardTheme
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

		// Token: 0x0600D659 RID: 54873 RVA: 0x0032707C File Offset: 0x0032527C
		public Span<byte> GetBlessCardThemeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D65A RID: 54874 RVA: 0x0032708C File Offset: 0x0032528C
		public byte[] GetBlessCardThemeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x0600D65B RID: 54875 RVA: 0x003270A4 File Offset: 0x003252A4
		public string BlessSuitIcon
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

		// Token: 0x0600D65C RID: 54876 RVA: 0x003270DC File Offset: 0x003252DC
		public Span<byte> GetBlessSuitIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D65D RID: 54877 RVA: 0x003270EC File Offset: 0x003252EC
		public byte[] GetBlessSuitIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x0600D65E RID: 54878 RVA: 0x00327104 File Offset: 0x00325304
		public string BlessSlotQuality
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

		// Token: 0x0600D65F RID: 54879 RVA: 0x0032713C File Offset: 0x0032533C
		public Span<byte> GetBlessSlotQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D660 RID: 54880 RVA: 0x0032714C File Offset: 0x0032534C
		public byte[] GetBlessSlotQualityArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0600D661 RID: 54881 RVA: 0x00327164 File Offset: 0x00325364
		public string ItemCard
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D662 RID: 54882 RVA: 0x0032719C File Offset: 0x0032539C
		public Span<byte> GetItemCardBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D663 RID: 54883 RVA: 0x003271AC File Offset: 0x003253AC
		public byte[] GetItemCardArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0600D664 RID: 54884 RVA: 0x003271C4 File Offset: 0x003253C4
		public string ItemGridSprite
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D665 RID: 54885 RVA: 0x003271FC File Offset: 0x003253FC
		public Span<byte> GetItemGridSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D666 RID: 54886 RVA: 0x0032720C File Offset: 0x0032540C
		public byte[] GetItemGridSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005789 RID: 22409
		private Table __p;
	}
}
