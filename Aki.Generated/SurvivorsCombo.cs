using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F8 RID: 4344
	public struct SurvivorsCombo : IFlatbufferObject
	{
		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0600DA25 RID: 55845 RVA: 0x0032320C File Offset: 0x0032140C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA26 RID: 55846 RVA: 0x00323219 File Offset: 0x00321419
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA27 RID: 55847 RVA: 0x00323220 File Offset: 0x00321420
		public static SurvivorsCombo GetRootAsSurvivorsCombo(ByteBuffer _bb)
		{
			return SurvivorsCombo.GetRootAsSurvivorsCombo(_bb, default(SurvivorsCombo));
		}

		// Token: 0x0600DA28 RID: 55848 RVA: 0x0032323C File Offset: 0x0032143C
		public static SurvivorsCombo GetRootAsSurvivorsCombo(ByteBuffer _bb, SurvivorsCombo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA29 RID: 55849 RVA: 0x00323259 File Offset: 0x00321459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA2A RID: 55850 RVA: 0x00323268 File Offset: 0x00321468
		public SurvivorsCombo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0600DA2B RID: 55851 RVA: 0x00323278 File Offset: 0x00321478
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

		// Token: 0x0600DA2C RID: 55852 RVA: 0x003232B4 File Offset: 0x003214B4
		public int ComboNum(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x0600DA2D RID: 55853 RVA: 0x003232F4 File Offset: 0x003214F4
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

		// Token: 0x0600DA2E RID: 55854 RVA: 0x0032331F File Offset: 0x0032151F
		public Span<int> GetComboNumBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600DA2F RID: 55855 RVA: 0x0032332E File Offset: 0x0032152E
		public int[] GetComboNumArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600DA30 RID: 55856 RVA: 0x00323348 File Offset: 0x00321548
		public int ComboDuration(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x0600DA31 RID: 55857 RVA: 0x00323388 File Offset: 0x00321588
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

		// Token: 0x0600DA32 RID: 55858 RVA: 0x003233B3 File Offset: 0x003215B3
		public Span<int> GetComboDurationBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600DA33 RID: 55859 RVA: 0x003233C2 File Offset: 0x003215C2
		public int[] GetComboDurationArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600DA34 RID: 55860 RVA: 0x003233DC File Offset: 0x003215DC
		public int PlayerBuffIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x0600DA35 RID: 55861 RVA: 0x0032341C File Offset: 0x0032161C
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

		// Token: 0x0600DA36 RID: 55862 RVA: 0x00323448 File Offset: 0x00321648
		public Span<int> GetPlayerBuffIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600DA37 RID: 55863 RVA: 0x00323458 File Offset: 0x00321658
		public int[] GetPlayerBuffIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600DA38 RID: 55864 RVA: 0x00323470 File Offset: 0x00321670
		public int WeaponBuffIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x0600DA39 RID: 55865 RVA: 0x003234B0 File Offset: 0x003216B0
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

		// Token: 0x0600DA3A RID: 55866 RVA: 0x003234DC File Offset: 0x003216DC
		public Span<int> GetWeaponBuffIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600DA3B RID: 55867 RVA: 0x003234EC File Offset: 0x003216EC
		public int[] GetWeaponBuffIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600DA3C RID: 55868 RVA: 0x00323504 File Offset: 0x00321704
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ComboDurationIter()或GetComboDurationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ComboDuration()
		{
			SurvivorsCombo survivorsCombo = this;
			return survivorsCombo.GetComboDurationArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DA3D RID: 55869 RVA: 0x00323528 File Offset: 0x00321728
		[NullableContext(1)]
		public readonly IEnumerable<int> ComboDurationIter()
		{
			SurvivorsCombo.<ComboDurationIter>d__31 <ComboDurationIter>d__ = new SurvivorsCombo.<ComboDurationIter>d__31(-2);
			<ComboDurationIter>d__.<>3__<>4__this = this;
			return <ComboDurationIter>d__;
		}

		// Token: 0x0600DA3E RID: 55870 RVA: 0x00323540 File Offset: 0x00321740
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ComboNumIter()或GetComboNumBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ComboNum()
		{
			SurvivorsCombo survivorsCombo = this;
			return survivorsCombo.GetComboNumArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DA3F RID: 55871 RVA: 0x00323564 File Offset: 0x00321764
		[NullableContext(1)]
		public readonly IEnumerable<int> ComboNumIter()
		{
			SurvivorsCombo.<ComboNumIter>d__33 <ComboNumIter>d__ = new SurvivorsCombo.<ComboNumIter>d__33(-2);
			<ComboNumIter>d__.<>3__<>4__this = this;
			return <ComboNumIter>d__;
		}

		// Token: 0x0600DA40 RID: 55872 RVA: 0x0032357C File Offset: 0x0032177C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PlayerBuffIdsIter()或GetPlayerBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PlayerBuffIds()
		{
			SurvivorsCombo survivorsCombo = this;
			return survivorsCombo.GetPlayerBuffIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DA41 RID: 55873 RVA: 0x003235A0 File Offset: 0x003217A0
		[NullableContext(1)]
		public readonly IEnumerable<int> PlayerBuffIdsIter()
		{
			SurvivorsCombo.<PlayerBuffIdsIter>d__35 <PlayerBuffIdsIter>d__ = new SurvivorsCombo.<PlayerBuffIdsIter>d__35(-2);
			<PlayerBuffIdsIter>d__.<>3__<>4__this = this;
			return <PlayerBuffIdsIter>d__;
		}

		// Token: 0x0600DA42 RID: 55874 RVA: 0x003235B8 File Offset: 0x003217B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponBuffIdsIter()或GetWeaponBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WeaponBuffIds()
		{
			SurvivorsCombo survivorsCombo = this;
			return survivorsCombo.GetWeaponBuffIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DA43 RID: 55875 RVA: 0x003235DC File Offset: 0x003217DC
		[NullableContext(1)]
		public readonly IEnumerable<int> WeaponBuffIdsIter()
		{
			SurvivorsCombo.<WeaponBuffIdsIter>d__37 <WeaponBuffIdsIter>d__ = new SurvivorsCombo.<WeaponBuffIdsIter>d__37(-2);
			<WeaponBuffIdsIter>d__.<>3__<>4__this = this;
			return <WeaponBuffIdsIter>d__;
		}

		// Token: 0x0400522E RID: 21038
		private Table __p;
	}
}
