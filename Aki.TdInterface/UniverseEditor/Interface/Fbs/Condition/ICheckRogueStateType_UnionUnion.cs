using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B1B RID: 19227
	public class ICheckRogueStateType_UnionUnion
	{
		// Token: 0x17008B76 RID: 35702
		// (get) Token: 0x0601E3D8 RID: 123864 RVA: 0x0043D419 File Offset: 0x0043B619
		// (set) Token: 0x0601E3D9 RID: 123865 RVA: 0x0043D421 File Offset: 0x0043B621
		public ICheckRogueStateType_Union Type { get; set; }

		// Token: 0x17008B77 RID: 35703
		// (get) Token: 0x0601E3DA RID: 123866 RVA: 0x0043D42A File Offset: 0x0043B62A
		// (set) Token: 0x0601E3DB RID: 123867 RVA: 0x0043D432 File Offset: 0x0043B632
		public object Value { get; set; }

		// Token: 0x0601E3DC RID: 123868 RVA: 0x0043D43B File Offset: 0x0043B63B
		public ICheckRogueStateType_UnionUnion()
		{
			this.Type = ICheckRogueStateType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601E3DD RID: 123869 RVA: 0x0043D451 File Offset: 0x0043B651
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E3DE RID: 123870 RVA: 0x0043D463 File Offset: 0x0043B663
		public ICheckRogueStateTypeT AsICheckRogueStateType()
		{
			return this.As<ICheckRogueStateTypeT>();
		}

		// Token: 0x0601E3DF RID: 123871 RVA: 0x0043D46B File Offset: 0x0043B66B
		public static ICheckRogueStateType_UnionUnion FromICheckRogueStateType(ICheckRogueStateTypeT _icheckroguestatetype)
		{
			return new ICheckRogueStateType_UnionUnion
			{
				Type = ICheckRogueStateType_Union.ICheckRogueStateType,
				Value = _icheckroguestatetype
			};
		}

		// Token: 0x0601E3E0 RID: 123872 RVA: 0x0043D480 File Offset: 0x0043B680
		public ICheckRogueTalentT AsICheckRogueTalent()
		{
			return this.As<ICheckRogueTalentT>();
		}

		// Token: 0x0601E3E1 RID: 123873 RVA: 0x0043D488 File Offset: 0x0043B688
		public static ICheckRogueStateType_UnionUnion FromICheckRogueTalent(ICheckRogueTalentT _icheckroguetalent)
		{
			return new ICheckRogueStateType_UnionUnion
			{
				Type = ICheckRogueStateType_Union.ICheckRogueTalent,
				Value = _icheckroguetalent
			};
		}

		// Token: 0x0601E3E2 RID: 123874 RVA: 0x0043D49D File Offset: 0x0043B69D
		public ICheckRogueMiracleCreationT AsICheckRogueMiracleCreation()
		{
			return this.As<ICheckRogueMiracleCreationT>();
		}

		// Token: 0x0601E3E3 RID: 123875 RVA: 0x0043D4A5 File Offset: 0x0043B6A5
		public static ICheckRogueStateType_UnionUnion FromICheckRogueMiracleCreation(ICheckRogueMiracleCreationT _icheckroguemiraclecreation)
		{
			return new ICheckRogueStateType_UnionUnion
			{
				Type = ICheckRogueStateType_Union.ICheckRogueMiracleCreation,
				Value = _icheckroguemiraclecreation
			};
		}

		// Token: 0x0601E3E4 RID: 123876 RVA: 0x0043D4BC File Offset: 0x0043B6BC
		public static int Pack(FlatBufferBuilder builder, ICheckRogueStateType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckRogueStateType_Union.ICheckRogueStateType:
				return ICheckRogueStateType.Pack(builder, _o.AsICheckRogueStateType()).Value;
			case ICheckRogueStateType_Union.ICheckRogueTalent:
				return ICheckRogueTalent.Pack(builder, _o.AsICheckRogueTalent()).Value;
			case ICheckRogueStateType_Union.ICheckRogueMiracleCreation:
				return ICheckRogueMiracleCreation.Pack(builder, _o.AsICheckRogueMiracleCreation()).Value;
			default:
				return 0;
			}
		}
	}
}
