using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CFB RID: 7419
	public class IInteractiveItemsFunction : EnableFunction
	{
		// Token: 0x06009D71 RID: 40305 RVA: 0x0016A734 File Offset: 0x00168934
		private IInteractiveItemsFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractiveItemsFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractiveItemsFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractiveItemsFunction_SetValue());
			}
			return result;
		}

		// Token: 0x06009D72 RID: 40306 RVA: 0x0016A76C File Offset: 0x0016896C
		public static IInteractiveItemsFunction Create([Nullable(2)] IInteractiveItemsFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractiveItemsFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D73 RID: 40307 RVA: 0x0016A77F File Offset: 0x0016897F
		public static IInteractiveItemsFunction CreateFromSetValue([Nullable(2)] IInteractiveItemsFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractiveItemsFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D74 RID: 40308 RVA: 0x0016A792 File Offset: 0x00168992
		public new IInteractiveItemsFunction_SetValue ToSetValue()
		{
			return new IInteractiveItemsFunction_SetValue
			{
				Type = this.Type,
				Enable = this.Enable
			};
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x06009D75 RID: 40309 RVA: 0x0016A7B1 File Offset: 0x001689B1
		// (set) Token: 0x06009D76 RID: 40310 RVA: 0x0016A7DC File Offset: 0x001689DC
		public override EEnableFunctionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableFunctionType.TeleportDungeon;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x06009D77 RID: 40311 RVA: 0x0016A7EA File Offset: 0x001689EA
		// (set) Token: 0x06009D78 RID: 40312 RVA: 0x0016A815 File Offset: 0x00168A15
		public virtual bool Enable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Enable;
				}
				return this.PocoInterface != null && this.PocoInterface.Enable;
			}
			set
			{
				this.GetOrCreatePoco().Enable = value;
			}
		}

		// Token: 0x0400601B RID: 24603
		[Nullable(2)]
		protected new IInteractiveItemsFunction FbInstance;

		// Token: 0x0400601C RID: 24604
		[Nullable(2)]
		protected new IInteractiveItemsFunction_SetValue PocoInterface;
	}
}
