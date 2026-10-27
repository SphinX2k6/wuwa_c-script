using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CA4 RID: 19620
	public class IQuestPreConditionDungeonBase_UnionUnion
	{
		// Token: 0x17008E70 RID: 36464
		// (get) Token: 0x0601F1ED RID: 127469 RVA: 0x00458E25 File Offset: 0x00457025
		// (set) Token: 0x0601F1EE RID: 127470 RVA: 0x00458E2D File Offset: 0x0045702D
		public IQuestPreConditionDungeonBase_Union Type { get; set; }

		// Token: 0x17008E71 RID: 36465
		// (get) Token: 0x0601F1EF RID: 127471 RVA: 0x00458E36 File Offset: 0x00457036
		// (set) Token: 0x0601F1F0 RID: 127472 RVA: 0x00458E3E File Offset: 0x0045703E
		public object Value { get; set; }

		// Token: 0x0601F1F1 RID: 127473 RVA: 0x00458E47 File Offset: 0x00457047
		public IQuestPreConditionDungeonBase_UnionUnion()
		{
			this.Type = IQuestPreConditionDungeonBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F1F2 RID: 127474 RVA: 0x00458E5D File Offset: 0x0045705D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F1F3 RID: 127475 RVA: 0x00458E6F File Offset: 0x0045706F
		public IQuestPreConditionDungeonBaseT AsIQuestPreConditionDungeonBase()
		{
			return this.As<IQuestPreConditionDungeonBaseT>();
		}

		// Token: 0x0601F1F4 RID: 127476 RVA: 0x00458E77 File Offset: 0x00457077
		public static IQuestPreConditionDungeonBase_UnionUnion FromIQuestPreConditionDungeonBase(IQuestPreConditionDungeonBaseT _iquestpreconditiondungeonbase)
		{
			return new IQuestPreConditionDungeonBase_UnionUnion
			{
				Type = IQuestPreConditionDungeonBase_Union.IQuestPreConditionDungeonBase,
				Value = _iquestpreconditiondungeonbase
			};
		}

		// Token: 0x0601F1F5 RID: 127477 RVA: 0x00458E8C File Offset: 0x0045708C
		public IQuestPreConditionDungeonIdT AsIQuestPreConditionDungeonId()
		{
			return this.As<IQuestPreConditionDungeonIdT>();
		}

		// Token: 0x0601F1F6 RID: 127478 RVA: 0x00458E94 File Offset: 0x00457094
		public static IQuestPreConditionDungeonBase_UnionUnion FromIQuestPreConditionDungeonId(IQuestPreConditionDungeonIdT _iquestpreconditiondungeonid)
		{
			return new IQuestPreConditionDungeonBase_UnionUnion
			{
				Type = IQuestPreConditionDungeonBase_Union.IQuestPreConditionDungeonId,
				Value = _iquestpreconditiondungeonid
			};
		}

		// Token: 0x0601F1F7 RID: 127479 RVA: 0x00458EAC File Offset: 0x004570AC
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
