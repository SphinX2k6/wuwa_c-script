using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F01 RID: 32513
	public class THideRangeConfigUnion
	{
		// Token: 0x1700F279 RID: 62073
		// (get) Token: 0x0603AA5D RID: 240221 RVA: 0x007E38BC File Offset: 0x007E1ABC
		// (set) Token: 0x0603AA5E RID: 240222 RVA: 0x007E38C4 File Offset: 0x007E1AC4
		public THideRangeConfig Type { get; set; }

		// Token: 0x1700F27A RID: 62074
		// (get) Token: 0x0603AA5F RID: 240223 RVA: 0x007E38CD File Offset: 0x007E1ACD
		// (set) Token: 0x0603AA60 RID: 240224 RVA: 0x007E38D5 File Offset: 0x007E1AD5
		public object Value { get; set; }

		// Token: 0x0603AA61 RID: 240225 RVA: 0x007E38DE File Offset: 0x007E1ADE
		public THideRangeConfigUnion()
		{
			this.Type = THideRangeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603AA62 RID: 240226 RVA: 0x007E38F4 File Offset: 0x007E1AF4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AA63 RID: 240227 RVA: 0x007E3906 File Offset: 0x007E1B06
		public IHideWorldEntityAndLevelPlayT AsIHideWorldEntityAndLevelPlay()
		{
			return this.As<IHideWorldEntityAndLevelPlayT>();
		}

		// Token: 0x0603AA64 RID: 240228 RVA: 0x007E390E File Offset: 0x007E1B0E
		public static THideRangeConfigUnion FromIHideWorldEntityAndLevelPlay(IHideWorldEntityAndLevelPlayT _ihideworldentityandlevelplay)
		{
			return new THideRangeConfigUnion
			{
				Type = THideRangeConfig.IHideWorldEntityAndLevelPlay,
				Value = _ihideworldentityandlevelplay
			};
		}

		// Token: 0x0603AA65 RID: 240229 RVA: 0x007E3923 File Offset: 0x007E1B23
		public IHideWorldMonsterAndMonsterTreasureT AsIHideWorldMonsterAndMonsterTreasure()
		{
			return this.As<IHideWorldMonsterAndMonsterTreasureT>();
		}

		// Token: 0x0603AA66 RID: 240230 RVA: 0x007E392B File Offset: 0x007E1B2B
		public static THideRangeConfigUnion FromIHideWorldMonsterAndMonsterTreasure(IHideWorldMonsterAndMonsterTreasureT _ihideworldmonsterandmonstertreasure)
		{
			return new THideRangeConfigUnion
			{
				Type = THideRangeConfig.IHideWorldMonsterAndMonsterTreasure,
				Value = _ihideworldmonsterandmonstertreasure
			};
		}

		// Token: 0x0603AA67 RID: 240231 RVA: 0x007E3940 File Offset: 0x007E1B40
		public IHideSpecifyEntityT AsIHideSpecifyEntity()
		{
			return this.As<IHideSpecifyEntityT>();
		}

		// Token: 0x0603AA68 RID: 240232 RVA: 0x007E3948 File Offset: 0x007E1B48
		public static THideRangeConfigUnion FromIHideSpecifyEntity(IHideSpecifyEntityT _ihidespecifyentity)
		{
			return new THideRangeConfigUnion
			{
				Type = THideRangeConfig.IHideSpecifyEntity,
				Value = _ihidespecifyentity
			};
		}

		// Token: 0x0603AA69 RID: 240233 RVA: 0x007E3960 File Offset: 0x007E1B60
		public static int Pack(FlatBufferBuilder builder, THideRangeConfigUnion _o)
		{
			switch (_o.Type)
			{
			case THideRangeConfig.IHideWorldEntityAndLevelPlay:
				return IHideWorldEntityAndLevelPlay.Pack(builder, _o.AsIHideWorldEntityAndLevelPlay()).Value;
			case THideRangeConfig.IHideWorldMonsterAndMonsterTreasure:
				return IHideWorldMonsterAndMonsterTreasure.Pack(builder, _o.AsIHideWorldMonsterAndMonsterTreasure()).Value;
			case THideRangeConfig.IHideSpecifyEntity:
				return IHideSpecifyEntity.Pack(builder, _o.AsIHideSpecifyEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
