using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D55 RID: 19797
	public class TRogueStateTypeUnion
	{
		// Token: 0x17008F53 RID: 36691
		// (get) Token: 0x0601F694 RID: 128660 RVA: 0x0046067A File Offset: 0x0045E87A
		// (set) Token: 0x0601F695 RID: 128661 RVA: 0x00460682 File Offset: 0x0045E882
		public TRogueStateType Type { get; set; }

		// Token: 0x17008F54 RID: 36692
		// (get) Token: 0x0601F696 RID: 128662 RVA: 0x0046068B File Offset: 0x0045E88B
		// (set) Token: 0x0601F697 RID: 128663 RVA: 0x00460693 File Offset: 0x0045E893
		public object Value { get; set; }

		// Token: 0x0601F698 RID: 128664 RVA: 0x0046069C File Offset: 0x0045E89C
		public TRogueStateTypeUnion()
		{
			this.Type = TRogueStateType.NONE;
			this.Value = null;
		}

		// Token: 0x0601F699 RID: 128665 RVA: 0x004606B2 File Offset: 0x0045E8B2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F69A RID: 128666 RVA: 0x004606C4 File Offset: 0x0045E8C4
		public ICheckRogueMiracleCreationT AsICheckRogueMiracleCreation()
		{
			return this.As<ICheckRogueMiracleCreationT>();
		}

		// Token: 0x0601F69B RID: 128667 RVA: 0x004606CC File Offset: 0x0045E8CC
		public static TRogueStateTypeUnion FromICheckRogueMiracleCreation(ICheckRogueMiracleCreationT _icheckroguemiraclecreation)
		{
			return new TRogueStateTypeUnion
			{
				Type = TRogueStateType.ICheckRogueMiracleCreation,
				Value = _icheckroguemiraclecreation
			};
		}

		// Token: 0x0601F69C RID: 128668 RVA: 0x004606E1 File Offset: 0x0045E8E1
		public ICheckRogueTalentT AsICheckRogueTalent()
		{
			return this.As<ICheckRogueTalentT>();
		}

		// Token: 0x0601F69D RID: 128669 RVA: 0x004606E9 File Offset: 0x0045E8E9
		public static TRogueStateTypeUnion FromICheckRogueTalent(ICheckRogueTalentT _icheckroguetalent)
		{
			return new TRogueStateTypeUnion
			{
				Type = TRogueStateType.ICheckRogueTalent,
				Value = _icheckroguetalent
			};
		}

		// Token: 0x0601F69E RID: 128670 RVA: 0x00460700 File Offset: 0x0045E900
		public static int Pack(FlatBufferBuilder builder, TRogueStateTypeUnion _o)
		{
			TRogueStateType type = _o.Type;
			if (type == TRogueStateType.ICheckRogueMiracleCreation)
			{
				return ICheckRogueMiracleCreation.Pack(builder, _o.AsICheckRogueMiracleCreation()).Value;
			}
			if (type != TRogueStateType.ICheckRogueTalent)
			{
				return 0;
			}
			return ICheckRogueTalent.Pack(builder, _o.AsICheckRogueTalent()).Value;
		}
	}
}
