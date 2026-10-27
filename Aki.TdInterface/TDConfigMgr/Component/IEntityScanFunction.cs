using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000333 RID: 819
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityScanFunction
	{
		// Token: 0x0600101E RID: 4126 RVA: 0x0003826C File Offset: 0x0003646C
		private IEntityScanFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityScanFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityScanFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityScanFunction_SetValue());
			}
			return result;
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x000382A4 File Offset: 0x000364A4
		public static IEntityScanFunction Create([Nullable(2)] IEntityScanFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityScanFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x000382B7 File Offset: 0x000364B7
		public static IEntityScanFunction CreateFromSetValue([Nullable(2)] IEntityScanFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityScanFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x000382CA File Offset: 0x000364CA
		public IEntityScanFunction_SetValue ToSetValue()
		{
			return new IEntityScanFunction_SetValue
			{
				ScanId = this.ScanId,
				IsConcealed = this.IsConcealed,
				TraceEffect = this.TraceEffect,
				SpecificScanType = this.SpecificScanType
			};
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x00038301 File Offset: 0x00036501
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x0003832C File Offset: 0x0003652C
		public virtual int ScanId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScanId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ScanId;
			}
			set
			{
				this.GetOrCreatePoco().ScanId = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x0003833A File Offset: 0x0003653A
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x00038365 File Offset: 0x00036565
		public virtual bool IsConcealed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsConcealed;
				}
				return this.PocoInterface != null && this.PocoInterface.IsConcealed;
			}
			set
			{
				this.GetOrCreatePoco().IsConcealed = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x00038374 File Offset: 0x00036574
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x000383D5 File Offset: 0x000365D5
		[Nullable(2)]
		public virtual IScanTraceEffect TraceEffect
		{
			[NullableContext(2)]
			get
			{
				if (this._TraceEffectInited)
				{
					return this._TraceEffectCache;
				}
				this._TraceEffectInited = true;
				if (this.FbInstance != null)
				{
					this._TraceEffectCache = IScanTraceEffect.Create(this.FbInstance.TraceEffect);
				}
				else
				{
					IEntityScanFunction_SetValue pocoInterface = this.PocoInterface;
					this._TraceEffectCache = ((pocoInterface != null) ? pocoInterface.TraceEffect : null);
				}
				return this._TraceEffectCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TraceEffect = value;
				this._TraceEffectInited = false;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x000383EC File Offset: 0x000365EC
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x00038426 File Offset: 0x00036626
		public virtual ESpecificScanType? SpecificScanType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpecificScanType;
				}
				IEntityScanFunction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SpecificScanType;
			}
			set
			{
				this.GetOrCreatePoco().SpecificScanType = value;
			}
		}

		// Token: 0x04000D9A RID: 3482
		[Nullable(2)]
		protected IEntityScanFunction FbInstance;

		// Token: 0x04000D9B RID: 3483
		[Nullable(2)]
		protected IEntityScanFunction_SetValue PocoInterface;

		// Token: 0x04000D9C RID: 3484
		private IScanTraceEffect _TraceEffectCache;

		// Token: 0x04000D9D RID: 3485
		private bool _TraceEffectInited;
	}
}
