using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B4 RID: 6580
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableSceneInteractionOperationConverter))]
	public class IDisableSceneInteractionOperation : ISceneInteractionOperationType
	{
		// Token: 0x06008CF5 RID: 36085 RVA: 0x0014A894 File Offset: 0x00148A94
		private IDisableSceneInteractionOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableSceneInteractionOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableSceneInteractionOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableSceneInteractionOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008CF6 RID: 36086 RVA: 0x0014A8CC File Offset: 0x00148ACC
		public static IDisableSceneInteractionOperation Create([Nullable(2)] IDisableSceneInteractionOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableSceneInteractionOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008CF7 RID: 36087 RVA: 0x0014A8DF File Offset: 0x00148ADF
		public static IDisableSceneInteractionOperation CreateFromSetValue([Nullable(2)] IDisableSceneInteractionOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableSceneInteractionOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008CF8 RID: 36088 RVA: 0x0014A8F2 File Offset: 0x00148AF2
		public new IDisableSceneInteractionOperation_SetValue ToSetValue()
		{
			return new IDisableSceneInteractionOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x06008CF9 RID: 36089 RVA: 0x0014A905 File Offset: 0x00148B05
		// (set) Token: 0x06008CFA RID: 36090 RVA: 0x0014A930 File Offset: 0x00148B30
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

		// Token: 0x040057A6 RID: 22438
		[Nullable(2)]
		protected new IDisableSceneInteractionOperation FbInstance;

		// Token: 0x040057A7 RID: 22439
		[Nullable(2)]
		protected new IDisableSceneInteractionOperation_SetValue PocoInterface;
	}
}
