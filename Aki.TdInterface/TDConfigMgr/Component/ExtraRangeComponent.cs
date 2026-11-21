using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000182 RID: 386
	public class ExtraRangeComponent : IComponentBase
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x0001F2F8 File Offset: 0x0001D4F8
		private ExtraRangeComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExtraRangeComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExtraRangeComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExtraRangeComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001F330 File Offset: 0x0001D530
		public static ExtraRangeComponent Create([Nullable(2)] ExtraRangeComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExtraRangeComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0001F343 File Offset: 0x0001D543
		public static ExtraRangeComponent CreateFromSetValue([Nullable(2)] ExtraRangeComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExtraRangeComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0001F356 File Offset: 0x0001D556
		public new ExtraRangeComponent_SetValue ToSetValue()
		{
			return new ExtraRangeComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ExtraRangeConfigs = this.ExtraRangeConfigs
			};
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0001F384 File Offset: 0x0001D584
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x0001F3BE File Offset: 0x0001D5BE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ExtraRangeComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0001F3CC File Offset: 0x0001D5CC
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x0001F3F6 File Offset: 0x0001D5F6
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

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0001F404 File Offset: 0x0001D604
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x0001F497 File Offset: 0x0001D697
		public virtual List<ISunSpiritBlockExtraRange> ExtraRangeConfigs
		{
			get
			{
				if (this._ExtraRangeConfigsInited)
				{
					return this._ExtraRangeConfigsCache;
				}
				this._ExtraRangeConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ISunSpiritBlockExtraRange> extraRangeConfigs = this.FbInstance.ExtraRangeConfigs;
					if (extraRangeConfigs != null)
					{
						this._ExtraRangeConfigsCache = new List<ISunSpiritBlockExtraRange>(extraRangeConfigs.Count);
						for (int i = 0; i < extraRangeConfigs.Count; i++)
						{
							this._ExtraRangeConfigsCache.Add(ISunSpiritBlockExtraRange.Create(extraRangeConfigs[i]));
						}
					}
				}
				else
				{
					ExtraRangeComponent_SetValue pocoInterface = this.PocoInterface;
					this._ExtraRangeConfigsCache = ((pocoInterface != null) ? pocoInterface.ExtraRangeConfigs : null);
				}
				return this._ExtraRangeConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().ExtraRangeConfigs = value;
				this._ExtraRangeConfigsInited = false;
			}
		}

		// Token: 0x04000739 RID: 1849
		[Nullable(2)]
		protected new ExtraRangeComponent FbInstance;

		// Token: 0x0400073A RID: 1850
		[Nullable(2)]
		protected new ExtraRangeComponent_SetValue PocoInterface;

		// Token: 0x0400073B RID: 1851
		private List<ISunSpiritBlockExtraRange> _ExtraRangeConfigsCache;

		// Token: 0x0400073C RID: 1852
		private bool _ExtraRangeConfigsInited;
	}
}
