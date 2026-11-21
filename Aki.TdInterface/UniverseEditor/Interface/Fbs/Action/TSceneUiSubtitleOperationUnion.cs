using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FA4 RID: 32676
	public class TSceneUiSubtitleOperationUnion
	{
		// Token: 0x1700F2E5 RID: 62181
		// (get) Token: 0x0603ADDF RID: 241119 RVA: 0x007E9012 File Offset: 0x007E7212
		// (set) Token: 0x0603ADE0 RID: 241120 RVA: 0x007E901A File Offset: 0x007E721A
		public TSceneUiSubtitleOperation Type { get; set; }

		// Token: 0x1700F2E6 RID: 62182
		// (get) Token: 0x0603ADE1 RID: 241121 RVA: 0x007E9023 File Offset: 0x007E7223
		// (set) Token: 0x0603ADE2 RID: 241122 RVA: 0x007E902B File Offset: 0x007E722B
		public object Value { get; set; }

		// Token: 0x0603ADE3 RID: 241123 RVA: 0x007E9034 File Offset: 0x007E7234
		public TSceneUiSubtitleOperationUnion()
		{
			this.Type = TSceneUiSubtitleOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0603ADE4 RID: 241124 RVA: 0x007E904A File Offset: 0x007E724A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ADE5 RID: 241125 RVA: 0x007E905C File Offset: 0x007E725C
		public IRemoveSceneUiSubtitleT AsIRemoveSceneUiSubtitle()
		{
			return this.As<IRemoveSceneUiSubtitleT>();
		}

		// Token: 0x0603ADE6 RID: 241126 RVA: 0x007E9064 File Offset: 0x007E7264
		public static TSceneUiSubtitleOperationUnion FromIRemoveSceneUiSubtitle(IRemoveSceneUiSubtitleT _iremovesceneuisubtitle)
		{
			return new TSceneUiSubtitleOperationUnion
			{
				Type = TSceneUiSubtitleOperation.IRemoveSceneUiSubtitle,
				Value = _iremovesceneuisubtitle
			};
		}

		// Token: 0x0603ADE7 RID: 241127 RVA: 0x007E9079 File Offset: 0x007E7279
		public ISpawnSceneUiSubtitleT AsISpawnSceneUiSubtitle()
		{
			return this.As<ISpawnSceneUiSubtitleT>();
		}

		// Token: 0x0603ADE8 RID: 241128 RVA: 0x007E9081 File Offset: 0x007E7281
		public static TSceneUiSubtitleOperationUnion FromISpawnSceneUiSubtitle(ISpawnSceneUiSubtitleT _ispawnsceneuisubtitle)
		{
			return new TSceneUiSubtitleOperationUnion
			{
				Type = TSceneUiSubtitleOperation.ISpawnSceneUiSubtitle,
				Value = _ispawnsceneuisubtitle
			};
		}

		// Token: 0x0603ADE9 RID: 241129 RVA: 0x007E9098 File Offset: 0x007E7298
		public static int Pack(FlatBufferBuilder builder, TSceneUiSubtitleOperationUnion _o)
		{
			TSceneUiSubtitleOperation type = _o.Type;
			if (type == TSceneUiSubtitleOperation.IRemoveSceneUiSubtitle)
			{
				return IRemoveSceneUiSubtitle.Pack(builder, _o.AsIRemoveSceneUiSubtitle()).Value;
			}
			if (type != TSceneUiSubtitleOperation.ISpawnSceneUiSubtitle)
			{
				return 0;
			}
			return ISpawnSceneUiSubtitle.Pack(builder, _o.AsISpawnSceneUiSubtitle()).Value;
		}
	}
}
