using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B7 RID: 10679
	public class IClientSendTagEventToControlCharacter : IExecClientBattleActionType
	{
		// Token: 0x0600EC85 RID: 60549 RVA: 0x0022CF64 File Offset: 0x0022B164
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

		// Token: 0x170045C5 RID: 17861
		// (get) Token: 0x0600EC86 RID: 60550 RVA: 0x0022CF83 File Offset: 0x0022B183
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045C6 RID: 17862
		// (get) Token: 0x0600EC87 RID: 60551 RVA: 0x0022CF90 File Offset: 0x0022B190
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

		// Token: 0x04008237 RID: 33335
		private IClientSendTagEventToControlCharacter Instance;

		// Token: 0x04008238 RID: 33336
		private List<string> _EventTagsCache;

		// Token: 0x04008239 RID: 33337
		private bool _EventTagsInited;
	}
}
