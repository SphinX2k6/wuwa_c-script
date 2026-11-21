using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114A RID: 4426
	public struct RoleTowerBranch : IFlatbufferObject
	{
		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600D1C5 RID: 53701 RVA: 0x0031D13C File Offset: 0x0031B33C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D1C6 RID: 53702 RVA: 0x0031D149 File Offset: 0x0031B349
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D1C7 RID: 53703 RVA: 0x0031D150 File Offset: 0x0031B350
		public static RoleTowerBranch GetRootAsRoleTowerBranch(ByteBuffer _bb)
		{
			return RoleTowerBranch.GetRootAsRoleTowerBranch(_bb, default(RoleTowerBranch));
		}

		// Token: 0x0600D1C8 RID: 53704 RVA: 0x0031D16C File Offset: 0x0031B36C
		public static RoleTowerBranch GetRootAsRoleTowerBranch(ByteBuffer _bb, RoleTowerBranch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D1C9 RID: 53705 RVA: 0x0031D189 File Offset: 0x0031B389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D1CA RID: 53706 RVA: 0x0031D198 File Offset: 0x0031B398
		public RoleTowerBranch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600D1CB RID: 53707 RVA: 0x0031D1A8 File Offset: 0x0031B3A8
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

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600D1CC RID: 53708 RVA: 0x0031D1E4 File Offset: 0x0031B3E4
		public int Type
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

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600D1CD RID: 53709 RVA: 0x0031D220 File Offset: 0x0031B420
		public int AddTime
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

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600D1CE RID: 53710 RVA: 0x0031D25C File Offset: 0x0031B45C
		public string BranchTitle
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

		// Token: 0x0600D1CF RID: 53711 RVA: 0x0031D294 File Offset: 0x0031B494
		public Span<byte> GetBranchTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D1D0 RID: 53712 RVA: 0x0031D2A4 File Offset: 0x0031B4A4
		public byte[] GetBranchTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600D1D1 RID: 53713 RVA: 0x0031D2BC File Offset: 0x0031B4BC
		public string BranchDes
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

		// Token: 0x0600D1D2 RID: 53714 RVA: 0x0031D2F4 File Offset: 0x0031B4F4
		public Span<byte> GetBranchDesBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D1D3 RID: 53715 RVA: 0x0031D304 File Offset: 0x0031B504
		public byte[] GetBranchDesArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D1D4 RID: 53716 RVA: 0x0031D31C File Offset: 0x0031B51C
		public string BranchDesParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600D1D5 RID: 53717 RVA: 0x0031D358 File Offset: 0x0031B558
		public int BranchDesParamLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D1D6 RID: 53718 RVA: 0x0031D384 File Offset: 0x0031B584
		public DicIntInt? BranchTokenList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600D1D7 RID: 53719 RVA: 0x0031D3E8 File Offset: 0x0031B5E8
		public int BranchTokenListLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D1D8 RID: 53720 RVA: 0x0031D414 File Offset: 0x0031B614
		[NullableContext(1)]
		public string[] BranchDesParam()
		{
			return this.BranchDesParamIter().ToArray<string>();
		}

		// Token: 0x0600D1D9 RID: 53721 RVA: 0x0031D421 File Offset: 0x0031B621
		[NullableContext(1)]
		public IEnumerable<string> BranchDesParamIter()
		{
			RoleTowerBranch.<BranchDesParamIter>d__29 <BranchDesParamIter>d__ = new RoleTowerBranch.<BranchDesParamIter>d__29(-2);
			<BranchDesParamIter>d__.<>3__<>4__this = this;
			return <BranchDesParamIter>d__;
		}

		// Token: 0x0600D1DA RID: 53722 RVA: 0x0031D438 File Offset: 0x0031B638
		[NullableContext(1)]
		public Dictionary<int, int> BranchTokenList()
		{
			return this.BranchTokenListIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D1DB RID: 53723 RVA: 0x0031D48E File Offset: 0x0031B68E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> BranchTokenListIter()
		{
			RoleTowerBranch.<BranchTokenListIter>d__31 <BranchTokenListIter>d__ = new RoleTowerBranch.<BranchTokenListIter>d__31(-2);
			<BranchTokenListIter>d__.<>3__<>4__this = this;
			return <BranchTokenListIter>d__;
		}

		// Token: 0x0600D1DC RID: 53724 RVA: 0x0031D4A4 File Offset: 0x0031B6A4
		public int? GetBranchTokenList(int key)
		{
			this.EnsureBranchTokenListCacheIfNeeded();
			int value;
			if (!this.BranchTokenListCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D1DD RID: 53725 RVA: 0x0031D4D8 File Offset: 0x0031B6D8
		private void EnsureBranchTokenListCacheIfNeeded()
		{
			if (this.BranchTokenListCache != null)
			{
				return;
			}
			this.BranchTokenListCache = this.BranchTokenListIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D1DE RID: 53726 RVA: 0x0031D53E File Offset: 0x0031B73E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetBranchTokenListFrozenDict()
		{
			this.EnsureBranchTokenListCacheIfNeeded();
			return this.BranchTokenListCache;
		}

		// Token: 0x0400574E RID: 22350
		private Table __p;

		// Token: 0x0400574F RID: 22351
		[Nullable(2)]
		private FrozenDictionary<int, int> BranchTokenListCache;
	}
}
