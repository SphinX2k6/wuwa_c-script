using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CCE RID: 3278
	public class EntityVisibleComponent : IComponentBase
	{
		// Token: 0x06004AE1 RID: 19169 RVA: 0x000BC22B File Offset: 0x000BA42B
		public static EntityVisibleComponent Create(IEntityVisibleComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityVisibleComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x000BC24C File Offset: 0x000BA44C
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

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06004AE3 RID: 19171 RVA: 0x000BC284 File Offset: 0x000BA484
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06004AE4 RID: 19172 RVA: 0x000BC29A File Offset: 0x000BA49A
		public virtual bool DelayChange
		{
			get
			{
				return this.Instance.DelayChange;
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06004AE5 RID: 19173 RVA: 0x000BC2A7 File Offset: 0x000BA4A7
		public virtual bool UseFadeEffect
		{
			get
			{
				return this.Instance.UseFadeEffect;
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x06004AE6 RID: 19174 RVA: 0x000BC2B4 File Offset: 0x000BA4B4
		public virtual bool? UseCutEffect
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseCutEffect);
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x000BC2EC File Offset: 0x000BA4EC
		public virtual bool? UseHolographicEffect
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseHolographicEffect);
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x06004AE8 RID: 19176 RVA: 0x000BC324 File Offset: 0x000BA524
		public virtual List<IVisibleConditionGroup> VisibleConditions
		{
			get
			{
				if (this._VisibleConditionsInited)
				{
					return this._VisibleConditionsCache;
				}
				this._VisibleConditionsInited = true;
				int visibleConditionsLength = this.Instance.VisibleConditionsLength;
				this._VisibleConditionsCache = new List<IVisibleConditionGroup>(visibleConditionsLength);
				for (int i = 0; i < visibleConditionsLength; i++)
				{
					this._VisibleConditionsCache.Add(IVisibleConditionGroup.Create(this.Instance.VisibleConditions(i)));
				}
				return this._VisibleConditionsCache;
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x06004AE9 RID: 19177 RVA: 0x000BC390 File Offset: 0x000BA590
		public virtual int? CustomVisibleRange
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.CustomVisibleRange);
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06004AEA RID: 19178 RVA: 0x000BC3C8 File Offset: 0x000BA5C8
		public virtual ERuntimePlatformOptions? TargetPlatform
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new ERuntimePlatformOptions?((ERuntimePlatformOptions)this.Instance.TargetPlatform);
			}
		}

		// Token: 0x04002A69 RID: 10857
		private IEntityVisibleComponent Instance;

		// Token: 0x04002A6A RID: 10858
		private List<IVisibleConditionGroup> _VisibleConditionsCache;

		// Token: 0x04002A6B RID: 10859
		private bool _VisibleConditionsInited;
	}
}
