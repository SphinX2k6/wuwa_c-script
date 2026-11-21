using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB7 RID: 3255
	public class IDestroyStageConfig : ILifeStageConfig
	{
		// Token: 0x06004A5A RID: 19034 RVA: 0x000BB02A File Offset: 0x000B922A
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

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06004A5B RID: 19035 RVA: 0x000BB04C File Offset: 0x000B924C
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

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06004A5C RID: 19036 RVA: 0x000BB084 File Offset: 0x000B9284
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

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06004A5D RID: 19037 RVA: 0x000BB0BC File Offset: 0x000B92BC
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

		// Token: 0x04002A22 RID: 10786
		private IDestroyStageConfig Instance;

		// Token: 0x04002A23 RID: 10787
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002A24 RID: 10788
		private bool _ActionsInited;
	}
}
