using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000876 RID: 2166
	public class IWaySplineCommonPoint : IWaySplinePointType
	{
		// Token: 0x06002EAB RID: 11947 RVA: 0x000789EC File Offset: 0x00076BEC
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

		// Token: 0x06002EAC RID: 11948 RVA: 0x00078A24 File Offset: 0x00076C24
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

		// Token: 0x06002EAD RID: 11949 RVA: 0x00078A37 File Offset: 0x00076C37
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

		// Token: 0x06002EAE RID: 11950 RVA: 0x00078A4A File Offset: 0x00076C4A
		public new IWaySplineCommonPoint_SetValue ToSetValue()
		{
			return new IWaySplineCommonPoint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x00078A5D File Offset: 0x00076C5D
		// (set) Token: 0x06002EB0 RID: 11952 RVA: 0x00078A88 File Offset: 0x00076C88
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

		// Token: 0x04001EE8 RID: 7912
		[Nullable(2)]
		protected new IWaySplineCommonPoint FbInstance;

		// Token: 0x04001EE9 RID: 7913
		[Nullable(2)]
		protected new IWaySplineCommonPoint_SetValue PocoInterface;
	}
}
