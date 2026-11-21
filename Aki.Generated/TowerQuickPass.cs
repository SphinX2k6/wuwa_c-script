using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001278 RID: 4728
	public struct TowerQuickPass : IFlatbufferObject
	{
		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x0600EDCA RID: 60874 RVA: 0x0035C940 File Offset: 0x0035AB40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EDCB RID: 60875 RVA: 0x0035C94D File Offset: 0x0035AB4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EDCC RID: 60876 RVA: 0x0035C954 File Offset: 0x0035AB54
		public static TowerQuickPass GetRootAsTowerQuickPass(ByteBuffer _bb)
		{
			return TowerQuickPass.GetRootAsTowerQuickPass(_bb, default(TowerQuickPass));
		}

		// Token: 0x0600EDCD RID: 60877 RVA: 0x0035C970 File Offset: 0x0035AB70
		public static TowerQuickPass GetRootAsTowerQuickPass(ByteBuffer _bb, TowerQuickPass obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EDCE RID: 60878 RVA: 0x0035C98D File Offset: 0x0035AB8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EDCF RID: 60879 RVA: 0x0035C99C File Offset: 0x0035AB9C
		public TowerQuickPass __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x0600EDD0 RID: 60880 RVA: 0x0035C9AC File Offset: 0x0035ABAC
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

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x0600EDD1 RID: 60881 RVA: 0x0035C9E8 File Offset: 0x0035ABE8
		public int Num
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

		// Token: 0x0600EDD2 RID: 60882 RVA: 0x0035CA24 File Offset: 0x0035AC24
		public string QuickPassInst(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x0600EDD3 RID: 60883 RVA: 0x0035CA60 File Offset: 0x0035AC60
		public int QuickPassInstLength
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

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x0600EDD4 RID: 60884 RVA: 0x0035CA8C File Offset: 0x0035AC8C
		public string TipText
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

		// Token: 0x0600EDD5 RID: 60885 RVA: 0x0035CAC4 File Offset: 0x0035ACC4
		public Span<byte> GetTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EDD6 RID: 60886 RVA: 0x0035CAD4 File Offset: 0x0035ACD4
		public byte[] GetTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EDD7 RID: 60887 RVA: 0x0035CAEC File Offset: 0x0035ACEC
		[NullableContext(1)]
		public string[] QuickPassInst()
		{
			return this.QuickPassInstIter().ToArray<string>();
		}

		// Token: 0x0600EDD8 RID: 60888 RVA: 0x0035CAF9 File Offset: 0x0035ACF9
		[NullableContext(1)]
		public IEnumerable<string> QuickPassInstIter()
		{
			TowerQuickPass.<QuickPassInstIter>d__20 <QuickPassInstIter>d__ = new TowerQuickPass.<QuickPassInstIter>d__20(-2);
			<QuickPassInstIter>d__.<>3__<>4__this = this;
			return <QuickPassInstIter>d__;
		}

		// Token: 0x040058C7 RID: 22727
		private Table __p;
	}
}
