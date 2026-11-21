using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119E RID: 4510
	public struct SheriffQuest : IFlatbufferObject
	{
		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x0600D90C RID: 55564 RVA: 0x0032CD7D File Offset: 0x0032AF7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D90D RID: 55565 RVA: 0x0032CD8A File Offset: 0x0032AF8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D90E RID: 55566 RVA: 0x0032CD94 File Offset: 0x0032AF94
		public static SheriffQuest GetRootAsSheriffQuest(ByteBuffer _bb)
		{
			return SheriffQuest.GetRootAsSheriffQuest(_bb, default(SheriffQuest));
		}

		// Token: 0x0600D90F RID: 55567 RVA: 0x0032CDB0 File Offset: 0x0032AFB0
		public static SheriffQuest GetRootAsSheriffQuest(ByteBuffer _bb, SheriffQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D910 RID: 55568 RVA: 0x0032CDCD File Offset: 0x0032AFCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D911 RID: 55569 RVA: 0x0032CDDC File Offset: 0x0032AFDC
		public SheriffQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0600D912 RID: 55570 RVA: 0x0032CDEC File Offset: 0x0032AFEC
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

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0600D913 RID: 55571 RVA: 0x0032CE28 File Offset: 0x0032B028
		public int SheriffZoneId
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

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0600D914 RID: 55572 RVA: 0x0032CE64 File Offset: 0x0032B064
		public int QuestId
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

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0600D915 RID: 55573 RVA: 0x0032CEA0 File Offset: 0x0032B0A0
		public int MarkId
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

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0600D916 RID: 55574 RVA: 0x0032CEE0 File Offset: 0x0032B0E0
		public int QuestType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x0600D917 RID: 55575 RVA: 0x0032CF20 File Offset: 0x0032B120
		public int UnlockConditionGroupId
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

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x0600D918 RID: 55576 RVA: 0x0032CF60 File Offset: 0x0032B160
		public string UnFinishDesc
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

		// Token: 0x0600D919 RID: 55577 RVA: 0x0032CF98 File Offset: 0x0032B198
		public Span<byte> GetUnFinishDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D91A RID: 55578 RVA: 0x0032CFA8 File Offset: 0x0032B1A8
		public byte[] GetUnFinishDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x0600D91B RID: 55579 RVA: 0x0032CFC0 File Offset: 0x0032B1C0
		public string GlobalVar
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

		// Token: 0x0600D91C RID: 55580 RVA: 0x0032CFF8 File Offset: 0x0032B1F8
		public Span<byte> GetGlobalVarBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D91D RID: 55581 RVA: 0x0032D008 File Offset: 0x0032B208
		public byte[] GetGlobalVarArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D91E RID: 55582 RVA: 0x0032D020 File Offset: 0x0032B220
		public DicIntString? FinishedDescDic(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x0600D91F RID: 55583 RVA: 0x0032D084 File Offset: 0x0032B284
		public int FinishedDescDicLength
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

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0600D920 RID: 55584 RVA: 0x0032D0B0 File Offset: 0x0032B2B0
		public string Picture
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

		// Token: 0x0600D921 RID: 55585 RVA: 0x0032D0E8 File Offset: 0x0032B2E8
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D922 RID: 55586 RVA: 0x0032D0F8 File Offset: 0x0032B2F8
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0600D923 RID: 55587 RVA: 0x0032D110 File Offset: 0x0032B310
		public int TextVisibleScale
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

		// Token: 0x0600D924 RID: 55588 RVA: 0x0032D150 File Offset: 0x0032B350
		[NullableContext(1)]
		public Dictionary<int, string> FinishedDescDic()
		{
			return this.FinishedDescDicIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600D925 RID: 55589 RVA: 0x0032D1A6 File Offset: 0x0032B3A6
		[NullableContext(1)]
		public IEnumerable<DicIntString> FinishedDescDicIter()
		{
			SheriffQuest.<FinishedDescDicIter>d__38 <FinishedDescDicIter>d__ = new SheriffQuest.<FinishedDescDicIter>d__38(-2);
			<FinishedDescDicIter>d__.<>3__<>4__this = this;
			return <FinishedDescDicIter>d__;
		}

		// Token: 0x0600D926 RID: 55590 RVA: 0x0032D1BC File Offset: 0x0032B3BC
		[NullableContext(2)]
		public string GetFinishedDescDic(int key)
		{
			this.EnsureFinishedDescDicCacheIfNeeded();
			string result;
			if (!this.FinishedDescDicCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600D927 RID: 55591 RVA: 0x0032D1E4 File Offset: 0x0032B3E4
		private void EnsureFinishedDescDicCacheIfNeeded()
		{
			if (this.FinishedDescDicCache != null)
			{
				return;
			}
			this.FinishedDescDicCache = this.FinishedDescDicIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600D928 RID: 55592 RVA: 0x0032D24A File Offset: 0x0032B44A
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetFinishedDescDicFrozenDict()
		{
			this.EnsureFinishedDescDicCacheIfNeeded();
			return this.FinishedDescDicCache;
		}

		// Token: 0x040057B0 RID: 22448
		private Table __p;

		// Token: 0x040057B1 RID: 22449
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> FinishedDescDicCache;
	}
}
