using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200292C RID: 10540
	public class ChangeEntityState : ActionParams
	{
		// Token: 0x0600EA4B RID: 59979 RVA: 0x00229491 File Offset: 0x00227691
		public static ChangeEntityState Create(IChangeEntityState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeEntityState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044A1 RID: 17569
		// (get) Token: 0x0600EA4C RID: 59980 RVA: 0x002294B0 File Offset: 0x002276B0
		public virtual EChangeEntityState Type
		{
			get
			{
				return (EChangeEntityState)this.Instance.Type;
			}
		}

		// Token: 0x170044A2 RID: 17570
		// (get) Token: 0x0600EA4D RID: 59981 RVA: 0x002294BD File Offset: 0x002276BD
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x0400812C RID: 33068
		private IChangeEntityState Instance;
	}
}
