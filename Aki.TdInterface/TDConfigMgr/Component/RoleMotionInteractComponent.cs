using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200091E RID: 2334
	public class RoleMotionInteractComponent : IComponentBase
	{
		// Token: 0x0600337D RID: 13181 RVA: 0x00083884 File Offset: 0x00081A84
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

		// Token: 0x0600337E RID: 13182 RVA: 0x000838BC File Offset: 0x00081ABC
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

		// Token: 0x0600337F RID: 13183 RVA: 0x000838CF File Offset: 0x00081ACF
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

		// Token: 0x06003380 RID: 13184 RVA: 0x000838E2 File Offset: 0x00081AE2
		public new RoleMotionInteractComponent_SetValue ToSetValue()
		{
			return new RoleMotionInteractComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				MotionInteractConfig = this.MotionInteractConfig
			};
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06003381 RID: 13185 RVA: 0x00083910 File Offset: 0x00081B10
		// (set) Token: 0x06003382 RID: 13186 RVA: 0x0008394A File Offset: 0x00081B4A
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

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06003383 RID: 13187 RVA: 0x00083958 File Offset: 0x00081B58
		// (set) Token: 0x06003384 RID: 13188 RVA: 0x00083982 File Offset: 0x00081B82
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

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06003385 RID: 13189 RVA: 0x00083990 File Offset: 0x00081B90
		// (set) Token: 0x06003386 RID: 13190 RVA: 0x000839F1 File Offset: 0x00081BF1
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

		// Token: 0x040021D3 RID: 8659
		[Nullable(2)]
		protected new RoleMotionInteractComponent FbInstance;

		// Token: 0x040021D4 RID: 8660
		[Nullable(2)]
		protected new RoleMotionInteractComponent_SetValue PocoInterface;

		// Token: 0x040021D5 RID: 8661
		private IPetalGrabRoleMotionInteract _MotionInteractConfigCache;

		// Token: 0x040021D6 RID: 8662
		private bool _MotionInteractConfigInited;
	}
}
