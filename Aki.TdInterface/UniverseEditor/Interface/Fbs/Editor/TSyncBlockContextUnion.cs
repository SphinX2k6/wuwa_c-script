using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048F1 RID: 18673
	public class TSyncBlockContextUnion
	{
		// Token: 0x17008774 RID: 34676
		// (get) Token: 0x0601D30E RID: 119566 RVA: 0x0041E904 File Offset: 0x0041CB04
		// (set) Token: 0x0601D30F RID: 119567 RVA: 0x0041E90C File Offset: 0x0041CB0C
		public TSyncBlockContext Type { get; set; }

		// Token: 0x17008775 RID: 34677
		// (get) Token: 0x0601D310 RID: 119568 RVA: 0x0041E915 File Offset: 0x0041CB15
		// (set) Token: 0x0601D311 RID: 119569 RVA: 0x0041E91D File Offset: 0x0041CB1D
		public object Value { get; set; }

		// Token: 0x0601D312 RID: 119570 RVA: 0x0041E926 File Offset: 0x0041CB26
		public TSyncBlockContextUnion()
		{
			this.Type = TSyncBlockContext.NONE;
			this.Value = null;
		}

		// Token: 0x0601D313 RID: 119571 RVA: 0x0041E93C File Offset: 0x0041CB3C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D314 RID: 119572 RVA: 0x0041E94E File Offset: 0x0041CB4E
		public ILevelPlaySyncBlockContextT AsILevelPlaySyncBlockContext()
		{
			return this.As<ILevelPlaySyncBlockContextT>();
		}

		// Token: 0x0601D315 RID: 119573 RVA: 0x0041E956 File Offset: 0x0041CB56
		public static TSyncBlockContextUnion FromILevelPlaySyncBlockContext(ILevelPlaySyncBlockContextT _ilevelplaysyncblockcontext)
		{
			return new TSyncBlockContextUnion
			{
				Type = TSyncBlockContext.ILevelPlaySyncBlockContext,
				Value = _ilevelplaysyncblockcontext
			};
		}

		// Token: 0x0601D316 RID: 119574 RVA: 0x0041E96B File Offset: 0x0041CB6B
		public IQuestSyncBlockContextT AsIQuestSyncBlockContext()
		{
			return this.As<IQuestSyncBlockContextT>();
		}

		// Token: 0x0601D317 RID: 119575 RVA: 0x0041E973 File Offset: 0x0041CB73
		public static TSyncBlockContextUnion FromIQuestSyncBlockContext(IQuestSyncBlockContextT _iquestsyncblockcontext)
		{
			return new TSyncBlockContextUnion
			{
				Type = TSyncBlockContext.IQuestSyncBlockContext,
				Value = _iquestsyncblockcontext
			};
		}

		// Token: 0x0601D318 RID: 119576 RVA: 0x0041E988 File Offset: 0x0041CB88
		public static int Pack(FlatBufferBuilder builder, TSyncBlockContextUnion _o)
		{
			TSyncBlockContext type = _o.Type;
			if (type == TSyncBlockContext.ILevelPlaySyncBlockContext)
			{
				return ILevelPlaySyncBlockContext.Pack(builder, _o.AsILevelPlaySyncBlockContext()).Value;
			}
			if (type != TSyncBlockContext.IQuestSyncBlockContext)
			{
				return 0;
			}
			return IQuestSyncBlockContext.Pack(builder, _o.AsIQuestSyncBlockContext()).Value;
		}
	}
}
