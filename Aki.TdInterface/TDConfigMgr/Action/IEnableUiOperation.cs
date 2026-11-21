using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B89 RID: 7049
	[JsonConverter(typeof(IEnableUiOperationConverter))]
	public class IEnableUiOperation : IUiOperationType
	{
		// Token: 0x060095CB RID: 38347 RVA: 0x0015D0C4 File Offset: 0x0015B2C4
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

		// Token: 0x060095CC RID: 38348 RVA: 0x0015D0FC File Offset: 0x0015B2FC
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

		// Token: 0x060095CD RID: 38349 RVA: 0x0015D10F File Offset: 0x0015B30F
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

		// Token: 0x060095CE RID: 38350 RVA: 0x0015D122 File Offset: 0x0015B322
		public new IEnableUiOperation_SetValue ToSetValue()
		{
			return new IEnableUiOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x060095CF RID: 38351 RVA: 0x0015D135 File Offset: 0x0015B335
		// (set) Token: 0x060095D0 RID: 38352 RVA: 0x0015D160 File Offset: 0x0015B360
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

		// Token: 0x04005CAB RID: 23723
		[Nullable(2)]
		protected new IEnableUiOperation FbInstance;

		// Token: 0x04005CAC RID: 23724
		[Nullable(2)]
		protected new IEnableUiOperation_SetValue PocoInterface;
	}
}
