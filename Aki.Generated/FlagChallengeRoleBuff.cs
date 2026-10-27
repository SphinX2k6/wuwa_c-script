using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C96 RID: 3222
	public struct FlagChallengeRoleBuff : IFlatbufferObject
	{
		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06007160 RID: 29024 RVA: 0x00236095 File Offset: 0x00234295
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x002360A2 File Offset: 0x002342A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x002360AC File Offset: 0x002342AC
		public static FlagChallengeRoleBuff GetRootAsFlagChallengeRoleBuff(ByteBuffer _bb)
		{
			return FlagChallengeRoleBuff.GetRootAsFlagChallengeRoleBuff(_bb, default(FlagChallengeRoleBuff));
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x002360C8 File Offset: 0x002342C8
		public static FlagChallengeRoleBuff GetRootAsFlagChallengeRoleBuff(ByteBuffer _bb, FlagChallengeRoleBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007164 RID: 29028 RVA: 0x002360E5 File Offset: 0x002342E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x002360F4 File Offset: 0x002342F4
		public FlagChallengeRoleBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06007166 RID: 29030 RVA: 0x00236104 File Offset: 0x00234304
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

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06007167 RID: 29031 RVA: 0x00236140 File Offset: 0x00234340
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

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06007168 RID: 29032 RVA: 0x0023617C File Offset: 0x0023437C
		public int Level
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

		// Token: 0x06007169 RID: 29033 RVA: 0x002361B8 File Offset: 0x002343B8
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x0600716A RID: 29034 RVA: 0x002361FC File Offset: 0x002343FC
		public int BuffIdsLength
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

		// Token: 0x0600716B RID: 29035 RVA: 0x00236228 File Offset: 0x00234428
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(10, 8);
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x00236238 File Offset: 0x00234438
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(10) ?? Array.Empty<long>();
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x0600716D RID: 29037 RVA: 0x00236250 File Offset: 0x00234450
		public string IconPathNormal
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

		// Token: 0x0600716E RID: 29038 RVA: 0x00236288 File Offset: 0x00234488
		public Span<byte> GetIconPathNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600716F RID: 29039 RVA: 0x00236298 File Offset: 0x00234498
		public byte[] GetIconPathNormalArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06007170 RID: 29040 RVA: 0x002362B0 File Offset: 0x002344B0
		public string IconPathActive
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

		// Token: 0x06007171 RID: 29041 RVA: 0x002362E8 File Offset: 0x002344E8
		public Span<byte> GetIconPathActiveBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007172 RID: 29042 RVA: 0x002362F8 File Offset: 0x002344F8
		public byte[] GetIconPathActiveArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06007173 RID: 29043 RVA: 0x00236310 File Offset: 0x00234510
		public string BuffName
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

		// Token: 0x06007174 RID: 29044 RVA: 0x00236348 File Offset: 0x00234548
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x00236358 File Offset: 0x00234558
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x06007176 RID: 29046 RVA: 0x00236370 File Offset: 0x00234570
		public string BuffDesc
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

		// Token: 0x06007177 RID: 29047 RVA: 0x002363A8 File Offset: 0x002345A8
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007178 RID: 29048 RVA: 0x002363B8 File Offset: 0x002345B8
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x06007179 RID: 29049 RVA: 0x002363D0 File Offset: 0x002345D0
		public string BuffDescDetail
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

		// Token: 0x0600717A RID: 29050 RVA: 0x00236408 File Offset: 0x00234608
		public Span<byte> GetBuffDescDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600717B RID: 29051 RVA: 0x00236418 File Offset: 0x00234618
		public byte[] GetBuffDescDetailArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600717C RID: 29052 RVA: 0x00236430 File Offset: 0x00234630
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsIter()或GetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIds()
		{
			FlagChallengeRoleBuff flagChallengeRoleBuff = this;
			return flagChallengeRoleBuff.GetBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600717D RID: 29053 RVA: 0x00236454 File Offset: 0x00234654
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsIter()
		{
			FlagChallengeRoleBuff.<BuffIdsIter>d__40 <BuffIdsIter>d__ = new FlagChallengeRoleBuff.<BuffIdsIter>d__40(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x04004CED RID: 19693
		private Table __p;
	}
}
