using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D0D RID: 11533
	public class BvbPlayDialog : ActionParams
	{
		// Token: 0x0600FC48 RID: 64584 RVA: 0x00247CC9 File Offset: 0x00245EC9
		public static BvbPlayDialog Create(IBvbPlayDialog? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BvbPlayDialog
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EDC RID: 20188
		// (get) Token: 0x0600FC49 RID: 64585 RVA: 0x00247CE8 File Offset: 0x00245EE8
		public virtual EBvbPlayDialogType DialogType
		{
			get
			{
				return (EBvbPlayDialogType)this.Instance.DialogType;
			}
		}

		// Token: 0x040089C9 RID: 35273
		private IBvbPlayDialog Instance;
	}
}
