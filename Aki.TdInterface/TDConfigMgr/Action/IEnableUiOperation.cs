using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F6 RID: 6646
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IEnableUiOperationConverter))]
	public class IEnableUiOperation : IUiOperationType
	{
		// Token: 0x06008E69 RID: 36457 RVA: 0x0014D254 File Offset: 0x0014B454
		private IEnableUiOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableUiOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableUiOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableUiOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008E6A RID: 36458 RVA: 0x0014D28C File Offset: 0x0014B48C
		public static IEnableUiOperation Create([Nullable(2)] IEnableUiOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableUiOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E6B RID: 36459 RVA: 0x0014D29F File Offset: 0x0014B49F
		public static IEnableUiOperation CreateFromSetValue([Nullable(2)] IEnableUiOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableUiOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E6C RID: 36460 RVA: 0x0014D2B2 File Offset: 0x0014B4B2
		public new IEnableUiOperation_SetValue ToSetValue()
		{
			return new IEnableUiOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x06008E6D RID: 36461 RVA: 0x0014D2C5 File Offset: 0x0014B4C5
		// (set) Token: 0x06008E6E RID: 36462 RVA: 0x0014D2F0 File Offset: 0x0014B4F0
		public override EUiOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUiOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005849 RID: 22601
		[Nullable(2)]
		protected new IEnableUiOperation FbInstance;

		// Token: 0x0400584A RID: 22602
		[Nullable(2)]
		protected new IEnableUiOperation_SetValue PocoInterface;
	}
}
