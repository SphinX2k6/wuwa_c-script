using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E80 RID: 3712
	public struct KurotatoDrop : IFlatbufferObject
	{
		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06008F52 RID: 36690 RVA: 0x0028BD4C File Offset: 0x00289F4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F53 RID: 36691 RVA: 0x0028BD59 File Offset: 0x00289F59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F54 RID: 36692 RVA: 0x0028BD60 File Offset: 0x00289F60
		public static KurotatoDrop GetRootAsKurotatoDrop(ByteBuffer _bb)
		{
			return KurotatoDrop.GetRootAsKurotatoDrop(_bb, default(KurotatoDrop));
		}

		// Token: 0x06008F55 RID: 36693 RVA: 0x0028BD7C File Offset: 0x00289F7C
		public static KurotatoDrop GetRootAsKurotatoDrop(ByteBuffer _bb, KurotatoDrop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F56 RID: 36694 RVA: 0x0028BD99 File Offset: 0x00289F99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F57 RID: 36695 RVA: 0x0028BDA8 File Offset: 0x00289FA8
		public KurotatoDrop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06008F58 RID: 36696 RVA: 0x0028BDB8 File Offset: 0x00289FB8
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

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06008F59 RID: 36697 RVA: 0x0028BDF4 File Offset: 0x00289FF4
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

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06008F5A RID: 36698 RVA: 0x0028BE30 File Offset: 0x0028A030
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

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06008F5B RID: 36699 RVA: 0x0028BE6C File Offset: 0x0028A06C
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

		// Token: 0x06008F5C RID: 36700 RVA: 0x0028BEA4 File Offset: 0x0028A0A4
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008F5D RID: 36701 RVA: 0x0028BEB4 File Offset: 0x0028A0B4
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06008F5E RID: 36702 RVA: 0x0028BECC File Offset: 0x0028A0CC
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

		// Token: 0x06008F5F RID: 36703 RVA: 0x0028BF0C File Offset: 0x0028A10C
		public int AbsorbEffects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06008F60 RID: 36704 RVA: 0x0028BF4C File Offset: 0x0028A14C
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

		// Token: 0x06008F61 RID: 36705 RVA: 0x0028BF78 File Offset: 0x0028A178
		public Span<int> GetAbsorbEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06008F62 RID: 36706 RVA: 0x0028BF88 File Offset: 0x0028A188
		public int[] GetAbsorbEffectsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x0028BFA0 File Offset: 0x0028A1A0
		[NullableContext(1)]
		public int[] AbsorbEffects()
		{
			return this.GetAbsorbEffectsArray();
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x0028BFA8 File Offset: 0x0028A1A8
		[NullableContext(1)]
		public IEnumerable<int> AbsorbEffectsIter()
		{
			KurotatoDrop.<AbsorbEffectsIter>d__26 <AbsorbEffectsIter>d__ = new KurotatoDrop.<AbsorbEffectsIter>d__26(-2);
			<AbsorbEffectsIter>d__.<>3__<>4__this = this;
			return <AbsorbEffectsIter>d__;
		}

		// Token: 0x04005410 RID: 21520
		private Table __p;
	}
}
