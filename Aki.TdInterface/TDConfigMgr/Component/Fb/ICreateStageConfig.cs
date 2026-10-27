using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE7 RID: 3047
	[NullableContext(2)]
	[Nullable(0)]
	public class ICreateStageConfig : ILifeStageConfig
	{
		// Token: 0x060045F7 RID: 17911 RVA: 0x000B0D9F File Offset: 0x000AEF9F
		[NullableContext(1)]
		public static ICreateStageConfig Create(ICreateStageConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreateStageConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x060045F8 RID: 17912 RVA: 0x000B0DC0 File Offset: 0x000AEFC0
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

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x060045F9 RID: 17913 RVA: 0x000B0DF6 File Offset: 0x000AEFF6
		public virtual ICreateBulletConfig BulletConfig
		{
			get
			{
				if (this._BulletConfigInited)
				{
					return this._BulletConfigCache;
				}
				this._BulletConfigInited = true;
				this._BulletConfigCache = ICreateBulletConfig.Create(this.Instance.BulletConfig);
				return this._BulletConfigCache;
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x000B0E2C File Offset: 0x000AF02C
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
				if ((this.Instance.NullMask & 2) == 0)
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

		// Token: 0x040027D2 RID: 10194
		private ICreateStageConfig Instance;

		// Token: 0x040027D3 RID: 10195
		private ICreateBulletConfig _BulletConfigCache;

		// Token: 0x040027D4 RID: 10196
		private bool _BulletConfigInited;

		// Token: 0x040027D5 RID: 10197
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040027D6 RID: 10198
		private bool _ActionsInited;
	}
}
