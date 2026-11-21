using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CE9 RID: 11497
	public class ISetAlertUiVisible : IAlertSystemOption
	{
		// Token: 0x0600FBD1 RID: 64465 RVA: 0x0024730D File Offset: 0x0024550D
		public static ISetAlertUiVisible Create(ISetAlertUiVisible? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAlertUiVisible
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EAD RID: 20141
		// (get) Token: 0x0600FBD2 RID: 64466 RVA: 0x0024732C File Offset: 0x0024552C
		public override EAlertSystemOption Type
		{
			get
			{
				return (EAlertSystemOption)this.Instance.Type;
			}
		}

		// Token: 0x17004EAE RID: 20142
		// (get) Token: 0x0600FBD3 RID: 64467 RVA: 0x00247339 File Offset: 0x00245539
		public override int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17004EAF RID: 20143
		// (get) Token: 0x0600FBD4 RID: 64468 RVA: 0x00247346 File Offset: 0x00245546
		public virtual bool IsVisible
		{
			get
			{
				return this.Instance.IsVisible;
			}
		}

		// Token: 0x0400898B RID: 35211
		private ISetAlertUiVisible Instance;
	}
}
