using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002966 RID: 10598
	[NullableContext(1)]
	[Nullable(0)]
	public class FocusOnMapMarkAction : ActionParams
	{
		// Token: 0x0600EAEB RID: 60139 RVA: 0x0022630A File Offset: 0x0022450A
		public static FocusOnMapMarkAction Create(IFocusOnMapMarkAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FocusOnMapMarkAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E1 RID: 18913
		// (get) Token: 0x0600EAEC RID: 60140 RVA: 0x00226329 File Offset: 0x00224529
		public virtual IFocusOnMapMark MapMarkType
		{
			get
			{
				if (this._MapMarkTypeInited)
				{
					return this._MapMarkTypeCache;
				}
				this._MapMarkTypeInited = true;
				this._MapMarkTypeCache = ActionReadHelper.ReadFocusOnMapMarkAction_MapMarkType(this.Instance);
				return this._MapMarkTypeCache;
			}
		}

		// Token: 0x0400816E RID: 33134
		private IFocusOnMapMarkAction Instance;

		// Token: 0x0400816F RID: 33135
		private IFocusOnMapMark _MapMarkTypeCache;

		// Token: 0x04008170 RID: 33136
		private bool _MapMarkTypeInited;
	}
}
