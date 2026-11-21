using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D7 RID: 10199
	public class IActorFxEmoteStopAll : IActorFxEmoteStopSubType
	{
		// Token: 0x0600E197 RID: 57751 RVA: 0x00212641 File Offset: 0x00210841
		public static IActorFxEmoteStopAll Create(IActorFxEmoteStopAll? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteStopAll
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x0600E198 RID: 57752 RVA: 0x00212660 File Offset: 0x00210860
		public override EActorFxEmoteStopSubType Type
		{
			get
			{
				return (EActorFxEmoteStopSubType)this.Instance.Type;
			}
		}

		// Token: 0x04007A97 RID: 31383
		private IActorFxEmoteStopAll Instance;
	}
}
