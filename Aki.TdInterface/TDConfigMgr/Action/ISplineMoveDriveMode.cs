using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EA1 RID: 7841
	[NullableContext(1)]
	[Nullable(0)]
	public class ISplineMoveDriveMode
	{
		// Token: 0x0600A7BA RID: 42938 RVA: 0x0017AED0 File Offset: 0x001790D0
		private ISplineMoveDriveMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineMoveDriveMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineMoveDriveMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineMoveDriveMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7BB RID: 42939 RVA: 0x0017AF08 File Offset: 0x00179108
		public static ISplineMoveDriveMode Create([Nullable(2)] ISplineMoveDriveMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveDriveMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7BC RID: 42940 RVA: 0x0017AF1B File Offset: 0x0017911B
		public static ISplineMoveDriveMode CreateFromSetValue([Nullable(2)] ISplineMoveDriveMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineMoveDriveMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7BD RID: 42941 RVA: 0x0017AF2E File Offset: 0x0017912E
		public ISplineMoveDriveMode_SetValue ToSetValue()
		{
			return new ISplineMoveDriveMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600A7BE RID: 42942 RVA: 0x0017AF41 File Offset: 0x00179141
		// (set) Token: 0x0600A7BF RID: 42943 RVA: 0x0017AF6C File Offset: 0x0017916C
		public virtual ESplineMoveDriveMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveDriveMode.InputDriven;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006400 RID: 25600
		[Nullable(2)]
		protected ISplineMoveDriveMode FbInstance;

		// Token: 0x04006401 RID: 25601
		[Nullable(2)]
		protected ISplineMoveDriveMode_SetValue PocoInterface;
	}
}
