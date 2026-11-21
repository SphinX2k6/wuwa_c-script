using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028CB RID: 10443
	public class IInteractionConfirmBoxType
	{
		// Token: 0x0600E880 RID: 59520 RVA: 0x00225C71 File Offset: 0x00223E71
		public static IInteractionConfirmBoxType Create(IInteractionConfirmBoxType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractionConfirmBoxType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004398 RID: 17304
		// (get) Token: 0x0600E881 RID: 59521 RVA: 0x00225C90 File Offset: 0x00223E90
		public virtual EInteractionConfirmBoxType Type
		{
			get
			{
				return (EInteractionConfirmBoxType)this.Instance.Type;
			}
		}

		// Token: 0x04008015 RID: 32789
		private IInteractionConfirmBoxType Instance;
	}
}
