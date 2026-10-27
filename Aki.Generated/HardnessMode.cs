using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D25 RID: 3365
	public struct HardnessMode : IFlatbufferObject
	{
		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06007E0F RID: 32271 RVA: 0x002531BD File Offset: 0x002513BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x002531CA File Offset: 0x002513CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x002531D4 File Offset: 0x002513D4
		public static HardnessMode GetRootAsHardnessMode(ByteBuffer _bb)
		{
			return HardnessMode.GetRootAsHardnessMode(_bb, default(HardnessMode));
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x002531F0 File Offset: 0x002513F0
		public static HardnessMode GetRootAsHardnessMode(ByteBuffer _bb, HardnessMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E13 RID: 32275 RVA: 0x0025320D File Offset: 0x0025140D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E14 RID: 32276 RVA: 0x0025321C File Offset: 0x0025141C
		public HardnessMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06007E15 RID: 32277 RVA: 0x0025322C File Offset: 0x0025142C
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

		// Token: 0x06007E16 RID: 32278 RVA: 0x00253268 File Offset: 0x00251468
		public float ReductionData(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06007E17 RID: 32279 RVA: 0x002532AC File Offset: 0x002514AC
		public int ReductionDataLength
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

		// Token: 0x06007E18 RID: 32280 RVA: 0x002532D7 File Offset: 0x002514D7
		public Span<float> GetReductionDataBytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x06007E19 RID: 32281 RVA: 0x002532E6 File Offset: 0x002514E6
		public float[] GetReductionDataArray()
		{
			return this.__p.__vector_as_array<float>(6) ?? Array.Empty<float>();
		}

		// Token: 0x06007E1A RID: 32282 RVA: 0x00253300 File Offset: 0x00251500
		public float AttackTypeData(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06007E1B RID: 32283 RVA: 0x00253344 File Offset: 0x00251544
		public int AttackTypeDataLength
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

		// Token: 0x06007E1C RID: 32284 RVA: 0x0025336F File Offset: 0x0025156F
		public Span<float> GetAttackTypeDataBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x06007E1D RID: 32285 RVA: 0x0025337E File Offset: 0x0025157E
		public float[] GetAttackTypeDataArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x06007E1E RID: 32286 RVA: 0x00253398 File Offset: 0x00251598
		public float CorrectData(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06007E1F RID: 32287 RVA: 0x002533DC File Offset: 0x002515DC
		public int CorrectDataLength
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

		// Token: 0x06007E20 RID: 32288 RVA: 0x00253408 File Offset: 0x00251608
		public Span<float> GetCorrectDataBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x06007E21 RID: 32289 RVA: 0x00253418 File Offset: 0x00251618
		public float[] GetCorrectDataArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x06007E22 RID: 32290 RVA: 0x00253430 File Offset: 0x00251630
		public float WeaponReduction(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06007E23 RID: 32291 RVA: 0x00253474 File Offset: 0x00251674
		public int WeaponReductionLength
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

		// Token: 0x06007E24 RID: 32292 RVA: 0x002534A0 File Offset: 0x002516A0
		public Span<float> GetWeaponReductionBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x06007E25 RID: 32293 RVA: 0x002534B0 File Offset: 0x002516B0
		public float[] GetWeaponReductionArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x06007E26 RID: 32294 RVA: 0x002534C8 File Offset: 0x002516C8
		public float SkillTypeParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06007E27 RID: 32295 RVA: 0x0025350C File Offset: 0x0025170C
		public int SkillTypeParamLength
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

		// Token: 0x06007E28 RID: 32296 RVA: 0x00253538 File Offset: 0x00251738
		public Span<float> GetSkillTypeParamBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x00253548 File Offset: 0x00251748
		public float[] GetSkillTypeParamArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06007E2A RID: 32298 RVA: 0x00253560 File Offset: 0x00251760
		public int Percent
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

		// Token: 0x06007E2B RID: 32299 RVA: 0x002535A0 File Offset: 0x002517A0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttackTypeDataIter()或GetAttackTypeDataBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] AttackTypeData()
		{
			HardnessMode hardnessMode = this;
			return hardnessMode.GetAttackTypeDataArray() ?? Array.Empty<float>();
		}

		// Token: 0x06007E2C RID: 32300 RVA: 0x002535C4 File Offset: 0x002517C4
		[NullableContext(1)]
		public readonly IEnumerable<float> AttackTypeDataIter()
		{
			HardnessMode.<AttackTypeDataIter>d__38 <AttackTypeDataIter>d__ = new HardnessMode.<AttackTypeDataIter>d__38(-2);
			<AttackTypeDataIter>d__.<>3__<>4__this = this;
			return <AttackTypeDataIter>d__;
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x002535DC File Offset: 0x002517DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CorrectDataIter()或GetCorrectDataBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CorrectData()
		{
			HardnessMode hardnessMode = this;
			return hardnessMode.GetCorrectDataArray() ?? Array.Empty<float>();
		}

		// Token: 0x06007E2E RID: 32302 RVA: 0x00253600 File Offset: 0x00251800
		[NullableContext(1)]
		public readonly IEnumerable<float> CorrectDataIter()
		{
			HardnessMode.<CorrectDataIter>d__40 <CorrectDataIter>d__ = new HardnessMode.<CorrectDataIter>d__40(-2);
			<CorrectDataIter>d__.<>3__<>4__this = this;
			return <CorrectDataIter>d__;
		}

		// Token: 0x06007E2F RID: 32303 RVA: 0x00253618 File Offset: 0x00251818
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReductionDataIter()或GetReductionDataBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] ReductionData()
		{
			HardnessMode hardnessMode = this;
			return hardnessMode.GetReductionDataArray() ?? Array.Empty<float>();
		}

		// Token: 0x06007E30 RID: 32304 RVA: 0x0025363C File Offset: 0x0025183C
		[NullableContext(1)]
		public readonly IEnumerable<float> ReductionDataIter()
		{
			HardnessMode.<ReductionDataIter>d__42 <ReductionDataIter>d__ = new HardnessMode.<ReductionDataIter>d__42(-2);
			<ReductionDataIter>d__.<>3__<>4__this = this;
			return <ReductionDataIter>d__;
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x00253654 File Offset: 0x00251854
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillTypeParamIter()或GetSkillTypeParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] SkillTypeParam()
		{
			HardnessMode hardnessMode = this;
			return hardnessMode.GetSkillTypeParamArray() ?? Array.Empty<float>();
		}

		// Token: 0x06007E32 RID: 32306 RVA: 0x00253678 File Offset: 0x00251878
		[NullableContext(1)]
		public readonly IEnumerable<float> SkillTypeParamIter()
		{
			HardnessMode.<SkillTypeParamIter>d__44 <SkillTypeParamIter>d__ = new HardnessMode.<SkillTypeParamIter>d__44(-2);
			<SkillTypeParamIter>d__.<>3__<>4__this = this;
			return <SkillTypeParamIter>d__;
		}

		// Token: 0x06007E33 RID: 32307 RVA: 0x00253690 File Offset: 0x00251890
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponReductionIter()或GetWeaponReductionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] WeaponReduction()
		{
			HardnessMode hardnessMode = this;
			return hardnessMode.GetWeaponReductionArray() ?? Array.Empty<float>();
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x002536B4 File Offset: 0x002518B4
		[NullableContext(1)]
		public readonly IEnumerable<float> WeaponReductionIter()
		{
			HardnessMode.<WeaponReductionIter>d__46 <WeaponReductionIter>d__ = new HardnessMode.<WeaponReductionIter>d__46(-2);
			<WeaponReductionIter>d__.<>3__<>4__this = this;
			return <WeaponReductionIter>d__;
		}

		// Token: 0x04004D9D RID: 19869
		private Table __p;
	}
}
