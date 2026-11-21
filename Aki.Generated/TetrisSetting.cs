using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200125D RID: 4701
	public struct TetrisSetting : IFlatbufferObject
	{
		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x0600EBC0 RID: 60352 RVA: 0x003582D1 File Offset: 0x003564D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EBC1 RID: 60353 RVA: 0x003582DE File Offset: 0x003564DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EBC2 RID: 60354 RVA: 0x003582E8 File Offset: 0x003564E8
		public static TetrisSetting GetRootAsTetrisSetting(ByteBuffer _bb)
		{
			return TetrisSetting.GetRootAsTetrisSetting(_bb, default(TetrisSetting));
		}

		// Token: 0x0600EBC3 RID: 60355 RVA: 0x00358304 File Offset: 0x00356504
		public static TetrisSetting GetRootAsTetrisSetting(ByteBuffer _bb, TetrisSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EBC4 RID: 60356 RVA: 0x00358321 File Offset: 0x00356521
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBC5 RID: 60357 RVA: 0x00358330 File Offset: 0x00356530
		public TetrisSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DAF RID: 15791
		// (get) Token: 0x0600EBC6 RID: 60358 RVA: 0x00358340 File Offset: 0x00356540
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EBC7 RID: 60359 RVA: 0x00358377 File Offset: 0x00356577
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600EBC8 RID: 60360 RVA: 0x00358386 File Offset: 0x00356586
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EBC9 RID: 60361 RVA: 0x003583A0 File Offset: 0x003565A0
		public int BasicScore(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DB0 RID: 15792
		// (get) Token: 0x0600EBCA RID: 60362 RVA: 0x003583E0 File Offset: 0x003565E0
		public int BasicScoreLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EBCB RID: 60363 RVA: 0x0035840B File Offset: 0x0035660B
		public Span<int> GetBasicScoreBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600EBCC RID: 60364 RVA: 0x0035841A File Offset: 0x0035661A
		public int[] GetBasicScoreArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600EBCD RID: 60365 RVA: 0x00358434 File Offset: 0x00356634
		public int ComboAddation(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x0600EBCE RID: 60366 RVA: 0x00358474 File Offset: 0x00356674
		public int ComboAddationLength
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

		// Token: 0x0600EBCF RID: 60367 RVA: 0x0035849F File Offset: 0x0035669F
		public Span<int> GetComboAddationBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600EBD0 RID: 60368 RVA: 0x003584AE File Offset: 0x003566AE
		public int[] GetComboAddationArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x0600EBD1 RID: 60369 RVA: 0x003584C8 File Offset: 0x003566C8
		public int AllClear
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

		// Token: 0x0600EBD2 RID: 60370 RVA: 0x00358508 File Offset: 0x00356708
		public int BombScore(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x0600EBD3 RID: 60371 RVA: 0x00358548 File Offset: 0x00356748
		public int BombScoreLength
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

		// Token: 0x0600EBD4 RID: 60372 RVA: 0x00358574 File Offset: 0x00356774
		public Span<int> GetBombScoreBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600EBD5 RID: 60373 RVA: 0x00358584 File Offset: 0x00356784
		public int[] GetBombScoreArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x0600EBD6 RID: 60374 RVA: 0x0035859C File Offset: 0x0035679C
		public float RotationLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EBD7 RID: 60375 RVA: 0x003585DD File Offset: 0x003567DD
		[NullableContext(1)]
		public int[] BasicScore()
		{
			return this.GetBasicScoreArray();
		}

		// Token: 0x0600EBD8 RID: 60376 RVA: 0x003585E5 File Offset: 0x003567E5
		[NullableContext(1)]
		public IEnumerable<int> BasicScoreIter()
		{
			TetrisSetting.<BasicScoreIter>d__32 <BasicScoreIter>d__ = new TetrisSetting.<BasicScoreIter>d__32(-2);
			<BasicScoreIter>d__.<>3__<>4__this = this;
			return <BasicScoreIter>d__;
		}

		// Token: 0x0600EBD9 RID: 60377 RVA: 0x003585FA File Offset: 0x003567FA
		[NullableContext(1)]
		public int[] BombScore()
		{
			return this.GetBombScoreArray();
		}

		// Token: 0x0600EBDA RID: 60378 RVA: 0x00358602 File Offset: 0x00356802
		[NullableContext(1)]
		public IEnumerable<int> BombScoreIter()
		{
			TetrisSetting.<BombScoreIter>d__34 <BombScoreIter>d__ = new TetrisSetting.<BombScoreIter>d__34(-2);
			<BombScoreIter>d__.<>3__<>4__this = this;
			return <BombScoreIter>d__;
		}

		// Token: 0x0600EBDB RID: 60379 RVA: 0x00358617 File Offset: 0x00356817
		[NullableContext(1)]
		public int[] ComboAddation()
		{
			return this.GetComboAddationArray();
		}

		// Token: 0x0600EBDC RID: 60380 RVA: 0x0035861F File Offset: 0x0035681F
		[NullableContext(1)]
		public IEnumerable<int> ComboAddationIter()
		{
			TetrisSetting.<ComboAddationIter>d__36 <ComboAddationIter>d__ = new TetrisSetting.<ComboAddationIter>d__36(-2);
			<ComboAddationIter>d__.<>3__<>4__this = this;
			return <ComboAddationIter>d__;
		}

		// Token: 0x040058A8 RID: 22696
		private Table __p;
	}
}
