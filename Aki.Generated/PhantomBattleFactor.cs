using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB5 RID: 4021
	public struct PhantomBattleFactor : IFlatbufferObject
	{
		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x0600AD23 RID: 44323 RVA: 0x002CCC89 File Offset: 0x002CAE89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD24 RID: 44324 RVA: 0x002CCC96 File Offset: 0x002CAE96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD25 RID: 44325 RVA: 0x002CCCA0 File Offset: 0x002CAEA0
		public static PhantomBattleFactor GetRootAsPhantomBattleFactor(ByteBuffer _bb)
		{
			return PhantomBattleFactor.GetRootAsPhantomBattleFactor(_bb, default(PhantomBattleFactor));
		}

		// Token: 0x0600AD26 RID: 44326 RVA: 0x002CCCBC File Offset: 0x002CAEBC
		public static PhantomBattleFactor GetRootAsPhantomBattleFactor(ByteBuffer _bb, PhantomBattleFactor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD27 RID: 44327 RVA: 0x002CCCD9 File Offset: 0x002CAED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD28 RID: 44328 RVA: 0x002CCCE8 File Offset: 0x002CAEE8
		public PhantomBattleFactor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x0600AD29 RID: 44329 RVA: 0x002CCCF8 File Offset: 0x002CAEF8
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

		// Token: 0x0600AD2A RID: 44330 RVA: 0x002CCD34 File Offset: 0x002CAF34
		public int PhantomBattleEffectId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x0600AD2B RID: 44331 RVA: 0x002CCD74 File Offset: 0x002CAF74
		public int PhantomBattleEffectIdLength
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

		// Token: 0x0600AD2C RID: 44332 RVA: 0x002CCD9F File Offset: 0x002CAF9F
		public Span<int> GetPhantomBattleEffectIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600AD2D RID: 44333 RVA: 0x002CCDAE File Offset: 0x002CAFAE
		public int[] GetPhantomBattleEffectIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x0600AD2E RID: 44334 RVA: 0x002CCDC8 File Offset: 0x002CAFC8
		public bool IsBeforeBattle
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x0600AD2F RID: 44335 RVA: 0x002CCE08 File Offset: 0x002CB008
		public string Tag
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

		// Token: 0x0600AD30 RID: 44336 RVA: 0x002CCE40 File Offset: 0x002CB040
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AD31 RID: 44337 RVA: 0x002CCE50 File Offset: 0x002CB050
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x0600AD32 RID: 44338 RVA: 0x002CCE68 File Offset: 0x002CB068
		public int Sort
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

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x0600AD33 RID: 44339 RVA: 0x002CCEA8 File Offset: 0x002CB0A8
		public string Name
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

		// Token: 0x0600AD34 RID: 44340 RVA: 0x002CCEE0 File Offset: 0x002CB0E0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AD35 RID: 44341 RVA: 0x002CCEF0 File Offset: 0x002CB0F0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x0600AD36 RID: 44342 RVA: 0x002CCF08 File Offset: 0x002CB108
		public string Description
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AD37 RID: 44343 RVA: 0x002CCF40 File Offset: 0x002CB140
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AD38 RID: 44344 RVA: 0x002CCF50 File Offset: 0x002CB150
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AD39 RID: 44345 RVA: 0x002CCF68 File Offset: 0x002CB168
		public string DescriptionParams(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x0600AD3A RID: 44346 RVA: 0x002CCFA4 File Offset: 0x002CB1A4
		public int DescriptionParamsLength
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

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x0600AD3B RID: 44347 RVA: 0x002CCFD0 File Offset: 0x002CB1D0
		public string DeActiveDescription
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AD3C RID: 44348 RVA: 0x002CD008 File Offset: 0x002CB208
		public Span<byte> GetDeActiveDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AD3D RID: 44349 RVA: 0x002CD018 File Offset: 0x002CB218
		public byte[] GetDeActiveDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AD3E RID: 44350 RVA: 0x002CD030 File Offset: 0x002CB230
		public string DeActiveDescriptionParams(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x0600AD3F RID: 44351 RVA: 0x002CD06C File Offset: 0x002CB26C
		public int DeActiveDescriptionParamsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x0600AD40 RID: 44352 RVA: 0x002CD098 File Offset: 0x002CB298
		public int EntryId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x0600AD41 RID: 44353 RVA: 0x002CD0D8 File Offset: 0x002CB2D8
		public int SlotTendency
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AD42 RID: 44354 RVA: 0x002CD115 File Offset: 0x002CB315
		[NullableContext(1)]
		public string[] DeActiveDescriptionParams()
		{
			return this.DeActiveDescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600AD43 RID: 44355 RVA: 0x002CD122 File Offset: 0x002CB322
		[NullableContext(1)]
		public IEnumerable<string> DeActiveDescriptionParamsIter()
		{
			PhantomBattleFactor.<DeActiveDescriptionParamsIter>d__46 <DeActiveDescriptionParamsIter>d__ = new PhantomBattleFactor.<DeActiveDescriptionParamsIter>d__46(-2);
			<DeActiveDescriptionParamsIter>d__.<>3__<>4__this = this;
			return <DeActiveDescriptionParamsIter>d__;
		}

		// Token: 0x0600AD44 RID: 44356 RVA: 0x002CD137 File Offset: 0x002CB337
		[NullableContext(1)]
		public string[] DescriptionParams()
		{
			return this.DescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600AD45 RID: 44357 RVA: 0x002CD144 File Offset: 0x002CB344
		[NullableContext(1)]
		public IEnumerable<string> DescriptionParamsIter()
		{
			PhantomBattleFactor.<DescriptionParamsIter>d__48 <DescriptionParamsIter>d__ = new PhantomBattleFactor.<DescriptionParamsIter>d__48(-2);
			<DescriptionParamsIter>d__.<>3__<>4__this = this;
			return <DescriptionParamsIter>d__;
		}

		// Token: 0x0600AD46 RID: 44358 RVA: 0x002CD159 File Offset: 0x002CB359
		[NullableContext(1)]
		public int[] PhantomBattleEffectId()
		{
			return this.GetPhantomBattleEffectIdArray();
		}

		// Token: 0x0600AD47 RID: 44359 RVA: 0x002CD161 File Offset: 0x002CB361
		[NullableContext(1)]
		public IEnumerable<int> PhantomBattleEffectIdIter()
		{
			PhantomBattleFactor.<PhantomBattleEffectIdIter>d__50 <PhantomBattleEffectIdIter>d__ = new PhantomBattleFactor.<PhantomBattleEffectIdIter>d__50(-2);
			<PhantomBattleEffectIdIter>d__.<>3__<>4__this = this;
			return <PhantomBattleEffectIdIter>d__;
		}

		// Token: 0x04005573 RID: 21875
		private Table __p;
	}
}
