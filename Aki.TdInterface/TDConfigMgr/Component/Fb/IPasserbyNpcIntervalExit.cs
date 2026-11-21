using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DCB RID: 3531
	public class IPasserbyNpcIntervalExit
	{
		// Token: 0x06005021 RID: 20513 RVA: 0x000C7050 File Offset: 0x000C5250
		public static IPasserbyNpcIntervalExit Create(IPasserbyNpcIntervalExit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcIntervalExit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06005022 RID: 20514 RVA: 0x000C706F File Offset: 0x000C526F
		public virtual IPasserbyNpcPerNpcRandomExitInterval IntervalType
		{
			get
			{
				if (this._IntervalTypeInited)
				{
					return this._IntervalTypeCache;
				}
				this._IntervalTypeInited = true;
				this._IntervalTypeCache = IPasserbyNpcPerNpcRandomExitInterval.Create(this.Instance.IntervalType);
				return this._IntervalTypeCache;
			}
		}

		// Token: 0x04002DA4 RID: 11684
		private IPasserbyNpcIntervalExit Instance;

		// Token: 0x04002DA5 RID: 11685
		[Nullable(2)]
		private IPasserbyNpcPerNpcRandomExitInterval _IntervalTypeCache;

		// Token: 0x04002DA6 RID: 11686
		private bool _IntervalTypeInited;
	}
}
