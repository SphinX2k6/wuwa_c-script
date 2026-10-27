using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026F1 RID: 9969
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientSendTagEventToControlCharacter : IExecClientBattleActionType
	{
		// Token: 0x0600DE9E RID: 56990 RVA: 0x0021062E File Offset: 0x0020E82E
		public static IClientSendTagEventToControlCharacter Create(IClientSendTagEventToControlCharacter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientSendTagEventToControlCharacter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700427E RID: 17022
		// (get) Token: 0x0600DE9F RID: 56991 RVA: 0x0021064D File Offset: 0x0020E84D
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x1700427F RID: 17023
		// (get) Token: 0x0600DEA0 RID: 56992 RVA: 0x0021065C File Offset: 0x0020E85C
		public virtual List<string> EventTags
		{
			get
			{
				if (this._EventTagsInited)
				{
					return this._EventTagsCache;
				}
				this._EventTagsInited = true;
				int eventTagsLength = this.Instance.EventTagsLength;
				this._EventTagsCache = new List<string>(eventTagsLength);
				for (int i = 0; i < eventTagsLength; i++)
				{
					this._EventTagsCache.Add(this.Instance.EventTags(i));
				}
				return this._EventTagsCache;
			}
		}

		// Token: 0x04007B93 RID: 31635
		private IClientSendTagEventToControlCharacter Instance;

		// Token: 0x04007B94 RID: 31636
		private List<string> _EventTagsCache;

		// Token: 0x04007B95 RID: 31637
		private bool _EventTagsInited;
	}
}
