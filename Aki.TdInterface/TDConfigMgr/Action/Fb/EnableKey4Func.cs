using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D8E RID: 11662
	public class EnableKey4Func : ActionParams
	{
		// Token: 0x0600FE42 RID: 65090 RVA: 0x0024AF76 File Offset: 0x00249176
		public static EnableKey4Func Create(IEnableKey4Func? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableKey4Func
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FD4 RID: 20436
		// (get) Token: 0x0600FE43 RID: 65091 RVA: 0x0024AF95 File Offset: 0x00249195
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x17004FD5 RID: 20437
		// (get) Token: 0x0600FE44 RID: 65092 RVA: 0x0024AFA2 File Offset: 0x002491A2
		public virtual EEnableKey4FuncKey FuncKey
		{
			get
			{
				return (EEnableKey4FuncKey)this.Instance.FuncKey;
			}
		}

		// Token: 0x04008ACA RID: 35530
		private IEnableKey4Func Instance;
	}
}
