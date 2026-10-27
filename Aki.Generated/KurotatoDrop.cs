using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9B RID: 3483
	public struct KurotatoDrop : IFlatbufferObject
	{
		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06008936 RID: 35126 RVA: 0x0026D198 File Offset: 0x0026B398
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008937 RID: 35127 RVA: 0x0026D1A5 File Offset: 0x0026B3A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008938 RID: 35128 RVA: 0x0026D1AC File Offset: 0x0026B3AC
		public static KurotatoDrop GetRootAsKurotatoDrop(ByteBuffer _bb)
		{
			return KurotatoDrop.GetRootAsKurotatoDrop(_bb, default(KurotatoDrop));
		}

		// Token: 0x06008939 RID: 35129 RVA: 0x0026D1C8 File Offset: 0x0026B3C8
		public static KurotatoDrop GetRootAsKurotatoDrop(ByteBuffer _bb, KurotatoDrop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600893A RID: 35130 RVA: 0x0026D1E5 File Offset: 0x0026B3E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600893B RID: 35131 RVA: 0x0026D1F4 File Offset: 0x0026B3F4
		public KurotatoDrop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x0600893C RID: 35132 RVA: 0x0026D204 File Offset: 0x0026B404
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

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x0600893D RID: 35133 RVA: 0x0026D240 File Offset: 0x0026B440
		public int TemplateId
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

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x0600893E RID: 35134 RVA: 0x0026D27C File Offset: 0x0026B47C
		public int SimpleCombatSubtypeId
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

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x0600893F RID: 35135 RVA: 0x0026D2B8 File Offset: 0x0026B4B8
		public string Type
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

		// Token: 0x06008940 RID: 35136 RVA: 0x0026D2F0 File Offset: 0x0026B4F0
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x0026D300 File Offset: 0x0026B500
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06008942 RID: 35138 RVA: 0x0026D318 File Offset: 0x0026B518
		public int Param1
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

		// Token: 0x06008943 RID: 35139 RVA: 0x0026D358 File Offset: 0x0026B558
		public int AbsorbEffects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06008944 RID: 35140 RVA: 0x0026D398 File Offset: 0x0026B598
		public int AbsorbEffectsLength
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

		// Token: 0x06008945 RID: 35141 RVA: 0x0026D3C4 File Offset: 0x0026B5C4
		public Span<int> GetAbsorbEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06008946 RID: 35142 RVA: 0x0026D3D4 File Offset: 0x0026B5D4
		public int[] GetAbsorbEffectsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06008947 RID: 35143 RVA: 0x0026D3EC File Offset: 0x0026B5EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AbsorbEffectsIter()或GetAbsorbEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AbsorbEffects()
		{
			KurotatoDrop kurotatoDrop = this;
			return kurotatoDrop.GetAbsorbEffectsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008948 RID: 35144 RVA: 0x0026D410 File Offset: 0x0026B610
		[NullableContext(1)]
		public readonly IEnumerable<int> AbsorbEffectsIter()
		{
			KurotatoDrop.<AbsorbEffectsIter>d__26 <AbsorbEffectsIter>d__ = new KurotatoDrop.<AbsorbEffectsIter>d__26(-2);
			<AbsorbEffectsIter>d__.<>3__<>4__this = this;
			return <AbsorbEffectsIter>d__;
		}

		// Token: 0x04004E2B RID: 20011
		private Table __p;
	}
}
