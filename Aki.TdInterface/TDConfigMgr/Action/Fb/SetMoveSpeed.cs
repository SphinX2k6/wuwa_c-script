using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B8 RID: 10424
	public class SetMoveSpeed : ActionParams
	{
		// Token: 0x0600E833 RID: 59443 RVA: 0x00225366 File Offset: 0x00223566
		public static SetMoveSpeed Create(ISetMoveSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetMoveSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004371 RID: 17265
		// (get) Token: 0x0600E834 RID: 59444 RVA: 0x00225385 File Offset: 0x00223585
		public virtual float Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x04007FDC RID: 32732
		private ISetMoveSpeed Instance;
	}
}
