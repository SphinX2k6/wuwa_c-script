using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB6 RID: 3254
	[NullableContext(2)]
	[Nullable(0)]
	public class ICreateStageConfig : ILifeStageConfig
	{
		// Token: 0x06004A55 RID: 19029 RVA: 0x000BAF1B File Offset: 0x000B911B
		[NullableContext(0)]
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

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06004A56 RID: 19030 RVA: 0x000BAF3C File Offset: 0x000B913C
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

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06004A57 RID: 19031 RVA: 0x000BAF72 File Offset: 0x000B9172
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

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06004A58 RID: 19032 RVA: 0x000BAFA8 File Offset: 0x000B91A8
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

		// Token: 0x04002A1D RID: 10781
		private ICreateStageConfig Instance;

		// Token: 0x04002A1E RID: 10782
		private ICreateBulletConfig _BulletConfigCache;

		// Token: 0x04002A1F RID: 10783
		private bool _BulletConfigInited;

		// Token: 0x04002A20 RID: 10784
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002A21 RID: 10785
		private bool _ActionsInited;
	}
}
