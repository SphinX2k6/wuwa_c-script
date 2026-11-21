using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C5B RID: 3163
	public class IPartHitConfig
	{
		// Token: 0x06004855 RID: 18517 RVA: 0x000B6F55 File Offset: 0x000B5155
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

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06004856 RID: 18518 RVA: 0x000B6F74 File Offset: 0x000B5174
		public virtual string PartName
		{
			get
			{
				return this.Instance.PartName;
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x000B6F81 File Offset: 0x000B5181
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

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x000B6FB0 File Offset: 0x000B51B0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x040028A0 RID: 10400
		private IPartHitConfig Instance;

		// Token: 0x040028A1 RID: 10401
		private IHitBulletType _HitBulletsCache;

		// Token: 0x040028A2 RID: 10402
		private bool _HitBulletsInited;

		// Token: 0x040028A3 RID: 10403
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040028A4 RID: 10404
		private bool _ActionsInited;
	}
}
