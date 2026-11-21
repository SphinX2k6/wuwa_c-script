using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003D9 RID: 985
	public class IFixedAngleTurntable : ITurntableControlType
	{
		// Token: 0x06001359 RID: 4953 RVA: 0x0003F3B8 File Offset: 0x0003D5B8
		private IFixedAngleTurntable_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixedAngleTurntable 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixedAngleTurntable_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixedAngleTurntable_SetValue());
			}
			return result;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0003F3F0 File Offset: 0x0003D5F0
		public static IFixedAngleTurntable Create([Nullable(2)] IFixedAngleTurntable instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedAngleTurntable
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0003F403 File Offset: 0x0003D603
		public static IFixedAngleTurntable CreateFromSetValue([Nullable(2)] IFixedAngleTurntable_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixedAngleTurntable
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0003F416 File Offset: 0x0003D616
		public new IFixedAngleTurntable_SetValue ToSetValue()
		{
			return new IFixedAngleTurntable_SetValue
			{
				Type = this.Type,
				RotationSpeed = this.RotationSpeed,
				ItemConfig = this.ItemConfig
			};
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x0003F441 File Offset: 0x0003D641
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x0003F46C File Offset: 0x0003D66C
		public override EControllerType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EControllerType.FreeAngle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x0003F47A File Offset: 0x0003D67A
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x0003F4A5 File Offset: 0x0003D6A5
		public override int RotationSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotationSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RotationSpeed;
			}
			set
			{
				this.GetOrCreatePoco().RotationSpeed = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x0003F4B4 File Offset: 0x0003D6B4
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x0003F547 File Offset: 0x0003D747
		public virtual List<IFixedAngleItem> ItemConfig
		{
			get
			{
				if (this._ItemConfigInited)
				{
					return this._ItemConfigCache;
				}
				this._ItemConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IFixedAngleItem> itemConfig = this.FbInstance.ItemConfig;
					if (itemConfig != null)
					{
						this._ItemConfigCache = new List<IFixedAngleItem>(itemConfig.Count);
						for (int i = 0; i < itemConfig.Count; i++)
						{
							this._ItemConfigCache.Add(IFixedAngleItem.Create(itemConfig[i]));
						}
					}
				}
				else
				{
					IFixedAngleTurntable_SetValue pocoInterface = this.PocoInterface;
					this._ItemConfigCache = ((pocoInterface != null) ? pocoInterface.ItemConfig : null);
				}
				return this._ItemConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().ItemConfig = value;
				this._ItemConfigInited = false;
			}
		}

		// Token: 0x04000F98 RID: 3992
		[Nullable(2)]
		protected new IFixedAngleTurntable FbInstance;

		// Token: 0x04000F99 RID: 3993
		[Nullable(2)]
		protected new IFixedAngleTurntable_SetValue PocoInterface;

		// Token: 0x04000F9A RID: 3994
		private List<IFixedAngleItem> _ItemConfigCache;

		// Token: 0x04000F9B RID: 3995
		private bool _ItemConfigInited;
	}
}
