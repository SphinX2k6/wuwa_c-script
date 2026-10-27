using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000ED4 RID: 3796
	[NullableContext(1)]
	[Nullable(0)]
	public class IAttributeToTarget
	{
		// Token: 0x060053CA RID: 21450 RVA: 0x000CDF38 File Offset: 0x000CC138
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

		// Token: 0x060053CB RID: 21451 RVA: 0x000CDF70 File Offset: 0x000CC170
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

		// Token: 0x060053CC RID: 21452 RVA: 0x000CDF83 File Offset: 0x000CC183
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

		// Token: 0x060053CD RID: 21453 RVA: 0x000CDF96 File Offset: 0x000CC196
		public IAttributeToTarget_SetValue ToSetValue()
		{
			return new IAttributeToTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x060053CE RID: 21454 RVA: 0x000CDFA9 File Offset: 0x000CC1A9
		// (set) Token: 0x060053CF RID: 21455 RVA: 0x000CDFD4 File Offset: 0x000CC1D4
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

		// Token: 0x040032BA RID: 12986
		[Nullable(2)]
		protected IAttributeToTarget FbInstance;

		// Token: 0x040032BB RID: 12987
		[Nullable(2)]
		protected IAttributeToTarget_SetValue PocoInterface;
	}
}
