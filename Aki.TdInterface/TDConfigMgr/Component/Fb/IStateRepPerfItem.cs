using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A94 RID: 2708
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateRepPerfItem
	{
		// Token: 0x06003E47 RID: 15943 RVA: 0x0009F6EC File Offset: 0x0009D8EC
		public static IStateRepPerfItem Create(IStateRepPerfItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06003E48 RID: 15944 RVA: 0x0009F70B File Offset: 0x0009D90B
		public virtual string StateTag
		{
			get
			{
				return this.Instance.StateTag;
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06003E49 RID: 15945 RVA: 0x0009F718 File Offset: 0x0009D918
		public virtual IStateRepPerfBase ReplacePerformance
		{
			get
			{
				if (this._ReplacePerformanceInited)
				{
					return this._ReplacePerformanceCache;
				}
				this._ReplacePerformanceInited = true;
				this._ReplacePerformanceCache = ComponentReadHelper.ReadIStateRepPerfItem_ReplacePerformance(this.Instance);
				return this._ReplacePerformanceCache;
			}
		}

		// Token: 0x040022AF RID: 8879
		private IStateRepPerfItem Instance;

		// Token: 0x040022B0 RID: 8880
		private IStateRepPerfBase _ReplacePerformanceCache;

		// Token: 0x040022B1 RID: 8881
		private bool _ReplacePerformanceInited;
	}
}
