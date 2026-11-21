using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E07 RID: 3591
	public class EffectAreaComponent : IComponentBase
	{
		// Token: 0x0600515E RID: 20830 RVA: 0x000C9881 File Offset: 0x000C7A81
		public static EffectAreaComponent Create(IEffectAreaComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EffectAreaComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x0600515F RID: 20831 RVA: 0x000C98A0 File Offset: 0x000C7AA0
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

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x06005160 RID: 20832 RVA: 0x000C98D8 File Offset: 0x000C7AD8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06005161 RID: 20833 RVA: 0x000C98EE File Offset: 0x000C7AEE
		public virtual IBuffArea Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = IBuffArea.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x04002E6A RID: 11882
		private IEffectAreaComponent Instance;

		// Token: 0x04002E6B RID: 11883
		[Nullable(2)]
		private IBuffArea _ConfigCache;

		// Token: 0x04002E6C RID: 11884
		private bool _ConfigInited;
	}
}
