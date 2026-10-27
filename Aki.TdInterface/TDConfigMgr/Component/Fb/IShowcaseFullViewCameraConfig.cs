using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFA RID: 3578
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowcaseFullViewCameraConfig
	{
		// Token: 0x0600510E RID: 20750 RVA: 0x000C8132 File Offset: 0x000C6332
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

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x0600510F RID: 20751 RVA: 0x000C8151 File Offset: 0x000C6351
		public virtual float Fov
		{
			get
			{
				return this.Instance.Fov;
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x000C815E File Offset: 0x000C635E
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

		// Token: 0x04002E99 RID: 11929
		private IShowcaseFullViewCameraConfig Instance;

		// Token: 0x04002E9A RID: 11930
		[Nullable(2)]
		private PosAndRot _PosAndRotCache;

		// Token: 0x04002E9B RID: 11931
		private bool _PosAndRotInited;
	}
}
