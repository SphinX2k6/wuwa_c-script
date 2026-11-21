using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000413 RID: 1043
	public class IFreeAngleTurntable : ITurntableControlType
	{
		// Token: 0x060014BB RID: 5307 RVA: 0x000426C4 File Offset: 0x000408C4
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

		// Token: 0x060014BC RID: 5308 RVA: 0x000426FC File Offset: 0x000408FC
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

		// Token: 0x060014BD RID: 5309 RVA: 0x0004270F File Offset: 0x0004090F
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

		// Token: 0x060014BE RID: 5310 RVA: 0x00042722 File Offset: 0x00040922
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

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x00042759 File Offset: 0x00040959
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x00042784 File Offset: 0x00040984
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

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x00042792 File Offset: 0x00040992
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x000427BD File Offset: 0x000409BD
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

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x000427CC File Offset: 0x000409CC
		// (set) Token: 0x060014C4 RID: 5316 RVA: 0x0004285F File Offset: 0x00040A5F
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

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x00042874 File Offset: 0x00040A74
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x0004289F File Offset: 0x00040A9F
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

		// Token: 0x04001078 RID: 4216
		[Nullable(2)]
		protected new IFreeAngleTurntable FbInstance;

		// Token: 0x04001079 RID: 4217
		[Nullable(2)]
		protected new IFreeAngleTurntable_SetValue PocoInterface;

		// Token: 0x0400107A RID: 4218
		private List<IFreeAngleItem> _ItemConfigCache;

		// Token: 0x0400107B RID: 4219
		private bool _ItemConfigInited;
	}
}
