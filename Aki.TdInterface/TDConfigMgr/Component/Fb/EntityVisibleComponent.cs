using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BFE RID: 3070
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityVisibleComponent : IComponentBase
	{
		// Token: 0x0600467E RID: 18046 RVA: 0x000B205F File Offset: 0x000B025F
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

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x0600467F RID: 18047 RVA: 0x000B2080 File Offset: 0x000B0280
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

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06004680 RID: 18048 RVA: 0x000B20B8 File Offset: 0x000B02B8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06004681 RID: 18049 RVA: 0x000B20CE File Offset: 0x000B02CE
		public virtual bool DelayChange
		{
			get
			{
				return this.Instance.DelayChange;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06004682 RID: 18050 RVA: 0x000B20DB File Offset: 0x000B02DB
		public virtual bool UseFadeEffect
		{
			get
			{
				return this.Instance.UseFadeEffect;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06004683 RID: 18051 RVA: 0x000B20E8 File Offset: 0x000B02E8
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

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06004684 RID: 18052 RVA: 0x000B2120 File Offset: 0x000B0320
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

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06004685 RID: 18053 RVA: 0x000B2158 File Offset: 0x000B0358
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

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x000B21C4 File Offset: 0x000B03C4
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

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06004687 RID: 18055 RVA: 0x000B21FC File Offset: 0x000B03FC
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

		// Token: 0x0400281D RID: 10269
		private IEntityVisibleComponent Instance;

		// Token: 0x0400281E RID: 10270
		private List<IVisibleConditionGroup> _VisibleConditionsCache;

		// Token: 0x0400281F RID: 10271
		private bool _VisibleConditionsInited;
	}
}
