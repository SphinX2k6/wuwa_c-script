using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F13 RID: 3859
	public struct PhotoMode : IFlatbufferObject
	{
		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x0600ACAC RID: 44204 RVA: 0x002BC73D File Offset: 0x002BA93D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ACAD RID: 44205 RVA: 0x002BC74A File Offset: 0x002BA94A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ACAE RID: 44206 RVA: 0x002BC754 File Offset: 0x002BA954
		public static PhotoMode GetRootAsPhotoMode(ByteBuffer _bb)
		{
			return PhotoMode.GetRootAsPhotoMode(_bb, default(PhotoMode));
		}

		// Token: 0x0600ACAF RID: 44207 RVA: 0x002BC770 File Offset: 0x002BA970
		public static PhotoMode GetRootAsPhotoMode(ByteBuffer _bb, PhotoMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ACB0 RID: 44208 RVA: 0x002BC78D File Offset: 0x002BA98D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ACB1 RID: 44209 RVA: 0x002BC79C File Offset: 0x002BA99C
		public PhotoMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x0600ACB2 RID: 44210 RVA: 0x002BC7AC File Offset: 0x002BA9AC
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

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x0600ACB3 RID: 44211 RVA: 0x002BC7E8 File Offset: 0x002BA9E8
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

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x0600ACB4 RID: 44212 RVA: 0x002BC824 File Offset: 0x002BAA24
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

		// Token: 0x0600ACB5 RID: 44213 RVA: 0x002BC85B File Offset: 0x002BAA5B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600ACB6 RID: 44214 RVA: 0x002BC86A File Offset: 0x002BAA6A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x0600ACB7 RID: 44215 RVA: 0x002BC884 File Offset: 0x002BAA84
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

		// Token: 0x0600ACB8 RID: 44216 RVA: 0x002BC8BC File Offset: 0x002BAABC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600ACB9 RID: 44217 RVA: 0x002BC8CC File Offset: 0x002BAACC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x0600ACBA RID: 44218 RVA: 0x002BC8E4 File Offset: 0x002BAAE4
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

		// Token: 0x0600ACBB RID: 44219 RVA: 0x002BC91C File Offset: 0x002BAB1C
		public Span<byte> GetDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600ACBC RID: 44220 RVA: 0x002BC92C File Offset: 0x002BAB2C
		public byte[] GetDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600ACBD RID: 44221 RVA: 0x002BC944 File Offset: 0x002BAB44
		public int PhotoSetupList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x0600ACBE RID: 44222 RVA: 0x002BC984 File Offset: 0x002BAB84
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

		// Token: 0x0600ACBF RID: 44223 RVA: 0x002BC9B0 File Offset: 0x002BABB0
		public Span<int> GetPhotoSetupListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600ACC0 RID: 44224 RVA: 0x002BC9C0 File Offset: 0x002BABC0
		public int[] GetPhotoSetupListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x0600ACC1 RID: 44225 RVA: 0x002BC9D8 File Offset: 0x002BABD8
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

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x0600ACC2 RID: 44226 RVA: 0x002BCA18 File Offset: 0x002BAC18
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

		// Token: 0x0600ACC3 RID: 44227 RVA: 0x002BCA58 File Offset: 0x002BAC58
		public int BanTabList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x0600ACC4 RID: 44228 RVA: 0x002BCA98 File Offset: 0x002BAC98
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

		// Token: 0x0600ACC5 RID: 44229 RVA: 0x002BCAC4 File Offset: 0x002BACC4
		public Span<int> GetBanTabListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600ACC6 RID: 44230 RVA: 0x002BCAD4 File Offset: 0x002BACD4
		public int[] GetBanTabListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600ACC7 RID: 44231 RVA: 0x002BCAEC File Offset: 0x002BACEC
		public int BanSubTabList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x0600ACC8 RID: 44232 RVA: 0x002BCB2C File Offset: 0x002BAD2C
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

		// Token: 0x0600ACC9 RID: 44233 RVA: 0x002BCB58 File Offset: 0x002BAD58
		public Span<int> GetBanSubTabListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600ACCA RID: 44234 RVA: 0x002BCB68 File Offset: 0x002BAD68
		public int[] GetBanSubTabListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x0600ACCB RID: 44235 RVA: 0x002BCB80 File Offset: 0x002BAD80
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

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x0600ACCC RID: 44236 RVA: 0x002BCBC4 File Offset: 0x002BADC4
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

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x0600ACCD RID: 44237 RVA: 0x002BCC08 File Offset: 0x002BAE08
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

		// Token: 0x0600ACCE RID: 44238 RVA: 0x002BCC40 File Offset: 0x002BAE40
		public Span<byte> GetCollisionBlockedTipBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x002BCC50 File Offset: 0x002BAE50
		public byte[] GetCollisionBlockedTipArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600ACD0 RID: 44240 RVA: 0x002BCC68 File Offset: 0x002BAE68
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BanSubTabListIter()或GetBanSubTabListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BanSubTabList()
		{
			PhotoMode photoMode = this;
			return photoMode.GetBanSubTabListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600ACD1 RID: 44241 RVA: 0x002BCC8C File Offset: 0x002BAE8C
		[NullableContext(1)]
		public readonly IEnumerable<int> BanSubTabListIter()
		{
			PhotoMode.<BanSubTabListIter>d__52 <BanSubTabListIter>d__ = new PhotoMode.<BanSubTabListIter>d__52(-2);
			<BanSubTabListIter>d__.<>3__<>4__this = this;
			return <BanSubTabListIter>d__;
		}

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x002BCCA4 File Offset: 0x002BAEA4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BanTabListIter()或GetBanTabListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BanTabList()
		{
			PhotoMode photoMode = this;
			return photoMode.GetBanTabListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x002BCCC8 File Offset: 0x002BAEC8
		[NullableContext(1)]
		public readonly IEnumerable<int> BanTabListIter()
		{
			PhotoMode.<BanTabListIter>d__54 <BanTabListIter>d__ = new PhotoMode.<BanTabListIter>d__54(-2);
			<BanTabListIter>d__.<>3__<>4__this = this;
			return <BanTabListIter>d__;
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x002BCCE0 File Offset: 0x002BAEE0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhotoSetupListIter()或GetPhotoSetupListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhotoSetupList()
		{
			PhotoMode photoMode = this;
			return photoMode.GetPhotoSetupListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600ACD5 RID: 44245 RVA: 0x002BCD04 File Offset: 0x002BAF04
		[NullableContext(1)]
		public readonly IEnumerable<int> PhotoSetupListIter()
		{
			PhotoMode.<PhotoSetupListIter>d__56 <PhotoSetupListIter>d__ = new PhotoMode.<PhotoSetupListIter>d__56(-2);
			<PhotoSetupListIter>d__.<>3__<>4__this = this;
			return <PhotoSetupListIter>d__;
		}

		// Token: 0x04004FDB RID: 20443
		private Table __p;
	}
}
