using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007D3 RID: 2003
	[NullableContext(1)]
	[Nullable(0)]
	public class IWaySplineCommonPoint : IWaySplinePointType
	{
		// Token: 0x06002B7B RID: 11131 RVA: 0x00071688 File Offset: 0x0006F888
		private IWaySplineCommonPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaySplineCommonPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaySplineCommonPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaySplineCommonPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000716C0 File Offset: 0x0006F8C0
		public static IWaySplineCommonPoint Create([Nullable(2)] IWaySplineCommonPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaySplineCommonPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x000716D3 File Offset: 0x0006F8D3
		public static IWaySplineCommonPoint CreateFromSetValue([Nullable(2)] IWaySplineCommonPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaySplineCommonPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x000716E6 File Offset: 0x0006F8E6
		public new IWaySplineCommonPoint_SetValue ToSetValue()
		{
			return new IWaySplineCommonPoint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000716F9 File Offset: 0x0006F8F9
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x00071724 File Offset: 0x0006F924
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

		// Token: 0x04001CDC RID: 7388
		[Nullable(2)]
		protected new IWaySplineCommonPoint FbInstance;

		// Token: 0x04001CDD RID: 7389
		[Nullable(2)]
		protected new IWaySplineCommonPoint_SetValue PocoInterface;
	}
}
