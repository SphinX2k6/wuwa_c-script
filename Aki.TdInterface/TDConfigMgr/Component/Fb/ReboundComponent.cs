using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C87 RID: 3207
	[NullableContext(1)]
	[Nullable(0)]
	public class ReboundComponent : IComponentBase
	{
		// Token: 0x06004963 RID: 18787 RVA: 0x000B8001 File Offset: 0x000B6201
		public static ReboundComponent Create(IReboundComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReboundComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06004964 RID: 18788 RVA: 0x000B8020 File Offset: 0x000B6220
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

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x000B8058 File Offset: 0x000B6258
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06004966 RID: 18790 RVA: 0x000B806E File Offset: 0x000B626E
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06004967 RID: 18791 RVA: 0x000B807B File Offset: 0x000B627B
		public virtual IForwardFrontRebound Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = IForwardFrontRebound.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x040029DC RID: 10716
		private IReboundComponent Instance;

		// Token: 0x040029DD RID: 10717
		[Nullable(2)]
		private IForwardFrontRebound _OptionCache;

		// Token: 0x040029DE RID: 10718
		private bool _OptionInited;
	}
}
