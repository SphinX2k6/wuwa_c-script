using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B41 RID: 6977
	[JsonConverter(typeof(IDisableSceneInteractionOperationConverter))]
	public class IDisableSceneInteractionOperation : ISceneInteractionOperationType
	{
		// Token: 0x06009437 RID: 37943 RVA: 0x0015A3A0 File Offset: 0x001585A0
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

		// Token: 0x06009438 RID: 37944 RVA: 0x0015A3D8 File Offset: 0x001585D8
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

		// Token: 0x06009439 RID: 37945 RVA: 0x0015A3EB File Offset: 0x001585EB
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

		// Token: 0x0600943A RID: 37946 RVA: 0x0015A3FE File Offset: 0x001585FE
		public new IDisableSceneInteractionOperation_SetValue ToSetValue()
		{
			return new IDisableSceneInteractionOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x0600943B RID: 37947 RVA: 0x0015A411 File Offset: 0x00158611
		// (set) Token: 0x0600943C RID: 37948 RVA: 0x0015A43C File Offset: 0x0015863C
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

		// Token: 0x04005BFB RID: 23547
		[Nullable(2)]
		protected new IDisableSceneInteractionOperation FbInstance;

		// Token: 0x04005BFC RID: 23548
		[Nullable(2)]
		protected new IDisableSceneInteractionOperation_SetValue PocoInterface;
	}
}
