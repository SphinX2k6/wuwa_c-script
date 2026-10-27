using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076EA RID: 30442
	public class THideGroupConfigUnion
	{
		// Token: 0x1700E635 RID: 58933
		// (get) Token: 0x0603757E RID: 226686 RVA: 0x0077F1E4 File Offset: 0x0077D3E4
		// (set) Token: 0x0603757F RID: 226687 RVA: 0x0077F1EC File Offset: 0x0077D3EC
		public THideGroupConfig Type { get; set; }

		// Token: 0x1700E636 RID: 58934
		// (get) Token: 0x06037580 RID: 226688 RVA: 0x0077F1F5 File Offset: 0x0077D3F5
		// (set) Token: 0x06037581 RID: 226689 RVA: 0x0077F1FD File Offset: 0x0077D3FD
		public object Value { get; set; }

		// Token: 0x06037582 RID: 226690 RVA: 0x0077F206 File Offset: 0x0077D406
		public THideGroupConfigUnion()
		{
			this.Type = THideGroupConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06037583 RID: 226691 RVA: 0x0077F21C File Offset: 0x0077D41C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037584 RID: 226692 RVA: 0x0077F22E File Offset: 0x0077D42E
		public IHideSpecifyDataLayersT AsIHideSpecifyDataLayers()
		{
			return this.As<IHideSpecifyDataLayersT>();
		}

		// Token: 0x06037585 RID: 226693 RVA: 0x0077F236 File Offset: 0x0077D436
		public static THideGroupConfigUnion FromIHideSpecifyDataLayers(IHideSpecifyDataLayersT _ihidespecifydatalayers)
		{
			return new THideGroupConfigUnion
			{
				Type = THideGroupConfig.IHideSpecifyDataLayers,
				Value = _ihidespecifydatalayers
			};
		}

		// Token: 0x06037586 RID: 226694 RVA: 0x0077F24B File Offset: 0x0077D44B
		public IHideSpecifyEntityGroupT AsIHideSpecifyEntityGroup()
		{
			return this.As<IHideSpecifyEntityGroupT>();
		}

		// Token: 0x06037587 RID: 226695 RVA: 0x0077F253 File Offset: 0x0077D453
		public static THideGroupConfigUnion FromIHideSpecifyEntityGroup(IHideSpecifyEntityGroupT _ihidespecifyentitygroup)
		{
			return new THideGroupConfigUnion
			{
				Type = THideGroupConfig.IHideSpecifyEntityGroup,
				Value = _ihidespecifyentitygroup
			};
		}

		// Token: 0x06037588 RID: 226696 RVA: 0x0077F268 File Offset: 0x0077D468
		public IHideSpecifyLevelPlayGroupT AsIHideSpecifyLevelPlayGroup()
		{
			return this.As<IHideSpecifyLevelPlayGroupT>();
		}

		// Token: 0x06037589 RID: 226697 RVA: 0x0077F270 File Offset: 0x0077D470
		public static THideGroupConfigUnion FromIHideSpecifyLevelPlayGroup(IHideSpecifyLevelPlayGroupT _ihidespecifylevelplaygroup)
		{
			return new THideGroupConfigUnion
			{
				Type = THideGroupConfig.IHideSpecifyLevelPlayGroup,
				Value = _ihidespecifylevelplaygroup
			};
		}

		// Token: 0x0603758A RID: 226698 RVA: 0x0077F285 File Offset: 0x0077D485
		public IHideWorldEntityAndLevelPlayGroupT AsIHideWorldEntityAndLevelPlayGroup()
		{
			return this.As<IHideWorldEntityAndLevelPlayGroupT>();
		}

		// Token: 0x0603758B RID: 226699 RVA: 0x0077F28D File Offset: 0x0077D48D
		public static THideGroupConfigUnion FromIHideWorldEntityAndLevelPlayGroup(IHideWorldEntityAndLevelPlayGroupT _ihideworldentityandlevelplaygroup)
		{
			return new THideGroupConfigUnion
			{
				Type = THideGroupConfig.IHideWorldEntityAndLevelPlayGroup,
				Value = _ihideworldentityandlevelplaygroup
			};
		}

		// Token: 0x0603758C RID: 226700 RVA: 0x0077F2A2 File Offset: 0x0077D4A2
		public IHideWorldMonsterAndMonsterTreasureGroupT AsIHideWorldMonsterAndMonsterTreasureGroup()
		{
			return this.As<IHideWorldMonsterAndMonsterTreasureGroupT>();
		}

		// Token: 0x0603758D RID: 226701 RVA: 0x0077F2AA File Offset: 0x0077D4AA
		public static THideGroupConfigUnion FromIHideWorldMonsterAndMonsterTreasureGroup(IHideWorldMonsterAndMonsterTreasureGroupT _ihideworldmonsterandmonstertreasuregroup)
		{
			return new THideGroupConfigUnion
			{
				Type = THideGroupConfig.IHideWorldMonsterAndMonsterTreasureGroup,
				Value = _ihideworldmonsterandmonstertreasuregroup
			};
		}

		// Token: 0x0603758E RID: 226702 RVA: 0x0077F2C0 File Offset: 0x0077D4C0
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
