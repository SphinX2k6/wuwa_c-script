using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9F RID: 3231
	public struct FloroRanchActivity : IFlatbufferObject
	{
		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x0600723A RID: 29242 RVA: 0x0023850C File Offset: 0x0023670C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x00238519 File Offset: 0x00236719
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x00238520 File Offset: 0x00236720
		public static FloroRanchActivity GetRootAsFloroRanchActivity(ByteBuffer _bb)
		{
			return FloroRanchActivity.GetRootAsFloroRanchActivity(_bb, default(FloroRanchActivity));
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x0023853C File Offset: 0x0023673C
		public static FloroRanchActivity GetRootAsFloroRanchActivity(ByteBuffer _bb, FloroRanchActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x00238559 File Offset: 0x00236759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x00238568 File Offset: 0x00236768
		public FloroRanchActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06007240 RID: 29248 RVA: 0x00238578 File Offset: 0x00236778
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

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06007241 RID: 29249 RVA: 0x002385B4 File Offset: 0x002367B4
		public int ActivityType
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

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06007242 RID: 29250 RVA: 0x002385F0 File Offset: 0x002367F0
		public int TechTreeCoinId
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

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06007243 RID: 29251 RVA: 0x0023862C File Offset: 0x0023682C
		public int ResetGachaBaseCost
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

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06007244 RID: 29252 RVA: 0x0023866C File Offset: 0x0023686C
		public int ResetGachaRiseCost
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

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06007245 RID: 29253 RVA: 0x002386AC File Offset: 0x002368AC
		public int ResetShopBaseCost
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

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06007246 RID: 29254 RVA: 0x002386EC File Offset: 0x002368EC
		public int ResetShopRiseCost
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

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06007247 RID: 29255 RVA: 0x0023872C File Offset: 0x0023692C
		public int UnlimitedParamBase
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

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06007248 RID: 29256 RVA: 0x0023876C File Offset: 0x0023696C
		public int UnlimitedParamRise
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

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06007249 RID: 29257 RVA: 0x002387AC File Offset: 0x002369AC
		public int EventCD
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

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x0600724A RID: 29258 RVA: 0x002387EC File Offset: 0x002369EC
		public int Speed
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

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x0600724B RID: 29259 RVA: 0x0023882C File Offset: 0x00236A2C
		public int MilestoneItemId
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

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x0600724C RID: 29260 RVA: 0x0023886C File Offset: 0x00236A6C
		public int CardItemId
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

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x0600724D RID: 29261 RVA: 0x002388AC File Offset: 0x00236AAC
		public int MaxToyNum
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x0600724E RID: 29262 RVA: 0x002388EC File Offset: 0x00236AEC
		public int TechPointItem
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x0600724F RID: 29263 RVA: 0x0023892C File Offset: 0x00236B2C
		public int AnimalNumLimit
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06007250 RID: 29264 RVA: 0x0023896C File Offset: 0x00236B6C
		public int ComicIntervalTime
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06007251 RID: 29265 RVA: 0x002389AC File Offset: 0x00236BAC
		public int RecommendQuestId
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x002389EC File Offset: 0x00236BEC
		public int RecommendQuestLinkList(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06007253 RID: 29267 RVA: 0x00238A2C File Offset: 0x00236C2C
		public int RecommendQuestLinkListLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x00238A58 File Offset: 0x00236C58
		public Span<int> GetRecommendQuestLinkListBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x00238A68 File Offset: 0x00236C68
		public int[] GetRecommendQuestLinkListArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06007256 RID: 29270 RVA: 0x00238A80 File Offset: 0x00236C80
		public string RecommendQuestLabel
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007257 RID: 29271 RVA: 0x00238AB8 File Offset: 0x00236CB8
		public Span<byte> GetRecommendQuestLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06007258 RID: 29272 RVA: 0x00238AC8 File Offset: 0x00236CC8
		public byte[] GetRecommendQuestLabelArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06007259 RID: 29273 RVA: 0x00238AE0 File Offset: 0x00236CE0
		public string Spine(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x0600725A RID: 29274 RVA: 0x00238B1C File Offset: 0x00236D1C
		public int SpineLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600725B RID: 29275 RVA: 0x00238B48 File Offset: 0x00236D48
		public string SpineSkeletonData(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x0600725C RID: 29276 RVA: 0x00238B84 File Offset: 0x00236D84
		public int SpineSkeletonDataLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x00238BB0 File Offset: 0x00236DB0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendQuestLinkListIter()或GetRecommendQuestLinkListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendQuestLinkList()
		{
			FloroRanchActivity floroRanchActivity = this;
			return floroRanchActivity.GetRecommendQuestLinkListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x00238BD4 File Offset: 0x00236DD4
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendQuestLinkListIter()
		{
			FloroRanchActivity.<RecommendQuestLinkListIter>d__60 <RecommendQuestLinkListIter>d__ = new FloroRanchActivity.<RecommendQuestLinkListIter>d__60(-2);
			<RecommendQuestLinkListIter>d__.<>3__<>4__this = this;
			return <RecommendQuestLinkListIter>d__;
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x00238BE9 File Offset: 0x00236DE9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineIter()或GetSpineBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Spine()
		{
			return this.SpineIter().ToArray<string>();
		}

		// Token: 0x06007260 RID: 29280 RVA: 0x00238BF6 File Offset: 0x00236DF6
		[NullableContext(1)]
		public readonly IEnumerable<string> SpineIter()
		{
			FloroRanchActivity.<SpineIter>d__62 <SpineIter>d__ = new FloroRanchActivity.<SpineIter>d__62(-2);
			<SpineIter>d__.<>3__<>4__this = this;
			return <SpineIter>d__;
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x00238C0B File Offset: 0x00236E0B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineSkeletonDataIter()或GetSpineSkeletonDataBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SpineSkeletonData()
		{
			return this.SpineSkeletonDataIter().ToArray<string>();
		}

		// Token: 0x06007262 RID: 29282 RVA: 0x00238C18 File Offset: 0x00236E18
		[NullableContext(1)]
		public readonly IEnumerable<string> SpineSkeletonDataIter()
		{
			FloroRanchActivity.<SpineSkeletonDataIter>d__64 <SpineSkeletonDataIter>d__ = new FloroRanchActivity.<SpineSkeletonDataIter>d__64(-2);
			<SpineSkeletonDataIter>d__.<>3__<>4__this = this;
			return <SpineSkeletonDataIter>d__;
		}

		// Token: 0x04004CFD RID: 19709
		private Table __p;
	}
}
