using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCF RID: 3535
	public struct LinkData : IFlatbufferObject
	{
		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06008E79 RID: 36473 RVA: 0x00278816 File Offset: 0x00276A16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E7A RID: 36474 RVA: 0x00278823 File Offset: 0x00276A23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E7B RID: 36475 RVA: 0x0027882C File Offset: 0x00276A2C
		public static LinkData GetRootAsLinkData(ByteBuffer _bb)
		{
			return LinkData.GetRootAsLinkData(_bb, default(LinkData));
		}

		// Token: 0x06008E7C RID: 36476 RVA: 0x00278848 File Offset: 0x00276A48
		public static LinkData GetRootAsLinkData(ByteBuffer _bb, LinkData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E7D RID: 36477 RVA: 0x00278865 File Offset: 0x00276A65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x00278874 File Offset: 0x00276A74
		public LinkData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06008E7F RID: 36479 RVA: 0x00278884 File Offset: 0x00276A84
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

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06008E80 RID: 36480 RVA: 0x002788C0 File Offset: 0x00276AC0
		public int BattleScoreId
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

		// Token: 0x06008E81 RID: 36481 RVA: 0x002788FC File Offset: 0x00276AFC
		public long BuffIdsInAccumulate(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06008E82 RID: 36482 RVA: 0x0027893C File Offset: 0x00276B3C
		public int BuffIdsInAccumulateLength
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

		// Token: 0x06008E83 RID: 36483 RVA: 0x00278967 File Offset: 0x00276B67
		public Span<long> GetBuffIdsInAccumulateBytes()
		{
			return this.__p.__vector_as_span<long>(8, 8);
		}

		// Token: 0x06008E84 RID: 36484 RVA: 0x00278976 File Offset: 0x00276B76
		public long[] GetBuffIdsInAccumulateArray()
		{
			return this.__p.__vector_as_array<long>(8) ?? Array.Empty<long>();
		}

		// Token: 0x06008E85 RID: 36485 RVA: 0x00278990 File Offset: 0x00276B90
		public long BulletIdsInAccumulate(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06008E86 RID: 36486 RVA: 0x002789D4 File Offset: 0x00276BD4
		public int BulletIdsInAccumulateLength
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

		// Token: 0x06008E87 RID: 36487 RVA: 0x00278A00 File Offset: 0x00276C00
		public Span<long> GetBulletIdsInAccumulateBytes()
		{
			return this.__p.__vector_as_span<long>(10, 8);
		}

		// Token: 0x06008E88 RID: 36488 RVA: 0x00278A10 File Offset: 0x00276C10
		public long[] GetBulletIdsInAccumulateArray()
		{
			return this.__p.__vector_as_array<long>(10) ?? Array.Empty<long>();
		}

		// Token: 0x06008E89 RID: 36489 RVA: 0x00278A28 File Offset: 0x00276C28
		public long BuffIdsInReady(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06008E8A RID: 36490 RVA: 0x00278A6C File Offset: 0x00276C6C
		public int BuffIdsInReadyLength
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

		// Token: 0x06008E8B RID: 36491 RVA: 0x00278A98 File Offset: 0x00276C98
		public Span<long> GetBuffIdsInReadyBytes()
		{
			return this.__p.__vector_as_span<long>(12, 8);
		}

		// Token: 0x06008E8C RID: 36492 RVA: 0x00278AA8 File Offset: 0x00276CA8
		public long[] GetBuffIdsInReadyArray()
		{
			return this.__p.__vector_as_array<long>(12) ?? Array.Empty<long>();
		}

		// Token: 0x06008E8D RID: 36493 RVA: 0x00278AC0 File Offset: 0x00276CC0
		public long BulletIdsInReady(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06008E8E RID: 36494 RVA: 0x00278B04 File Offset: 0x00276D04
		public int BulletIdsInReadyLength
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

		// Token: 0x06008E8F RID: 36495 RVA: 0x00278B30 File Offset: 0x00276D30
		public Span<long> GetBulletIdsInReadyBytes()
		{
			return this.__p.__vector_as_span<long>(14, 8);
		}

		// Token: 0x06008E90 RID: 36496 RVA: 0x00278B40 File Offset: 0x00276D40
		public long[] GetBulletIdsInReadyArray()
		{
			return this.__p.__vector_as_array<long>(14) ?? Array.Empty<long>();
		}

		// Token: 0x06008E91 RID: 36497 RVA: 0x00278B58 File Offset: 0x00276D58
		public long BuffIdsInBrust(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06008E92 RID: 36498 RVA: 0x00278B9C File Offset: 0x00276D9C
		public int BuffIdsInBrustLength
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

		// Token: 0x06008E93 RID: 36499 RVA: 0x00278BC8 File Offset: 0x00276DC8
		public Span<long> GetBuffIdsInBrustBytes()
		{
			return this.__p.__vector_as_span<long>(16, 8);
		}

		// Token: 0x06008E94 RID: 36500 RVA: 0x00278BD8 File Offset: 0x00276DD8
		public long[] GetBuffIdsInBrustArray()
		{
			return this.__p.__vector_as_array<long>(16) ?? Array.Empty<long>();
		}

		// Token: 0x06008E95 RID: 36501 RVA: 0x00278BF0 File Offset: 0x00276DF0
		public long BulletIdsInBrust(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06008E96 RID: 36502 RVA: 0x00278C34 File Offset: 0x00276E34
		public int BulletIdsInBrustLength
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

		// Token: 0x06008E97 RID: 36503 RVA: 0x00278C60 File Offset: 0x00276E60
		public Span<long> GetBulletIdsInBrustBytes()
		{
			return this.__p.__vector_as_span<long>(18, 8);
		}

		// Token: 0x06008E98 RID: 36504 RVA: 0x00278C70 File Offset: 0x00276E70
		public long[] GetBulletIdsInBrustArray()
		{
			return this.__p.__vector_as_array<long>(18) ?? Array.Empty<long>();
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06008E99 RID: 36505 RVA: 0x00278C88 File Offset: 0x00276E88
		public float BrustDuration
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06008E9A RID: 36506 RVA: 0x00278CCC File Offset: 0x00276ECC
		public int IsEnableOneRoleBurst
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x06008E9B RID: 36507 RVA: 0x00278D0C File Offset: 0x00276F0C
		public int OneRoleBurstTeammateId
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

		// Token: 0x06008E9C RID: 36508 RVA: 0x00278D4C File Offset: 0x00276F4C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsInAccumulateIter()或GetBuffIdsInAccumulateBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIdsInAccumulate()
		{
			LinkData linkData = this;
			return linkData.GetBuffIdsInAccumulateArray() ?? Array.Empty<long>();
		}

		// Token: 0x06008E9D RID: 36509 RVA: 0x00278D70 File Offset: 0x00276F70
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsInAccumulateIter()
		{
			LinkData.<BuffIdsInAccumulateIter>d__49 <BuffIdsInAccumulateIter>d__ = new LinkData.<BuffIdsInAccumulateIter>d__49(-2);
			<BuffIdsInAccumulateIter>d__.<>3__<>4__this = this;
			return <BuffIdsInAccumulateIter>d__;
		}

		// Token: 0x06008E9E RID: 36510 RVA: 0x00278D88 File Offset: 0x00276F88
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsInBrustIter()或GetBuffIdsInBrustBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIdsInBrust()
		{
			LinkData linkData = this;
			return linkData.GetBuffIdsInBrustArray() ?? Array.Empty<long>();
		}

		// Token: 0x06008E9F RID: 36511 RVA: 0x00278DAC File Offset: 0x00276FAC
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsInBrustIter()
		{
			LinkData.<BuffIdsInBrustIter>d__51 <BuffIdsInBrustIter>d__ = new LinkData.<BuffIdsInBrustIter>d__51(-2);
			<BuffIdsInBrustIter>d__.<>3__<>4__this = this;
			return <BuffIdsInBrustIter>d__;
		}

		// Token: 0x06008EA0 RID: 36512 RVA: 0x00278DC4 File Offset: 0x00276FC4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsInReadyIter()或GetBuffIdsInReadyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIdsInReady()
		{
			LinkData linkData = this;
			return linkData.GetBuffIdsInReadyArray() ?? Array.Empty<long>();
		}

		// Token: 0x06008EA1 RID: 36513 RVA: 0x00278DE8 File Offset: 0x00276FE8
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsInReadyIter()
		{
			LinkData.<BuffIdsInReadyIter>d__53 <BuffIdsInReadyIter>d__ = new LinkData.<BuffIdsInReadyIter>d__53(-2);
			<BuffIdsInReadyIter>d__.<>3__<>4__this = this;
			return <BuffIdsInReadyIter>d__;
		}

		// Token: 0x06008EA2 RID: 36514 RVA: 0x00278E00 File Offset: 0x00277000
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BulletIdsInAccumulateIter()或GetBulletIdsInAccumulateBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BulletIdsInAccumulate()
		{
			LinkData linkData = this;
			return linkData.GetBulletIdsInAccumulateArray() ?? Array.Empty<long>();
		}

		// Token: 0x06008EA3 RID: 36515 RVA: 0x00278E24 File Offset: 0x00277024
		[NullableContext(1)]
		public readonly IEnumerable<long> BulletIdsInAccumulateIter()
		{
			LinkData.<BulletIdsInAccumulateIter>d__55 <BulletIdsInAccumulateIter>d__ = new LinkData.<BulletIdsInAccumulateIter>d__55(-2);
			<BulletIdsInAccumulateIter>d__.<>3__<>4__this = this;
			return <BulletIdsInAccumulateIter>d__;
		}

		// Token: 0x06008EA4 RID: 36516 RVA: 0x00278E3C File Offset: 0x0027703C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BulletIdsInBrustIter()或GetBulletIdsInBrustBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BulletIdsInBrust()
		{
			LinkData linkData = this;
			return linkData.GetBulletIdsInBrustArray() ?? Array.Empty<long>();
		}

		// Token: 0x06008EA5 RID: 36517 RVA: 0x00278E60 File Offset: 0x00277060
		[NullableContext(1)]
		public readonly IEnumerable<long> BulletIdsInBrustIter()
		{
			LinkData.<BulletIdsInBrustIter>d__57 <BulletIdsInBrustIter>d__ = new LinkData.<BulletIdsInBrustIter>d__57(-2);
			<BulletIdsInBrustIter>d__.<>3__<>4__this = this;
			return <BulletIdsInBrustIter>d__;
		}

		// Token: 0x06008EA6 RID: 36518 RVA: 0x00278E78 File Offset: 0x00277078
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BulletIdsInReadyIter()或GetBulletIdsInReadyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BulletIdsInReady()
		{
			LinkData linkData = this;
			return linkData.GetBulletIdsInReadyArray() ?? Array.Empty<long>();
		}

		// Token: 0x06008EA7 RID: 36519 RVA: 0x00278E9C File Offset: 0x0027709C
		[NullableContext(1)]
		public readonly IEnumerable<long> BulletIdsInReadyIter()
		{
			LinkData.<BulletIdsInReadyIter>d__59 <BulletIdsInReadyIter>d__ = new LinkData.<BulletIdsInReadyIter>d__59(-2);
			<BulletIdsInReadyIter>d__.<>3__<>4__this = this;
			return <BulletIdsInReadyIter>d__;
		}

		// Token: 0x04004E65 RID: 20069
		private Table __p;
	}
}
