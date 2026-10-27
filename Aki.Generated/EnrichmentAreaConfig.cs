using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C31 RID: 3121
	public struct EnrichmentAreaConfig : IFlatbufferObject
	{
		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06006935 RID: 26933 RVA: 0x00223500 File Offset: 0x00221700
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x0022350D File Offset: 0x0022170D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x00223514 File Offset: 0x00221714
		public static EnrichmentAreaConfig GetRootAsEnrichmentAreaConfig(ByteBuffer _bb)
		{
			return EnrichmentAreaConfig.GetRootAsEnrichmentAreaConfig(_bb, default(EnrichmentAreaConfig));
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x00223530 File Offset: 0x00221730
		public static EnrichmentAreaConfig GetRootAsEnrichmentAreaConfig(ByteBuffer _bb, EnrichmentAreaConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x0022354D File Offset: 0x0022174D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x0022355C File Offset: 0x0022175C
		public EnrichmentAreaConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x0600693B RID: 26939 RVA: 0x0022356C File Offset: 0x0022176C
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

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x0600693C RID: 26940 RVA: 0x002235A8 File Offset: 0x002217A8
		public int EnrichmentId
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

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x0600693D RID: 26941 RVA: 0x002235E4 File Offset: 0x002217E4
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

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x0600693E RID: 26942 RVA: 0x00223620 File Offset: 0x00221820
		public int LevelId
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

		// Token: 0x0600693F RID: 26943 RVA: 0x00223660 File Offset: 0x00221860
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06006940 RID: 26944 RVA: 0x002236A0 File Offset: 0x002218A0
		public int EntityIdsLength
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

		// Token: 0x06006941 RID: 26945 RVA: 0x002236CC File Offset: 0x002218CC
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x002236DC File Offset: 0x002218DC
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x002236F4 File Offset: 0x002218F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EntityIdsIter()或GetEntityIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EntityIds()
		{
			EnrichmentAreaConfig enrichmentAreaConfig = this;
			return enrichmentAreaConfig.GetEntityIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x00223718 File Offset: 0x00221918
		[NullableContext(1)]
		public readonly IEnumerable<int> EntityIdsIter()
		{
			EnrichmentAreaConfig.<EntityIdsIter>d__22 <EntityIdsIter>d__ = new EnrichmentAreaConfig.<EntityIdsIter>d__22(-2);
			<EntityIdsIter>d__.<>3__<>4__this = this;
			return <EntityIdsIter>d__;
		}

		// Token: 0x04004C71 RID: 19569
		private Table __p;
	}
}
