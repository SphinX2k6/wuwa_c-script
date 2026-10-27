using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200087B RID: 2171
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleMotionInteractComponent : IComponentBase
	{
		// Token: 0x06003041 RID: 12353 RVA: 0x0007C39C File Offset: 0x0007A59C
		private RoleMotionInteractComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RoleMotionInteractComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RoleMotionInteractComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RoleMotionInteractComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x0007C3D4 File Offset: 0x0007A5D4
		public static RoleMotionInteractComponent Create([Nullable(2)] RoleMotionInteractComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoleMotionInteractComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x0007C3E7 File Offset: 0x0007A5E7
		public static RoleMotionInteractComponent CreateFromSetValue([Nullable(2)] RoleMotionInteractComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RoleMotionInteractComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x0007C3FA File Offset: 0x0007A5FA
		public new RoleMotionInteractComponent_SetValue ToSetValue()
		{
			return new RoleMotionInteractComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				MotionInteractConfig = this.MotionInteractConfig
			};
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06003045 RID: 12357 RVA: 0x0007C428 File Offset: 0x0007A628
		// (set) Token: 0x06003046 RID: 12358 RVA: 0x0007C462 File Offset: 0x0007A662
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RoleMotionInteractComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06003047 RID: 12359 RVA: 0x0007C470 File Offset: 0x0007A670
		// (set) Token: 0x06003048 RID: 12360 RVA: 0x0007C49A File Offset: 0x0007A69A
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

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06003049 RID: 12361 RVA: 0x0007C4A8 File Offset: 0x0007A6A8
		// (set) Token: 0x0600304A RID: 12362 RVA: 0x0007C509 File Offset: 0x0007A709
		public virtual IPetalGrabRoleMotionInteract MotionInteractConfig
		{
			get
			{
				if (this._MotionInteractConfigInited)
				{
					return this._MotionInteractConfigCache;
				}
				this._MotionInteractConfigInited = true;
				if (this.FbInstance != null)
				{
					this._MotionInteractConfigCache = IPetalGrabRoleMotionInteract.Create(this.FbInstance.MotionInteractConfig);
				}
				else
				{
					RoleMotionInteractComponent_SetValue pocoInterface = this.PocoInterface;
					this._MotionInteractConfigCache = ((pocoInterface != null) ? pocoInterface.MotionInteractConfig : null);
				}
				return this._MotionInteractConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().MotionInteractConfig = value;
				this._MotionInteractConfigInited = false;
			}
		}

		// Token: 0x04001FC1 RID: 8129
		[Nullable(2)]
		protected new RoleMotionInteractComponent FbInstance;

		// Token: 0x04001FC2 RID: 8130
		[Nullable(2)]
		protected new RoleMotionInteractComponent_SetValue PocoInterface;

		// Token: 0x04001FC3 RID: 8131
		private IPetalGrabRoleMotionInteract _MotionInteractConfigCache;

		// Token: 0x04001FC4 RID: 8132
		private bool _MotionInteractConfigInited;
	}
}
