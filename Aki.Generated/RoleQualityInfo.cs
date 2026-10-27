using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001057 RID: 4183
	public struct RoleQualityInfo : IFlatbufferObject
	{
		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600C9CB RID: 51659 RVA: 0x002FD509 File Offset: 0x002FB709
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C9CC RID: 51660 RVA: 0x002FD516 File Offset: 0x002FB716
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C9CD RID: 51661 RVA: 0x002FD520 File Offset: 0x002FB720
		public static RoleQualityInfo GetRootAsRoleQualityInfo(ByteBuffer _bb)
		{
			return RoleQualityInfo.GetRootAsRoleQualityInfo(_bb, default(RoleQualityInfo));
		}

		// Token: 0x0600C9CE RID: 51662 RVA: 0x002FD53C File Offset: 0x002FB73C
		public static RoleQualityInfo GetRootAsRoleQualityInfo(ByteBuffer _bb, RoleQualityInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C9CF RID: 51663 RVA: 0x002FD559 File Offset: 0x002FB759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C9D0 RID: 51664 RVA: 0x002FD568 File Offset: 0x002FB768
		public RoleQualityInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600C9D1 RID: 51665 RVA: 0x002FD578 File Offset: 0x002FB778
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

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600C9D2 RID: 51666 RVA: 0x002FD5B4 File Offset: 0x002FB7B4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C9D3 RID: 51667 RVA: 0x002FD5EB File Offset: 0x002FB7EB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C9D4 RID: 51668 RVA: 0x002FD5FA File Offset: 0x002FB7FA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600C9D5 RID: 51669 RVA: 0x002FD614 File Offset: 0x002FB814
		public string Icon
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

		// Token: 0x0600C9D6 RID: 51670 RVA: 0x002FD64B File Offset: 0x002FB84B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C9D7 RID: 51671 RVA: 0x002FD65A File Offset: 0x002FB85A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600C9D8 RID: 51672 RVA: 0x002FD674 File Offset: 0x002FB874
		public string QualityColor
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

		// Token: 0x0600C9D9 RID: 51673 RVA: 0x002FD6AC File Offset: 0x002FB8AC
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C9DA RID: 51674 RVA: 0x002FD6BC File Offset: 0x002FB8BC
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600C9DB RID: 51675 RVA: 0x002FD6D4 File Offset: 0x002FB8D4
		public string Image
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

		// Token: 0x0600C9DC RID: 51676 RVA: 0x002FD70C File Offset: 0x002FB90C
		public Span<byte> GetImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C9DD RID: 51677 RVA: 0x002FD71C File Offset: 0x002FB91C
		public byte[] GetImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600C9DE RID: 51678 RVA: 0x002FD734 File Offset: 0x002FB934
		public string GachaQualityImage
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

		// Token: 0x0600C9DF RID: 51679 RVA: 0x002FD76C File Offset: 0x002FB96C
		public Span<byte> GetGachaQualityImageBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C9E0 RID: 51680 RVA: 0x002FD77C File Offset: 0x002FB97C
		public byte[] GetGachaQualityImageArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C9E1 RID: 51681 RVA: 0x002FD794 File Offset: 0x002FB994
		public DicIntInt? SpiloverCompensate(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600C9E2 RID: 51682 RVA: 0x002FD7F8 File Offset: 0x002FB9F8
		public int SpiloverCompensateLength
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

		// Token: 0x0600C9E3 RID: 51683 RVA: 0x002FD824 File Offset: 0x002FBA24
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SpiloverCompensateFrozenDict()缓存字典，遍历请使用SpiloverCompensateIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SpiloverCompensate()
		{
			return this.SpiloverCompensateIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C9E4 RID: 51684 RVA: 0x002FD87A File Offset: 0x002FBA7A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SpiloverCompensateIter()
		{
			RoleQualityInfo.<SpiloverCompensateIter>d__34 <SpiloverCompensateIter>d__ = new RoleQualityInfo.<SpiloverCompensateIter>d__34(-2);
			<SpiloverCompensateIter>d__.<>3__<>4__this = this;
			return <SpiloverCompensateIter>d__;
		}

		// Token: 0x0600C9E5 RID: 51685 RVA: 0x002FD890 File Offset: 0x002FBA90
		public int? GetSpiloverCompensate(int key)
		{
			this.EnsureSpiloverCompensateCacheIfNeeded();
			int value;
			if (!this.SpiloverCompensateCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C9E6 RID: 51686 RVA: 0x002FD8C4 File Offset: 0x002FBAC4
		private void EnsureSpiloverCompensateCacheIfNeeded()
		{
			if (this.SpiloverCompensateCache != null)
			{
				return;
			}
			this.SpiloverCompensateCache = this.SpiloverCompensateIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C9E7 RID: 51687 RVA: 0x002FD92A File Offset: 0x002FBB2A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSpiloverCompensateFrozenDict(int key)
		{
			this.EnsureSpiloverCompensateCacheIfNeeded();
			return this.SpiloverCompensateCache;
		}

		// Token: 0x04005158 RID: 20824
		private Table __p;

		// Token: 0x04005159 RID: 20825
		[Nullable(2)]
		private FrozenDictionary<int, int> SpiloverCompensateCache;
	}
}
