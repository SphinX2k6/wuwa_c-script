using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019EA RID: 6634
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IEnableSceneInteractionOperationConverter))]
	public class IEnableSceneInteractionOperation : ISceneInteractionOperationType
	{
		// Token: 0x06008E0D RID: 36365 RVA: 0x0014C6E4 File Offset: 0x0014A8E4
		private IEnableSceneInteractionOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableSceneInteractionOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableSceneInteractionOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableSceneInteractionOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008E0E RID: 36366 RVA: 0x0014C71C File Offset: 0x0014A91C
		public static IEnableSceneInteractionOperation Create([Nullable(2)] IEnableSceneInteractionOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSceneInteractionOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x0014C72F File Offset: 0x0014A92F
		public static IEnableSceneInteractionOperation CreateFromSetValue([Nullable(2)] IEnableSceneInteractionOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableSceneInteractionOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E10 RID: 36368 RVA: 0x0014C742 File Offset: 0x0014A942
		public new IEnableSceneInteractionOperation_SetValue ToSetValue()
		{
			return new IEnableSceneInteractionOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x06008E11 RID: 36369 RVA: 0x0014C755 File Offset: 0x0014A955
		// (set) Token: 0x06008E12 RID: 36370 RVA: 0x0014C780 File Offset: 0x0014A980
		public override ESceneInteractionOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneInteractionOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005821 RID: 22561
		[Nullable(2)]
		protected new IEnableSceneInteractionOperation FbInstance;

		// Token: 0x04005822 RID: 22562
		[Nullable(2)]
		protected new IEnableSceneInteractionOperation_SetValue PocoInterface;
	}
}
