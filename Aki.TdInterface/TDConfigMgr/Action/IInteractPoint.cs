using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B52 RID: 6994
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractPoint
	{
		// Token: 0x060095BF RID: 38335 RVA: 0x0015A288 File Offset: 0x00158488
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

		// Token: 0x060095C0 RID: 38336 RVA: 0x0015A2C0 File Offset: 0x001584C0
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

		// Token: 0x060095C1 RID: 38337 RVA: 0x0015A2D3 File Offset: 0x001584D3
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

		// Token: 0x060095C2 RID: 38338 RVA: 0x0015A2E8 File Offset: 0x001584E8
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

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x060095C3 RID: 38339 RVA: 0x0015A342 File Offset: 0x00158542
		// (set) Token: 0x060095C4 RID: 38340 RVA: 0x0015A36D File Offset: 0x0015856D
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

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x060095C5 RID: 38341 RVA: 0x0015A37B File Offset: 0x0015857B
		// (set) Token: 0x060095C6 RID: 38342 RVA: 0x0015A3A2 File Offset: 0x001585A2
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

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x060095C7 RID: 38343 RVA: 0x0015A3B0 File Offset: 0x001585B0
		// (set) Token: 0x060095C8 RID: 38344 RVA: 0x0015A3DB File Offset: 0x001585DB
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

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x060095C9 RID: 38345 RVA: 0x0015A3EC File Offset: 0x001585EC
		// (set) Token: 0x060095CA RID: 38346 RVA: 0x0015A426 File Offset: 0x00158626
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

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x060095CB RID: 38347 RVA: 0x0015A434 File Offset: 0x00158634
		// (set) Token: 0x060095CC RID: 38348 RVA: 0x0015A46E File Offset: 0x0015866E
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

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x060095CD RID: 38349 RVA: 0x0015A47C File Offset: 0x0015867C
		// (set) Token: 0x060095CE RID: 38350 RVA: 0x0015A4DD File Offset: 0x001586DD
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

		// Token: 0x04005BA2 RID: 23458
		[Nullable(2)]
		protected IInteractPoint FbInstance;

		// Token: 0x04005BA3 RID: 23459
		[Nullable(2)]
		protected IInteractPoint_SetValue PocoInterface;

		// Token: 0x04005BA4 RID: 23460
		private IDragInteractPointInteraction _InteractionConfigCache;

		// Token: 0x04005BA5 RID: 23461
		private bool _InteractionConfigInited;
	}
}
