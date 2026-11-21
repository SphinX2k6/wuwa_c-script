using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043BF RID: 17343
	public class IPhoneMessageProgressTypeBase_UnionUnion
	{
		// Token: 0x17007770 RID: 30576
		// (get) Token: 0x060189BF RID: 100799 RVA: 0x00382AC5 File Offset: 0x00380CC5
		// (set) Token: 0x060189C0 RID: 100800 RVA: 0x00382ACD File Offset: 0x00380CCD
		public IPhoneMessageProgressTypeBase_Union Type { get; set; }

		// Token: 0x17007771 RID: 30577
		// (get) Token: 0x060189C1 RID: 100801 RVA: 0x00382AD6 File Offset: 0x00380CD6
		// (set) Token: 0x060189C2 RID: 100802 RVA: 0x00382ADE File Offset: 0x00380CDE
		public object Value { get; set; }

		// Token: 0x060189C3 RID: 100803 RVA: 0x00382AE7 File Offset: 0x00380CE7
		public IPhoneMessageProgressTypeBase_UnionUnion()
		{
			this.Type = IPhoneMessageProgressTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060189C4 RID: 100804 RVA: 0x00382AFD File Offset: 0x00380CFD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060189C5 RID: 100805 RVA: 0x00382B0F File Offset: 0x00380D0F
		public IPhoneMessageProgressTypeBaseT AsIPhoneMessageProgressTypeBase()
		{
			return this.As<IPhoneMessageProgressTypeBaseT>();
		}

		// Token: 0x060189C6 RID: 100806 RVA: 0x00382B17 File Offset: 0x00380D17
		public static IPhoneMessageProgressTypeBase_UnionUnion FromIPhoneMessageProgressTypeBase(IPhoneMessageProgressTypeBaseT _iphonemessageprogresstypebase)
		{
			return new IPhoneMessageProgressTypeBase_UnionUnion
			{
				Type = IPhoneMessageProgressTypeBase_Union.IPhoneMessageProgressTypeBase,
				Value = _iphonemessageprogresstypebase
			};
		}

		// Token: 0x060189C7 RID: 100807 RVA: 0x00382B2C File Offset: 0x00380D2C
		public ICompleteMessageQuestConditionT AsICompleteMessageQuestCondition()
		{
			return this.As<ICompleteMessageQuestConditionT>();
		}

		// Token: 0x060189C8 RID: 100808 RVA: 0x00382B34 File Offset: 0x00380D34
		public static IPhoneMessageProgressTypeBase_UnionUnion FromICompleteMessageQuestCondition(ICompleteMessageQuestConditionT _icompletemessagequestcondition)
		{
			return new IPhoneMessageProgressTypeBase_UnionUnion
			{
				Type = IPhoneMessageProgressTypeBase_Union.ICompleteMessageQuestCondition,
				Value = _icompletemessagequestcondition
			};
		}

		// Token: 0x060189C9 RID: 100809 RVA: 0x00382B4C File Offset: 0x00380D4C
		public static int Pack(FlatBufferBuilder builder, IPhoneMessageProgressTypeBase_UnionUnion _o)
		{
			IPhoneMessageProgressTypeBase_Union type = _o.Type;
			if (type == IPhoneMessageProgressTypeBase_Union.IPhoneMessageProgressTypeBase)
			{
				return IPhoneMessageProgressTypeBase.Pack(builder, _o.AsIPhoneMessageProgressTypeBase()).Value;
			}
			if (type != IPhoneMessageProgressTypeBase_Union.ICompleteMessageQuestCondition)
			{
				return 0;
			}
			return ICompleteMessageQuestCondition.Pack(builder, _o.AsICompleteMessageQuestCondition()).Value;
		}
	}
}
