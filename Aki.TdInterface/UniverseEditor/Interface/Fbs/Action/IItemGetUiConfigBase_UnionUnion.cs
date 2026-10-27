using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C1 RID: 27073
	public class IItemGetUiConfigBase_UnionUnion
	{
		// Token: 0x1700C8CA RID: 51402
		// (get) Token: 0x0602F4D5 RID: 193749 RVA: 0x006711F1 File Offset: 0x0066F3F1
		// (set) Token: 0x0602F4D6 RID: 193750 RVA: 0x006711F9 File Offset: 0x0066F3F9
		public IItemGetUiConfigBase_Union Type { get; set; }

		// Token: 0x1700C8CB RID: 51403
		// (get) Token: 0x0602F4D7 RID: 193751 RVA: 0x00671202 File Offset: 0x0066F402
		// (set) Token: 0x0602F4D8 RID: 193752 RVA: 0x0067120A File Offset: 0x0066F40A
		public object Value { get; set; }

		// Token: 0x0602F4D9 RID: 193753 RVA: 0x00671213 File Offset: 0x0066F413
		public IItemGetUiConfigBase_UnionUnion()
		{
			this.Type = IItemGetUiConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F4DA RID: 193754 RVA: 0x00671229 File Offset: 0x0066F429
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F4DB RID: 193755 RVA: 0x0067123B File Offset: 0x0066F43B
		public IItemGetUiConfigBaseT AsIItemGetUiConfigBase()
		{
			return this.As<IItemGetUiConfigBaseT>();
		}

		// Token: 0x0602F4DC RID: 193756 RVA: 0x00671243 File Offset: 0x0066F443
		public static IItemGetUiConfigBase_UnionUnion FromIItemGetUiConfigBase(IItemGetUiConfigBaseT _iitemgetuiconfigbase)
		{
			return new IItemGetUiConfigBase_UnionUnion
			{
				Type = IItemGetUiConfigBase_Union.IItemGetUiConfigBase,
				Value = _iitemgetuiconfigbase
			};
		}

		// Token: 0x0602F4DD RID: 193757 RVA: 0x00671258 File Offset: 0x0066F458
		public IItemGetUiConfigSpecialQuestT AsIItemGetUiConfigSpecialQuest()
		{
			return this.As<IItemGetUiConfigSpecialQuestT>();
		}

		// Token: 0x0602F4DE RID: 193758 RVA: 0x00671260 File Offset: 0x0066F460
		public static IItemGetUiConfigBase_UnionUnion FromIItemGetUiConfigSpecialQuest(IItemGetUiConfigSpecialQuestT _iitemgetuiconfigspecialquest)
		{
			return new IItemGetUiConfigBase_UnionUnion
			{
				Type = IItemGetUiConfigBase_Union.IItemGetUiConfigSpecialQuest,
				Value = _iitemgetuiconfigspecialquest
			};
		}

		// Token: 0x0602F4DF RID: 193759 RVA: 0x00671278 File Offset: 0x0066F478
		public static int Pack(FlatBufferBuilder builder, IItemGetUiConfigBase_UnionUnion _o)
		{
			IItemGetUiConfigBase_Union type = _o.Type;
			if (type == IItemGetUiConfigBase_Union.IItemGetUiConfigBase)
			{
				return IItemGetUiConfigBase.Pack(builder, _o.AsIItemGetUiConfigBase()).Value;
			}
			if (type != IItemGetUiConfigBase_Union.IItemGetUiConfigSpecialQuest)
			{
				return 0;
			}
			return IItemGetUiConfigSpecialQuest.Pack(builder, _o.AsIItemGetUiConfigSpecialQuest()).Value;
		}
	}
}
