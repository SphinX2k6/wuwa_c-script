using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005251 RID: 21073
	public class TRogueStateTypeUnion
	{
		// Token: 0x1700968C RID: 38540
		// (get) Token: 0x060212DD RID: 135901 RVA: 0x0049464E File Offset: 0x0049284E
		// (set) Token: 0x060212DE RID: 135902 RVA: 0x00494656 File Offset: 0x00492856
		public TRogueStateType Type { get; set; }

		// Token: 0x1700968D RID: 38541
		// (get) Token: 0x060212DF RID: 135903 RVA: 0x0049465F File Offset: 0x0049285F
		// (set) Token: 0x060212E0 RID: 135904 RVA: 0x00494667 File Offset: 0x00492867
		public object Value { get; set; }

		// Token: 0x060212E1 RID: 135905 RVA: 0x00494670 File Offset: 0x00492870
		public TRogueStateTypeUnion()
		{
			this.Type = TRogueStateType.NONE;
			this.Value = null;
		}

		// Token: 0x060212E2 RID: 135906 RVA: 0x00494686 File Offset: 0x00492886
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060212E3 RID: 135907 RVA: 0x00494698 File Offset: 0x00492898
		public ICheckRogueMiracleCreationT AsICheckRogueMiracleCreation()
		{
			return this.As<ICheckRogueMiracleCreationT>();
		}

		// Token: 0x060212E4 RID: 135908 RVA: 0x004946A0 File Offset: 0x004928A0
		public static TRogueStateTypeUnion FromICheckRogueMiracleCreation(ICheckRogueMiracleCreationT _icheckroguemiraclecreation)
		{
			return new TRogueStateTypeUnion
			{
				Type = TRogueStateType.ICheckRogueMiracleCreation,
				Value = _icheckroguemiraclecreation
			};
		}

		// Token: 0x060212E5 RID: 135909 RVA: 0x004946B5 File Offset: 0x004928B5
		public ICheckRogueTalentT AsICheckRogueTalent()
		{
			return this.As<ICheckRogueTalentT>();
		}

		// Token: 0x060212E6 RID: 135910 RVA: 0x004946BD File Offset: 0x004928BD
		public static TRogueStateTypeUnion FromICheckRogueTalent(ICheckRogueTalentT _icheckroguetalent)
		{
			return new TRogueStateTypeUnion
			{
				Type = TRogueStateType.ICheckRogueTalent,
				Value = _icheckroguetalent
			};
		}

		// Token: 0x060212E7 RID: 135911 RVA: 0x004946D4 File Offset: 0x004928D4
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
