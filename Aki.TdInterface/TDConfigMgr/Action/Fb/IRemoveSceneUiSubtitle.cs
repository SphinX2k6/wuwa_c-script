using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200288C RID: 10380
	public class IRemoveSceneUiSubtitle : ISceneUiSubtitleOperationBase
	{
		// Token: 0x0600E750 RID: 59216 RVA: 0x0022375E File Offset: 0x0022195E
		public static IRemoveSceneUiSubtitle Create(IRemoveSceneUiSubtitle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemoveSceneUiSubtitle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042E6 RID: 17126
		// (get) Token: 0x0600E751 RID: 59217 RVA: 0x0022377D File Offset: 0x0022197D
		public override ESceneUiSubtitleOperationType Type
		{
			get
			{
				return (ESceneUiSubtitleOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170042E7 RID: 17127
		// (get) Token: 0x0600E752 RID: 59218 RVA: 0x0022378A File Offset: 0x0022198A
		public virtual string Mark
		{
			get
			{
				return this.Instance.Mark;
			}
		}

		// Token: 0x04007F60 RID: 32608
		private IRemoveSceneUiSubtitle Instance;
	}
}
