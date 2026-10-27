using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200177E RID: 6014
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorLookAtData
	{
		// Token: 0x06007F55 RID: 32597 RVA: 0x00130770 File Offset: 0x0012E970
		private IActorLookAtData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAtData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAtData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAtData_SetValue());
			}
			return result;
		}

		// Token: 0x06007F56 RID: 32598 RVA: 0x001307A8 File Offset: 0x0012E9A8
		public static IActorLookAtData Create([Nullable(2)] IActorLookAtData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F57 RID: 32599 RVA: 0x001307BB File Offset: 0x0012E9BB
		public static IActorLookAtData CreateFromSetValue([Nullable(2)] IActorLookAtData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAtData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F58 RID: 32600 RVA: 0x001307CE File Offset: 0x0012E9CE
		public IActorLookAtData_SetValue ToSetValue()
		{
			return new IActorLookAtData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x06007F59 RID: 32601 RVA: 0x001307E1 File Offset: 0x0012E9E1
		// (set) Token: 0x06007F5A RID: 32602 RVA: 0x0013080C File Offset: 0x0012EA0C
		public virtual EActorLookAtMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorLookAtMode.Talker;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040050F7 RID: 20727
		[Nullable(2)]
		protected IActorLookAtData FbInstance;

		// Token: 0x040050F8 RID: 20728
		[Nullable(2)]
		protected IActorLookAtData_SetValue PocoInterface;
	}
}
