using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5E RID: 2910
	public class IStateRepPerfItem
	{
		// Token: 0x06004270 RID: 17008 RVA: 0x000A8CA4 File Offset: 0x000A6EA4
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

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x000A8CC3 File Offset: 0x000A6EC3
		public virtual string StateTag
		{
			get
			{
				return this.Instance.StateTag;
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06004272 RID: 17010 RVA: 0x000A8CD0 File Offset: 0x000A6ED0
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

		// Token: 0x040024CB RID: 9419
		private IStateRepPerfItem Instance;

		// Token: 0x040024CC RID: 9420
		private IStateRepPerfBase _ReplacePerformanceCache;

		// Token: 0x040024CD RID: 9421
		private bool _ReplacePerformanceInited;
	}
}
