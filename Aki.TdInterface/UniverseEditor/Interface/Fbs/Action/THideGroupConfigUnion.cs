using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EFE RID: 32510
	public class THideGroupConfigUnion
	{
		// Token: 0x1700F277 RID: 62071
		// (get) Token: 0x0603AA4B RID: 240203 RVA: 0x007E36F0 File Offset: 0x007E18F0
		// (set) Token: 0x0603AA4C RID: 240204 RVA: 0x007E36F8 File Offset: 0x007E18F8
		public THideGroupConfig Type { get; set; }

		// Token: 0x1700F278 RID: 62072
		// (get) Token: 0x0603AA4D RID: 240205 RVA: 0x007E3701 File Offset: 0x007E1901
		// (set) Token: 0x0603AA4E RID: 240206 RVA: 0x007E3709 File Offset: 0x007E1909
		public object Value { get; set; }

		// Token: 0x0603AA4F RID: 240207 RVA: 0x007E3712 File Offset: 0x007E1912
		public THideGroupConfigUnion()
		{
			this.Type = THideGroupConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603AA50 RID: 240208 RVA: 0x007E3728 File Offset: 0x007E1928
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AA51 RID: 240209 RVA: 0x007E373A File Offset: 0x007E193A
		public IHideSpecifyDataLayersT AsIHideSpecifyDataLayers()
		{
			return this.As<IHideSpecifyDataLayersT>();
		}

		// Token: 0x0603AA52 RID: 240210 RVA: 0x007E3742 File Offset: 0x007E1942
		public static THideGroupConfigUnion FromIHideSpecifyDataLayers(IHideSpecifyDataLayersT _ihidespecifydatalayers)
		{
			return new THideGroupConfigUnion
			{
				Type = THideGroupConfig.IHideSpecifyDataLayers,
				Value = _ihidespecifydatalayers
			};
		}

		// Token: 0x0603AA53 RID: 240211 RVA: 0x007E3757 File Offset: 0x007E1957
		public IHideSpecifyEntityGroupT AsIHideSpecifyEntityGroup()
		{
			return this.As<IHideSpecifyEntityGroupT>();
		}

		// Token: 0x0603AA54 RID: 240212 RVA: 0x007E375F File Offset: 0x007E195F
		public static THideGroupConfigUnion FromIHideSpecifyEntityGroup(IHideSpecifyEntityGroupT _ihidespecifyentitygroup)
		{
			return new THideGroupConfigUnion
			{
				Type = THideGroupConfig.IHideSpecifyEntityGroup,
				Value = _ihidespecifyentitygroup
			};
		}

		// Token: 0x0603AA55 RID: 240213 RVA: 0x007E3774 File Offset: 0x007E1974
		public IHideSpecifyLevelPlayGroupT AsIHideSpecifyLevelPlayGroup()
		{
			return this.As<IHideSpecifyLevelPlayGroupT>();
		}

		// Token: 0x0603AA56 RID: 240214 RVA: 0x007E377C File Offset: 0x007E197C
		public static THideGroupConfigUnion FromIHideSpecifyLevelPlayGroup(IHideSpecifyLevelPlayGroupT _ihidespecifylevelplaygroup)
		{
			return new THideGroupConfigUnion
			{
				Type = THideGroupConfig.IHideSpecifyLevelPlayGroup,
				Value = _ihidespecifylevelplaygroup
			};
		}

		// Token: 0x0603AA57 RID: 240215 RVA: 0x007E3791 File Offset: 0x007E1991
		public IHideWorldEntityAndLevelPlayGroupT AsIHideWorldEntityAndLevelPlayGroup()
		{
			return this.As<IHideWorldEntityAndLevelPlayGroupT>();
		}

		// Token: 0x0603AA58 RID: 240216 RVA: 0x007E3799 File Offset: 0x007E1999
		public static THideGroupConfigUnion FromIHideWorldEntityAndLevelPlayGroup(IHideWorldEntityAndLevelPlayGroupT _ihideworldentityandlevelplaygroup)
		{
			return new THideGroupConfigUnion
			{
				Type = THideGroupConfig.IHideWorldEntityAndLevelPlayGroup,
				Value = _ihideworldentityandlevelplaygroup
			};
		}

		// Token: 0x0603AA59 RID: 240217 RVA: 0x007E37AE File Offset: 0x007E19AE
		public IHideWorldMonsterAndMonsterTreasureGroupT AsIHideWorldMonsterAndMonsterTreasureGroup()
		{
			return this.As<IHideWorldMonsterAndMonsterTreasureGroupT>();
		}

		// Token: 0x0603AA5A RID: 240218 RVA: 0x007E37B6 File Offset: 0x007E19B6
		public static THideGroupConfigUnion FromIHideWorldMonsterAndMonsterTreasureGroup(IHideWorldMonsterAndMonsterTreasureGroupT _ihideworldmonsterandmonstertreasuregroup)
		{
			return new THideGroupConfigUnion
			{
				Type = THideGroupConfig.IHideWorldMonsterAndMonsterTreasureGroup,
				Value = _ihideworldmonsterandmonstertreasuregroup
			};
		}

		// Token: 0x0603AA5B RID: 240219 RVA: 0x007E37CC File Offset: 0x007E19CC
		public static int Pack(FlatBufferBuilder builder, THideGroupConfigUnion _o)
		{
			switch (_o.Type)
			{
			case THideGroupConfig.IHideSpecifyDataLayers:
				return IHideSpecifyDataLayers.Pack(builder, _o.AsIHideSpecifyDataLayers()).Value;
			case THideGroupConfig.IHideSpecifyEntityGroup:
				return IHideSpecifyEntityGroup.Pack(builder, _o.AsIHideSpecifyEntityGroup()).Value;
			case THideGroupConfig.IHideSpecifyLevelPlayGroup:
				return IHideSpecifyLevelPlayGroup.Pack(builder, _o.AsIHideSpecifyLevelPlayGroup()).Value;
			case THideGroupConfig.IHideWorldEntityAndLevelPlayGroup:
				return IHideWorldEntityAndLevelPlayGroup.Pack(builder, _o.AsIHideWorldEntityAndLevelPlayGroup()).Value;
			case THideGroupConfig.IHideWorldMonsterAndMonsterTreasureGroup:
				return IHideWorldMonsterAndMonsterTreasureGroup.Pack(builder, _o.AsIHideWorldMonsterAndMonsterTreasureGroup()).Value;
			default:
				return 0;
			}
		}
	}
}
