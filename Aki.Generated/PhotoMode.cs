using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF8 RID: 4088
	public struct PhotoMode : IFlatbufferObject
	{
		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x0600B2CD RID: 45773 RVA: 0x002D93B1 File Offset: 0x002D75B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B2CE RID: 45774 RVA: 0x002D93BE File Offset: 0x002D75BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B2CF RID: 45775 RVA: 0x002D93C8 File Offset: 0x002D75C8
		public static PhotoMode GetRootAsPhotoMode(ByteBuffer _bb)
		{
			return PhotoMode.GetRootAsPhotoMode(_bb, default(PhotoMode));
		}

		// Token: 0x0600B2D0 RID: 45776 RVA: 0x002D93E4 File Offset: 0x002D75E4
		public static PhotoMode GetRootAsPhotoMode(ByteBuffer _bb, PhotoMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B2D1 RID: 45777 RVA: 0x002D9401 File Offset: 0x002D7601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B2D2 RID: 45778 RVA: 0x002D9410 File Offset: 0x002D7610
		public PhotoMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x0600B2D3 RID: 45779 RVA: 0x002D9420 File Offset: 0x002D7620
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

		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x0600B2D4 RID: 45780 RVA: 0x002D945C File Offset: 0x002D765C
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

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x0600B2D5 RID: 45781 RVA: 0x002D9498 File Offset: 0x002D7698
		public string Name
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

		// Token: 0x0600B2D6 RID: 45782 RVA: 0x002D94CF File Offset: 0x002D76CF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B2D7 RID: 45783 RVA: 0x002D94DE File Offset: 0x002D76DE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x0600B2D8 RID: 45784 RVA: 0x002D94F8 File Offset: 0x002D76F8
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

		// Token: 0x0600B2D9 RID: 45785 RVA: 0x002D9530 File Offset: 0x002D7730
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B2DA RID: 45786 RVA: 0x002D9540 File Offset: 0x002D7740
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x0600B2DB RID: 45787 RVA: 0x002D9558 File Offset: 0x002D7758
		public string DAPath
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

		// Token: 0x0600B2DC RID: 45788 RVA: 0x002D9590 File Offset: 0x002D7790
		public Span<byte> GetDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B2DD RID: 45789 RVA: 0x002D95A0 File Offset: 0x002D77A0
		public byte[] GetDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B2DE RID: 45790 RVA: 0x002D95B8 File Offset: 0x002D77B8
		public int PhotoSetupList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x0600B2DF RID: 45791 RVA: 0x002D95F8 File Offset: 0x002D77F8
		public int PhotoSetupListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B2E0 RID: 45792 RVA: 0x002D9624 File Offset: 0x002D7824
		public Span<int> GetPhotoSetupListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600B2E1 RID: 45793 RVA: 0x002D9634 File Offset: 0x002D7834
		public int[] GetPhotoSetupListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x0600B2E2 RID: 45794 RVA: 0x002D964C File Offset: 0x002D784C
		public int MotionSelectMode
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

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x0600B2E3 RID: 45795 RVA: 0x002D968C File Offset: 0x002D788C
		public int PhotoTemplateGroupId
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

		// Token: 0x0600B2E4 RID: 45796 RVA: 0x002D96CC File Offset: 0x002D78CC
		public int BanTabList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x0600B2E5 RID: 45797 RVA: 0x002D970C File Offset: 0x002D790C
		public int BanTabListLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B2E6 RID: 45798 RVA: 0x002D9738 File Offset: 0x002D7938
		public Span<int> GetBanTabListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600B2E7 RID: 45799 RVA: 0x002D9748 File Offset: 0x002D7948
		public int[] GetBanTabListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600B2E8 RID: 45800 RVA: 0x002D9760 File Offset: 0x002D7960
		public int BanSubTabList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x0600B2E9 RID: 45801 RVA: 0x002D97A0 File Offset: 0x002D79A0
		public int BanSubTabListLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B2EA RID: 45802 RVA: 0x002D97CC File Offset: 0x002D79CC
		public Span<int> GetBanSubTabListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600B2EB RID: 45803 RVA: 0x002D97DC File Offset: 0x002D79DC
		public int[] GetBanSubTabListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x0600B2EC RID: 45804 RVA: 0x002D97F4 File Offset: 0x002D79F4
		public float CollisionRadius
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x0600B2ED RID: 45805 RVA: 0x002D9838 File Offset: 0x002D7A38
		public float CollisionRadiusOffset
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x0600B2EE RID: 45806 RVA: 0x002D987C File Offset: 0x002D7A7C
		public string CollisionBlockedTip
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B2EF RID: 45807 RVA: 0x002D98B4 File Offset: 0x002D7AB4
		public Span<byte> GetCollisionBlockedTipBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B2F0 RID: 45808 RVA: 0x002D98C4 File Offset: 0x002D7AC4
		public byte[] GetCollisionBlockedTipArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B2F1 RID: 45809 RVA: 0x002D98DC File Offset: 0x002D7ADC
		[NullableContext(1)]
		public int[] BanSubTabList()
		{
			return this.GetBanSubTabListArray();
		}

		// Token: 0x0600B2F2 RID: 45810 RVA: 0x002D98E4 File Offset: 0x002D7AE4
		[NullableContext(1)]
		public IEnumerable<int> BanSubTabListIter()
		{
			PhotoMode.<BanSubTabListIter>d__52 <BanSubTabListIter>d__ = new PhotoMode.<BanSubTabListIter>d__52(-2);
			<BanSubTabListIter>d__.<>3__<>4__this = this;
			return <BanSubTabListIter>d__;
		}

		// Token: 0x0600B2F3 RID: 45811 RVA: 0x002D98F9 File Offset: 0x002D7AF9
		[NullableContext(1)]
		public int[] BanTabList()
		{
			return this.GetBanTabListArray();
		}

		// Token: 0x0600B2F4 RID: 45812 RVA: 0x002D9901 File Offset: 0x002D7B01
		[NullableContext(1)]
		public IEnumerable<int> BanTabListIter()
		{
			PhotoMode.<BanTabListIter>d__54 <BanTabListIter>d__ = new PhotoMode.<BanTabListIter>d__54(-2);
			<BanTabListIter>d__.<>3__<>4__this = this;
			return <BanTabListIter>d__;
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x002D9916 File Offset: 0x002D7B16
		[NullableContext(1)]
		public int[] PhotoSetupList()
		{
			return this.GetPhotoSetupListArray();
		}

		// Token: 0x0600B2F6 RID: 45814 RVA: 0x002D991E File Offset: 0x002D7B1E
		[NullableContext(1)]
		public IEnumerable<int> PhotoSetupListIter()
		{
			PhotoMode.<PhotoSetupListIter>d__56 <PhotoSetupListIter>d__ = new PhotoMode.<PhotoSetupListIter>d__56(-2);
			<PhotoSetupListIter>d__.<>3__<>4__this = this;
			return <PhotoSetupListIter>d__;
		}

		// Token: 0x040055C0 RID: 21952
		private Table __p;
	}
}
