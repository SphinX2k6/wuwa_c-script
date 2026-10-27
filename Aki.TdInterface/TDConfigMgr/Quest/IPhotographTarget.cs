using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001047 RID: 4167
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotographTarget
	{
		// Token: 0x06005D5C RID: 23900 RVA: 0x000E2150 File Offset: 0x000E0350
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

		// Token: 0x06005D5D RID: 23901 RVA: 0x000E2188 File Offset: 0x000E0388
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

		// Token: 0x06005D5E RID: 23902 RVA: 0x000E219B File Offset: 0x000E039B
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

		// Token: 0x06005D5F RID: 23903 RVA: 0x000E21AE File Offset: 0x000E03AE
		public IPhotographTarget_SetValue ToSetValue()
		{
			return new IPhotographTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x06005D60 RID: 23904 RVA: 0x000E21C1 File Offset: 0x000E03C1
		// (set) Token: 0x06005D61 RID: 23905 RVA: 0x000E21EC File Offset: 0x000E03EC
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

		// Token: 0x0400383A RID: 14394
		[Nullable(2)]
		protected IPhotographTarget FbInstance;

		// Token: 0x0400383B RID: 14395
		[Nullable(2)]
		protected IPhotographTarget_SetValue PocoInterface;
	}
}
