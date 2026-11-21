using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200288A RID: 10378
	public class ISceneUiSubtitleOperationBase
	{
		// Token: 0x0600E746 RID: 59206 RVA: 0x00223654 File Offset: 0x00221854
		public static ISceneUiSubtitleOperationBase Create(ISceneUiSubtitleOperationBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleOperationBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042E0 RID: 17120
		// (get) Token: 0x0600E747 RID: 59207 RVA: 0x00223673 File Offset: 0x00221873
		public virtual ESceneUiSubtitleOperationType Type
		{
			get
			{
				return (ESceneUiSubtitleOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04007F5A RID: 32602
		private ISceneUiSubtitleOperationBase Instance;
	}
}
