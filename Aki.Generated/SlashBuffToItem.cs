using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011CA RID: 4554
	public struct SlashBuffToItem : IFlatbufferObject
	{
		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x0600DE84 RID: 56964 RVA: 0x0033A2BC File Offset: 0x003384BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE85 RID: 56965 RVA: 0x0033A2C9 File Offset: 0x003384C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE86 RID: 56966 RVA: 0x0033A2D0 File Offset: 0x003384D0
		public static SlashBuffToItem GetRootAsSlashBuffToItem(ByteBuffer _bb)
		{
			return SlashBuffToItem.GetRootAsSlashBuffToItem(_bb, default(SlashBuffToItem));
		}

		// Token: 0x0600DE87 RID: 56967 RVA: 0x0033A2EC File Offset: 0x003384EC
		public static SlashBuffToItem GetRootAsSlashBuffToItem(ByteBuffer _bb, SlashBuffToItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE88 RID: 56968 RVA: 0x0033A309 File Offset: 0x00338509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE89 RID: 56969 RVA: 0x0033A318 File Offset: 0x00338518
		public SlashBuffToItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x0600DE8A RID: 56970 RVA: 0x0033A328 File Offset: 0x00338528
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

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x0600DE8B RID: 56971 RVA: 0x0033A364 File Offset: 0x00338564
		public int Season
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

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0600DE8C RID: 56972 RVA: 0x0033A3A0 File Offset: 0x003385A0
		public int ItemId
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

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0600DE8D RID: 56973 RVA: 0x0033A3DC File Offset: 0x003385DC
		public int Tips
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

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0600DE8E RID: 56974 RVA: 0x0033A41C File Offset: 0x0033861C
		public int StartSeason
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x0600DE8F RID: 56975 RVA: 0x0033A45C File Offset: 0x0033865C
		public int EndSeason
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0600DE90 RID: 56976 RVA: 0x0033A49C File Offset: 0x0033869C
		public bool Unlimited
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600DE91 RID: 56977 RVA: 0x0033A4DC File Offset: 0x003386DC
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0600DE92 RID: 56978 RVA: 0x0033A520 File Offset: 0x00338720
		public int BuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DE93 RID: 56979 RVA: 0x0033A54C File Offset: 0x0033874C
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(18, 8);
		}

		// Token: 0x0600DE94 RID: 56980 RVA: 0x0033A55C File Offset: 0x0033875C
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(18) ?? Array.Empty<long>();
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0600DE95 RID: 56981 RVA: 0x0033A574 File Offset: 0x00338774
		public int BuffTime
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

		// Token: 0x0600DE96 RID: 56982 RVA: 0x0033A5B1 File Offset: 0x003387B1
		[NullableContext(1)]
		public long[] BuffIds()
		{
			return this.GetBuffIdsArray();
		}

		// Token: 0x0600DE97 RID: 56983 RVA: 0x0033A5B9 File Offset: 0x003387B9
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsIter()
		{
			SlashBuffToItem.<BuffIdsIter>d__30 <BuffIdsIter>d__ = new SlashBuffToItem.<BuffIdsIter>d__30(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x04005800 RID: 22528
		private Table __p;
	}
}
