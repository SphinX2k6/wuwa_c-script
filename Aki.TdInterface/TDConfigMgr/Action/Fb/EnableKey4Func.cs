using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A9A RID: 10906
	public class EnableKey4Func : ActionParams
	{
		// Token: 0x0600EF8C RID: 61324 RVA: 0x0022D26A File Offset: 0x0022B46A
		[NullableContext(1)]
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

		// Token: 0x17004C1A RID: 19482
		// (get) Token: 0x0600EF8D RID: 61325 RVA: 0x0022D289 File Offset: 0x0022B489
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x17004C1B RID: 19483
		// (get) Token: 0x0600EF8E RID: 61326 RVA: 0x0022D296 File Offset: 0x0022B496
		public virtual EEnableKey4FuncKey FuncKey
		{
			get
			{
				return (EEnableKey4FuncKey)this.Instance.FuncKey;
			}
		}

		// Token: 0x040083C6 RID: 33734
		private IEnableKey4Func Instance;
	}
}
