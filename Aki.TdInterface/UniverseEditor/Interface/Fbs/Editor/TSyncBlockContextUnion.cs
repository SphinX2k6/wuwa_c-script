using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D56 RID: 19798
	public class TSyncBlockContextUnion
	{
		// Token: 0x17008DBC RID: 36284
		// (get) Token: 0x0601EAFB RID: 125691 RVA: 0x0044B0A0 File Offset: 0x004492A0
		// (set) Token: 0x0601EAFC RID: 125692 RVA: 0x0044B0A8 File Offset: 0x004492A8
		public TSyncBlockContext Type { get; set; }

		// Token: 0x17008DBD RID: 36285
		// (get) Token: 0x0601EAFD RID: 125693 RVA: 0x0044B0B1 File Offset: 0x004492B1
		// (set) Token: 0x0601EAFE RID: 125694 RVA: 0x0044B0B9 File Offset: 0x004492B9
		public object Value { get; set; }

		// Token: 0x0601EAFF RID: 125695 RVA: 0x0044B0C2 File Offset: 0x004492C2
		public TSyncBlockContextUnion()
		{
			this.Type = TSyncBlockContext.NONE;
			this.Value = null;
		}

		// Token: 0x0601EB00 RID: 125696 RVA: 0x0044B0D8 File Offset: 0x004492D8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EB01 RID: 125697 RVA: 0x0044B0EA File Offset: 0x004492EA
		public ILevelPlaySyncBlockContextT AsILevelPlaySyncBlockContext()
		{
			return this.As<ILevelPlaySyncBlockContextT>();
		}

		// Token: 0x0601EB02 RID: 125698 RVA: 0x0044B0F2 File Offset: 0x004492F2
		public static TSyncBlockContextUnion FromILevelPlaySyncBlockContext(ILevelPlaySyncBlockContextT _ilevelplaysyncblockcontext)
		{
			return new TSyncBlockContextUnion
			{
				Type = TSyncBlockContext.ILevelPlaySyncBlockContext,
				Value = _ilevelplaysyncblockcontext
			};
		}

		// Token: 0x0601EB03 RID: 125699 RVA: 0x0044B107 File Offset: 0x00449307
		public IQuestSyncBlockContextT AsIQuestSyncBlockContext()
		{
			return this.As<IQuestSyncBlockContextT>();
		}

		// Token: 0x0601EB04 RID: 125700 RVA: 0x0044B10F File Offset: 0x0044930F
		public static TSyncBlockContextUnion FromIQuestSyncBlockContext(IQuestSyncBlockContextT _iquestsyncblockcontext)
		{
			return new TSyncBlockContextUnion
			{
				Type = TSyncBlockContext.IQuestSyncBlockContext,
				Value = _iquestsyncblockcontext
			};
		}

		// Token: 0x0601EB05 RID: 125701 RVA: 0x0044B124 File Offset: 0x00449324
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
