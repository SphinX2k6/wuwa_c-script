using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B77 RID: 7031
	[JsonConverter(typeof(IEnableMoveOperationConverter))]
	public class IEnableMoveOperation : IMoveOperationType
	{
		// Token: 0x06009551 RID: 38225 RVA: 0x0015C234 File Offset: 0x0015A434
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

		// Token: 0x06009552 RID: 38226 RVA: 0x0015C26C File Offset: 0x0015A46C
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

		// Token: 0x06009553 RID: 38227 RVA: 0x0015C27F File Offset: 0x0015A47F
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

		// Token: 0x06009554 RID: 38228 RVA: 0x0015C292 File Offset: 0x0015A492
		public new IEnableMoveOperation_SetValue ToSetValue()
		{
			return new IEnableMoveOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x06009555 RID: 38229 RVA: 0x0015C2A5 File Offset: 0x0015A4A5
		// (set) Token: 0x06009556 RID: 38230 RVA: 0x0015C2D0 File Offset: 0x0015A4D0
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

		// Token: 0x04005C77 RID: 23671
		[Nullable(2)]
		protected new IEnableMoveOperation FbInstance;

		// Token: 0x04005C78 RID: 23672
		[Nullable(2)]
		protected new IEnableMoveOperation_SetValue PocoInterface;
	}
}
