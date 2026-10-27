using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE1 RID: 4065
	public struct RogueHotEntry : IFlatbufferObject
	{
		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x0600BF2B RID: 48939 RVA: 0x002E52C5 File Offset: 0x002E34C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF2C RID: 48940 RVA: 0x002E52D2 File Offset: 0x002E34D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF2D RID: 48941 RVA: 0x002E52DC File Offset: 0x002E34DC
		public static RogueHotEntry GetRootAsRogueHotEntry(ByteBuffer _bb)
		{
			return RogueHotEntry.GetRootAsRogueHotEntry(_bb, default(RogueHotEntry));
		}

		// Token: 0x0600BF2E RID: 48942 RVA: 0x002E52F8 File Offset: 0x002E34F8
		public static RogueHotEntry GetRootAsRogueHotEntry(ByteBuffer _bb, RogueHotEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF2F RID: 48943 RVA: 0x002E5315 File Offset: 0x002E3515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF30 RID: 48944 RVA: 0x002E5324 File Offset: 0x002E3524
		public RogueHotEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x0600BF31 RID: 48945 RVA: 0x002E5334 File Offset: 0x002E3534
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

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x0600BF32 RID: 48946 RVA: 0x002E5370 File Offset: 0x002E3570
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

		// Token: 0x0600BF33 RID: 48947 RVA: 0x002E53A7 File Offset: 0x002E35A7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x002E53B6 File Offset: 0x002E35B6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x0600BF35 RID: 48949 RVA: 0x002E53D0 File Offset: 0x002E35D0
		public int EffectId
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

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x0600BF36 RID: 48950 RVA: 0x002E540C File Offset: 0x002E360C
		public string Icon
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

		// Token: 0x0600BF37 RID: 48951 RVA: 0x002E5444 File Offset: 0x002E3644
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BF38 RID: 48952 RVA: 0x002E5454 File Offset: 0x002E3654
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x0600BF39 RID: 48953 RVA: 0x002E546C File Offset: 0x002E366C
		public string Desc
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

		// Token: 0x0600BF3A RID: 48954 RVA: 0x002E54A4 File Offset: 0x002E36A4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BF3B RID: 48955 RVA: 0x002E54B4 File Offset: 0x002E36B4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BF3C RID: 48956 RVA: 0x002E54CC File Offset: 0x002E36CC
		public string DescParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x0600BF3D RID: 48957 RVA: 0x002E5508 File Offset: 0x002E3708
		public int DescParamLength
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

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x0600BF3E RID: 48958 RVA: 0x002E5534 File Offset: 0x002E3734
		public int OverviewId
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

		// Token: 0x0600BF3F RID: 48959 RVA: 0x002E5574 File Offset: 0x002E3774
		public int OverviewShowParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x0600BF40 RID: 48960 RVA: 0x002E55B4 File Offset: 0x002E37B4
		public int OverviewShowParamLength
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

		// Token: 0x0600BF41 RID: 48961 RVA: 0x002E55E0 File Offset: 0x002E37E0
		public Span<int> GetOverviewShowParamBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600BF42 RID: 48962 RVA: 0x002E55F0 File Offset: 0x002E37F0
		public int[] GetOverviewShowParamArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600BF43 RID: 48963 RVA: 0x002E5608 File Offset: 0x002E3808
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamIter()或GetDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x0600BF44 RID: 48964 RVA: 0x002E5615 File Offset: 0x002E3815
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamIter()
		{
			RogueHotEntry.<DescParamIter>d__35 <DescParamIter>d__ = new RogueHotEntry.<DescParamIter>d__35(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x0600BF45 RID: 48965 RVA: 0x002E562C File Offset: 0x002E382C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OverviewShowParamIter()或GetOverviewShowParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] OverviewShowParam()
		{
			RogueHotEntry rogueHotEntry = this;
			return rogueHotEntry.GetOverviewShowParamArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BF46 RID: 48966 RVA: 0x002E5650 File Offset: 0x002E3850
		[NullableContext(1)]
		public readonly IEnumerable<int> OverviewShowParamIter()
		{
			RogueHotEntry.<OverviewShowParamIter>d__37 <OverviewShowParamIter>d__ = new RogueHotEntry.<OverviewShowParamIter>d__37(-2);
			<OverviewShowParamIter>d__.<>3__<>4__this = this;
			return <OverviewShowParamIter>d__;
		}

		// Token: 0x040050BE RID: 20670
		private Table __p;
	}
}
