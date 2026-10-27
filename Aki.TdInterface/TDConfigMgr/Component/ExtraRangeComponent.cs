using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200016D RID: 365
	[NullableContext(1)]
	[Nullable(0)]
	public class ExtraRangeComponent : IComponentBase
	{
		// Token: 0x060004A4 RID: 1188 RVA: 0x0001E984 File Offset: 0x0001CB84
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

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001E9BC File Offset: 0x0001CBBC
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

		// Token: 0x060004A6 RID: 1190 RVA: 0x0001E9CF File Offset: 0x0001CBCF
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

		// Token: 0x060004A7 RID: 1191 RVA: 0x0001E9E2 File Offset: 0x0001CBE2
		public new ExtraRangeComponent_SetValue ToSetValue()
		{
			return new ExtraRangeComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ExtraRangeConfigs = this.ExtraRangeConfigs
			};
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0001EA10 File Offset: 0x0001CC10
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x0001EA4A File Offset: 0x0001CC4A
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0001EA58 File Offset: 0x0001CC58
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x0001EA82 File Offset: 0x0001CC82
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

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0001EA90 File Offset: 0x0001CC90
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x0001EB23 File Offset: 0x0001CD23
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

		// Token: 0x040006EC RID: 1772
		[Nullable(2)]
		protected new ExtraRangeComponent FbInstance;

		// Token: 0x040006ED RID: 1773
		[Nullable(2)]
		protected new ExtraRangeComponent_SetValue PocoInterface;

		// Token: 0x040006EE RID: 1774
		private List<ISunSpiritBlockExtraRange> _ExtraRangeConfigsCache;

		// Token: 0x040006EF RID: 1775
		private bool _ExtraRangeConfigsInited;
	}
}
