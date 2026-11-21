using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD6 RID: 27606
	public class IDelayRemoveType_UnionUnion
	{
		// Token: 0x1700CA7D RID: 51837
		// (get) Token: 0x0602F83E RID: 194622 RVA: 0x0067A81D File Offset: 0x00678A1D
		// (set) Token: 0x0602F83F RID: 194623 RVA: 0x0067A825 File Offset: 0x00678A25
		public IDelayRemoveType_Union Type { get; set; }

		// Token: 0x1700CA7E RID: 51838
		// (get) Token: 0x0602F840 RID: 194624 RVA: 0x0067A82E File Offset: 0x00678A2E
		// (set) Token: 0x0602F841 RID: 194625 RVA: 0x0067A836 File Offset: 0x00678A36
		public object Value { get; set; }

		// Token: 0x0602F842 RID: 194626 RVA: 0x0067A83F File Offset: 0x00678A3F
		public IDelayRemoveType_UnionUnion()
		{
			this.Type = IDelayRemoveType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F843 RID: 194627 RVA: 0x0067A855 File Offset: 0x00678A55
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F844 RID: 194628 RVA: 0x0067A867 File Offset: 0x00678A67
		public IDelayRemoveTypeT AsIDelayRemoveType()
		{
			return this.As<IDelayRemoveTypeT>();
		}

		// Token: 0x0602F845 RID: 194629 RVA: 0x0067A86F File Offset: 0x00678A6F
		public static IDelayRemoveType_UnionUnion FromIDelayRemoveType(IDelayRemoveTypeT _idelayremovetype)
		{
			return new IDelayRemoveType_UnionUnion
			{
				Type = IDelayRemoveType_Union.IDelayRemoveType,
				Value = _idelayremovetype
			};
		}

		// Token: 0x0602F846 RID: 194630 RVA: 0x0067A884 File Offset: 0x00678A84
		public IDelayRemoveAfterSkillFinishT AsIDelayRemoveAfterSkillFinish()
		{
			return this.As<IDelayRemoveAfterSkillFinishT>();
		}

		// Token: 0x0602F847 RID: 194631 RVA: 0x0067A88C File Offset: 0x00678A8C
		public static IDelayRemoveType_UnionUnion FromIDelayRemoveAfterSkillFinish(IDelayRemoveAfterSkillFinishT _idelayremoveafterskillfinish)
		{
			return new IDelayRemoveType_UnionUnion
			{
				Type = IDelayRemoveType_Union.IDelayRemoveAfterSkillFinish,
				Value = _idelayremoveafterskillfinish
			};
		}

		// Token: 0x0602F848 RID: 194632 RVA: 0x0067A8A4 File Offset: 0x00678AA4
		public static int Pack(FlatBufferBuilder builder, IDelayRemoveType_UnionUnion _o)
		{
			IDelayRemoveType_Union type = _o.Type;
			if (type == IDelayRemoveType_Union.IDelayRemoveType)
			{
				return IDelayRemoveType.Pack(builder, _o.AsIDelayRemoveType()).Value;
			}
			if (type != IDelayRemoveType_Union.IDelayRemoveAfterSkillFinish)
			{
				return 0;
			}
			return IDelayRemoveAfterSkillFinish.Pack(builder, _o.AsIDelayRemoveAfterSkillFinish()).Value;
		}
	}
}
