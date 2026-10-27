using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007D7 RID: 2007
	[NullableContext(1)]
	[Nullable(0)]
	public class IWaySplinePointType
	{
		// Token: 0x06002B95 RID: 11157 RVA: 0x00071A5C File Offset: 0x0006FC5C
		private IWaySplinePointType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaySplinePointType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaySplinePointType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaySplinePointType_SetValue());
			}
			return result;
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x00071A94 File Offset: 0x0006FC94
		public static IWaySplinePointType Create([Nullable(2)] IWaySplinePointType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaySplinePointType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00071AA7 File Offset: 0x0006FCA7
		public static IWaySplinePointType CreateFromSetValue([Nullable(2)] IWaySplinePointType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaySplinePointType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x00071ABA File Offset: 0x0006FCBA
		public IWaySplinePointType_SetValue ToSetValue()
		{
			return new IWaySplinePointType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x00071ACD File Offset: 0x0006FCCD
		// (set) Token: 0x06002B9A RID: 11162 RVA: 0x00071AF8 File Offset: 0x0006FCF8
		public virtual EWaySplinePointType Type
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

		// Token: 0x04001CEF RID: 7407
		[Nullable(2)]
		protected IWaySplinePointType FbInstance;

		// Token: 0x04001CF0 RID: 7408
		[Nullable(2)]
		protected IWaySplinePointType_SetValue PocoInterface;
	}
}
