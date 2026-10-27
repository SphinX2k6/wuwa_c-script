using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1A RID: 3610
	public struct MonsterPerformanceConf : IFlatbufferObject
	{
		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x06009560 RID: 38240 RVA: 0x00288301 File Offset: 0x00286501
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009561 RID: 38241 RVA: 0x0028830E File Offset: 0x0028650E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009562 RID: 38242 RVA: 0x00288318 File Offset: 0x00286518
		public static MonsterPerformanceConf GetRootAsMonsterPerformanceConf(ByteBuffer _bb)
		{
			return MonsterPerformanceConf.GetRootAsMonsterPerformanceConf(_bb, default(MonsterPerformanceConf));
		}

		// Token: 0x06009563 RID: 38243 RVA: 0x00288334 File Offset: 0x00286534
		public static MonsterPerformanceConf GetRootAsMonsterPerformanceConf(ByteBuffer _bb, MonsterPerformanceConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009564 RID: 38244 RVA: 0x00288351 File Offset: 0x00286551
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009565 RID: 38245 RVA: 0x00288360 File Offset: 0x00286560
		public MonsterPerformanceConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x06009566 RID: 38246 RVA: 0x00288370 File Offset: 0x00286570
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

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06009567 RID: 38247 RVA: 0x002883AC File Offset: 0x002865AC
		public int MonsterPerformanceId
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

		// Token: 0x06009568 RID: 38248 RVA: 0x002883E8 File Offset: 0x002865E8
		public int SkillIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06009569 RID: 38249 RVA: 0x00288428 File Offset: 0x00286628
		public int SkillIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x00288453 File Offset: 0x00286653
		public Span<int> GetSkillIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x00288462 File Offset: 0x00286662
		public int[] GetSkillIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x0600956C RID: 38252 RVA: 0x0028847C File Offset: 0x0028667C
		public string Tag
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

		// Token: 0x0600956D RID: 38253 RVA: 0x002884B4 File Offset: 0x002866B4
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600956E RID: 38254 RVA: 0x002884C4 File Offset: 0x002866C4
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600956F RID: 38255 RVA: 0x002884DC File Offset: 0x002866DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIdsIter()或GetSkillIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillIds()
		{
			MonsterPerformanceConf monsterPerformanceConf = this;
			return monsterPerformanceConf.GetSkillIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009570 RID: 38256 RVA: 0x00288500 File Offset: 0x00286700
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillIdsIter()
		{
			MonsterPerformanceConf.<SkillIdsIter>d__22 <SkillIdsIter>d__ = new MonsterPerformanceConf.<SkillIdsIter>d__22(-2);
			<SkillIdsIter>d__.<>3__<>4__this = this;
			return <SkillIdsIter>d__;
		}

		// Token: 0x04004EBF RID: 20159
		private Table __p;
	}
}
