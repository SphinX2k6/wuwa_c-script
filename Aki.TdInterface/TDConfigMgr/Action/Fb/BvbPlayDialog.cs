using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A20 RID: 10784
	public class BvbPlayDialog : ActionParams
	{
		// Token: 0x0600EDB0 RID: 60848 RVA: 0x0022A316 File Offset: 0x00228516
		[NullableContext(1)]
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

		// Token: 0x17004B32 RID: 19250
		// (get) Token: 0x0600EDB1 RID: 60849 RVA: 0x0022A335 File Offset: 0x00228535
		public virtual EBvbPlayDialogType DialogType
		{
			get
			{
				return (EBvbPlayDialogType)this.Instance.DialogType;
			}
		}

		// Token: 0x040082D6 RID: 33494
		private IBvbPlayDialog Instance;
	}
}
