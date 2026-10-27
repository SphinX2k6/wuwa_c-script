using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002662 RID: 9826
	[NullableContext(1)]
	[Nullable(0)]
	public class ITransitionPopupConfig
	{
		// Token: 0x0600DC3A RID: 56378 RVA: 0x0020C33C File Offset: 0x0020A53C
		public static ITransitionPopupConfig Create(ITransitionPopupConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004138 RID: 16696
		// (get) Token: 0x0600DC3B RID: 56379 RVA: 0x0020C35C File Offset: 0x0020A55C
		public virtual float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x17004139 RID: 16697
		// (get) Token: 0x0600DC3C RID: 56380 RVA: 0x0020C392 File Offset: 0x0020A592
		public virtual ITransitionPopupStyle PopupStyle
		{
			get
			{
				if (this._PopupStyleInited)
				{
					return this._PopupStyleCache;
				}
				this._PopupStyleInited = true;
				this._PopupStyleCache = ActionReadHelper.ReadITransitionPopupConfig_PopupStyle(this.Instance);
				return this._PopupStyleCache;
			}
		}

		// Token: 0x04007A64 RID: 31332
		private ITransitionPopupConfig Instance;

		// Token: 0x04007A65 RID: 31333
		private ITransitionPopupStyle _PopupStyleCache;

		// Token: 0x04007A66 RID: 31334
		private bool _PopupStyleInited;
	}
}
