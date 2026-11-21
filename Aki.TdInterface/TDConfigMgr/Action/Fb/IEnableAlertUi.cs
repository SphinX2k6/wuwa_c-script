using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CE8 RID: 11496
	public class IEnableAlertUi : IAlertSystemOption
	{
		// Token: 0x0600FBCC RID: 64460 RVA: 0x002472BF File Offset: 0x002454BF
		public static IEnableAlertUi Create(IEnableAlertUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableAlertUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EAA RID: 20138
		// (get) Token: 0x0600FBCD RID: 64461 RVA: 0x002472DE File Offset: 0x002454DE
		public override EAlertSystemOption Type
		{
			get
			{
				return (EAlertSystemOption)this.Instance.Type;
			}
		}

		// Token: 0x17004EAB RID: 20139
		// (get) Token: 0x0600FBCE RID: 64462 RVA: 0x002472EB File Offset: 0x002454EB
		public override int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17004EAC RID: 20140
		// (get) Token: 0x0600FBCF RID: 64463 RVA: 0x002472F8 File Offset: 0x002454F8
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x0400898A RID: 35210
		private IEnableAlertUi Instance;
	}
}
