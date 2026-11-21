using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FEA RID: 4074
	public class IAttributeToTarget
	{
		// Token: 0x06005946 RID: 22854 RVA: 0x000DA0E0 File Offset: 0x000D82E0
		private IAttributeToTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAttributeToTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAttributeToTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAttributeToTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x000DA118 File Offset: 0x000D8318
		public static IAttributeToTarget Create([Nullable(2)] IAttributeToTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAttributeToTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x000DA12B File Offset: 0x000D832B
		public static IAttributeToTarget CreateFromSetValue([Nullable(2)] IAttributeToTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAttributeToTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x000DA13E File Offset: 0x000D833E
		public IAttributeToTarget_SetValue ToSetValue()
		{
			return new IAttributeToTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x0600594A RID: 22858 RVA: 0x000DA151 File Offset: 0x000D8351
		// (set) Token: 0x0600594B RID: 22859 RVA: 0x000DA17C File Offset: 0x000D837C
		public virtual EAttributeToTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttributeToTarget.Health;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040035C7 RID: 13767
		[Nullable(2)]
		protected IAttributeToTarget FbInstance;

		// Token: 0x040035C8 RID: 13768
		[Nullable(2)]
		protected IAttributeToTarget_SetValue PocoInterface;
	}
}
