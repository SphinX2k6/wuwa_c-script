using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002815 RID: 10261
	[NullableContext(1)]
	[Nullable(0)]
	public class LeisureInteract : ActionParams
	{
		// Token: 0x0600E3A2 RID: 58274 RVA: 0x00218A91 File Offset: 0x00216C91
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

		// Token: 0x1700453A RID: 17722
		// (get) Token: 0x0600E3A3 RID: 58275 RVA: 0x00218AB0 File Offset: 0x00216CB0
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

		// Token: 0x1700453B RID: 17723
		// (get) Token: 0x0600E3A4 RID: 58276 RVA: 0x00218AE0 File Offset: 0x00216CE0
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

		// Token: 0x04007E07 RID: 32263
		private ILeisureInteract Instance;

		// Token: 0x04007E08 RID: 32264
		private ILeisureInteractType _OptionCache;

		// Token: 0x04007E09 RID: 32265
		private bool _OptionInited;
	}
}
