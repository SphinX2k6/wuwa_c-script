using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F5C RID: 3932
	public class TurntableConnectorComponent : IComponentBase
	{
		// Token: 0x0600581D RID: 22557 RVA: 0x000D76D6 File Offset: 0x000D58D6
		public static TurntableConnectorComponent Create(ITurntableConnectorComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TurntableConnectorComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x0600581E RID: 22558 RVA: 0x000D76F8 File Offset: 0x000D58F8
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

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x0600581F RID: 22559 RVA: 0x000D7730 File Offset: 0x000D5930
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06005820 RID: 22560 RVA: 0x000D7746 File Offset: 0x000D5946
		public virtual ICircuitConnect Gameplay
		{
			get
			{
				if (this._GameplayInited)
				{
					return this._GameplayCache;
				}
				this._GameplayInited = true;
				this._GameplayCache = ICircuitConnect.Create(this.Instance.Gameplay);
				return this._GameplayCache;
			}
		}

		// Token: 0x04003297 RID: 12951
		private ITurntableConnectorComponent Instance;

		// Token: 0x04003298 RID: 12952
		[Nullable(2)]
		private ICircuitConnect _GameplayCache;

		// Token: 0x04003299 RID: 12953
		private bool _GameplayInited;
	}
}
