using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019E8 RID: 6632
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IEnableMoveOperationConverter))]
	public class IEnableMoveOperation : IMoveOperationType
	{
		// Token: 0x06008E05 RID: 36357 RVA: 0x0014C628 File Offset: 0x0014A828
		private IEnableMoveOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableMoveOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableMoveOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableMoveOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x0014C660 File Offset: 0x0014A860
		public static IEnableMoveOperation Create([Nullable(2)] IEnableMoveOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableMoveOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x0014C673 File Offset: 0x0014A873
		public static IEnableMoveOperation CreateFromSetValue([Nullable(2)] IEnableMoveOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableMoveOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E08 RID: 36360 RVA: 0x0014C686 File Offset: 0x0014A886
		public new IEnableMoveOperation_SetValue ToSetValue()
		{
			return new IEnableMoveOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x06008E09 RID: 36361 RVA: 0x0014C699 File Offset: 0x0014A899
		// (set) Token: 0x06008E0A RID: 36362 RVA: 0x0014C6C4 File Offset: 0x0014A8C4
		public override EMoveOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMoveOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400581E RID: 22558
		[Nullable(2)]
		protected new IEnableMoveOperation FbInstance;

		// Token: 0x0400581F RID: 22559
		[Nullable(2)]
		protected new IEnableMoveOperation_SetValue PocoInterface;
	}
}
