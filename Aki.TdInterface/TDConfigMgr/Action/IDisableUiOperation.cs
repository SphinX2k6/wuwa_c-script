using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B47 RID: 6983
	[JsonConverter(typeof(IDisableUiOperationConverter))]
	public class IDisableUiOperation : IUiOperationType
	{
		// Token: 0x0600945F RID: 37983 RVA: 0x0015A8E0 File Offset: 0x00158AE0
		private IDisableUiOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableUiOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableUiOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableUiOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06009460 RID: 37984 RVA: 0x0015A918 File Offset: 0x00158B18
		public static IDisableUiOperation Create([Nullable(2)] IDisableUiOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableUiOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009461 RID: 37985 RVA: 0x0015A92B File Offset: 0x00158B2B
		public static IDisableUiOperation CreateFromSetValue([Nullable(2)] IDisableUiOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableUiOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009462 RID: 37986 RVA: 0x0015A93E File Offset: 0x00158B3E
		public new IDisableUiOperation_SetValue ToSetValue()
		{
			return new IDisableUiOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x06009463 RID: 37987 RVA: 0x0015A951 File Offset: 0x00158B51
		// (set) Token: 0x06009464 RID: 37988 RVA: 0x0015A97C File Offset: 0x00158B7C
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

		// Token: 0x04005C10 RID: 23568
		[Nullable(2)]
		protected new IDisableUiOperation FbInstance;

		// Token: 0x04005C11 RID: 23569
		[Nullable(2)]
		protected new IDisableUiOperation_SetValue PocoInterface;
	}
}
