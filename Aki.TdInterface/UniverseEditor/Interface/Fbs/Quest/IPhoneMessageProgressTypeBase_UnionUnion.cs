using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F7E RID: 16254
	public class IPhoneMessageProgressTypeBase_UnionUnion
	{
		// Token: 0x17007172 RID: 29042
		// (get) Token: 0x06017330 RID: 95024 RVA: 0x00358EAD File Offset: 0x003570AD
		// (set) Token: 0x06017331 RID: 95025 RVA: 0x00358EB5 File Offset: 0x003570B5
		public IPhoneMessageProgressTypeBase_Union Type { get; set; }

		// Token: 0x17007173 RID: 29043
		// (get) Token: 0x06017332 RID: 95026 RVA: 0x00358EBE File Offset: 0x003570BE
		// (set) Token: 0x06017333 RID: 95027 RVA: 0x00358EC6 File Offset: 0x003570C6
		public object Value { get; set; }

		// Token: 0x06017334 RID: 95028 RVA: 0x00358ECF File Offset: 0x003570CF
		public IPhoneMessageProgressTypeBase_UnionUnion()
		{
			this.Type = IPhoneMessageProgressTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017335 RID: 95029 RVA: 0x00358EE5 File Offset: 0x003570E5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017336 RID: 95030 RVA: 0x00358EF7 File Offset: 0x003570F7
		public IPhoneMessageProgressTypeBaseT AsIPhoneMessageProgressTypeBase()
		{
			return this.As<IPhoneMessageProgressTypeBaseT>();
		}

		// Token: 0x06017337 RID: 95031 RVA: 0x00358EFF File Offset: 0x003570FF
		public static IPhoneMessageProgressTypeBase_UnionUnion FromIPhoneMessageProgressTypeBase(IPhoneMessageProgressTypeBaseT _iphonemessageprogresstypebase)
		{
			return new IPhoneMessageProgressTypeBase_UnionUnion
			{
				Type = IPhoneMessageProgressTypeBase_Union.IPhoneMessageProgressTypeBase,
				Value = _iphonemessageprogresstypebase
			};
		}

		// Token: 0x06017338 RID: 95032 RVA: 0x00358F14 File Offset: 0x00357114
		public ICompleteMessageQuestConditionT AsICompleteMessageQuestCondition()
		{
			return this.As<ICompleteMessageQuestConditionT>();
		}

		// Token: 0x06017339 RID: 95033 RVA: 0x00358F1C File Offset: 0x0035711C
		public static IPhoneMessageProgressTypeBase_UnionUnion FromICompleteMessageQuestCondition(ICompleteMessageQuestConditionT _icompletemessagequestcondition)
		{
			return new IPhoneMessageProgressTypeBase_UnionUnion
			{
				Type = IPhoneMessageProgressTypeBase_Union.ICompleteMessageQuestCondition,
				Value = _icompletemessagequestcondition
			};
		}

		// Token: 0x0601733A RID: 95034 RVA: 0x00358F34 File Offset: 0x00357134
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
