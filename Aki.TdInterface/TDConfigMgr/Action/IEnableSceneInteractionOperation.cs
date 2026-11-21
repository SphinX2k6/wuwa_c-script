using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B7D RID: 7037
	[JsonConverter(typeof(IEnableSceneInteractionOperationConverter))]
	public class IEnableSceneInteractionOperation : ISceneInteractionOperationType
	{
		// Token: 0x0600956F RID: 38255 RVA: 0x0015C554 File Offset: 0x0015A754
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

		// Token: 0x06009570 RID: 38256 RVA: 0x0015C58C File Offset: 0x0015A78C
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

		// Token: 0x06009571 RID: 38257 RVA: 0x0015C59F File Offset: 0x0015A79F
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

		// Token: 0x06009572 RID: 38258 RVA: 0x0015C5B2 File Offset: 0x0015A7B2
		public new IEnableSceneInteractionOperation_SetValue ToSetValue()
		{
			return new IEnableSceneInteractionOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x06009573 RID: 38259 RVA: 0x0015C5C5 File Offset: 0x0015A7C5
		// (set) Token: 0x06009574 RID: 38260 RVA: 0x0015C5F0 File Offset: 0x0015A7F0
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

		// Token: 0x04005C83 RID: 23683
		[Nullable(2)]
		protected new IEnableSceneInteractionOperation FbInstance;

		// Token: 0x04005C84 RID: 23684
		[Nullable(2)]
		protected new IEnableSceneInteractionOperation_SetValue PocoInterface;
	}
}
