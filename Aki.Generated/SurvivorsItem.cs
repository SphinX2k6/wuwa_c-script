using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FC RID: 4348
	public struct SurvivorsItem : IFlatbufferObject
	{
		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0600DA76 RID: 55926 RVA: 0x00323D05 File Offset: 0x00321F05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA77 RID: 55927 RVA: 0x00323D12 File Offset: 0x00321F12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA78 RID: 55928 RVA: 0x00323D1C File Offset: 0x00321F1C
		public static SurvivorsItem GetRootAsSurvivorsItem(ByteBuffer _bb)
		{
			return SurvivorsItem.GetRootAsSurvivorsItem(_bb, default(SurvivorsItem));
		}

		// Token: 0x0600DA79 RID: 55929 RVA: 0x00323D38 File Offset: 0x00321F38
		public static SurvivorsItem GetRootAsSurvivorsItem(ByteBuffer _bb, SurvivorsItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA7A RID: 55930 RVA: 0x00323D55 File Offset: 0x00321F55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA7B RID: 55931 RVA: 0x00323D64 File Offset: 0x00321F64
		public SurvivorsItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0600DA7C RID: 55932 RVA: 0x00323D74 File Offset: 0x00321F74
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

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x0600DA7D RID: 55933 RVA: 0x00323DB0 File Offset: 0x00321FB0
		public int ActivityId
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

		// Token: 0x0600DA7E RID: 55934 RVA: 0x00323DEC File Offset: 0x00321FEC
		public int Effect(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x0600DA7F RID: 55935 RVA: 0x00323E2C File Offset: 0x0032202C
		public int EffectLength
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

		// Token: 0x0600DA80 RID: 55936 RVA: 0x00323E57 File Offset: 0x00322057
		public Span<int> GetEffectBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600DA81 RID: 55937 RVA: 0x00323E66 File Offset: 0x00322066
		public int[] GetEffectArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x0600DA82 RID: 55938 RVA: 0x00323E80 File Offset: 0x00322080
		public string Name
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

		// Token: 0x0600DA83 RID: 55939 RVA: 0x00323EB8 File Offset: 0x003220B8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DA84 RID: 55940 RVA: 0x00323EC8 File Offset: 0x003220C8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x0600DA85 RID: 55941 RVA: 0x00323EE0 File Offset: 0x003220E0
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

		// Token: 0x0600DA86 RID: 55942 RVA: 0x00323F18 File Offset: 0x00322118
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DA87 RID: 55943 RVA: 0x00323F28 File Offset: 0x00322128
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x0600DA88 RID: 55944 RVA: 0x00323F40 File Offset: 0x00322140
		public string Icon
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

		// Token: 0x0600DA89 RID: 55945 RVA: 0x00323F78 File Offset: 0x00322178
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DA8A RID: 55946 RVA: 0x00323F88 File Offset: 0x00322188
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x0600DA8B RID: 55947 RVA: 0x00323FA0 File Offset: 0x003221A0
		public int Quality
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

		// Token: 0x0600DA8C RID: 55948 RVA: 0x00323FE0 File Offset: 0x003221E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectIter()或GetEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Effect()
		{
			SurvivorsItem survivorsItem = this;
			return survivorsItem.GetEffectArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DA8D RID: 55949 RVA: 0x00324004 File Offset: 0x00322204
		[NullableContext(1)]
		public readonly IEnumerable<int> EffectIter()
		{
			SurvivorsItem.<EffectIter>d__32 <EffectIter>d__ = new SurvivorsItem.<EffectIter>d__32(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x04005232 RID: 21042
		private Table __p;
	}
}
