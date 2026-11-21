using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CCA RID: 11466
	public class PlayerInput : ActionParams
	{
		// Token: 0x0600FB5B RID: 64347 RVA: 0x0024694E File Offset: 0x00244B4E
		public static PlayerInput Create(IPlayerInput? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayerInput
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E75 RID: 20085
		// (get) Token: 0x0600FB5C RID: 64348 RVA: 0x0024696D File Offset: 0x00244B6D
		public virtual EPlayerInputType Input
		{
			get
			{
				return (EPlayerInputType)this.Instance.Input;
			}
		}

		// Token: 0x04008956 RID: 35158
		private IPlayerInput Instance;
	}
}
