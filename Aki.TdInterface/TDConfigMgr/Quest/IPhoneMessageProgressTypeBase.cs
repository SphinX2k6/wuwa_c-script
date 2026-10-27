using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200103D RID: 4157
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhoneMessageProgressTypeBase
	{
		// Token: 0x06005D24 RID: 23844 RVA: 0x000E1B08 File Offset: 0x000DFD08
		private IPhoneMessageProgressTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhoneMessageProgressTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhoneMessageProgressTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhoneMessageProgressTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x000E1B40 File Offset: 0x000DFD40
		public static IPhoneMessageProgressTypeBase Create([Nullable(2)] IPhoneMessageProgressTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneMessageProgressTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D26 RID: 23846 RVA: 0x000E1B53 File Offset: 0x000DFD53
		public static IPhoneMessageProgressTypeBase CreateFromSetValue([Nullable(2)] IPhoneMessageProgressTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhoneMessageProgressTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D27 RID: 23847 RVA: 0x000E1B66 File Offset: 0x000DFD66
		public IPhoneMessageProgressTypeBase_SetValue ToSetValue()
		{
			return new IPhoneMessageProgressTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06005D28 RID: 23848 RVA: 0x000E1B79 File Offset: 0x000DFD79
		// (set) Token: 0x06005D29 RID: 23849 RVA: 0x000E1BA4 File Offset: 0x000DFDA4
		public virtual EPhoneMessageProgressType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneMessageProgressType.CompleteMessage;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400381F RID: 14367
		[Nullable(2)]
		protected IPhoneMessageProgressTypeBase FbInstance;

		// Token: 0x04003820 RID: 14368
		[Nullable(2)]
		protected IPhoneMessageProgressTypeBase_SetValue PocoInterface;
	}
}
