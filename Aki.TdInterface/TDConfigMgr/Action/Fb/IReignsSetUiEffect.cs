using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A50 RID: 10832
	[NullableContext(1)]
	[Nullable(0)]
	public class IReignsSetUiEffect : ActionParams
	{
		// Token: 0x0600EE62 RID: 61026 RVA: 0x0022B466 File Offset: 0x00229666
		public static IReignsSetUiEffect Create(IReignsSetUiEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IReignsSetUiEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B84 RID: 19332
		// (get) Token: 0x0600EE63 RID: 61027 RVA: 0x0022B485 File Offset: 0x00229685
		public virtual string Effect
		{
			get
			{
				return this.Instance.Effect;
			}
		}

		// Token: 0x17004B85 RID: 19333
		// (get) Token: 0x0600EE64 RID: 61028 RVA: 0x0022B492 File Offset: 0x00229692
		public virtual bool IsVisible
		{
			get
			{
				return this.Instance.IsVisible;
			}
		}

		// Token: 0x0400832C RID: 33580
		private IReignsSetUiEffect Instance;
	}
}
