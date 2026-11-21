using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007071 RID: 28785
	public class IItemGetUiConfigBase_UnionUnion
	{
		// Token: 0x1700D2CA RID: 53962
		// (get) Token: 0x06031E95 RID: 204437 RVA: 0x006C1549 File Offset: 0x006BF749
		// (set) Token: 0x06031E96 RID: 204438 RVA: 0x006C1551 File Offset: 0x006BF751
		public IItemGetUiConfigBase_Union Type { get; set; }

		// Token: 0x1700D2CB RID: 53963
		// (get) Token: 0x06031E97 RID: 204439 RVA: 0x006C155A File Offset: 0x006BF75A
		// (set) Token: 0x06031E98 RID: 204440 RVA: 0x006C1562 File Offset: 0x006BF762
		public object Value { get; set; }

		// Token: 0x06031E99 RID: 204441 RVA: 0x006C156B File Offset: 0x006BF76B
		public IItemGetUiConfigBase_UnionUnion()
		{
			this.Type = IItemGetUiConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031E9A RID: 204442 RVA: 0x006C1581 File Offset: 0x006BF781
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031E9B RID: 204443 RVA: 0x006C1593 File Offset: 0x006BF793
		public IItemGetUiConfigBaseT AsIItemGetUiConfigBase()
		{
			return this.As<IItemGetUiConfigBaseT>();
		}

		// Token: 0x06031E9C RID: 204444 RVA: 0x006C159B File Offset: 0x006BF79B
		public static IItemGetUiConfigBase_UnionUnion FromIItemGetUiConfigBase(IItemGetUiConfigBaseT _iitemgetuiconfigbase)
		{
			return new IItemGetUiConfigBase_UnionUnion
			{
				Type = IItemGetUiConfigBase_Union.IItemGetUiConfigBase,
				Value = _iitemgetuiconfigbase
			};
		}

		// Token: 0x06031E9D RID: 204445 RVA: 0x006C15B0 File Offset: 0x006BF7B0
		public IItemGetUiConfigSpecialQuestT AsIItemGetUiConfigSpecialQuest()
		{
			return this.As<IItemGetUiConfigSpecialQuestT>();
		}

		// Token: 0x06031E9E RID: 204446 RVA: 0x006C15B8 File Offset: 0x006BF7B8
		public static IItemGetUiConfigBase_UnionUnion FromIItemGetUiConfigSpecialQuest(IItemGetUiConfigSpecialQuestT _iitemgetuiconfigspecialquest)
		{
			return new IItemGetUiConfigBase_UnionUnion
			{
				Type = IItemGetUiConfigBase_Union.IItemGetUiConfigSpecialQuest,
				Value = _iitemgetuiconfigspecialquest
			};
		}

		// Token: 0x06031E9F RID: 204447 RVA: 0x006C15D0 File Offset: 0x006BF7D0
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
