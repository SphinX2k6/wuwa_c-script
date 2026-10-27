using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002713 RID: 10003
	[NullableContext(1)]
	[Nullable(0)]
	public class UnlockSystemItem : ActionParams
	{
		// Token: 0x0600DF25 RID: 57125 RVA: 0x00211217 File Offset: 0x0020F417
		public static UnlockSystemItem Create(IUnlockSystemItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnlockSystemItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042C1 RID: 17089
		// (get) Token: 0x0600DF26 RID: 57126 RVA: 0x00211236 File Offset: 0x0020F436
		public virtual IUnlockSystemItemType SystemOption
		{
			get
			{
				if (this._SystemOptionInited)
				{
					return this._SystemOptionCache;
				}
				this._SystemOptionInited = true;
				this._SystemOptionCache = ActionReadHelper.ReadUnlockSystemItem_SystemOption(this.Instance);
				return this._SystemOptionCache;
			}
		}

		// Token: 0x04007BD3 RID: 31699
		private IUnlockSystemItem Instance;

		// Token: 0x04007BD4 RID: 31700
		private IUnlockSystemItemType _SystemOptionCache;

		// Token: 0x04007BD5 RID: 31701
		private bool _SystemOptionInited;
	}
}
