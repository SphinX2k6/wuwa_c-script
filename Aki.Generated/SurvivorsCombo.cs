using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200122E RID: 4654
	public struct SurvivorsCombo : IFlatbufferObject
	{
		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x0600E770 RID: 59248 RVA: 0x0034E6BC File Offset: 0x0034C8BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E771 RID: 59249 RVA: 0x0034E6C9 File Offset: 0x0034C8C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E772 RID: 59250 RVA: 0x0034E6D0 File Offset: 0x0034C8D0
		public static SurvivorsCombo GetRootAsSurvivorsCombo(ByteBuffer _bb)
		{
			return SurvivorsCombo.GetRootAsSurvivorsCombo(_bb, default(SurvivorsCombo));
		}

		// Token: 0x0600E773 RID: 59251 RVA: 0x0034E6EC File Offset: 0x0034C8EC
		public static SurvivorsCombo GetRootAsSurvivorsCombo(ByteBuffer _bb, SurvivorsCombo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E774 RID: 59252 RVA: 0x0034E709 File Offset: 0x0034C909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E775 RID: 59253 RVA: 0x0034E718 File Offset: 0x0034C918
		public SurvivorsCombo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C05 RID: 15365
		// (get) Token: 0x0600E776 RID: 59254 RVA: 0x0034E728 File Offset: 0x0034C928
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

		// Token: 0x0600E777 RID: 59255 RVA: 0x0034E764 File Offset: 0x0034C964
		public int ComboNum(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x0600E778 RID: 59256 RVA: 0x0034E7A4 File Offset: 0x0034C9A4
		public int ComboNumLength
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

		// Token: 0x0600E779 RID: 59257 RVA: 0x0034E7CF File Offset: 0x0034C9CF
		public Span<int> GetComboNumBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600E77A RID: 59258 RVA: 0x0034E7DE File Offset: 0x0034C9DE
		public int[] GetComboNumArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600E77B RID: 59259 RVA: 0x0034E7F8 File Offset: 0x0034C9F8
		public int ComboDuration(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x0600E77C RID: 59260 RVA: 0x0034E838 File Offset: 0x0034CA38
		public int ComboDurationLength
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

		// Token: 0x0600E77D RID: 59261 RVA: 0x0034E863 File Offset: 0x0034CA63
		public Span<int> GetComboDurationBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600E77E RID: 59262 RVA: 0x0034E872 File Offset: 0x0034CA72
		public int[] GetComboDurationArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600E77F RID: 59263 RVA: 0x0034E88C File Offset: 0x0034CA8C
		public int PlayerBuffIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x0600E780 RID: 59264 RVA: 0x0034E8CC File Offset: 0x0034CACC
		public int PlayerBuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E781 RID: 59265 RVA: 0x0034E8F8 File Offset: 0x0034CAF8
		public Span<int> GetPlayerBuffIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600E782 RID: 59266 RVA: 0x0034E908 File Offset: 0x0034CB08
		public int[] GetPlayerBuffIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600E783 RID: 59267 RVA: 0x0034E920 File Offset: 0x0034CB20
		public int WeaponBuffIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x0600E784 RID: 59268 RVA: 0x0034E960 File Offset: 0x0034CB60
		public int WeaponBuffIdsLength
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

		// Token: 0x0600E785 RID: 59269 RVA: 0x0034E98C File Offset: 0x0034CB8C
		public Span<int> GetWeaponBuffIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E786 RID: 59270 RVA: 0x0034E99C File Offset: 0x0034CB9C
		public int[] GetWeaponBuffIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600E787 RID: 59271 RVA: 0x0034E9B4 File Offset: 0x0034CBB4
		[NullableContext(1)]
		public int[] ComboDuration()
		{
			return this.GetComboDurationArray();
		}

		// Token: 0x0600E788 RID: 59272 RVA: 0x0034E9BC File Offset: 0x0034CBBC
		[NullableContext(1)]
		public IEnumerable<int> ComboDurationIter()
		{
			SurvivorsCombo.<ComboDurationIter>d__31 <ComboDurationIter>d__ = new SurvivorsCombo.<ComboDurationIter>d__31(-2);
			<ComboDurationIter>d__.<>3__<>4__this = this;
			return <ComboDurationIter>d__;
		}

		// Token: 0x0600E789 RID: 59273 RVA: 0x0034E9D1 File Offset: 0x0034CBD1
		[NullableContext(1)]
		public int[] ComboNum()
		{
			return this.GetComboNumArray();
		}

		// Token: 0x0600E78A RID: 59274 RVA: 0x0034E9D9 File Offset: 0x0034CBD9
		[NullableContext(1)]
		public IEnumerable<int> ComboNumIter()
		{
			SurvivorsCombo.<ComboNumIter>d__33 <ComboNumIter>d__ = new SurvivorsCombo.<ComboNumIter>d__33(-2);
			<ComboNumIter>d__.<>3__<>4__this = this;
			return <ComboNumIter>d__;
		}

		// Token: 0x0600E78B RID: 59275 RVA: 0x0034E9EE File Offset: 0x0034CBEE
		[NullableContext(1)]
		public int[] PlayerBuffIds()
		{
			return this.GetPlayerBuffIdsArray();
		}

		// Token: 0x0600E78C RID: 59276 RVA: 0x0034E9F6 File Offset: 0x0034CBF6
		[NullableContext(1)]
		public IEnumerable<int> PlayerBuffIdsIter()
		{
			SurvivorsCombo.<PlayerBuffIdsIter>d__35 <PlayerBuffIdsIter>d__ = new SurvivorsCombo.<PlayerBuffIdsIter>d__35(-2);
			<PlayerBuffIdsIter>d__.<>3__<>4__this = this;
			return <PlayerBuffIdsIter>d__;
		}

		// Token: 0x0600E78D RID: 59277 RVA: 0x0034EA0B File Offset: 0x0034CC0B
		[NullableContext(1)]
		public int[] WeaponBuffIds()
		{
			return this.GetWeaponBuffIdsArray();
		}

		// Token: 0x0600E78E RID: 59278 RVA: 0x0034EA13 File Offset: 0x0034CC13
		[NullableContext(1)]
		public IEnumerable<int> WeaponBuffIdsIter()
		{
			SurvivorsCombo.<WeaponBuffIdsIter>d__37 <WeaponBuffIdsIter>d__ = new SurvivorsCombo.<WeaponBuffIdsIter>d__37(-2);
			<WeaponBuffIdsIter>d__.<>3__<>4__this = this;
			return <WeaponBuffIdsIter>d__;
		}

		// Token: 0x04005871 RID: 22641
		private Table __p;
	}
}
