using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200471A RID: 18202
	public class TCheckTrapDefenseEventUnion
	{
		// Token: 0x17007F64 RID: 32612
		// (get) Token: 0x0601AC75 RID: 109685 RVA: 0x003CD9A6 File Offset: 0x003CBBA6
		// (set) Token: 0x0601AC76 RID: 109686 RVA: 0x003CD9AE File Offset: 0x003CBBAE
		public TCheckTrapDefenseEvent Type { get; set; }

		// Token: 0x17007F65 RID: 32613
		// (get) Token: 0x0601AC77 RID: 109687 RVA: 0x003CD9B7 File Offset: 0x003CBBB7
		// (set) Token: 0x0601AC78 RID: 109688 RVA: 0x003CD9BF File Offset: 0x003CBBBF
		public object Value { get; set; }

		// Token: 0x0601AC79 RID: 109689 RVA: 0x003CD9C8 File Offset: 0x003CBBC8
		public TCheckTrapDefenseEventUnion()
		{
			this.Type = TCheckTrapDefenseEvent.NONE;
			this.Value = null;
		}

		// Token: 0x0601AC7A RID: 109690 RVA: 0x003CD9DE File Offset: 0x003CBBDE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AC7B RID: 109691 RVA: 0x003CD9F0 File Offset: 0x003CBBF0
		public ICheckTrapDefenseBdBuffQualityUpT AsICheckTrapDefenseBdBuffQualityUp()
		{
			return this.As<ICheckTrapDefenseBdBuffQualityUpT>();
		}

		// Token: 0x0601AC7C RID: 109692 RVA: 0x003CD9F8 File Offset: 0x003CBBF8
		public static TCheckTrapDefenseEventUnion FromICheckTrapDefenseBdBuffQualityUp(ICheckTrapDefenseBdBuffQualityUpT _ichecktrapdefensebdbuffqualityup)
		{
			return new TCheckTrapDefenseEventUnion
			{
				Type = TCheckTrapDefenseEvent.ICheckTrapDefenseBdBuffQualityUp,
				Value = _ichecktrapdefensebdbuffqualityup
			};
		}

		// Token: 0x0601AC7D RID: 109693 RVA: 0x003CDA0D File Offset: 0x003CBC0D
		public ICheckTrapDefenseEventMonsterKilledT AsICheckTrapDefenseEventMonsterKilled()
		{
			return this.As<ICheckTrapDefenseEventMonsterKilledT>();
		}

		// Token: 0x0601AC7E RID: 109694 RVA: 0x003CDA15 File Offset: 0x003CBC15
		public static TCheckTrapDefenseEventUnion FromICheckTrapDefenseEventMonsterKilled(ICheckTrapDefenseEventMonsterKilledT _ichecktrapdefenseeventmonsterkilled)
		{
			return new TCheckTrapDefenseEventUnion
			{
				Type = TCheckTrapDefenseEvent.ICheckTrapDefenseEventMonsterKilled,
				Value = _ichecktrapdefenseeventmonsterkilled
			};
		}

		// Token: 0x0601AC7F RID: 109695 RVA: 0x003CDA2C File Offset: 0x003CBC2C
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
