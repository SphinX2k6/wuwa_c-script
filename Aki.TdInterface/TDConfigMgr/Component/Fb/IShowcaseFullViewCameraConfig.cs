using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EF6 RID: 3830
	public class IShowcaseFullViewCameraConfig
	{
		// Token: 0x06005635 RID: 22069 RVA: 0x000D39FA File Offset: 0x000D1BFA
		public static IShowcaseFullViewCameraConfig Create(IShowcaseFullViewCameraConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowcaseFullViewCameraConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06005636 RID: 22070 RVA: 0x000D3A19 File Offset: 0x000D1C19
		public virtual float Fov
		{
			get
			{
				return this.Instance.Fov;
			}
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06005637 RID: 22071 RVA: 0x000D3A26 File Offset: 0x000D1C26
		public virtual PosAndRot PosAndRot
		{
			get
			{
				if (this._PosAndRotInited)
				{
					return this._PosAndRotCache;
				}
				this._PosAndRotInited = true;
				this._PosAndRotCache = PosAndRot.Create(this.Instance.PosAndRot);
				return this._PosAndRotCache;
			}
		}

		// Token: 0x04003161 RID: 12641
		private IShowcaseFullViewCameraConfig Instance;

		// Token: 0x04003162 RID: 12642
		[Nullable(2)]
		private PosAndRot _PosAndRotCache;

		// Token: 0x04003163 RID: 12643
		private bool _PosAndRotInited;
	}
}
