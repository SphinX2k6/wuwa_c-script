using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD6 RID: 3542
	public struct GatherActivity : IFlatbufferObject
	{
		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06007FBD RID: 32701 RVA: 0x002680B5 File Offset: 0x002662B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007FBE RID: 32702 RVA: 0x002680C2 File Offset: 0x002662C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x002680CC File Offset: 0x002662CC
		public static GatherActivity GetRootAsGatherActivity(ByteBuffer _bb)
		{
			return GatherActivity.GetRootAsGatherActivity(_bb, default(GatherActivity));
		}

		// Token: 0x06007FC0 RID: 32704 RVA: 0x002680E8 File Offset: 0x002662E8
		public static GatherActivity GetRootAsGatherActivity(ByteBuffer _bb, GatherActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007FC1 RID: 32705 RVA: 0x00268105 File Offset: 0x00266305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007FC2 RID: 32706 RVA: 0x00268114 File Offset: 0x00266314
		public GatherActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06007FC3 RID: 32707 RVA: 0x00268124 File Offset: 0x00266324
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

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06007FC4 RID: 32708 RVA: 0x00268160 File Offset: 0x00266360
		public int PlayTask
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

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06007FC5 RID: 32709 RVA: 0x0026819C File Offset: 0x0026639C
		public string TaskClue
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

		// Token: 0x06007FC6 RID: 32710 RVA: 0x002681D3 File Offset: 0x002663D3
		public Span<byte> GetTaskClueBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007FC7 RID: 32711 RVA: 0x002681E2 File Offset: 0x002663E2
		public byte[] GetTaskClueArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06007FC8 RID: 32712 RVA: 0x002681FC File Offset: 0x002663FC
		public DicIntInt? SubmitItem(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06007FC9 RID: 32713 RVA: 0x00268260 File Offset: 0x00266460
		public int SubmitItemLength
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

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06007FCA RID: 32714 RVA: 0x0026828C File Offset: 0x0026648C
		public int Reward
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

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06007FCB RID: 32715 RVA: 0x002682CC File Offset: 0x002664CC
		public int LocationEntityConfigId
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

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06007FCC RID: 32716 RVA: 0x0026830C File Offset: 0x0026650C
		public int MarkId
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

		// Token: 0x06007FCD RID: 32717 RVA: 0x0026834C File Offset: 0x0026654C
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06007FCE RID: 32718 RVA: 0x002683B0 File Offset: 0x002665B0
		public int RewardItemLength
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

		// Token: 0x06007FCF RID: 32719 RVA: 0x002683DC File Offset: 0x002665DC
		[NullableContext(1)]
		public Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007FD0 RID: 32720 RVA: 0x00268432 File Offset: 0x00266632
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardItemIter()
		{
			GatherActivity.<RewardItemIter>d__29 <RewardItemIter>d__ = new GatherActivity.<RewardItemIter>d__29(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x00268448 File Offset: 0x00266648
		[NullableContext(1)]
		public Dictionary<int, int> SubmitItem()
		{
			return this.SubmitItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007FD2 RID: 32722 RVA: 0x0026849E File Offset: 0x0026669E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SubmitItemIter()
		{
			GatherActivity.<SubmitItemIter>d__31 <SubmitItemIter>d__ = new GatherActivity.<SubmitItemIter>d__31(-2);
			<SubmitItemIter>d__.<>3__<>4__this = this;
			return <SubmitItemIter>d__;
		}

		// Token: 0x06007FD3 RID: 32723 RVA: 0x002684B4 File Offset: 0x002666B4
		public int? GetRewardItem(int key)
		{
			this.EnsureRewardItemCacheIfNeeded();
			int value;
			if (!this.RewardItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007FD4 RID: 32724 RVA: 0x002684E8 File Offset: 0x002666E8
		public int? GetSubmitItem(int key)
		{
			this.EnsureSubmitItemCacheIfNeeded();
			int value;
			if (!this.SubmitItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007FD5 RID: 32725 RVA: 0x0026851C File Offset: 0x0026671C
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x00268584 File Offset: 0x00266784
		private void EnsureSubmitItemCacheIfNeeded()
		{
			if (this.SubmitItemCache != null)
			{
				return;
			}
			this.SubmitItemCache = this.SubmitItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007FD7 RID: 32727 RVA: 0x002685EA File Offset: 0x002667EA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict()
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x002685F8 File Offset: 0x002667F8
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSubmitItemFrozenDict()
		{
			this.EnsureSubmitItemCacheIfNeeded();
			return this.SubmitItemCache;
		}

		// Token: 0x04005347 RID: 21319
		private Table __p;

		// Token: 0x04005348 RID: 21320
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;

		// Token: 0x04005349 RID: 21321
		[Nullable(2)]
		private FrozenDictionary<int, int> SubmitItemCache;
	}
}
