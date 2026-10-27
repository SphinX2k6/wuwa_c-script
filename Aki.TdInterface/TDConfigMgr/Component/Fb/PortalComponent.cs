using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D00 RID: 3328
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalComponent : IComponentBase
	{
		// Token: 0x06004BF9 RID: 19449 RVA: 0x000BD7CB File Offset: 0x000BB9CB
		public static PortalComponent Create(IPortalComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PortalComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06004BFA RID: 19450 RVA: 0x000BD7EC File Offset: 0x000BB9EC
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06004BFB RID: 19451 RVA: 0x000BD824 File Offset: 0x000BBA24
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06004BFC RID: 19452 RVA: 0x000BD83A File Offset: 0x000BBA3A
		public virtual IPortalMode Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ComponentReadHelper.ReadPortalComponent_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04002B6F RID: 11119
		private IPortalComponent Instance;

		// Token: 0x04002B70 RID: 11120
		private IPortalMode _ConfigCache;

		// Token: 0x04002B71 RID: 11121
		private bool _ConfigInited;
	}
}
