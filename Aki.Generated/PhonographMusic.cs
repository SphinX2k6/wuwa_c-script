using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F03 RID: 3843
	public struct PhonographMusic : IFlatbufferObject
	{
		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x0600AB07 RID: 43783 RVA: 0x002B8AF4 File Offset: 0x002B6CF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AB08 RID: 43784 RVA: 0x002B8B01 File Offset: 0x002B6D01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AB09 RID: 43785 RVA: 0x002B8B08 File Offset: 0x002B6D08
		public static PhonographMusic GetRootAsPhonographMusic(ByteBuffer _bb)
		{
			return PhonographMusic.GetRootAsPhonographMusic(_bb, default(PhonographMusic));
		}

		// Token: 0x0600AB0A RID: 43786 RVA: 0x002B8B24 File Offset: 0x002B6D24
		public static PhonographMusic GetRootAsPhonographMusic(ByteBuffer _bb, PhonographMusic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AB0B RID: 43787 RVA: 0x002B8B41 File Offset: 0x002B6D41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AB0C RID: 43788 RVA: 0x002B8B50 File Offset: 0x002B6D50
		public PhonographMusic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x0600AB0D RID: 43789 RVA: 0x002B8B60 File Offset: 0x002B6D60
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

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x0600AB0E RID: 43790 RVA: 0x002B8B9C File Offset: 0x002B6D9C
		public int ItemId
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

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x0600AB0F RID: 43791 RVA: 0x002B8BD8 File Offset: 0x002B6DD8
		public string MusicEvent
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

		// Token: 0x0600AB10 RID: 43792 RVA: 0x002B8C0F File Offset: 0x002B6E0F
		public Span<byte> GetMusicEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AB11 RID: 43793 RVA: 0x002B8C1E File Offset: 0x002B6E1E
		public byte[] GetMusicEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AB12 RID: 43794 RVA: 0x002B8C38 File Offset: 0x002B6E38
		public int Album(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x0600AB13 RID: 43795 RVA: 0x002B8C78 File Offset: 0x002B6E78
		public int AlbumLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AB14 RID: 43796 RVA: 0x002B8CA4 File Offset: 0x002B6EA4
		public Span<int> GetAlbumBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600AB15 RID: 43797 RVA: 0x002B8CB4 File Offset: 0x002B6EB4
		public int[] GetAlbumArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x0600AB16 RID: 43798 RVA: 0x002B8CCC File Offset: 0x002B6ECC
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x0600AB17 RID: 43799 RVA: 0x002B8D0C File Offset: 0x002B6F0C
		public string Title
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

		// Token: 0x0600AB18 RID: 43800 RVA: 0x002B8D44 File Offset: 0x002B6F44
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AB19 RID: 43801 RVA: 0x002B8D54 File Offset: 0x002B6F54
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x0600AB1A RID: 43802 RVA: 0x002B8D6C File Offset: 0x002B6F6C
		public string Desc
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

		// Token: 0x0600AB1B RID: 43803 RVA: 0x002B8DA4 File Offset: 0x002B6FA4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AB1C RID: 43804 RVA: 0x002B8DB4 File Offset: 0x002B6FB4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x0600AB1D RID: 43805 RVA: 0x002B8DCC File Offset: 0x002B6FCC
		public string UnlockConditionText
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

		// Token: 0x0600AB1E RID: 43806 RVA: 0x002B8E04 File Offset: 0x002B7004
		public Span<byte> GetUnlockConditionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AB1F RID: 43807 RVA: 0x002B8E14 File Offset: 0x002B7014
		public byte[] GetUnlockConditionTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AB20 RID: 43808 RVA: 0x002B8E2C File Offset: 0x002B702C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AlbumIter()或GetAlbumBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Album()
		{
			PhonographMusic phonographMusic = this;
			return phonographMusic.GetAlbumArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AB21 RID: 43809 RVA: 0x002B8E50 File Offset: 0x002B7050
		[NullableContext(1)]
		public readonly IEnumerable<int> AlbumIter()
		{
			PhonographMusic.<AlbumIter>d__36 <AlbumIter>d__ = new PhonographMusic.<AlbumIter>d__36(-2);
			<AlbumIter>d__.<>3__<>4__this = this;
			return <AlbumIter>d__;
		}

		// Token: 0x04004FCB RID: 20427
		private Table __p;
	}
}
