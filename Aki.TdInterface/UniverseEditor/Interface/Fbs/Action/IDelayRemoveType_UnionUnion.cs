using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006565 RID: 25957
	public class IDelayRemoveType_UnionUnion
	{
		// Token: 0x1700C0E2 RID: 49378
		// (get) Token: 0x0602D082 RID: 184450 RVA: 0x0062E059 File Offset: 0x0062C259
		// (set) Token: 0x0602D083 RID: 184451 RVA: 0x0062E061 File Offset: 0x0062C261
		public IDelayRemoveType_Union Type { get; set; }

		// Token: 0x1700C0E3 RID: 49379
		// (get) Token: 0x0602D084 RID: 184452 RVA: 0x0062E06A File Offset: 0x0062C26A
		// (set) Token: 0x0602D085 RID: 184453 RVA: 0x0062E072 File Offset: 0x0062C272
		public object Value { get; set; }

		// Token: 0x0602D086 RID: 184454 RVA: 0x0062E07B File Offset: 0x0062C27B
		public IDelayRemoveType_UnionUnion()
		{
			this.Type = IDelayRemoveType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D087 RID: 184455 RVA: 0x0062E091 File Offset: 0x0062C291
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D088 RID: 184456 RVA: 0x0062E0A3 File Offset: 0x0062C2A3
		public IDelayRemoveTypeT AsIDelayRemoveType()
		{
			return this.As<IDelayRemoveTypeT>();
		}

		// Token: 0x0602D089 RID: 184457 RVA: 0x0062E0AB File Offset: 0x0062C2AB
		public static IDelayRemoveType_UnionUnion FromIDelayRemoveType(IDelayRemoveTypeT _idelayremovetype)
		{
			return new IDelayRemoveType_UnionUnion
			{
				Type = IDelayRemoveType_Union.IDelayRemoveType,
				Value = _idelayremovetype
			};
		}

		// Token: 0x0602D08A RID: 184458 RVA: 0x0062E0C0 File Offset: 0x0062C2C0
		public IDelayRemoveAfterSkillFinishT AsIDelayRemoveAfterSkillFinish()
		{
			return this.As<IDelayRemoveAfterSkillFinishT>();
		}

		// Token: 0x0602D08B RID: 184459 RVA: 0x0062E0C8 File Offset: 0x0062C2C8
		public static IDelayRemoveType_UnionUnion FromIDelayRemoveAfterSkillFinish(IDelayRemoveAfterSkillFinishT _idelayremoveafterskillfinish)
		{
			return new IDelayRemoveType_UnionUnion
			{
				Type = IDelayRemoveType_Union.IDelayRemoveAfterSkillFinish,
				Value = _idelayremoveafterskillfinish
			};
		}

		// Token: 0x0602D08C RID: 184460 RVA: 0x0062E0E0 File Offset: 0x0062C2E0
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
