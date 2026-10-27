using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018C4 RID: 6340
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientModifyTarget
	{
		// Token: 0x06008801 RID: 34817 RVA: 0x00141FF8 File Offset: 0x001401F8
		private IClientModifyTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientModifyTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientModifyTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientModifyTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x00142030 File Offset: 0x00140230
		public static IClientModifyTarget Create([Nullable(2)] IClientModifyTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientModifyTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008803 RID: 34819 RVA: 0x00142043 File Offset: 0x00140243
		public static IClientModifyTarget CreateFromSetValue([Nullable(2)] IClientModifyTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientModifyTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x00142056 File Offset: 0x00140256
		public IClientModifyTarget_SetValue ToSetValue()
		{
			return new IClientModifyTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x06008805 RID: 34821 RVA: 0x00142069 File Offset: 0x00140269
		// (set) Token: 0x06008806 RID: 34822 RVA: 0x00142094 File Offset: 0x00140294
		public virtual EClientModifyTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientModifyTargetType.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400557C RID: 21884
		[Nullable(2)]
		protected IClientModifyTarget FbInstance;

		// Token: 0x0400557D RID: 21885
		[Nullable(2)]
		protected IClientModifyTarget_SetValue PocoInterface;
	}
}
