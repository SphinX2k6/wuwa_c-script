using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DCC RID: 3532
	[NullableContext(2)]
	[Nullable(0)]
	public class IPasserbyNpcLiftStopExitTiming : IPasserbyNpcExitTimingBase
	{
		// Token: 0x06005024 RID: 20516 RVA: 0x000C70AB File Offset: 0x000C52AB
		[NullableContext(0)]
		public static IPasserbyNpcLiftStopExitTiming Create(IPasserbyNpcLiftStopExitTiming? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcLiftStopExitTiming
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06005025 RID: 20517 RVA: 0x000C70CA File Offset: 0x000C52CA
		public override EPasserbyNpcExitTimingType Type
		{
			get
			{
				return (EPasserbyNpcExitTimingType)this.Instance.Type;
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06005026 RID: 20518 RVA: 0x000C70D7 File Offset: 0x000C52D7
		public virtual IPasserbyNpcIntervalExit IntervalExit
		{
			get
			{
				if (this._IntervalExitInited)
				{
					return this._IntervalExitCache;
				}
				this._IntervalExitInited = true;
				this._IntervalExitCache = IPasserbyNpcIntervalExit.Create(this.Instance.IntervalExit);
				return this._IntervalExitCache;
			}
		}

		// Token: 0x04002DA7 RID: 11687
		private IPasserbyNpcLiftStopExitTiming Instance;

		// Token: 0x04002DA8 RID: 11688
		private IPasserbyNpcIntervalExit _IntervalExitCache;

		// Token: 0x04002DA9 RID: 11689
		private bool _IntervalExitInited;
	}
}
