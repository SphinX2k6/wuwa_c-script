using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200087C RID: 2172
	public class IWaySplineStartPoint : IWaySplinePointType
	{
		// Token: 0x06002ECD RID: 11981 RVA: 0x00078E7C File Offset: 0x0007707C
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

		// Token: 0x06002ECE RID: 11982 RVA: 0x00078EB4 File Offset: 0x000770B4
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

		// Token: 0x06002ECF RID: 11983 RVA: 0x00078EC7 File Offset: 0x000770C7
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

		// Token: 0x06002ED0 RID: 11984 RVA: 0x00078EDA File Offset: 0x000770DA
		public new IWaySplineStartPoint_SetValue ToSetValue()
		{
			return new IWaySplineStartPoint_SetValue
			{
				Type = this.Type,
				GenerationConfig = this.GenerationConfig
			};
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x00078EF9 File Offset: 0x000770F9
		// (set) Token: 0x06002ED2 RID: 11986 RVA: 0x00078F24 File Offset: 0x00077124
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

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x00078F34 File Offset: 0x00077134
		// (set) Token: 0x06002ED4 RID: 11988 RVA: 0x00078F95 File Offset: 0x00077195
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

		// Token: 0x04001EFE RID: 7934
		[Nullable(2)]
		protected new IWaySplineStartPoint FbInstance;

		// Token: 0x04001EFF RID: 7935
		[Nullable(2)]
		protected new IWaySplineStartPoint_SetValue PocoInterface;

		// Token: 0x04001F00 RID: 7936
		private IVehicleGenerationConfig _GenerationConfigCache;

		// Token: 0x04001F01 RID: 7937
		private bool _GenerationConfigInited;
	}
}
