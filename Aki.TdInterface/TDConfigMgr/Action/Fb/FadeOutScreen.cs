using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A4A RID: 10826
	[NullableContext(2)]
	[Nullable(0)]
	public class FadeOutScreen : ActionParams
	{
		// Token: 0x0600EF1A RID: 61210 RVA: 0x00230AF7 File Offset: 0x0022ECF7
		[NullableContext(0)]
		public static FadeOutScreen Create(IFadeOutScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FadeOutScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004734 RID: 18228
		// (get) Token: 0x0600EF1B RID: 61211 RVA: 0x00230B16 File Offset: 0x0022ED16
		public virtual IEaseData Ease
		{
			get
			{
				if (this._EaseInited)
				{
					return this._EaseCache;
				}
				this._EaseInited = true;
				this._EaseCache = IEaseData.Create(this.Instance.Ease);
				return this._EaseCache;
			}
		}

		// Token: 0x17004735 RID: 18229
		// (get) Token: 0x0600EF1C RID: 61212 RVA: 0x00230B4C File Offset: 0x0022ED4C
		public virtual bool? OnlyLowMemoryDeviceExecute
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.OnlyLowMemoryDeviceExecute);
			}
		}

		// Token: 0x0400834A RID: 33610
		private IFadeOutScreen Instance;

		// Token: 0x0400834B RID: 33611
		private IEaseData _EaseCache;

		// Token: 0x0400834C RID: 33612
		private bool _EaseInited;
	}
}
