using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019D5 RID: 6613
	[JsonConverter(typeof(ICameraOperationTypeConverter))]
	public class ICameraOperationType
	{
		// Token: 0x06008CB7 RID: 36023 RVA: 0x0014D27C File Offset: 0x0014B47C
		private ICameraOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x06008CB8 RID: 36024 RVA: 0x0014D2B4 File Offset: 0x0014B4B4
		public static ICameraOperationType Create([Nullable(2)] ICameraOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008CB9 RID: 36025 RVA: 0x0014D2C7 File Offset: 0x0014B4C7
		public static ICameraOperationType CreateFromSetValue([Nullable(2)] ICameraOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008CBA RID: 36026 RVA: 0x0014D2DA File Offset: 0x0014B4DA
		public ICameraOperationType_SetValue ToSetValue()
		{
			return new ICameraOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x06008CBB RID: 36027 RVA: 0x0014D2ED File Offset: 0x0014B4ED
		// (set) Token: 0x06008CBC RID: 36028 RVA: 0x0014D318 File Offset: 0x0014B518
		public virtual ECameraOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECameraOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040058A7 RID: 22695
		[Nullable(2)]
		protected ICameraOperationType FbInstance;

		// Token: 0x040058A8 RID: 22696
		[Nullable(2)]
		protected ICameraOperationType_SetValue PocoInterface;
	}
}
