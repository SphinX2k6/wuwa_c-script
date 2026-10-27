using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBA RID: 4026
	public struct ResonanceAmplification : IFlatbufferObject
	{
		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x0600BBB0 RID: 48048 RVA: 0x002DD753 File Offset: 0x002DB953
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BBB1 RID: 48049 RVA: 0x002DD760 File Offset: 0x002DB960
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BBB2 RID: 48050 RVA: 0x002DD768 File Offset: 0x002DB968
		public static ResonanceAmplification GetRootAsResonanceAmplification(ByteBuffer _bb)
		{
			return ResonanceAmplification.GetRootAsResonanceAmplification(_bb, default(ResonanceAmplification));
		}

		// Token: 0x0600BBB3 RID: 48051 RVA: 0x002DD784 File Offset: 0x002DB984
		public static ResonanceAmplification GetRootAsResonanceAmplification(ByteBuffer _bb, ResonanceAmplification obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BBB4 RID: 48052 RVA: 0x002DD7A1 File Offset: 0x002DB9A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BBB5 RID: 48053 RVA: 0x002DD7B0 File Offset: 0x002DB9B0
		public ResonanceAmplification __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x0600BBB6 RID: 48054 RVA: 0x002DD7C0 File Offset: 0x002DB9C0
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

		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x0600BBB7 RID: 48055 RVA: 0x002DD7FC File Offset: 0x002DB9FC
		public int Attr
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 7;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BBB8 RID: 48056 RVA: 0x002DD838 File Offset: 0x002DBA38
		public float LifeSeatBoostFactor(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x0600BBB9 RID: 48057 RVA: 0x002DD87C File Offset: 0x002DBA7C
		public int LifeSeatBoostFactorLength
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

		// Token: 0x0600BBBA RID: 48058 RVA: 0x002DD8A7 File Offset: 0x002DBAA7
		public Span<float> GetLifeSeatBoostFactorBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x0600BBBB RID: 48059 RVA: 0x002DD8B6 File Offset: 0x002DBAB6
		public float[] GetLifeSeatBoostFactorArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x0600BBBC RID: 48060 RVA: 0x002DD8D0 File Offset: 0x002DBAD0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LifeSeatBoostFactorIter()或GetLifeSeatBoostFactorBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] LifeSeatBoostFactor()
		{
			ResonanceAmplification resonanceAmplification = this;
			return resonanceAmplification.GetLifeSeatBoostFactorArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600BBBD RID: 48061 RVA: 0x002DD8F4 File Offset: 0x002DBAF4
		[NullableContext(1)]
		public readonly IEnumerable<float> LifeSeatBoostFactorIter()
		{
			ResonanceAmplification.<LifeSeatBoostFactorIter>d__18 <LifeSeatBoostFactorIter>d__ = new ResonanceAmplification.<LifeSeatBoostFactorIter>d__18(-2);
			<LifeSeatBoostFactorIter>d__.<>3__<>4__this = this;
			return <LifeSeatBoostFactorIter>d__;
		}

		// Token: 0x04005093 RID: 20627
		private Table __p;
	}
}
