using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200037A RID: 890
	public class IEntityScanFunction
	{
		// Token: 0x06001150 RID: 4432 RVA: 0x0003B238 File Offset: 0x00039438
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

		// Token: 0x06001151 RID: 4433 RVA: 0x0003B270 File Offset: 0x00039470
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

		// Token: 0x06001152 RID: 4434 RVA: 0x0003B283 File Offset: 0x00039483
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

		// Token: 0x06001153 RID: 4435 RVA: 0x0003B296 File Offset: 0x00039496
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

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0003B2CD File Offset: 0x000394CD
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x0003B2F8 File Offset: 0x000394F8
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

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0003B306 File Offset: 0x00039506
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x0003B331 File Offset: 0x00039531
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

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0003B340 File Offset: 0x00039540
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x0003B3A1 File Offset: 0x000395A1
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x0003B3B8 File Offset: 0x000395B8
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x0003B3F2 File Offset: 0x000395F2
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

		// Token: 0x04000E85 RID: 3717
		[Nullable(2)]
		protected IEntityScanFunction FbInstance;

		// Token: 0x04000E86 RID: 3718
		[Nullable(2)]
		protected IEntityScanFunction_SetValue PocoInterface;

		// Token: 0x04000E87 RID: 3719
		private IScanTraceEffect _TraceEffectCache;

		// Token: 0x04000E88 RID: 3720
		private bool _TraceEffectInited;
	}
}
