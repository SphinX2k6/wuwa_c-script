using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200519D RID: 20893
	public class IQuestPreConditionDungeonBase_UnionUnion
	{
		// Token: 0x1700959E RID: 38302
		// (get) Token: 0x06020E0F RID: 134671 RVA: 0x0048C975 File Offset: 0x0048AB75
		// (set) Token: 0x06020E10 RID: 134672 RVA: 0x0048C97D File Offset: 0x0048AB7D
		public IQuestPreConditionDungeonBase_Union Type { get; set; }

		// Token: 0x1700959F RID: 38303
		// (get) Token: 0x06020E11 RID: 134673 RVA: 0x0048C986 File Offset: 0x0048AB86
		// (set) Token: 0x06020E12 RID: 134674 RVA: 0x0048C98E File Offset: 0x0048AB8E
		public object Value { get; set; }

		// Token: 0x06020E13 RID: 134675 RVA: 0x0048C997 File Offset: 0x0048AB97
		public IQuestPreConditionDungeonBase_UnionUnion()
		{
			this.Type = IQuestPreConditionDungeonBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020E14 RID: 134676 RVA: 0x0048C9AD File Offset: 0x0048ABAD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020E15 RID: 134677 RVA: 0x0048C9BF File Offset: 0x0048ABBF
		public IQuestPreConditionDungeonBaseT AsIQuestPreConditionDungeonBase()
		{
			return this.As<IQuestPreConditionDungeonBaseT>();
		}

		// Token: 0x06020E16 RID: 134678 RVA: 0x0048C9C7 File Offset: 0x0048ABC7
		public static IQuestPreConditionDungeonBase_UnionUnion FromIQuestPreConditionDungeonBase(IQuestPreConditionDungeonBaseT _iquestpreconditiondungeonbase)
		{
			return new IQuestPreConditionDungeonBase_UnionUnion
			{
				Type = IQuestPreConditionDungeonBase_Union.IQuestPreConditionDungeonBase,
				Value = _iquestpreconditiondungeonbase
			};
		}

		// Token: 0x06020E17 RID: 134679 RVA: 0x0048C9DC File Offset: 0x0048ABDC
		public IQuestPreConditionDungeonIdT AsIQuestPreConditionDungeonId()
		{
			return this.As<IQuestPreConditionDungeonIdT>();
		}

		// Token: 0x06020E18 RID: 134680 RVA: 0x0048C9E4 File Offset: 0x0048ABE4
		public static IQuestPreConditionDungeonBase_UnionUnion FromIQuestPreConditionDungeonId(IQuestPreConditionDungeonIdT _iquestpreconditiondungeonid)
		{
			return new IQuestPreConditionDungeonBase_UnionUnion
			{
				Type = IQuestPreConditionDungeonBase_Union.IQuestPreConditionDungeonId,
				Value = _iquestpreconditiondungeonid
			};
		}

		// Token: 0x06020E19 RID: 134681 RVA: 0x0048C9FC File Offset: 0x0048ABFC
		public static int Pack(FlatBufferBuilder builder, IQuestPreConditionDungeonBase_UnionUnion _o)
		{
			IQuestPreConditionDungeonBase_Union type = _o.Type;
			if (type == IQuestPreConditionDungeonBase_Union.IQuestPreConditionDungeonBase)
			{
				return IQuestPreConditionDungeonBase.Pack(builder, _o.AsIQuestPreConditionDungeonBase()).Value;
			}
			if (type != IQuestPreConditionDungeonBase_Union.IQuestPreConditionDungeonId)
			{
				return 0;
			}
			return IQuestPreConditionDungeonId.Pack(builder, _o.AsIQuestPreConditionDungeonId()).Value;
		}
	}
}
