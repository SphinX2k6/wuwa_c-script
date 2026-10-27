using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF0 RID: 2800
	public struct AiSenseGroup : IFlatbufferObject
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060046E0 RID: 18144 RVA: 0x001D3C01 File Offset: 0x001D1E01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x001D3C0E File Offset: 0x001D1E0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x001D3C18 File Offset: 0x001D1E18
		public static AiSenseGroup GetRootAsAiSenseGroup(ByteBuffer _bb)
		{
			return AiSenseGroup.GetRootAsAiSenseGroup(_bb, default(AiSenseGroup));
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x001D3C34 File Offset: 0x001D1E34
		public static AiSenseGroup GetRootAsAiSenseGroup(ByteBuffer _bb, AiSenseGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x001D3C51 File Offset: 0x001D1E51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x001D3C60 File Offset: 0x001D1E60
		public AiSenseGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060046E6 RID: 18150 RVA: 0x001D3C70 File Offset: 0x001D1E70
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

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060046E7 RID: 18151 RVA: 0x001D3CAC File Offset: 0x001D1EAC
		public FloatRange? LoseDelay
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x001D3D0C File Offset: 0x001D1F0C
		public int AiSenseIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060046E9 RID: 18153 RVA: 0x001D3D4C File Offset: 0x001D1F4C
		public int AiSenseIdsLength
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

		// Token: 0x060046EA RID: 18154 RVA: 0x001D3D77 File Offset: 0x001D1F77
		public Span<int> GetAiSenseIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x001D3D86 File Offset: 0x001D1F86
		public int[] GetAiSenseIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x001D3DA0 File Offset: 0x001D1FA0
		public float ShareDis
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x001D3DE4 File Offset: 0x001D1FE4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AiSenseIdsIter()或GetAiSenseIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AiSenseIds()
		{
			AiSenseGroup aiSenseGroup = this;
			return aiSenseGroup.GetAiSenseIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x001D3E08 File Offset: 0x001D2008
		[NullableContext(1)]
		public readonly IEnumerable<int> AiSenseIdsIter()
		{
			AiSenseGroup.<AiSenseIdsIter>d__20 <AiSenseIdsIter>d__ = new AiSenseGroup.<AiSenseIdsIter>d__20(-2);
			<AiSenseIdsIter>d__.<>3__<>4__this = this;
			return <AiSenseIdsIter>d__;
		}

		// Token: 0x04004AD1 RID: 19153
		private Table __p;
	}
}
