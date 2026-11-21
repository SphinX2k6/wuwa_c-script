using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027DC RID: 10204
	public class IActorFxEmote
	{
		// Token: 0x0600E1AE RID: 57774 RVA: 0x002128FE File Offset: 0x00210AFE
		public static IActorFxEmote Create(IActorFxEmote? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmote
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EA4 RID: 16036
		// (get) Token: 0x0600E1AF RID: 57775 RVA: 0x0021291D File Offset: 0x00210B1D
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x0600E1B0 RID: 57776 RVA: 0x0021292A File Offset: 0x00210B2A
		public virtual IActorFxEmoteType FxEmote
		{
			get
			{
				if (this._FxEmoteInited)
				{
					return this._FxEmoteCache;
				}
				this._FxEmoteInited = true;
				this._FxEmoteCache = ActionReadHelper.ReadIActorFxEmote_FxEmote(this.Instance);
				return this._FxEmoteCache;
			}
		}

		// Token: 0x04007AA2 RID: 31394
		private IActorFxEmote Instance;

		// Token: 0x04007AA3 RID: 31395
		private IActorFxEmoteType _FxEmoteCache;

		// Token: 0x04007AA4 RID: 31396
		private bool _FxEmoteInited;
	}
}
