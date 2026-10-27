using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F00 RID: 3840
	public struct PhoneMessageAttachment : IFlatbufferObject
	{
		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x0600AAC9 RID: 43721 RVA: 0x002B832D File Offset: 0x002B652D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AACA RID: 43722 RVA: 0x002B833A File Offset: 0x002B653A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AACB RID: 43723 RVA: 0x002B8344 File Offset: 0x002B6544
		public static PhoneMessageAttachment GetRootAsPhoneMessageAttachment(ByteBuffer _bb)
		{
			return PhoneMessageAttachment.GetRootAsPhoneMessageAttachment(_bb, default(PhoneMessageAttachment));
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x002B8360 File Offset: 0x002B6560
		public static PhoneMessageAttachment GetRootAsPhoneMessageAttachment(ByteBuffer _bb, PhoneMessageAttachment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AACD RID: 43725 RVA: 0x002B837D File Offset: 0x002B657D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AACE RID: 43726 RVA: 0x002B838C File Offset: 0x002B658C
		public PhoneMessageAttachment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x0600AACF RID: 43727 RVA: 0x002B839C File Offset: 0x002B659C
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

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x0600AAD0 RID: 43728 RVA: 0x002B83D8 File Offset: 0x002B65D8
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

		// Token: 0x0600AAD1 RID: 43729 RVA: 0x002B840F File Offset: 0x002B660F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AAD2 RID: 43730 RVA: 0x002B841E File Offset: 0x002B661E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x0600AAD3 RID: 43731 RVA: 0x002B8438 File Offset: 0x002B6638
		public string Type
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

		// Token: 0x0600AAD4 RID: 43732 RVA: 0x002B846F File Offset: 0x002B666F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AAD5 RID: 43733 RVA: 0x002B847E File Offset: 0x002B667E
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x0600AAD6 RID: 43734 RVA: 0x002B8498 File Offset: 0x002B6698
		public string Thumbnail
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

		// Token: 0x0600AAD7 RID: 43735 RVA: 0x002B84D0 File Offset: 0x002B66D0
		public Span<byte> GetThumbnailBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AAD8 RID: 43736 RVA: 0x002B84E0 File Offset: 0x002B66E0
		public byte[] GetThumbnailArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x0600AAD9 RID: 43737 RVA: 0x002B84F8 File Offset: 0x002B66F8
		public string ThumbnailMaleVariant
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

		// Token: 0x0600AADA RID: 43738 RVA: 0x002B8530 File Offset: 0x002B6730
		public Span<byte> GetThumbnailMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AADB RID: 43739 RVA: 0x002B8540 File Offset: 0x002B6740
		public byte[] GetThumbnailMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x0600AADC RID: 43740 RVA: 0x002B8558 File Offset: 0x002B6758
		public string AttachmentPath
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

		// Token: 0x0600AADD RID: 43741 RVA: 0x002B8590 File Offset: 0x002B6790
		public Span<byte> GetAttachmentPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AADE RID: 43742 RVA: 0x002B85A0 File Offset: 0x002B67A0
		public byte[] GetAttachmentPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x0600AADF RID: 43743 RVA: 0x002B85B8 File Offset: 0x002B67B8
		public string AttachmentPathMaleVariant
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

		// Token: 0x0600AAE0 RID: 43744 RVA: 0x002B85F0 File Offset: 0x002B67F0
		public Span<byte> GetAttachmentPathMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AAE1 RID: 43745 RVA: 0x002B8600 File Offset: 0x002B6800
		public byte[] GetAttachmentPathMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x0600AAE2 RID: 43746 RVA: 0x002B8618 File Offset: 0x002B6818
		public int InformationViewId
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

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x0600AAE3 RID: 43747 RVA: 0x002B8658 File Offset: 0x002B6858
		public int InformationViewIdMaleVariant
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x0600AAE4 RID: 43748 RVA: 0x002B8698 File Offset: 0x002B6898
		public int CoordinateTeleportId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004FC8 RID: 20424
		private Table __p;
	}
}
