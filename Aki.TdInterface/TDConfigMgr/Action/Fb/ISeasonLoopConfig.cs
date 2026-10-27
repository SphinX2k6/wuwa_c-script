using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200289F RID: 10399
	public class ISeasonLoopConfig
	{
		// Token: 0x0600E636 RID: 58934 RVA: 0x0021D407 File Offset: 0x0021B607
		[NullableContext(1)]
		public static ISeasonLoopConfig Create(ISeasonLoopConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISeasonLoopConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046BA RID: 18106
		// (get) Token: 0x0600E637 RID: 58935 RVA: 0x0021D426 File Offset: 0x0021B626
		public virtual float HoldTime
		{
			get
			{
				return this.Instance.HoldTime;
			}
		}

		// Token: 0x170046BB RID: 18107
		// (get) Token: 0x0600E638 RID: 58936 RVA: 0x0021D433 File Offset: 0x0021B633
		public virtual float SwitchTime
		{
			get
			{
				return this.Instance.SwitchTime;
			}
		}

		// Token: 0x04007F45 RID: 32581
		private ISeasonLoopConfig Instance;
	}
}
