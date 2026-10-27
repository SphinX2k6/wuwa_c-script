using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002778 RID: 10104
	[NullableContext(2)]
	[Nullable(0)]
	public class FadeOutScreen : ActionParams
	{
		// Token: 0x0600E0FC RID: 57596 RVA: 0x00213D63 File Offset: 0x00211F63
		[NullableContext(1)]
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

		// Token: 0x170043CE RID: 17358
		// (get) Token: 0x0600E0FD RID: 57597 RVA: 0x00213D82 File Offset: 0x00211F82
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

		// Token: 0x170043CF RID: 17359
		// (get) Token: 0x0600E0FE RID: 57598 RVA: 0x00213DB8 File Offset: 0x00211FB8
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

		// Token: 0x04007C94 RID: 31892
		private IFadeOutScreen Instance;

		// Token: 0x04007C95 RID: 31893
		private IEaseData _EaseCache;

		// Token: 0x04007C96 RID: 31894
		private bool _EaseInited;
	}
}
