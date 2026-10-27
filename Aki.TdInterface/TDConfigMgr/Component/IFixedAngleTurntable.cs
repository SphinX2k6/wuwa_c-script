using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000390 RID: 912
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedAngleTurntable : ITurntableControlType
	{
		// Token: 0x06001215 RID: 4629 RVA: 0x0003C0D4 File Offset: 0x0003A2D4
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

		// Token: 0x06001216 RID: 4630 RVA: 0x0003C10C File Offset: 0x0003A30C
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

		// Token: 0x06001217 RID: 4631 RVA: 0x0003C11F File Offset: 0x0003A31F
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

		// Token: 0x06001218 RID: 4632 RVA: 0x0003C132 File Offset: 0x0003A332
		public new IFixedAngleTurntable_SetValue ToSetValue()
		{
			return new IFixedAngleTurntable_SetValue
			{
				Type = this.Type,
				RotationSpeed = this.RotationSpeed,
				ItemConfig = this.ItemConfig
			};
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x0003C15D File Offset: 0x0003A35D
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x0003C188 File Offset: 0x0003A388
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

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0003C196 File Offset: 0x0003A396
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x0003C1C1 File Offset: 0x0003A3C1
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

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x0003C1D0 File Offset: 0x0003A3D0
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x0003C263 File Offset: 0x0003A463
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

		// Token: 0x04000EA1 RID: 3745
		[Nullable(2)]
		protected new IFixedAngleTurntable FbInstance;

		// Token: 0x04000EA2 RID: 3746
		[Nullable(2)]
		protected new IFixedAngleTurntable_SetValue PocoInterface;

		// Token: 0x04000EA3 RID: 3747
		private List<IFixedAngleItem> _ItemConfigCache;

		// Token: 0x04000EA4 RID: 3748
		private bool _ItemConfigInited;
	}
}
