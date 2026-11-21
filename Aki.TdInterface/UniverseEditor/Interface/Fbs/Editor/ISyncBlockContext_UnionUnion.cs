using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D13 RID: 19731
	public class ISyncBlockContext_UnionUnion
	{
		// Token: 0x17008D2F RID: 36143
		// (get) Token: 0x0601E89F RID: 125087 RVA: 0x004467B4 File Offset: 0x004449B4
		// (set) Token: 0x0601E8A0 RID: 125088 RVA: 0x004467BC File Offset: 0x004449BC
		public ISyncBlockContext_Union Type { get; set; }

		// Token: 0x17008D30 RID: 36144
		// (get) Token: 0x0601E8A1 RID: 125089 RVA: 0x004467C5 File Offset: 0x004449C5
		// (set) Token: 0x0601E8A2 RID: 125090 RVA: 0x004467CD File Offset: 0x004449CD
		public object Value { get; set; }

		// Token: 0x0601E8A3 RID: 125091 RVA: 0x004467D6 File Offset: 0x004449D6
		public ISyncBlockContext_UnionUnion()
		{
			this.Type = ISyncBlockContext_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601E8A4 RID: 125092 RVA: 0x004467EC File Offset: 0x004449EC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E8A5 RID: 125093 RVA: 0x004467FE File Offset: 0x004449FE
		public ISyncBlockContextT AsISyncBlockContext()
		{
			return this.As<ISyncBlockContextT>();
		}

		// Token: 0x0601E8A6 RID: 125094 RVA: 0x00446806 File Offset: 0x00444A06
		public static ISyncBlockContext_UnionUnion FromISyncBlockContext(ISyncBlockContextT _isyncblockcontext)
		{
			return new ISyncBlockContext_UnionUnion
			{
				Type = ISyncBlockContext_Union.ISyncBlockContext,
				Value = _isyncblockcontext
			};
		}

		// Token: 0x0601E8A7 RID: 125095 RVA: 0x0044681B File Offset: 0x00444A1B
		public ILevelPlaySyncBlockContextT AsILevelPlaySyncBlockContext()
		{
			return this.As<ILevelPlaySyncBlockContextT>();
		}

		// Token: 0x0601E8A8 RID: 125096 RVA: 0x00446823 File Offset: 0x00444A23
		public static ISyncBlockContext_UnionUnion FromILevelPlaySyncBlockContext(ILevelPlaySyncBlockContextT _ilevelplaysyncblockcontext)
		{
			return new ISyncBlockContext_UnionUnion
			{
				Type = ISyncBlockContext_Union.ILevelPlaySyncBlockContext,
				Value = _ilevelplaysyncblockcontext
			};
		}

		// Token: 0x0601E8A9 RID: 125097 RVA: 0x00446838 File Offset: 0x00444A38
		public IQuestSyncBlockContextT AsIQuestSyncBlockContext()
		{
			return this.As<IQuestSyncBlockContextT>();
		}

		// Token: 0x0601E8AA RID: 125098 RVA: 0x00446840 File Offset: 0x00444A40
		public static ISyncBlockContext_UnionUnion FromIQuestSyncBlockContext(IQuestSyncBlockContextT _iquestsyncblockcontext)
		{
			return new ISyncBlockContext_UnionUnion
			{
				Type = ISyncBlockContext_Union.IQuestSyncBlockContext,
				Value = _iquestsyncblockcontext
			};
		}

		// Token: 0x0601E8AB RID: 125099 RVA: 0x00446858 File Offset: 0x00444A58
		public static int Pack(FlatBufferBuilder builder, ISyncBlockContext_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISyncBlockContext_Union.ISyncBlockContext:
				return ISyncBlockContext.Pack(builder, _o.AsISyncBlockContext()).Value;
			case ISyncBlockContext_Union.ILevelPlaySyncBlockContext:
				return ILevelPlaySyncBlockContext.Pack(builder, _o.AsILevelPlaySyncBlockContext()).Value;
			case ISyncBlockContext_Union.IQuestSyncBlockContext:
				return IQuestSyncBlockContext.Pack(builder, _o.AsIQuestSyncBlockContext()).Value;
			default:
				return 0;
			}
		}
	}
}
