using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003C8 RID: 968
	[NullableContext(1)]
	[Nullable(0)]
	public class IFreeAngleTurntable : ITurntableControlType
	{
		// Token: 0x06001365 RID: 4965 RVA: 0x0003F124 File Offset: 0x0003D324
		private IFreeAngleTurntable_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFreeAngleTurntable 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFreeAngleTurntable_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFreeAngleTurntable_SetValue());
			}
			return result;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0003F15C File Offset: 0x0003D35C
		public static IFreeAngleTurntable Create([Nullable(2)] IFreeAngleTurntable instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFreeAngleTurntable
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0003F16F File Offset: 0x0003D36F
		public static IFreeAngleTurntable CreateFromSetValue([Nullable(2)] IFreeAngleTurntable_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFreeAngleTurntable
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0003F182 File Offset: 0x0003D382
		public new IFreeAngleTurntable_SetValue ToSetValue()
		{
			return new IFreeAngleTurntable_SetValue
			{
				Type = this.Type,
				RotationSpeed = this.RotationSpeed,
				ItemConfig = this.ItemConfig,
				IntervalAngle = this.IntervalAngle
			};
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x0003F1B9 File Offset: 0x0003D3B9
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x0003F1E4 File Offset: 0x0003D3E4
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
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x0003F1F2 File Offset: 0x0003D3F2
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x0003F21D File Offset: 0x0003D41D
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
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x0003F22C File Offset: 0x0003D42C
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x0003F2BF File Offset: 0x0003D4BF
		public virtual List<IFreeAngleItem> ItemConfig
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
					List<IFreeAngleItem> itemConfig = this.FbInstance.ItemConfig;
					if (itemConfig != null)
					{
						this._ItemConfigCache = new List<IFreeAngleItem>(itemConfig.Count);
						for (int i = 0; i < itemConfig.Count; i++)
						{
							this._ItemConfigCache.Add(IFreeAngleItem.Create(itemConfig[i]));
						}
					}
				}
				else
				{
					IFreeAngleTurntable_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x0003F2D4 File Offset: 0x0003D4D4
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x0003F2FF File Offset: 0x0003D4FF
		public virtual int IntervalAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IntervalAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.IntervalAngle;
			}
			set
			{
				this.GetOrCreatePoco().IntervalAngle = value;
			}
		}

		// Token: 0x04000F77 RID: 3959
		[Nullable(2)]
		protected new IFreeAngleTurntable FbInstance;

		// Token: 0x04000F78 RID: 3960
		[Nullable(2)]
		protected new IFreeAngleTurntable_SetValue PocoInterface;

		// Token: 0x04000F79 RID: 3961
		private List<IFreeAngleItem> _ItemConfigCache;

		// Token: 0x04000F7A RID: 3962
		private bool _ItemConfigInited;
	}
}
