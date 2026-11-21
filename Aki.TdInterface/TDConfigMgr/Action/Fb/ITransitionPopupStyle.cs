using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002920 RID: 10528
	public class ITransitionPopupStyle
	{
		// Token: 0x0600E9FC RID: 59900 RVA: 0x00228A26 File Offset: 0x00226C26
		public static ITransitionPopupStyle Create(ITransitionPopupStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700446A RID: 17514
		// (get) Token: 0x0600E9FD RID: 59901 RVA: 0x00228A45 File Offset: 0x00226C45
		public virtual ETransitionPopupStyleType Type
		{
			get
			{
				return (ETransitionPopupStyleType)this.Instance.Type;
			}
		}

		// Token: 0x040080FC RID: 33020
		private ITransitionPopupStyle Instance;
	}
}
