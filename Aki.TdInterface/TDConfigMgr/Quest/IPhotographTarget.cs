using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001175 RID: 4469
	public class IPhotographTarget
	{
		// Token: 0x0600634E RID: 25422 RVA: 0x000EF124 File Offset: 0x000ED324
		private IPhotographTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x000EF15C File Offset: 0x000ED35C
		public static IPhotographTarget Create([Nullable(2)] IPhotographTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x000EF16F File Offset: 0x000ED36F
		public static IPhotographTarget CreateFromSetValue([Nullable(2)] IPhotographTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x000EF182 File Offset: 0x000ED382
		public IPhotographTarget_SetValue ToSetValue()
		{
			return new IPhotographTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x06006352 RID: 25426 RVA: 0x000EF195 File Offset: 0x000ED395
		// (set) Token: 0x06006353 RID: 25427 RVA: 0x000EF1C0 File Offset: 0x000ED3C0
		public virtual EPhotographTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhotographTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003B82 RID: 15234
		[Nullable(2)]
		protected IPhotographTarget FbInstance;

		// Token: 0x04003B83 RID: 15235
		[Nullable(2)]
		protected IPhotographTarget_SetValue PocoInterface;
	}
}
