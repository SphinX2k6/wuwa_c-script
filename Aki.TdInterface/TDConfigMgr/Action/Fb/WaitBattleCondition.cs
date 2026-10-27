using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002709 RID: 9993
	[NullableContext(1)]
	[Nullable(0)]
	public class WaitBattleCondition : ActionParams
	{
		// Token: 0x0600DF00 RID: 57088 RVA: 0x00210EEC File Offset: 0x0020F0EC
		public static WaitBattleCondition Create(IWaitBattleCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WaitBattleCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042B0 RID: 17072
		// (get) Token: 0x0600DF01 RID: 57089 RVA: 0x00210F0B File Offset: 0x0020F10B
		public virtual IDetectBattleTag StateOption
		{
			get
			{
				if (this._StateOptionInited)
				{
					return this._StateOptionCache;
				}
				this._StateOptionInited = true;
				this._StateOptionCache = IDetectBattleTag.Create(this.Instance.StateOption);
				return this._StateOptionCache;
			}
		}

		// Token: 0x04007BC1 RID: 31681
		private IWaitBattleCondition Instance;

		// Token: 0x04007BC2 RID: 31682
		[Nullable(2)]
		private IDetectBattleTag _StateOptionCache;

		// Token: 0x04007BC3 RID: 31683
		private bool _StateOptionInited;
	}
}
