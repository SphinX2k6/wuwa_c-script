using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B4F RID: 2895
	[NullableContext(1)]
	[Nullable(0)]
	public class IThrowCfg
	{
		// Token: 0x060042B4 RID: 17076 RVA: 0x000AA4C6 File Offset: 0x000A86C6
		public static IThrowCfg Create(IThrowCfg? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowCfg
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x060042B5 RID: 17077 RVA: 0x000AA4E5 File Offset: 0x000A86E5
		public virtual IThrowMotion MotionConfig
		{
			get
			{
				if (this._MotionConfigInited)
				{
					return this._MotionConfigCache;
				}
				this._MotionConfigInited = true;
				this._MotionConfigCache = ComponentReadHelper.ReadIThrowCfg_MotionConfig(this.Instance);
				return this._MotionConfigCache;
			}
		}

		// Token: 0x04002590 RID: 9616
		private IThrowCfg Instance;

		// Token: 0x04002591 RID: 9617
		private IThrowMotion _MotionConfigCache;

		// Token: 0x04002592 RID: 9618
		private bool _MotionConfigInited;
	}
}
