using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002E4 RID: 740
	public class ICustomViewDistance : IViewDistanceMode
	{
		// Token: 0x06000DAB RID: 3499 RVA: 0x00033394 File Offset: 0x00031594
		private ICustomViewDistance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomViewDistance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomViewDistance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomViewDistance_SetValue());
			}
			return result;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000333CC File Offset: 0x000315CC
		public static ICustomViewDistance Create([Nullable(2)] ICustomViewDistance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomViewDistance
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000333DF File Offset: 0x000315DF
		public static ICustomViewDistance CreateFromSetValue([Nullable(2)] ICustomViewDistance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomViewDistance
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x000333F2 File Offset: 0x000315F2
		public new ICustomViewDistance_SetValue ToSetValue()
		{
			return new ICustomViewDistance_SetValue
			{
				Type = this.Type,
				Distance = this.Distance
			};
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00033411 File Offset: 0x00031611
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x0003343C File Offset: 0x0003163C
		public override EViewDistanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EViewDistanceType.Low;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0003344A File Offset: 0x0003164A
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x00033475 File Offset: 0x00031675
		public virtual int Distance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Distance;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Distance;
			}
			set
			{
				this.GetOrCreatePoco().Distance = value;
			}
		}

		// Token: 0x04000C9C RID: 3228
		[Nullable(2)]
		protected new ICustomViewDistance FbInstance;

		// Token: 0x04000C9D RID: 3229
		[Nullable(2)]
		protected new ICustomViewDistance_SetValue PocoInterface;
	}
}
