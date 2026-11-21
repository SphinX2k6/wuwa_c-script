using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB4 RID: 3764
	public struct LinkData : IFlatbufferObject
	{
		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x06009495 RID: 38037 RVA: 0x00296D06 File Offset: 0x00294F06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x00296D13 File Offset: 0x00294F13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x00296D1C File Offset: 0x00294F1C
		public static LinkData GetRootAsLinkData(ByteBuffer _bb)
		{
			return LinkData.GetRootAsLinkData(_bb, default(LinkData));
		}

		// Token: 0x06009498 RID: 38040 RVA: 0x00296D38 File Offset: 0x00294F38
		public static LinkData GetRootAsLinkData(ByteBuffer _bb, LinkData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009499 RID: 38041 RVA: 0x00296D55 File Offset: 0x00294F55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600949A RID: 38042 RVA: 0x00296D64 File Offset: 0x00294F64
		public LinkData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x0600949B RID: 38043 RVA: 0x00296D74 File Offset: 0x00294F74
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

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x0600949C RID: 38044 RVA: 0x00296DB0 File Offset: 0x00294FB0
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

		// Token: 0x0600949D RID: 38045 RVA: 0x00296DEC File Offset: 0x00294FEC
		public long BuffIdsInAccumulate(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x0600949E RID: 38046 RVA: 0x00296E2C File Offset: 0x0029502C
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

		// Token: 0x0600949F RID: 38047 RVA: 0x00296E57 File Offset: 0x00295057
		public Span<long> GetBuffIdsInAccumulateBytes()
		{
			return this.__p.__vector_as_span<long>(8, 8);
		}

		// Token: 0x060094A0 RID: 38048 RVA: 0x00296E66 File Offset: 0x00295066
		public long[] GetBuffIdsInAccumulateArray()
		{
			return this.__p.__vector_as_array<long>(8) ?? Array.Empty<long>();
		}

		// Token: 0x060094A1 RID: 38049 RVA: 0x00296E80 File Offset: 0x00295080
		public long BulletIdsInAccumulate(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x060094A2 RID: 38050 RVA: 0x00296EC4 File Offset: 0x002950C4
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

		// Token: 0x060094A3 RID: 38051 RVA: 0x00296EF0 File Offset: 0x002950F0
		public Span<long> GetBulletIdsInAccumulateBytes()
		{
			return this.__p.__vector_as_span<long>(10, 8);
		}

		// Token: 0x060094A4 RID: 38052 RVA: 0x00296F00 File Offset: 0x00295100
		public long[] GetBulletIdsInAccumulateArray()
		{
			return this.__p.__vector_as_array<long>(10) ?? Array.Empty<long>();
		}

		// Token: 0x060094A5 RID: 38053 RVA: 0x00296F18 File Offset: 0x00295118
		public long BuffIdsInReady(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x060094A6 RID: 38054 RVA: 0x00296F5C File Offset: 0x0029515C
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

		// Token: 0x060094A7 RID: 38055 RVA: 0x00296F88 File Offset: 0x00295188
		public Span<long> GetBuffIdsInReadyBytes()
		{
			return this.__p.__vector_as_span<long>(12, 8);
		}

		// Token: 0x060094A8 RID: 38056 RVA: 0x00296F98 File Offset: 0x00295198
		public long[] GetBuffIdsInReadyArray()
		{
			return this.__p.__vector_as_array<long>(12) ?? Array.Empty<long>();
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x00296FB0 File Offset: 0x002951B0
		public long BulletIdsInReady(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x060094AA RID: 38058 RVA: 0x00296FF4 File Offset: 0x002951F4
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

		// Token: 0x060094AB RID: 38059 RVA: 0x00297020 File Offset: 0x00295220
		public Span<long> GetBulletIdsInReadyBytes()
		{
			return this.__p.__vector_as_span<long>(14, 8);
		}

		// Token: 0x060094AC RID: 38060 RVA: 0x00297030 File Offset: 0x00295230
		public long[] GetBulletIdsInReadyArray()
		{
			return this.__p.__vector_as_array<long>(14) ?? Array.Empty<long>();
		}

		// Token: 0x060094AD RID: 38061 RVA: 0x00297048 File Offset: 0x00295248
		public long BuffIdsInBrust(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x060094AE RID: 38062 RVA: 0x0029708C File Offset: 0x0029528C
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

		// Token: 0x060094AF RID: 38063 RVA: 0x002970B8 File Offset: 0x002952B8
		public Span<long> GetBuffIdsInBrustBytes()
		{
			return this.__p.__vector_as_span<long>(16, 8);
		}

		// Token: 0x060094B0 RID: 38064 RVA: 0x002970C8 File Offset: 0x002952C8
		public long[] GetBuffIdsInBrustArray()
		{
			return this.__p.__vector_as_array<long>(16) ?? Array.Empty<long>();
		}

		// Token: 0x060094B1 RID: 38065 RVA: 0x002970E0 File Offset: 0x002952E0
		public long BulletIdsInBrust(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x060094B2 RID: 38066 RVA: 0x00297124 File Offset: 0x00295324
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

		// Token: 0x060094B3 RID: 38067 RVA: 0x00297150 File Offset: 0x00295350
		public Span<long> GetBulletIdsInBrustBytes()
		{
			return this.__p.__vector_as_span<long>(18, 8);
		}

		// Token: 0x060094B4 RID: 38068 RVA: 0x00297160 File Offset: 0x00295360
		public long[] GetBulletIdsInBrustArray()
		{
			return this.__p.__vector_as_array<long>(18) ?? Array.Empty<long>();
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x060094B5 RID: 38069 RVA: 0x00297178 File Offset: 0x00295378
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

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x060094B6 RID: 38070 RVA: 0x002971BC File Offset: 0x002953BC
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

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x060094B7 RID: 38071 RVA: 0x002971FC File Offset: 0x002953FC
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

		// Token: 0x060094B8 RID: 38072 RVA: 0x00297239 File Offset: 0x00295439
		[NullableContext(1)]
		public long[] BuffIdsInAccumulate()
		{
			return this.GetBuffIdsInAccumulateArray();
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x00297241 File Offset: 0x00295441
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsInAccumulateIter()
		{
			LinkData.<BuffIdsInAccumulateIter>d__49 <BuffIdsInAccumulateIter>d__ = new LinkData.<BuffIdsInAccumulateIter>d__49(-2);
			<BuffIdsInAccumulateIter>d__.<>3__<>4__this = this;
			return <BuffIdsInAccumulateIter>d__;
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x00297256 File Offset: 0x00295456
		[NullableContext(1)]
		public long[] BuffIdsInBrust()
		{
			return this.GetBuffIdsInBrustArray();
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x0029725E File Offset: 0x0029545E
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsInBrustIter()
		{
			LinkData.<BuffIdsInBrustIter>d__51 <BuffIdsInBrustIter>d__ = new LinkData.<BuffIdsInBrustIter>d__51(-2);
			<BuffIdsInBrustIter>d__.<>3__<>4__this = this;
			return <BuffIdsInBrustIter>d__;
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x00297273 File Offset: 0x00295473
		[NullableContext(1)]
		public long[] BuffIdsInReady()
		{
			return this.GetBuffIdsInReadyArray();
		}

		// Token: 0x060094BD RID: 38077 RVA: 0x0029727B File Offset: 0x0029547B
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsInReadyIter()
		{
			LinkData.<BuffIdsInReadyIter>d__53 <BuffIdsInReadyIter>d__ = new LinkData.<BuffIdsInReadyIter>d__53(-2);
			<BuffIdsInReadyIter>d__.<>3__<>4__this = this;
			return <BuffIdsInReadyIter>d__;
		}

		// Token: 0x060094BE RID: 38078 RVA: 0x00297290 File Offset: 0x00295490
		[NullableContext(1)]
		public long[] BulletIdsInAccumulate()
		{
			return this.GetBulletIdsInAccumulateArray();
		}

		// Token: 0x060094BF RID: 38079 RVA: 0x00297298 File Offset: 0x00295498
		[NullableContext(1)]
		public IEnumerable<long> BulletIdsInAccumulateIter()
		{
			LinkData.<BulletIdsInAccumulateIter>d__55 <BulletIdsInAccumulateIter>d__ = new LinkData.<BulletIdsInAccumulateIter>d__55(-2);
			<BulletIdsInAccumulateIter>d__.<>3__<>4__this = this;
			return <BulletIdsInAccumulateIter>d__;
		}

		// Token: 0x060094C0 RID: 38080 RVA: 0x002972AD File Offset: 0x002954AD
		[NullableContext(1)]
		public long[] BulletIdsInBrust()
		{
			return this.GetBulletIdsInBrustArray();
		}

		// Token: 0x060094C1 RID: 38081 RVA: 0x002972B5 File Offset: 0x002954B5
		[NullableContext(1)]
		public IEnumerable<long> BulletIdsInBrustIter()
		{
			LinkData.<BulletIdsInBrustIter>d__57 <BulletIdsInBrustIter>d__ = new LinkData.<BulletIdsInBrustIter>d__57(-2);
			<BulletIdsInBrustIter>d__.<>3__<>4__this = this;
			return <BulletIdsInBrustIter>d__;
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x002972CA File Offset: 0x002954CA
		[NullableContext(1)]
		public long[] BulletIdsInReady()
		{
			return this.GetBulletIdsInReadyArray();
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x002972D2 File Offset: 0x002954D2
		[NullableContext(1)]
		public IEnumerable<long> BulletIdsInReadyIter()
		{
			LinkData.<BulletIdsInReadyIter>d__59 <BulletIdsInReadyIter>d__ = new LinkData.<BulletIdsInReadyIter>d__59(-2);
			<BulletIdsInReadyIter>d__.<>3__<>4__this = this;
			return <BulletIdsInReadyIter>d__;
		}

		// Token: 0x0400544A RID: 21578
		private Table __p;
	}
}
