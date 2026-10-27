using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B4C RID: 6988
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractiveItemsFunction : EnableFunction
	{
		// Token: 0x06009587 RID: 38279 RVA: 0x00159A58 File Offset: 0x00157C58
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

		// Token: 0x06009588 RID: 38280 RVA: 0x00159A90 File Offset: 0x00157C90
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

		// Token: 0x06009589 RID: 38281 RVA: 0x00159AA3 File Offset: 0x00157CA3
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

		// Token: 0x0600958A RID: 38282 RVA: 0x00159AB6 File Offset: 0x00157CB6
		public new IInteractiveItemsFunction_SetValue ToSetValue()
		{
			return new IInteractiveItemsFunction_SetValue
			{
				Type = this.Type,
				Enable = this.Enable
			};
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x0600958B RID: 38283 RVA: 0x00159AD5 File Offset: 0x00157CD5
		// (set) Token: 0x0600958C RID: 38284 RVA: 0x00159B00 File Offset: 0x00157D00
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

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x0600958D RID: 38285 RVA: 0x00159B0E File Offset: 0x00157D0E
		// (set) Token: 0x0600958E RID: 38286 RVA: 0x00159B39 File Offset: 0x00157D39
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

		// Token: 0x04005B7D RID: 23421
		[Nullable(2)]
		protected new IInteractiveItemsFunction FbInstance;

		// Token: 0x04005B7E RID: 23422
		[Nullable(2)]
		protected new IInteractiveItemsFunction_SetValue PocoInterface;
	}
}
