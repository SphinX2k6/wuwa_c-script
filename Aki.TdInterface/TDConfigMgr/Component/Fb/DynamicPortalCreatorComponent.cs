using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFD RID: 3581
	public class DynamicPortalCreatorComponent : IComponentBase
	{
		// Token: 0x06005125 RID: 20773 RVA: 0x000C90A6 File Offset: 0x000C72A6
		public static DynamicPortalCreatorComponent Create(IDynamicPortalCreatorComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicPortalCreatorComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x000C90C8 File Offset: 0x000C72C8
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

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x06005127 RID: 20775 RVA: 0x000C9100 File Offset: 0x000C7300
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x000C9116 File Offset: 0x000C7316
		public virtual IDynamicPortalByBullet Model
		{
			get
			{
				if (this._ModelInited)
				{
					return this._ModelCache;
				}
				this._ModelInited = true;
				this._ModelCache = IDynamicPortalByBullet.Create(this.Instance.Model);
				return this._ModelCache;
			}
		}

		// Token: 0x04002E40 RID: 11840
		private IDynamicPortalCreatorComponent Instance;

		// Token: 0x04002E41 RID: 11841
		[Nullable(2)]
		private IDynamicPortalByBullet _ModelCache;

		// Token: 0x04002E42 RID: 11842
		private bool _ModelInited;
	}
}
