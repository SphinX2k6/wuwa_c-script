using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000107 RID: 263
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityVisibleComponent : IComponentBase
	{
		// Token: 0x0600045A RID: 1114 RVA: 0x0001DF00 File Offset: 0x0001C100
		private EntityVisibleComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EntityVisibleComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EntityVisibleComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EntityVisibleComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001DF38 File Offset: 0x0001C138
		public static EntityVisibleComponent Create([Nullable(2)] EntityVisibleComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityVisibleComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001DF4B File Offset: 0x0001C14B
		public static EntityVisibleComponent CreateFromSetValue([Nullable(2)] EntityVisibleComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EntityVisibleComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001DF60 File Offset: 0x0001C160
		public new EntityVisibleComponent_SetValue ToSetValue()
		{
			return new EntityVisibleComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				DelayChange = this.DelayChange,
				UseFadeEffect = this.UseFadeEffect,
				UseCutEffect = this.UseCutEffect,
				UseHolographicEffect = this.UseHolographicEffect,
				VisibleConditions = this.VisibleConditions,
				CustomVisibleRange = this.CustomVisibleRange,
				TargetPlatform = this.TargetPlatform
			};
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0001DFE0 File Offset: 0x0001C1E0
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x0001E01A File Offset: 0x0001C21A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				EntityVisibleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0001E028 File Offset: 0x0001C228
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x0001E052 File Offset: 0x0001C252
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0001E060 File Offset: 0x0001C260
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x0001E08B File Offset: 0x0001C28B
		public virtual bool DelayChange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayChange;
				}
				return this.PocoInterface != null && this.PocoInterface.DelayChange;
			}
			set
			{
				this.GetOrCreatePoco().DelayChange = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0001E099 File Offset: 0x0001C299
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x0001E0C4 File Offset: 0x0001C2C4
		public virtual bool UseFadeEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseFadeEffect;
				}
				return this.PocoInterface != null && this.PocoInterface.UseFadeEffect;
			}
			set
			{
				this.GetOrCreatePoco().UseFadeEffect = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0001E0D4 File Offset: 0x0001C2D4
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x0001E10E File Offset: 0x0001C30E
		public virtual bool? UseCutEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseCutEffect;
				}
				EntityVisibleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseCutEffect;
			}
			set
			{
				this.GetOrCreatePoco().UseCutEffect = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001E11C File Offset: 0x0001C31C
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0001E156 File Offset: 0x0001C356
		public virtual bool? UseHolographicEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseHolographicEffect;
				}
				EntityVisibleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseHolographicEffect;
			}
			set
			{
				this.GetOrCreatePoco().UseHolographicEffect = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0001E164 File Offset: 0x0001C364
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0001E1F7 File Offset: 0x0001C3F7
		public virtual List<IVisibleConditionGroup> VisibleConditions
		{
			get
			{
				if (this._VisibleConditionsInited)
				{
					return this._VisibleConditionsCache;
				}
				this._VisibleConditionsInited = true;
				if (this.FbInstance != null)
				{
					List<IVisibleConditionGroup> visibleConditions = this.FbInstance.VisibleConditions;
					if (visibleConditions != null)
					{
						this._VisibleConditionsCache = new List<IVisibleConditionGroup>(visibleConditions.Count);
						for (int i = 0; i < visibleConditions.Count; i++)
						{
							this._VisibleConditionsCache.Add(IVisibleConditionGroup.Create(visibleConditions[i]));
						}
					}
				}
				else
				{
					EntityVisibleComponent_SetValue pocoInterface = this.PocoInterface;
					this._VisibleConditionsCache = ((pocoInterface != null) ? pocoInterface.VisibleConditions : null);
				}
				return this._VisibleConditionsCache;
			}
			set
			{
				this.GetOrCreatePoco().VisibleConditions = value;
				this._VisibleConditionsInited = false;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0001E20C File Offset: 0x0001C40C
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0001E246 File Offset: 0x0001C446
		public virtual int? CustomVisibleRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CustomVisibleRange;
				}
				EntityVisibleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CustomVisibleRange;
			}
			set
			{
				this.GetOrCreatePoco().CustomVisibleRange = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001E254 File Offset: 0x0001C454
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x0001E28E File Offset: 0x0001C48E
		public virtual ERuntimePlatformOptions? TargetPlatform
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetPlatform;
				}
				EntityVisibleComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetPlatform;
			}
			set
			{
				this.GetOrCreatePoco().TargetPlatform = value;
			}
		}

		// Token: 0x0400057F RID: 1407
		[Nullable(2)]
		protected new EntityVisibleComponent FbInstance;

		// Token: 0x04000580 RID: 1408
		[Nullable(2)]
		protected new EntityVisibleComponent_SetValue PocoInterface;

		// Token: 0x04000581 RID: 1409
		private List<IVisibleConditionGroup> _VisibleConditionsCache;

		// Token: 0x04000582 RID: 1410
		private bool _VisibleConditionsInited;
	}
}
