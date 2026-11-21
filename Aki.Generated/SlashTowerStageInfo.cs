using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011CC RID: 4556
	public struct SlashTowerStageInfo : IFlatbufferObject
	{
		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x0600DEA3 RID: 56995 RVA: 0x0033A714 File Offset: 0x00338914
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DEA4 RID: 56996 RVA: 0x0033A721 File Offset: 0x00338921
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DEA5 RID: 56997 RVA: 0x0033A728 File Offset: 0x00338928
		public static SlashTowerStageInfo GetRootAsSlashTowerStageInfo(ByteBuffer _bb)
		{
			return SlashTowerStageInfo.GetRootAsSlashTowerStageInfo(_bb, default(SlashTowerStageInfo));
		}

		// Token: 0x0600DEA6 RID: 56998 RVA: 0x0033A744 File Offset: 0x00338944
		public static SlashTowerStageInfo GetRootAsSlashTowerStageInfo(ByteBuffer _bb, SlashTowerStageInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DEA7 RID: 56999 RVA: 0x0033A761 File Offset: 0x00338961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DEA8 RID: 57000 RVA: 0x0033A770 File Offset: 0x00338970
		public SlashTowerStageInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x0600DEA9 RID: 57001 RVA: 0x0033A780 File Offset: 0x00338980
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

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x0600DEAA RID: 57002 RVA: 0x0033A7BC File Offset: 0x003389BC
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

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x0600DEAB RID: 57003 RVA: 0x0033A7F8 File Offset: 0x003389F8
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

		// Token: 0x0600DEAC RID: 57004 RVA: 0x0033A834 File Offset: 0x00338A34
		public int MonsterId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x0600DEAD RID: 57005 RVA: 0x0033A874 File Offset: 0x00338A74
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

		// Token: 0x0600DEAE RID: 57006 RVA: 0x0033A8A0 File Offset: 0x00338AA0
		public Span<int> GetMonsterIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600DEAF RID: 57007 RVA: 0x0033A8B0 File Offset: 0x00338AB0
		public int[] GetMonsterIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600DEB0 RID: 57008 RVA: 0x0033A8C8 File Offset: 0x00338AC8
		public int BuffId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x0600DEB1 RID: 57009 RVA: 0x0033A908 File Offset: 0x00338B08
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

		// Token: 0x0600DEB2 RID: 57010 RVA: 0x0033A934 File Offset: 0x00338B34
		public Span<int> GetBuffIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600DEB3 RID: 57011 RVA: 0x0033A944 File Offset: 0x00338B44
		public int[] GetBuffIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600DEB4 RID: 57012 RVA: 0x0033A95C File Offset: 0x00338B5C
		[NullableContext(1)]
		public int[] BuffId()
		{
			return this.GetBuffIdArray();
		}

		// Token: 0x0600DEB5 RID: 57013 RVA: 0x0033A964 File Offset: 0x00338B64
		[NullableContext(1)]
		public IEnumerable<int> BuffIdIter()
		{
			SlashTowerStageInfo.<BuffIdIter>d__25 <BuffIdIter>d__ = new SlashTowerStageInfo.<BuffIdIter>d__25(-2);
			<BuffIdIter>d__.<>3__<>4__this = this;
			return <BuffIdIter>d__;
		}

		// Token: 0x0600DEB6 RID: 57014 RVA: 0x0033A979 File Offset: 0x00338B79
		[NullableContext(1)]
		public int[] MonsterId()
		{
			return this.GetMonsterIdArray();
		}

		// Token: 0x0600DEB7 RID: 57015 RVA: 0x0033A981 File Offset: 0x00338B81
		[NullableContext(1)]
		public IEnumerable<int> MonsterIdIter()
		{
			SlashTowerStageInfo.<MonsterIdIter>d__27 <MonsterIdIter>d__ = new SlashTowerStageInfo.<MonsterIdIter>d__27(-2);
			<MonsterIdIter>d__.<>3__<>4__this = this;
			return <MonsterIdIter>d__;
		}

		// Token: 0x04005802 RID: 22530
		private Table __p;
	}
}
