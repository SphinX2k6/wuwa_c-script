using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AEE RID: 10990
	public class NpcLeisureInteract : ActionParams
	{
		// Token: 0x0600F1E7 RID: 61927 RVA: 0x00235C56 File Offset: 0x00233E56
		public static NpcLeisureInteract Create(INpcLeisureInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NpcLeisureInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048B9 RID: 18617
		// (get) Token: 0x0600F1E8 RID: 61928 RVA: 0x00235C75 File Offset: 0x00233E75
		public virtual INpcLeisureInteractType Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = ActionReadHelper.ReadNpcLeisureInteract_Option(this.Instance);
				return this._OptionCache;
			}
		}

		// Token: 0x040084CE RID: 33998
		private INpcLeisureInteract Instance;

		// Token: 0x040084CF RID: 33999
		private INpcLeisureInteractType _OptionCache;

		// Token: 0x040084D0 RID: 34000
		private bool _OptionInited;
	}
}
