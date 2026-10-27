using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C07 RID: 23559
	public class TElementalMatchConfigUnion
	{
		// Token: 0x1700B1E2 RID: 45538
		// (get) Token: 0x060286A1 RID: 165537 RVA: 0x005902E2 File Offset: 0x0058E4E2
		// (set) Token: 0x060286A2 RID: 165538 RVA: 0x005902EA File Offset: 0x0058E4EA
		public TElementalMatchConfig Type { get; set; }

		// Token: 0x1700B1E3 RID: 45539
		// (get) Token: 0x060286A3 RID: 165539 RVA: 0x005902F3 File Offset: 0x0058E4F3
		// (set) Token: 0x060286A4 RID: 165540 RVA: 0x005902FB File Offset: 0x0058E4FB
		public object Value { get; set; }

		// Token: 0x060286A5 RID: 165541 RVA: 0x00590304 File Offset: 0x0058E504
		public TElementalMatchConfigUnion()
		{
			this.Type = TElementalMatchConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060286A6 RID: 165542 RVA: 0x0059031A File Offset: 0x0058E51A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060286A7 RID: 165543 RVA: 0x0059032C File Offset: 0x0058E52C
		public IFireElementalMatchT AsIFireElementalMatch()
		{
			return this.As<IFireElementalMatchT>();
		}

		// Token: 0x060286A8 RID: 165544 RVA: 0x00590334 File Offset: 0x0058E534
		public static TElementalMatchConfigUnion FromIFireElementalMatch(IFireElementalMatchT _ifireelementalmatch)
		{
			return new TElementalMatchConfigUnion
			{
				Type = TElementalMatchConfig.IFireElementalMatch,
				Value = _ifireelementalmatch
			};
		}

		// Token: 0x060286A9 RID: 165545 RVA: 0x00590349 File Offset: 0x0058E549
		public IWaterElementalMatchT AsIWaterElementalMatch()
		{
			return this.As<IWaterElementalMatchT>();
		}

		// Token: 0x060286AA RID: 165546 RVA: 0x00590351 File Offset: 0x0058E551
		public static TElementalMatchConfigUnion FromIWaterElementalMatch(IWaterElementalMatchT _iwaterelementalmatch)
		{
			return new TElementalMatchConfigUnion
			{
				Type = TElementalMatchConfig.IWaterElementalMatch,
				Value = _iwaterelementalmatch
			};
		}

		// Token: 0x060286AB RID: 165547 RVA: 0x00590366 File Offset: 0x0058E566
		public IWoodElementalMatchT AsIWoodElementalMatch()
		{
			return this.As<IWoodElementalMatchT>();
		}

		// Token: 0x060286AC RID: 165548 RVA: 0x0059036E File Offset: 0x0058E56E
		public static TElementalMatchConfigUnion FromIWoodElementalMatch(IWoodElementalMatchT _iwoodelementalmatch)
		{
			return new TElementalMatchConfigUnion
			{
				Type = TElementalMatchConfig.IWoodElementalMatch,
				Value = _iwoodelementalmatch
			};
		}

		// Token: 0x060286AD RID: 165549 RVA: 0x00590384 File Offset: 0x0058E584
		public static int Pack(FlatBufferBuilder builder, TElementalMatchConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TElementalMatchConfig.IFireElementalMatch:
				return IFireElementalMatch.Pack(builder, _o.AsIFireElementalMatch()).Value;
			case TElementalMatchConfig.IWaterElementalMatch:
				return IWaterElementalMatch.Pack(builder, _o.AsIWaterElementalMatch()).Value;
			case TElementalMatchConfig.IWoodElementalMatch:
				return IWoodElementalMatch.Pack(builder, _o.AsIWoodElementalMatch()).Value;
			default:
				return 0;
			}
		}
	}
}
