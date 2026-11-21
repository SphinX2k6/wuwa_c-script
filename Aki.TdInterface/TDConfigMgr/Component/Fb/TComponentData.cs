using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F5F RID: 3935
	public class TComponentData
	{
		// Token: 0x0600582A RID: 22570 RVA: 0x000D7921 File Offset: 0x000D5B21
		public static TComponentData Create(TComponentData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TComponentData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x0600582B RID: 22571 RVA: 0x000D7940 File Offset: 0x000D5B40
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x0600582C RID: 22572 RVA: 0x000D794D File Offset: 0x000D5B4D
		public virtual IComponentBase Value
		{
			get
			{
				if (this._ValueInited)
				{
					return this._ValueCache;
				}
				this._ValueInited = true;
				this._ValueCache = ComponentReadHelper.ReadTComponentData_Value(this.Instance);
				return this._ValueCache;
			}
		}

		// Token: 0x040032A2 RID: 12962
		private TComponentData Instance;

		// Token: 0x040032A3 RID: 12963
		private IComponentBase _ValueCache;

		// Token: 0x040032A4 RID: 12964
		private bool _ValueInited;
	}
}
