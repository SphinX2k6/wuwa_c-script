using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200072D RID: 1837
	public class IRoleInhalation : IInhalationPerformanceType
	{
		// Token: 0x06002702 RID: 9986 RVA: 0x00068A94 File Offset: 0x00066C94
		private IRoleInhalation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleInhalation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleInhalation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleInhalation_SetValue());
			}
			return result;
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x00068ACC File Offset: 0x00066CCC
		public static IRoleInhalation Create([Nullable(2)] IRoleInhalation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleInhalation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x00068ADF File Offset: 0x00066CDF
		public static IRoleInhalation CreateFromSetValue([Nullable(2)] IRoleInhalation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleInhalation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00068AF2 File Offset: 0x00066CF2
		public new IRoleInhalation_SetValue ToSetValue()
		{
			return new IRoleInhalation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x00068B05 File Offset: 0x00066D05
		// (set) Token: 0x06002707 RID: 9991 RVA: 0x00068B30 File Offset: 0x00066D30
		public override EInhalationPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInhalationPerformanceType.Role;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001AB7 RID: 6839
		[Nullable(2)]
		protected new IRoleInhalation FbInstance;

		// Token: 0x04001AB8 RID: 6840
		[Nullable(2)]
		protected new IRoleInhalation_SetValue PocoInterface;
	}
}
