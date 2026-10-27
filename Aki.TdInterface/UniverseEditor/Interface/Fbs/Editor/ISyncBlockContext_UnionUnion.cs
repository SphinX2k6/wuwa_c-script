using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048AE RID: 18606
	public class ISyncBlockContext_UnionUnion
	{
		// Token: 0x170086E7 RID: 34535
		// (get) Token: 0x0601D0B2 RID: 118962 RVA: 0x0041A018 File Offset: 0x00418218
		// (set) Token: 0x0601D0B3 RID: 118963 RVA: 0x0041A020 File Offset: 0x00418220
		public ISyncBlockContext_Union Type { get; set; }

		// Token: 0x170086E8 RID: 34536
		// (get) Token: 0x0601D0B4 RID: 118964 RVA: 0x0041A029 File Offset: 0x00418229
		// (set) Token: 0x0601D0B5 RID: 118965 RVA: 0x0041A031 File Offset: 0x00418231
		public object Value { get; set; }

		// Token: 0x0601D0B6 RID: 118966 RVA: 0x0041A03A File Offset: 0x0041823A
		public ISyncBlockContext_UnionUnion()
		{
			this.Type = ISyncBlockContext_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601D0B7 RID: 118967 RVA: 0x0041A050 File Offset: 0x00418250
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D0B8 RID: 118968 RVA: 0x0041A062 File Offset: 0x00418262
		public ISyncBlockContextT AsISyncBlockContext()
		{
			return this.As<ISyncBlockContextT>();
		}

		// Token: 0x0601D0B9 RID: 118969 RVA: 0x0041A06A File Offset: 0x0041826A
		public static ISyncBlockContext_UnionUnion FromISyncBlockContext(ISyncBlockContextT _isyncblockcontext)
		{
			return new ISyncBlockContext_UnionUnion
			{
				Type = ISyncBlockContext_Union.ISyncBlockContext,
				Value = _isyncblockcontext
			};
		}

		// Token: 0x0601D0BA RID: 118970 RVA: 0x0041A07F File Offset: 0x0041827F
		public ILevelPlaySyncBlockContextT AsILevelPlaySyncBlockContext()
		{
			return this.As<ILevelPlaySyncBlockContextT>();
		}

		// Token: 0x0601D0BB RID: 118971 RVA: 0x0041A087 File Offset: 0x00418287
		public static ISyncBlockContext_UnionUnion FromILevelPlaySyncBlockContext(ILevelPlaySyncBlockContextT _ilevelplaysyncblockcontext)
		{
			return new ISyncBlockContext_UnionUnion
			{
				Type = ISyncBlockContext_Union.ILevelPlaySyncBlockContext,
				Value = _ilevelplaysyncblockcontext
			};
		}

		// Token: 0x0601D0BC RID: 118972 RVA: 0x0041A09C File Offset: 0x0041829C
		public IQuestSyncBlockContextT AsIQuestSyncBlockContext()
		{
			return this.As<IQuestSyncBlockContextT>();
		}

		// Token: 0x0601D0BD RID: 118973 RVA: 0x0041A0A4 File Offset: 0x004182A4
		public static ISyncBlockContext_UnionUnion FromIQuestSyncBlockContext(IQuestSyncBlockContextT _iquestsyncblockcontext)
		{
			return new ISyncBlockContext_UnionUnion
			{
				Type = ISyncBlockContext_Union.IQuestSyncBlockContext,
				Value = _iquestsyncblockcontext
			};
		}

		// Token: 0x0601D0BE RID: 118974 RVA: 0x0041A0BC File Offset: 0x004182BC
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
