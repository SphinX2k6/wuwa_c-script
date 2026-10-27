using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076ED RID: 30445
	public class THideRangeConfigUnion
	{
		// Token: 0x1700E637 RID: 58935
		// (get) Token: 0x06037590 RID: 226704 RVA: 0x0077F3B0 File Offset: 0x0077D5B0
		// (set) Token: 0x06037591 RID: 226705 RVA: 0x0077F3B8 File Offset: 0x0077D5B8
		public THideRangeConfig Type { get; set; }

		// Token: 0x1700E638 RID: 58936
		// (get) Token: 0x06037592 RID: 226706 RVA: 0x0077F3C1 File Offset: 0x0077D5C1
		// (set) Token: 0x06037593 RID: 226707 RVA: 0x0077F3C9 File Offset: 0x0077D5C9
		public object Value { get; set; }

		// Token: 0x06037594 RID: 226708 RVA: 0x0077F3D2 File Offset: 0x0077D5D2
		public THideRangeConfigUnion()
		{
			this.Type = THideRangeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06037595 RID: 226709 RVA: 0x0077F3E8 File Offset: 0x0077D5E8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037596 RID: 226710 RVA: 0x0077F3FA File Offset: 0x0077D5FA
		public IHideWorldEntityAndLevelPlayT AsIHideWorldEntityAndLevelPlay()
		{
			return this.As<IHideWorldEntityAndLevelPlayT>();
		}

		// Token: 0x06037597 RID: 226711 RVA: 0x0077F402 File Offset: 0x0077D602
		public static THideRangeConfigUnion FromIHideWorldEntityAndLevelPlay(IHideWorldEntityAndLevelPlayT _ihideworldentityandlevelplay)
		{
			return new THideRangeConfigUnion
			{
				Type = THideRangeConfig.IHideWorldEntityAndLevelPlay,
				Value = _ihideworldentityandlevelplay
			};
		}

		// Token: 0x06037598 RID: 226712 RVA: 0x0077F417 File Offset: 0x0077D617
		public IHideWorldMonsterAndMonsterTreasureT AsIHideWorldMonsterAndMonsterTreasure()
		{
			return this.As<IHideWorldMonsterAndMonsterTreasureT>();
		}

		// Token: 0x06037599 RID: 226713 RVA: 0x0077F41F File Offset: 0x0077D61F
		public static THideRangeConfigUnion FromIHideWorldMonsterAndMonsterTreasure(IHideWorldMonsterAndMonsterTreasureT _ihideworldmonsterandmonstertreasure)
		{
			return new THideRangeConfigUnion
			{
				Type = THideRangeConfig.IHideWorldMonsterAndMonsterTreasure,
				Value = _ihideworldmonsterandmonstertreasure
			};
		}

		// Token: 0x0603759A RID: 226714 RVA: 0x0077F434 File Offset: 0x0077D634
		public IHideSpecifyEntityT AsIHideSpecifyEntity()
		{
			return this.As<IHideSpecifyEntityT>();
		}

		// Token: 0x0603759B RID: 226715 RVA: 0x0077F43C File Offset: 0x0077D63C
		public static THideRangeConfigUnion FromIHideSpecifyEntity(IHideSpecifyEntityT _ihidespecifyentity)
		{
			return new THideRangeConfigUnion
			{
				Type = THideRangeConfig.IHideSpecifyEntity,
				Value = _ihidespecifyentity
			};
		}

		// Token: 0x0603759C RID: 226716 RVA: 0x0077F454 File Offset: 0x0077D654
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
