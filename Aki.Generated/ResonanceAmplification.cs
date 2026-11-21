using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A2 RID: 4258
	public struct ResonanceAmplification : IFlatbufferObject
	{
		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x0600C1FA RID: 49658 RVA: 0x002F9EC7 File Offset: 0x002F80C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C1FB RID: 49659 RVA: 0x002F9ED4 File Offset: 0x002F80D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C1FC RID: 49660 RVA: 0x002F9EDC File Offset: 0x002F80DC
		public static ResonanceAmplification GetRootAsResonanceAmplification(ByteBuffer _bb)
		{
			return ResonanceAmplification.GetRootAsResonanceAmplification(_bb, default(ResonanceAmplification));
		}

		// Token: 0x0600C1FD RID: 49661 RVA: 0x002F9EF8 File Offset: 0x002F80F8
		public static ResonanceAmplification GetRootAsResonanceAmplification(ByteBuffer _bb, ResonanceAmplification obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C1FE RID: 49662 RVA: 0x002F9F15 File Offset: 0x002F8115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C1FF RID: 49663 RVA: 0x002F9F24 File Offset: 0x002F8124
		public ResonanceAmplification __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x0600C200 RID: 49664 RVA: 0x002F9F34 File Offset: 0x002F8134
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

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x0600C201 RID: 49665 RVA: 0x002F9F70 File Offset: 0x002F8170
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

		// Token: 0x0600C202 RID: 49666 RVA: 0x002F9FAC File Offset: 0x002F81AC
		public float LifeSeatBoostFactor(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x0600C203 RID: 49667 RVA: 0x002F9FF0 File Offset: 0x002F81F0
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

		// Token: 0x0600C204 RID: 49668 RVA: 0x002FA01B File Offset: 0x002F821B
		public Span<float> GetLifeSeatBoostFactorBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x0600C205 RID: 49669 RVA: 0x002FA02A File Offset: 0x002F822A
		public float[] GetLifeSeatBoostFactorArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x0600C206 RID: 49670 RVA: 0x002FA041 File Offset: 0x002F8241
		[NullableContext(1)]
		public float[] LifeSeatBoostFactor()
		{
			return this.GetLifeSeatBoostFactorArray();
		}

		// Token: 0x0600C207 RID: 49671 RVA: 0x002FA049 File Offset: 0x002F8249
		[NullableContext(1)]
		public IEnumerable<float> LifeSeatBoostFactorIter()
		{
			ResonanceAmplification.<LifeSeatBoostFactorIter>d__18 <LifeSeatBoostFactorIter>d__ = new ResonanceAmplification.<LifeSeatBoostFactorIter>d__18(-2);
			<LifeSeatBoostFactorIter>d__.<>3__<>4__this = this;
			return <LifeSeatBoostFactorIter>d__;
		}

		// Token: 0x0400567B RID: 22139
		private Table __p;
	}
}
