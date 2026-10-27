using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002535 RID: 9525
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFxEmote
	{
		// Token: 0x0600D44E RID: 54350 RVA: 0x001F6E9E File Offset: 0x001F509E
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

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x0600D44F RID: 54351 RVA: 0x001F6EBD File Offset: 0x001F50BD
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x0600D450 RID: 54352 RVA: 0x001F6ECA File Offset: 0x001F50CA
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

		// Token: 0x0400744D RID: 29773
		private IActorFxEmote Instance;

		// Token: 0x0400744E RID: 29774
		private IActorFxEmoteType _FxEmoteCache;

		// Token: 0x0400744F RID: 29775
		private bool _FxEmoteInited;
	}
}
