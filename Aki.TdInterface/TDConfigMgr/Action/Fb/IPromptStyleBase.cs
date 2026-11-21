using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286E RID: 10350
	public class IPromptStyleBase
	{
		// Token: 0x0600E6CD RID: 59085 RVA: 0x0022283C File Offset: 0x00220A3C
		public static IPromptStyleBase Create(IPromptStyleBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700429F RID: 17055
		// (get) Token: 0x0600E6CE RID: 59086 RVA: 0x0022285B File Offset: 0x00220A5B
		public virtual EPromptStyle Type
		{
			get
			{
				return (EPromptStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007F1E RID: 32542
		private IPromptStyleBase Instance;
	}
}
