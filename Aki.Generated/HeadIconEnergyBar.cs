using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D27 RID: 3367
	public struct HeadIconEnergyBar : IFlatbufferObject
	{
		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06007E42 RID: 32322 RVA: 0x00253831 File Offset: 0x00251A31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E43 RID: 32323 RVA: 0x0025383E File Offset: 0x00251A3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E44 RID: 32324 RVA: 0x00253848 File Offset: 0x00251A48
		public static HeadIconEnergyBar GetRootAsHeadIconEnergyBar(ByteBuffer _bb)
		{
			return HeadIconEnergyBar.GetRootAsHeadIconEnergyBar(_bb, default(HeadIconEnergyBar));
		}

		// Token: 0x06007E45 RID: 32325 RVA: 0x00253864 File Offset: 0x00251A64
		public static HeadIconEnergyBar GetRootAsHeadIconEnergyBar(ByteBuffer _bb, HeadIconEnergyBar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E46 RID: 32326 RVA: 0x00253881 File Offset: 0x00251A81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E47 RID: 32327 RVA: 0x00253890 File Offset: 0x00251A90
		public HeadIconEnergyBar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06007E48 RID: 32328 RVA: 0x002538A0 File Offset: 0x00251AA0
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

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06007E49 RID: 32329 RVA: 0x002538DC File Offset: 0x00251ADC
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

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06007E4A RID: 32330 RVA: 0x00253918 File Offset: 0x00251B18
		public int AttributeId
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

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06007E4B RID: 32331 RVA: 0x00253954 File Offset: 0x00251B54
		public string PrefabPath
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

		// Token: 0x06007E4C RID: 32332 RVA: 0x0025398C File Offset: 0x00251B8C
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x0025399C File Offset: 0x00251B9C
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06007E4E RID: 32334 RVA: 0x002539B4 File Offset: 0x00251BB4
		public float EffectCd
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06007E4F RID: 32335 RVA: 0x002539F8 File Offset: 0x00251BF8
		public bool PlayIncreaseEffect
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06007E50 RID: 32336 RVA: 0x00253A38 File Offset: 0x00251C38
		public bool PlayDecreaseEffect
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06007E51 RID: 32337 RVA: 0x00253A78 File Offset: 0x00251C78
		public bool FormationVisible
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x00253AB8 File Offset: 0x00251CB8
		public int Params(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06007E53 RID: 32339 RVA: 0x00253AF8 File Offset: 0x00251CF8
		public int ParamsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007E54 RID: 32340 RVA: 0x00253B24 File Offset: 0x00251D24
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x00253B34 File Offset: 0x00251D34
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x00253B4C File Offset: 0x00251D4C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Params()
		{
			HeadIconEnergyBar headIconEnergyBar = this;
			return headIconEnergyBar.GetParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007E57 RID: 32343 RVA: 0x00253B70 File Offset: 0x00251D70
		[NullableContext(1)]
		public readonly IEnumerable<int> ParamsIter()
		{
			HeadIconEnergyBar.<ParamsIter>d__32 <ParamsIter>d__ = new HeadIconEnergyBar.<ParamsIter>d__32(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04004D9F RID: 19871
		private Table __p;
	}
}
