using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0A RID: 3594
	public struct HardnessMode : IFlatbufferObject
	{
		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06008429 RID: 33833 RVA: 0x00271ACD File Offset: 0x0026FCCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x00271ADA File Offset: 0x0026FCDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x00271AE4 File Offset: 0x0026FCE4
		public static HardnessMode GetRootAsHardnessMode(ByteBuffer _bb)
		{
			return HardnessMode.GetRootAsHardnessMode(_bb, default(HardnessMode));
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x00271B00 File Offset: 0x0026FD00
		public static HardnessMode GetRootAsHardnessMode(ByteBuffer _bb, HardnessMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x00271B1D File Offset: 0x0026FD1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x00271B2C File Offset: 0x0026FD2C
		public HardnessMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x0600842F RID: 33839 RVA: 0x00271B3C File Offset: 0x0026FD3C
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

		// Token: 0x06008430 RID: 33840 RVA: 0x00271B78 File Offset: 0x0026FD78
		public float ReductionData(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06008431 RID: 33841 RVA: 0x00271BBC File Offset: 0x0026FDBC
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

		// Token: 0x06008432 RID: 33842 RVA: 0x00271BE7 File Offset: 0x0026FDE7
		public Span<float> GetReductionDataBytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x00271BF6 File Offset: 0x0026FDF6
		public float[] GetReductionDataArray()
		{
			return this.__p.__vector_as_array<float>(6) ?? Array.Empty<float>();
		}

		// Token: 0x06008434 RID: 33844 RVA: 0x00271C10 File Offset: 0x0026FE10
		public float AttackTypeData(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06008435 RID: 33845 RVA: 0x00271C54 File Offset: 0x0026FE54
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

		// Token: 0x06008436 RID: 33846 RVA: 0x00271C7F File Offset: 0x0026FE7F
		public Span<float> GetAttackTypeDataBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x06008437 RID: 33847 RVA: 0x00271C8E File Offset: 0x0026FE8E
		public float[] GetAttackTypeDataArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x06008438 RID: 33848 RVA: 0x00271CA8 File Offset: 0x0026FEA8
		public float CorrectData(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06008439 RID: 33849 RVA: 0x00271CEC File Offset: 0x0026FEEC
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

		// Token: 0x0600843A RID: 33850 RVA: 0x00271D18 File Offset: 0x0026FF18
		public Span<float> GetCorrectDataBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x0600843B RID: 33851 RVA: 0x00271D28 File Offset: 0x0026FF28
		public float[] GetCorrectDataArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x0600843C RID: 33852 RVA: 0x00271D40 File Offset: 0x0026FF40
		public float WeaponReduction(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x0600843D RID: 33853 RVA: 0x00271D84 File Offset: 0x0026FF84
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

		// Token: 0x0600843E RID: 33854 RVA: 0x00271DB0 File Offset: 0x0026FFB0
		public Span<float> GetWeaponReductionBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x00271DC0 File Offset: 0x0026FFC0
		public float[] GetWeaponReductionArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x06008440 RID: 33856 RVA: 0x00271DD8 File Offset: 0x0026FFD8
		public float SkillTypeParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06008441 RID: 33857 RVA: 0x00271E1C File Offset: 0x0027001C
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

		// Token: 0x06008442 RID: 33858 RVA: 0x00271E48 File Offset: 0x00270048
		public Span<float> GetSkillTypeParamBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x00271E58 File Offset: 0x00270058
		public float[] GetSkillTypeParamArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06008444 RID: 33860 RVA: 0x00271E70 File Offset: 0x00270070
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

		// Token: 0x06008445 RID: 33861 RVA: 0x00271EAD File Offset: 0x002700AD
		[NullableContext(1)]
		public float[] AttackTypeData()
		{
			return this.GetAttackTypeDataArray();
		}

		// Token: 0x06008446 RID: 33862 RVA: 0x00271EB5 File Offset: 0x002700B5
		[NullableContext(1)]
		public IEnumerable<float> AttackTypeDataIter()
		{
			HardnessMode.<AttackTypeDataIter>d__38 <AttackTypeDataIter>d__ = new HardnessMode.<AttackTypeDataIter>d__38(-2);
			<AttackTypeDataIter>d__.<>3__<>4__this = this;
			return <AttackTypeDataIter>d__;
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x00271ECA File Offset: 0x002700CA
		[NullableContext(1)]
		public float[] CorrectData()
		{
			return this.GetCorrectDataArray();
		}

		// Token: 0x06008448 RID: 33864 RVA: 0x00271ED2 File Offset: 0x002700D2
		[NullableContext(1)]
		public IEnumerable<float> CorrectDataIter()
		{
			HardnessMode.<CorrectDataIter>d__40 <CorrectDataIter>d__ = new HardnessMode.<CorrectDataIter>d__40(-2);
			<CorrectDataIter>d__.<>3__<>4__this = this;
			return <CorrectDataIter>d__;
		}

		// Token: 0x06008449 RID: 33865 RVA: 0x00271EE7 File Offset: 0x002700E7
		[NullableContext(1)]
		public float[] ReductionData()
		{
			return this.GetReductionDataArray();
		}

		// Token: 0x0600844A RID: 33866 RVA: 0x00271EEF File Offset: 0x002700EF
		[NullableContext(1)]
		public IEnumerable<float> ReductionDataIter()
		{
			HardnessMode.<ReductionDataIter>d__42 <ReductionDataIter>d__ = new HardnessMode.<ReductionDataIter>d__42(-2);
			<ReductionDataIter>d__.<>3__<>4__this = this;
			return <ReductionDataIter>d__;
		}

		// Token: 0x0600844B RID: 33867 RVA: 0x00271F04 File Offset: 0x00270104
		[NullableContext(1)]
		public float[] SkillTypeParam()
		{
			return this.GetSkillTypeParamArray();
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x00271F0C File Offset: 0x0027010C
		[NullableContext(1)]
		public IEnumerable<float> SkillTypeParamIter()
		{
			HardnessMode.<SkillTypeParamIter>d__44 <SkillTypeParamIter>d__ = new HardnessMode.<SkillTypeParamIter>d__44(-2);
			<SkillTypeParamIter>d__.<>3__<>4__this = this;
			return <SkillTypeParamIter>d__;
		}

		// Token: 0x0600844D RID: 33869 RVA: 0x00271F21 File Offset: 0x00270121
		[NullableContext(1)]
		public float[] WeaponReduction()
		{
			return this.GetWeaponReductionArray();
		}

		// Token: 0x0600844E RID: 33870 RVA: 0x00271F29 File Offset: 0x00270129
		[NullableContext(1)]
		public IEnumerable<float> WeaponReductionIter()
		{
			HardnessMode.<WeaponReductionIter>d__46 <WeaponReductionIter>d__ = new HardnessMode.<WeaponReductionIter>d__46(-2);
			<WeaponReductionIter>d__.<>3__<>4__this = this;
			return <WeaponReductionIter>d__;
		}

		// Token: 0x04005382 RID: 21378
		private Table __p;
	}
}
