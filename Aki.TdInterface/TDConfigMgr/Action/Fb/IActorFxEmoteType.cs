using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D9 RID: 10201
	public class IActorFxEmoteType
	{
		// Token: 0x0600E19E RID: 57758 RVA: 0x00212710 File Offset: 0x00210910
		public static IActorFxEmoteType Create(IActorFxEmoteType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x0600E19F RID: 57759 RVA: 0x0021272F File Offset: 0x0021092F
		public virtual EActorFxEmoteType Type
		{
			get
			{
				return (EActorFxEmoteType)this.Instance.Type;
			}
		}

		// Token: 0x04007A9B RID: 31387
		private IActorFxEmoteType Instance;
	}
}
