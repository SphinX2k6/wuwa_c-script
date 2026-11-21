using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286D RID: 10349
	public class SetCameraMode : ActionParams
	{
		// Token: 0x0600E6CA RID: 59082 RVA: 0x00222808 File Offset: 0x00220A08
		public static SetCameraMode Create(ISetCameraMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetCameraMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700429E RID: 17054
		// (get) Token: 0x0600E6CB RID: 59083 RVA: 0x00222827 File Offset: 0x00220A27
		public virtual string Mode
		{
			get
			{
				return this.Instance.Mode;
			}
		}

		// Token: 0x04007F1D RID: 32541
		private ISetCameraMode Instance;
	}
}
