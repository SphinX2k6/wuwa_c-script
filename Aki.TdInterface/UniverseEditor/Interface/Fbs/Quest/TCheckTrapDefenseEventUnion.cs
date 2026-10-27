using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042BE RID: 17086
	public class TCheckTrapDefenseEventUnion
	{
		// Token: 0x17007933 RID: 31027
		// (get) Token: 0x06019509 RID: 103689 RVA: 0x003A22CE File Offset: 0x003A04CE
		// (set) Token: 0x0601950A RID: 103690 RVA: 0x003A22D6 File Offset: 0x003A04D6
		public TCheckTrapDefenseEvent Type { get; set; }

		// Token: 0x17007934 RID: 31028
		// (get) Token: 0x0601950B RID: 103691 RVA: 0x003A22DF File Offset: 0x003A04DF
		// (set) Token: 0x0601950C RID: 103692 RVA: 0x003A22E7 File Offset: 0x003A04E7
		public object Value { get; set; }

		// Token: 0x0601950D RID: 103693 RVA: 0x003A22F0 File Offset: 0x003A04F0
		public TCheckTrapDefenseEventUnion()
		{
			this.Type = TCheckTrapDefenseEvent.NONE;
			this.Value = null;
		}

		// Token: 0x0601950E RID: 103694 RVA: 0x003A2306 File Offset: 0x003A0506
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601950F RID: 103695 RVA: 0x003A2318 File Offset: 0x003A0518
		public ICheckTrapDefenseBdBuffQualityUpT AsICheckTrapDefenseBdBuffQualityUp()
		{
			return this.As<ICheckTrapDefenseBdBuffQualityUpT>();
		}

		// Token: 0x06019510 RID: 103696 RVA: 0x003A2320 File Offset: 0x003A0520
		public static TCheckTrapDefenseEventUnion FromICheckTrapDefenseBdBuffQualityUp(ICheckTrapDefenseBdBuffQualityUpT _ichecktrapdefensebdbuffqualityup)
		{
			return new TCheckTrapDefenseEventUnion
			{
				Type = TCheckTrapDefenseEvent.ICheckTrapDefenseBdBuffQualityUp,
				Value = _ichecktrapdefensebdbuffqualityup
			};
		}

		// Token: 0x06019511 RID: 103697 RVA: 0x003A2335 File Offset: 0x003A0535
		public ICheckTrapDefenseEventMonsterKilledT AsICheckTrapDefenseEventMonsterKilled()
		{
			return this.As<ICheckTrapDefenseEventMonsterKilledT>();
		}

		// Token: 0x06019512 RID: 103698 RVA: 0x003A233D File Offset: 0x003A053D
		public static TCheckTrapDefenseEventUnion FromICheckTrapDefenseEventMonsterKilled(ICheckTrapDefenseEventMonsterKilledT _ichecktrapdefenseeventmonsterkilled)
		{
			return new TCheckTrapDefenseEventUnion
			{
				Type = TCheckTrapDefenseEvent.ICheckTrapDefenseEventMonsterKilled,
				Value = _ichecktrapdefenseeventmonsterkilled
			};
		}

		// Token: 0x06019513 RID: 103699 RVA: 0x003A2354 File Offset: 0x003A0554
		public static int Pack(FlatBufferBuilder builder, TCheckTrapDefenseEventUnion _o)
		{
			TCheckTrapDefenseEvent type = _o.Type;
			if (type == TCheckTrapDefenseEvent.ICheckTrapDefenseBdBuffQualityUp)
			{
				return ICheckTrapDefenseBdBuffQualityUp.Pack(builder, _o.AsICheckTrapDefenseBdBuffQualityUp()).Value;
			}
			if (type != TCheckTrapDefenseEvent.ICheckTrapDefenseEventMonsterKilled)
			{
				return 0;
			}
			return ICheckTrapDefenseEventMonsterKilled.Pack(builder, _o.AsICheckTrapDefenseEventMonsterKilled()).Value;
		}
	}
}
