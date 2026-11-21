using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D01 RID: 7425
	public class IInteractPoint
	{
		// Token: 0x06009DAB RID: 40363 RVA: 0x0016AFA4 File Offset: 0x001691A4
		private IInteractPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06009DAC RID: 40364 RVA: 0x0016AFDC File Offset: 0x001691DC
		public static IInteractPoint Create([Nullable(2)] IInteractPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DAD RID: 40365 RVA: 0x0016AFEF File Offset: 0x001691EF
		public static IInteractPoint CreateFromSetValue([Nullable(2)] IInteractPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DAE RID: 40366 RVA: 0x0016B004 File Offset: 0x00169204
		public IInteractPoint_SetValue ToSetValue()
		{
			return new IInteractPoint_SetValue
			{
				Tag = this.Tag,
				InteractEffects = this.InteractEffects,
				IsValidPoint = this.IsValidPoint,
				ProtectTime = this.ProtectTime,
				CancelRaycast = this.CancelRaycast,
				InteractionConfig = this.InteractionConfig
			};
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x06009DAF RID: 40367 RVA: 0x0016B05E File Offset: 0x0016925E
		// (set) Token: 0x06009DB0 RID: 40368 RVA: 0x0016B089 File Offset: 0x00169289
		public virtual int Tag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Tag;
			}
			set
			{
				this.GetOrCreatePoco().Tag = value;
			}
		}

		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x06009DB1 RID: 40369 RVA: 0x0016B097 File Offset: 0x00169297
		// (set) Token: 0x06009DB2 RID: 40370 RVA: 0x0016B0BE File Offset: 0x001692BE
		public virtual List<IInteractEffect> InteractEffects
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InteractEffects;
				}
				IInteractPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InteractEffects;
			}
			set
			{
				this.GetOrCreatePoco().InteractEffects = value;
			}
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x06009DB3 RID: 40371 RVA: 0x0016B0CC File Offset: 0x001692CC
		// (set) Token: 0x06009DB4 RID: 40372 RVA: 0x0016B0F7 File Offset: 0x001692F7
		public virtual bool IsValidPoint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsValidPoint;
				}
				return this.PocoInterface != null && this.PocoInterface.IsValidPoint;
			}
			set
			{
				this.GetOrCreatePoco().IsValidPoint = value;
			}
		}

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x06009DB5 RID: 40373 RVA: 0x0016B108 File Offset: 0x00169308
		// (set) Token: 0x06009DB6 RID: 40374 RVA: 0x0016B142 File Offset: 0x00169342
		public virtual float? ProtectTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProtectTime;
				}
				IInteractPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProtectTime;
			}
			set
			{
				this.GetOrCreatePoco().ProtectTime = value;
			}
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x06009DB7 RID: 40375 RVA: 0x0016B150 File Offset: 0x00169350
		// (set) Token: 0x06009DB8 RID: 40376 RVA: 0x0016B18A File Offset: 0x0016938A
		public virtual bool? CancelRaycast
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CancelRaycast;
				}
				IInteractPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CancelRaycast;
			}
			set
			{
				this.GetOrCreatePoco().CancelRaycast = value;
			}
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x06009DB9 RID: 40377 RVA: 0x0016B198 File Offset: 0x00169398
		// (set) Token: 0x06009DBA RID: 40378 RVA: 0x0016B1F9 File Offset: 0x001693F9
		[Nullable(2)]
		public virtual IDragInteractPointInteraction InteractionConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._InteractionConfigInited)
				{
					return this._InteractionConfigCache;
				}
				this._InteractionConfigInited = true;
				if (this.FbInstance != null)
				{
					this._InteractionConfigCache = IDragInteractPointInteraction.Create(this.FbInstance.InteractionConfig);
				}
				else
				{
					IInteractPoint_SetValue pocoInterface = this.PocoInterface;
					this._InteractionConfigCache = ((pocoInterface != null) ? pocoInterface.InteractionConfig : null);
				}
				return this._InteractionConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().InteractionConfig = value;
				this._InteractionConfigInited = false;
			}
		}

		// Token: 0x04006041 RID: 24641
		[Nullable(2)]
		protected IInteractPoint FbInstance;

		// Token: 0x04006042 RID: 24642
		[Nullable(2)]
		protected IInteractPoint_SetValue PocoInterface;

		// Token: 0x04006043 RID: 24643
		private IDragInteractPointInteraction _InteractionConfigCache;

		// Token: 0x04006044 RID: 24644
		private bool _InteractionConfigInited;
	}
}
