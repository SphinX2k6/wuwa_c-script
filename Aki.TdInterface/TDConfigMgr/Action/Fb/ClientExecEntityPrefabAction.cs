using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E0D RID: 11789
	public class ClientExecEntityPrefabAction : ActionParams
	{
		// Token: 0x0601002E RID: 65582 RVA: 0x0024DF4B File Offset: 0x0024C14B
		public static ClientExecEntityPrefabAction Create(IClientExecEntityPrefabAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientExecEntityPrefabAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050C2 RID: 20674
		// (get) Token: 0x0601002F RID: 65583 RVA: 0x0024DF6A File Offset: 0x0024C16A
		public virtual IClientModifyEntityPrefabParams Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = IClientModifyEntityPrefabParams.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x04008BCF RID: 35791
		private IClientExecEntityPrefabAction Instance;

		// Token: 0x04008BD0 RID: 35792
		[Nullable(2)]
		private IClientModifyEntityPrefabParams _OptionCache;

		// Token: 0x04008BD1 RID: 35793
		private bool _OptionInited;
	}
}
