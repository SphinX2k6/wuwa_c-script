using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F8C RID: 8076
	[NullableContext(1)]
	[Nullable(0)]
	public class ITargetEntityType
	{
		// Token: 0x0600B1A6 RID: 45478 RVA: 0x0019E6FC File Offset: 0x0019C8FC
		private ITargetEntityType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITargetEntityType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITargetEntityType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITargetEntityType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1A7 RID: 45479 RVA: 0x0019E734 File Offset: 0x0019C934
		public static ITargetEntityType Create([Nullable(2)] ITargetEntityType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetEntityType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1A8 RID: 45480 RVA: 0x0019E747 File Offset: 0x0019C947
		public static ITargetEntityType CreateFromSetValue([Nullable(2)] ITargetEntityType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITargetEntityType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1A9 RID: 45481 RVA: 0x0019E75A File Offset: 0x0019C95A
		public ITargetEntityType_SetValue ToSetValue()
		{
			return new ITargetEntityType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x0600B1AA RID: 45482 RVA: 0x0019E76D File Offset: 0x0019C96D
		// (set) Token: 0x0600B1AB RID: 45483 RVA: 0x0019E798 File Offset: 0x0019C998
		public virtual ETargetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetEntityType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B64 RID: 27492
		[Nullable(2)]
		protected ITargetEntityType FbInstance;

		// Token: 0x04006B65 RID: 27493
		[Nullable(2)]
		protected ITargetEntityType_SetValue PocoInterface;
	}
}
