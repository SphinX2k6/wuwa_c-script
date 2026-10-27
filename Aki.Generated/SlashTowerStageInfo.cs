using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D1 RID: 4305
	public struct SlashTowerStageInfo : IFlatbufferObject
	{
		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x0600D6C6 RID: 54982 RVA: 0x0031B7BC File Offset: 0x003199BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D6C7 RID: 54983 RVA: 0x0031B7C9 File Offset: 0x003199C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D6C8 RID: 54984 RVA: 0x0031B7D0 File Offset: 0x003199D0
		public static SlashTowerStageInfo GetRootAsSlashTowerStageInfo(ByteBuffer _bb)
		{
			return SlashTowerStageInfo.GetRootAsSlashTowerStageInfo(_bb, default(SlashTowerStageInfo));
		}

		// Token: 0x0600D6C9 RID: 54985 RVA: 0x0031B7EC File Offset: 0x003199EC
		public static SlashTowerStageInfo GetRootAsSlashTowerStageInfo(ByteBuffer _bb, SlashTowerStageInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D6CA RID: 54986 RVA: 0x0031B809 File Offset: 0x00319A09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D6CB RID: 54987 RVA: 0x0031B818 File Offset: 0x00319A18
		public SlashTowerStageInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x0600D6CC RID: 54988 RVA: 0x0031B828 File Offset: 0x00319A28
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

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x0600D6CD RID: 54989 RVA: 0x0031B864 File Offset: 0x00319A64
		public int InstId
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

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x0600D6CE RID: 54990 RVA: 0x0031B8A0 File Offset: 0x00319AA0
		public int SeasonVersion
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

		// Token: 0x0600D6CF RID: 54991 RVA: 0x0031B8DC File Offset: 0x00319ADC
		public int MonsterId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x0600D6D0 RID: 54992 RVA: 0x0031B91C File Offset: 0x00319B1C
		public int MonsterIdLength
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

		// Token: 0x0600D6D1 RID: 54993 RVA: 0x0031B948 File Offset: 0x00319B48
		public Span<int> GetMonsterIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600D6D2 RID: 54994 RVA: 0x0031B958 File Offset: 0x00319B58
		public int[] GetMonsterIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600D6D3 RID: 54995 RVA: 0x0031B970 File Offset: 0x00319B70
		public int BuffId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x0600D6D4 RID: 54996 RVA: 0x0031B9B0 File Offset: 0x00319BB0
		public int BuffIdLength
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

		// Token: 0x0600D6D5 RID: 54997 RVA: 0x0031B9DC File Offset: 0x00319BDC
		public Span<int> GetBuffIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D6D6 RID: 54998 RVA: 0x0031B9EC File Offset: 0x00319BEC
		public int[] GetBuffIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600D6D7 RID: 54999 RVA: 0x0031BA04 File Offset: 0x00319C04
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdIter()或GetBuffIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BuffId()
		{
			SlashTowerStageInfo slashTowerStageInfo = this;
			return slashTowerStageInfo.GetBuffIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D6D8 RID: 55000 RVA: 0x0031BA28 File Offset: 0x00319C28
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffIdIter()
		{
			SlashTowerStageInfo.<BuffIdIter>d__25 <BuffIdIter>d__ = new SlashTowerStageInfo.<BuffIdIter>d__25(-2);
			<BuffIdIter>d__.<>3__<>4__this = this;
			return <BuffIdIter>d__;
		}

		// Token: 0x0600D6D9 RID: 55001 RVA: 0x0031BA40 File Offset: 0x00319C40
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterIdIter()或GetMonsterIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MonsterId()
		{
			SlashTowerStageInfo slashTowerStageInfo = this;
			return slashTowerStageInfo.GetMonsterIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D6DA RID: 55002 RVA: 0x0031BA64 File Offset: 0x00319C64
		[NullableContext(1)]
		public readonly IEnumerable<int> MonsterIdIter()
		{
			SlashTowerStageInfo.<MonsterIdIter>d__27 <MonsterIdIter>d__ = new SlashTowerStageInfo.<MonsterIdIter>d__27(-2);
			<MonsterIdIter>d__.<>3__<>4__this = this;
			return <MonsterIdIter>d__;
		}

		// Token: 0x04005203 RID: 20995
		private Table __p;
	}
}
