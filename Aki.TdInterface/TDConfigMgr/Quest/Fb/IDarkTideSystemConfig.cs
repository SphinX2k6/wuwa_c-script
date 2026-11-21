using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001441 RID: 5185
	public class IDarkTideSystemConfig : IEnableSystemConfig
	{
		// Token: 0x0600754A RID: 30026 RVA: 0x00119A9C File Offset: 0x00117C9C
		public static IDarkTideSystemConfig Create(IDarkTideSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x0600754B RID: 30027 RVA: 0x00119ABB File Offset: 0x00117CBB
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x0600754C RID: 30028 RVA: 0x00119AC8 File Offset: 0x00117CC8
		public virtual IDarkTideBossEventModule Module
		{
			get
			{
				if (this._ModuleInited)
				{
					return this._ModuleCache;
				}
				this._ModuleInited = true;
				this._ModuleCache = IDarkTideBossEventModule.Create(this.Instance.Module);
				return this._ModuleCache;
			}
		}

		// Token: 0x040042E9 RID: 17129
		private IDarkTideSystemConfig Instance;

		// Token: 0x040042EA RID: 17130
		[Nullable(2)]
		private IDarkTideBossEventModule _ModuleCache;

		// Token: 0x040042EB RID: 17131
		private bool _ModuleInited;
	}
}
