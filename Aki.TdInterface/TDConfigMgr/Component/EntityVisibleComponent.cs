using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000110 RID: 272
	public class EntityVisibleComponent : IComponentBase
	{
		// Token: 0x0600045E RID: 1118 RVA: 0x0001E874 File Offset: 0x0001CA74
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

		// Token: 0x0600045F RID: 1119 RVA: 0x0001E8AC File Offset: 0x0001CAAC
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

		// Token: 0x06000460 RID: 1120 RVA: 0x0001E8BF File Offset: 0x0001CABF
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

		// Token: 0x06000461 RID: 1121 RVA: 0x0001E8D4 File Offset: 0x0001CAD4
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

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0001E954 File Offset: 0x0001CB54
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x0001E98E File Offset: 0x0001CB8E
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

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0001E99C File Offset: 0x0001CB9C
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x0001E9C6 File Offset: 0x0001CBC6
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0001E9D4 File Offset: 0x0001CBD4
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x0001E9FF File Offset: 0x0001CBFF
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001EA0D File Offset: 0x0001CC0D
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0001EA38 File Offset: 0x0001CC38
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

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0001EA48 File Offset: 0x0001CC48
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0001EA82 File Offset: 0x0001CC82
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

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0001EA90 File Offset: 0x0001CC90
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0001EACA File Offset: 0x0001CCCA
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

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001EAD8 File Offset: 0x0001CCD8
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x0001EB6B File Offset: 0x0001CD6B
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

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0001EB80 File Offset: 0x0001CD80
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0001EBBA File Offset: 0x0001CDBA
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

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0001EBC8 File Offset: 0x0001CDC8
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x0001EC02 File Offset: 0x0001CE02
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

		// Token: 0x040005A9 RID: 1449
		[Nullable(2)]
		protected new EntityVisibleComponent FbInstance;

		// Token: 0x040005AA RID: 1450
		[Nullable(2)]
		protected new EntityVisibleComponent_SetValue PocoInterface;

		// Token: 0x040005AB RID: 1451
		private List<IVisibleConditionGroup> _VisibleConditionsCache;

		// Token: 0x040005AC RID: 1452
		private bool _VisibleConditionsInited;
	}
}
