using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E8E RID: 3726
	public class WindSourceComponent : IComponentBase
	{
		// Token: 0x06005424 RID: 21540 RVA: 0x000CF671 File Offset: 0x000CD871
		public static WindSourceComponent Create(IWindSourceComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WindSourceComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06005425 RID: 21541 RVA: 0x000CF690 File Offset: 0x000CD890
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

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06005426 RID: 21542 RVA: 0x000CF6C8 File Offset: 0x000CD8C8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x06005427 RID: 21543 RVA: 0x000CF6DE File Offset: 0x000CD8DE
		public virtual IWindDirectional WindSource
		{
			get
			{
				if (this._WindSourceInited)
				{
					return this._WindSourceCache;
				}
				this._WindSourceInited = true;
				this._WindSourceCache = IWindDirectional.Create(this.Instance.WindSource);
				return this._WindSourceCache;
			}
		}

		// Token: 0x0400302F RID: 12335
		private IWindSourceComponent Instance;

		// Token: 0x04003030 RID: 12336
		[Nullable(2)]
		private IWindDirectional _WindSourceCache;

		// Token: 0x04003031 RID: 12337
		private bool _WindSourceInited;
	}
}
