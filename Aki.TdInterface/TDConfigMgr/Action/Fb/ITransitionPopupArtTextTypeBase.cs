using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002921 RID: 10529
	public class ITransitionPopupArtTextTypeBase
	{
		// Token: 0x0600E9FF RID: 59903 RVA: 0x00228A5A File Offset: 0x00226C5A
		public static ITransitionPopupArtTextTypeBase Create(ITransitionPopupArtTextTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupArtTextTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700446B RID: 17515
		// (get) Token: 0x0600EA00 RID: 59904 RVA: 0x00228A79 File Offset: 0x00226C79
		public virtual ETransitionPopupArtTextType Type
		{
			get
			{
				return (ETransitionPopupArtTextType)this.Instance.Type;
			}
		}

		// Token: 0x040080FD RID: 33021
		private ITransitionPopupArtTextTypeBase Instance;
	}
}
