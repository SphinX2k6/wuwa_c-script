using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D6 RID: 10198
	public class IActorFxEmoteStopSubType
	{
		// Token: 0x0600E194 RID: 57748 RVA: 0x0021260D File Offset: 0x0021080D
		public static IActorFxEmoteStopSubType Create(IActorFxEmoteStopSubType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteStopSubType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x0600E195 RID: 57749 RVA: 0x0021262C File Offset: 0x0021082C
		public virtual EActorFxEmoteStopSubType Type
		{
			get
			{
				return (EActorFxEmoteStopSubType)this.Instance.Type;
			}
		}

		// Token: 0x04007A96 RID: 31382
		private IActorFxEmoteStopSubType Instance;
	}
}
