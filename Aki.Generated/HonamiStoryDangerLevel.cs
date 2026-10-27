using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D33 RID: 3379
	public struct HonamiStoryDangerLevel : IFlatbufferObject
	{
		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06007F4B RID: 32587 RVA: 0x0025602C File Offset: 0x0025422C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F4C RID: 32588 RVA: 0x00256039 File Offset: 0x00254239
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F4D RID: 32589 RVA: 0x00256040 File Offset: 0x00254240
		public static HonamiStoryDangerLevel GetRootAsHonamiStoryDangerLevel(ByteBuffer _bb)
		{
			return HonamiStoryDangerLevel.GetRootAsHonamiStoryDangerLevel(_bb, default(HonamiStoryDangerLevel));
		}

		// Token: 0x06007F4E RID: 32590 RVA: 0x0025605C File Offset: 0x0025425C
		public static HonamiStoryDangerLevel GetRootAsHonamiStoryDangerLevel(ByteBuffer _bb, HonamiStoryDangerLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F4F RID: 32591 RVA: 0x00256079 File Offset: 0x00254279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F50 RID: 32592 RVA: 0x00256088 File Offset: 0x00254288
		public HonamiStoryDangerLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06007F51 RID: 32593 RVA: 0x00256098 File Offset: 0x00254298
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

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06007F52 RID: 32594 RVA: 0x002560D4 File Offset: 0x002542D4
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

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06007F53 RID: 32595 RVA: 0x00256110 File Offset: 0x00254310
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

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06007F54 RID: 32596 RVA: 0x0025614C File Offset: 0x0025434C
		public int MonsterEnhanceLevel
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

		// Token: 0x06007F55 RID: 32597 RVA: 0x0025618C File Offset: 0x0025438C
		public DicIntInt? ConsumeItems(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06007F56 RID: 32598 RVA: 0x002561F0 File Offset: 0x002543F0
		public int ConsumeItemsLength
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

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06007F57 RID: 32599 RVA: 0x0025621C File Offset: 0x0025441C
		public int SafeLeavePrice
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

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06007F58 RID: 32600 RVA: 0x0025625C File Offset: 0x0025445C
		public int AddDropLevel
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

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06007F59 RID: 32601 RVA: 0x0025629C File Offset: 0x0025449C
		public int DangerLv
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

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06007F5A RID: 32602 RVA: 0x002562DC File Offset: 0x002544DC
		public int PollutionGroup
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

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06007F5B RID: 32603 RVA: 0x0025631C File Offset: 0x0025451C
		public string LvShow
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

		// Token: 0x06007F5C RID: 32604 RVA: 0x00256354 File Offset: 0x00254554
		public Span<byte> GetLvShowBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x00256364 File Offset: 0x00254564
		public byte[] GetLvShowArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06007F5E RID: 32606 RVA: 0x0025637C File Offset: 0x0025457C
		public string FallQuaId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x002563B4 File Offset: 0x002545B4
		public Span<byte> GetFallQuaIdBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007F60 RID: 32608 RVA: 0x002563C4 File Offset: 0x002545C4
		public byte[] GetFallQuaIdArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06007F61 RID: 32609 RVA: 0x002563DC File Offset: 0x002545DC
		public int HightQuality
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06007F62 RID: 32610 RVA: 0x0025641C File Offset: 0x0025461C
		public int BoZaiTalk
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

		// Token: 0x06007F63 RID: 32611 RVA: 0x0025645C File Offset: 0x0025465C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeItemsFrozenDict()缓存字典，遍历请使用ConsumeItemsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ConsumeItems()
		{
			return this.ConsumeItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007F64 RID: 32612 RVA: 0x002564B2 File Offset: 0x002546B2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeItemsIter()
		{
			HonamiStoryDangerLevel.<ConsumeItemsIter>d__40 <ConsumeItemsIter>d__ = new HonamiStoryDangerLevel.<ConsumeItemsIter>d__40(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x06007F65 RID: 32613 RVA: 0x002564C8 File Offset: 0x002546C8
		public int? GetConsumeItems(int key)
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			int value;
			if (!this.ConsumeItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007F66 RID: 32614 RVA: 0x002564FC File Offset: 0x002546FC
		private void EnsureConsumeItemsCacheIfNeeded()
		{
			if (this.ConsumeItemsCache != null)
			{
				return;
			}
			this.ConsumeItemsCache = this.ConsumeItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007F67 RID: 32615 RVA: 0x00256562 File Offset: 0x00254762
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeItemsFrozenDict(int key)
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			return this.ConsumeItemsCache;
		}

		// Token: 0x04004DAC RID: 19884
		private Table __p;

		// Token: 0x04004DAD RID: 19885
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeItemsCache;
	}
}
