using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E46 RID: 3654
	public struct MotorFightLevel : IFlatbufferObject
	{
		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x0600987E RID: 39038 RVA: 0x0028F200 File Offset: 0x0028D400
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600987F RID: 39039 RVA: 0x0028F20D File Offset: 0x0028D40D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009880 RID: 39040 RVA: 0x0028F214 File Offset: 0x0028D414
		public static MotorFightLevel GetRootAsMotorFightLevel(ByteBuffer _bb)
		{
			return MotorFightLevel.GetRootAsMotorFightLevel(_bb, default(MotorFightLevel));
		}

		// Token: 0x06009881 RID: 39041 RVA: 0x0028F230 File Offset: 0x0028D430
		public static MotorFightLevel GetRootAsMotorFightLevel(ByteBuffer _bb, MotorFightLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009882 RID: 39042 RVA: 0x0028F24D File Offset: 0x0028D44D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009883 RID: 39043 RVA: 0x0028F25C File Offset: 0x0028D45C
		public MotorFightLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x06009884 RID: 39044 RVA: 0x0028F26C File Offset: 0x0028D46C
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

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x06009885 RID: 39045 RVA: 0x0028F2A8 File Offset: 0x0028D4A8
		public int ActivityId
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

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x06009886 RID: 39046 RVA: 0x0028F2E4 File Offset: 0x0028D4E4
		public int InstId
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

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x06009887 RID: 39047 RVA: 0x0028F320 File Offset: 0x0028D520
		public int InstType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009888 RID: 39048 RVA: 0x0028F360 File Offset: 0x0028D560
		public int PreId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x06009889 RID: 39049 RVA: 0x0028F3A0 File Offset: 0x0028D5A0
		public int PreIdLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600988A RID: 39050 RVA: 0x0028F3CC File Offset: 0x0028D5CC
		public Span<int> GetPreIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600988B RID: 39051 RVA: 0x0028F3DC File Offset: 0x0028D5DC
		public int[] GetPreIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x0600988C RID: 39052 RVA: 0x0028F3F4 File Offset: 0x0028D5F4
		public int OpenDay
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

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x0600988D RID: 39053 RVA: 0x0028F434 File Offset: 0x0028D634
		public string LevelName
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

		// Token: 0x0600988E RID: 39054 RVA: 0x0028F46C File Offset: 0x0028D66C
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600988F RID: 39055 RVA: 0x0028F47C File Offset: 0x0028D67C
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x06009890 RID: 39056 RVA: 0x0028F494 File Offset: 0x0028D694
		public string LevelDesc
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

		// Token: 0x06009891 RID: 39057 RVA: 0x0028F4CC File Offset: 0x0028D6CC
		public Span<byte> GetLevelDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009892 RID: 39058 RVA: 0x0028F4DC File Offset: 0x0028D6DC
		public byte[] GetLevelDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x06009893 RID: 39059 RVA: 0x0028F4F4 File Offset: 0x0028D6F4
		public string LevelTexture
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

		// Token: 0x06009894 RID: 39060 RVA: 0x0028F52C File Offset: 0x0028D72C
		public Span<byte> GetLevelTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009895 RID: 39061 RVA: 0x0028F53C File Offset: 0x0028D73C
		public byte[] GetLevelTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x06009896 RID: 39062 RVA: 0x0028F554 File Offset: 0x0028D754
		public string SerialNumber
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

		// Token: 0x06009897 RID: 39063 RVA: 0x0028F58C File Offset: 0x0028D78C
		public Span<byte> GetSerialNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009898 RID: 39064 RVA: 0x0028F59C File Offset: 0x0028D79C
		public byte[] GetSerialNumberArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x06009899 RID: 39065 RVA: 0x0028F5B4 File Offset: 0x0028D7B4
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x0028F5F4 File Offset: 0x0028D7F4
		public int RecommnedRoleList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x0600989B RID: 39067 RVA: 0x0028F634 File Offset: 0x0028D834
		public int RecommnedRoleListLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x0028F660 File Offset: 0x0028D860
		public Span<int> GetRecommnedRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600989D RID: 39069 RVA: 0x0028F670 File Offset: 0x0028D870
		public int[] GetRecommnedRoleListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x0600989E RID: 39070 RVA: 0x0028F688 File Offset: 0x0028D888
		public int Column
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x0600989F RID: 39071 RVA: 0x0028F6C8 File Offset: 0x0028D8C8
		public int Row
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x060098A0 RID: 39072 RVA: 0x0028F708 File Offset: 0x0028D908
		public string LevelBg
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060098A1 RID: 39073 RVA: 0x0028F740 File Offset: 0x0028D940
		public Span<byte> GetLevelBgBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060098A2 RID: 39074 RVA: 0x0028F750 File Offset: 0x0028D950
		public byte[] GetLevelBgArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x060098A3 RID: 39075 RVA: 0x0028F768 File Offset: 0x0028D968
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreIdIter()或GetPreIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreId()
		{
			MotorFightLevel motorFightLevel = this;
			return motorFightLevel.GetPreIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x0028F78C File Offset: 0x0028D98C
		[NullableContext(1)]
		public readonly IEnumerable<int> PreIdIter()
		{
			MotorFightLevel.<PreIdIter>d__55 <PreIdIter>d__ = new MotorFightLevel.<PreIdIter>d__55(-2);
			<PreIdIter>d__.<>3__<>4__this = this;
			return <PreIdIter>d__;
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x0028F7A4 File Offset: 0x0028D9A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommnedRoleListIter()或GetRecommnedRoleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommnedRoleList()
		{
			MotorFightLevel motorFightLevel = this;
			return motorFightLevel.GetRecommnedRoleListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x0028F7C8 File Offset: 0x0028D9C8
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommnedRoleListIter()
		{
			MotorFightLevel.<RecommnedRoleListIter>d__57 <RecommnedRoleListIter>d__ = new MotorFightLevel.<RecommnedRoleListIter>d__57(-2);
			<RecommnedRoleListIter>d__.<>3__<>4__this = this;
			return <RecommnedRoleListIter>d__;
		}

		// Token: 0x04004EEE RID: 20206
		private Table __p;
	}
}
