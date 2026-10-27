using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007D9 RID: 2009
	[NullableContext(1)]
	[Nullable(0)]
	public class IWaySplineStartPoint : IWaySplinePointType
	{
		// Token: 0x06002B9D RID: 11165 RVA: 0x00071B18 File Offset: 0x0006FD18
		private IWaySplineStartPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaySplineStartPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaySplineStartPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaySplineStartPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x00071B50 File Offset: 0x0006FD50
		public static IWaySplineStartPoint Create([Nullable(2)] IWaySplineStartPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaySplineStartPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x00071B63 File Offset: 0x0006FD63
		public static IWaySplineStartPoint CreateFromSetValue([Nullable(2)] IWaySplineStartPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaySplineStartPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00071B76 File Offset: 0x0006FD76
		public new IWaySplineStartPoint_SetValue ToSetValue()
		{
			return new IWaySplineStartPoint_SetValue
			{
				Type = this.Type,
				GenerationConfig = this.GenerationConfig
			};
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x00071B95 File Offset: 0x0006FD95
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x00071BC0 File Offset: 0x0006FDC0
		public override EWaySplinePointType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWaySplinePointType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x00071BD0 File Offset: 0x0006FDD0
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x00071C31 File Offset: 0x0006FE31
		[Nullable(2)]
		public virtual IVehicleGenerationConfig GenerationConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._GenerationConfigInited)
				{
					return this._GenerationConfigCache;
				}
				this._GenerationConfigInited = true;
				if (this.FbInstance != null)
				{
					this._GenerationConfigCache = IVehicleGenerationConfig.Create(this.FbInstance.GenerationConfig);
				}
				else
				{
					IWaySplineStartPoint_SetValue pocoInterface = this.PocoInterface;
					this._GenerationConfigCache = ((pocoInterface != null) ? pocoInterface.GenerationConfig : null);
				}
				return this._GenerationConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().GenerationConfig = value;
				this._GenerationConfigInited = false;
			}
		}

		// Token: 0x04001CF2 RID: 7410
		[Nullable(2)]
		protected new IWaySplineStartPoint FbInstance;

		// Token: 0x04001CF3 RID: 7411
		[Nullable(2)]
		protected new IWaySplineStartPoint_SetValue PocoInterface;

		// Token: 0x04001CF4 RID: 7412
		private IVehicleGenerationConfig _GenerationConfigCache;

		// Token: 0x04001CF5 RID: 7413
		private bool _GenerationConfigInited;
	}
}
