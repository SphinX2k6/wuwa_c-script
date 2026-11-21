using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D2 RID: 10450
	public class ILongPressInteractStyleConfig
	{
		// Token: 0x0600E89C RID: 59548 RVA: 0x00225EE9 File Offset: 0x002240E9
		public static ILongPressInteractStyleConfig Create(ILongPressInteractStyleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043A6 RID: 17318
		// (get) Token: 0x0600E89D RID: 59549 RVA: 0x00225F08 File Offset: 0x00224108
		public virtual ELongPressInteractStyle Type
		{
			get
			{
				return (ELongPressInteractStyle)this.Instance.Type;
			}
		}

		// Token: 0x04008022 RID: 32802
		private ILongPressInteractStyleConfig Instance;
	}
}
