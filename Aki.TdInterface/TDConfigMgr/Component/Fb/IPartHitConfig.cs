using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B8D RID: 2957
	[NullableContext(1)]
	[Nullable(0)]
	public class IPartHitConfig
	{
		// Token: 0x060043FC RID: 17404 RVA: 0x000ACE91 File Offset: 0x000AB091
		public static IPartHitConfig Create(IPartHitConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPartHitConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x060043FD RID: 17405 RVA: 0x000ACEB0 File Offset: 0x000AB0B0
		public virtual string PartName
		{
			get
			{
				return this.Instance.PartName;
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x060043FE RID: 17406 RVA: 0x000ACEBD File Offset: 0x000AB0BD
		public virtual IHitBulletType HitBullets
		{
			get
			{
				if (this._HitBulletsInited)
				{
					return this._HitBulletsCache;
				}
				this._HitBulletsInited = true;
				this._HitBulletsCache = ComponentReadHelper.ReadIPartHitConfig_HitBullets(this.Instance);
				return this._HitBulletsCache;
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x060043FF RID: 17407 RVA: 0x000ACEEC File Offset: 0x000AB0EC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x04002658 RID: 9816
		private IPartHitConfig Instance;

		// Token: 0x04002659 RID: 9817
		private IHitBulletType _HitBulletsCache;

		// Token: 0x0400265A RID: 9818
		private bool _HitBulletsInited;

		// Token: 0x0400265B RID: 9819
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x0400265C RID: 9820
		private bool _ActionsInited;
	}
}
