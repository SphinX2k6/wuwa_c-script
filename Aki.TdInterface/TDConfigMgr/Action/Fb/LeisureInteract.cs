using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE8 RID: 10984
	public class LeisureInteract : ActionParams
	{
		// Token: 0x0600F1C7 RID: 61895 RVA: 0x002358F5 File Offset: 0x00233AF5
		public static LeisureInteract Create(ILeisureInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LeisureInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048A5 RID: 18597
		// (get) Token: 0x0600F1C8 RID: 61896 RVA: 0x00235914 File Offset: 0x00233B14
		public virtual ILeisureInteractType Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = ActionReadHelper.ReadLeisureInteract_Option(this.Instance);
				return this._OptionCache;
			}
		}

		// Token: 0x170048A6 RID: 18598
		// (get) Token: 0x0600F1C9 RID: 61897 RVA: 0x00235944 File Offset: 0x00233B44
		public virtual int? SceneEntity
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SceneEntity);
			}
		}

		// Token: 0x040084C4 RID: 33988
		private ILeisureInteract Instance;

		// Token: 0x040084C5 RID: 33989
		private ILeisureInteractType _OptionCache;

		// Token: 0x040084C6 RID: 33990
		private bool _OptionInited;
	}
}
