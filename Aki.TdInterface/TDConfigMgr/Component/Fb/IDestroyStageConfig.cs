using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE8 RID: 3048
	public class IDestroyStageConfig : ILifeStageConfig
	{
		// Token: 0x060045FC RID: 17916 RVA: 0x000B0EAE File Offset: 0x000AF0AE
		[NullableContext(1)]
		public static IDestroyStageConfig Create(IDestroyStageConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyStageConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x060045FD RID: 17917 RVA: 0x000B0ED0 File Offset: 0x000AF0D0
		public override float? PerformDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.PerformDuration);
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x060045FE RID: 17918 RVA: 0x000B0F08 File Offset: 0x000AF108
		public virtual long? BulletId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new long?(this.Instance.BulletId);
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x060045FF RID: 17919 RVA: 0x000B0F40 File Offset: 0x000AF140
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
				if ((this.Instance.NullMask & 4) == 0)
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

		// Token: 0x040027D7 RID: 10199
		private IDestroyStageConfig Instance;

		// Token: 0x040027D8 RID: 10200
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040027D9 RID: 10201
		private bool _ActionsInited;
	}
}
