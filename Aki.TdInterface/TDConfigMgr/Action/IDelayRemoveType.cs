using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200197E RID: 6526
	[NullableContext(1)]
	[Nullable(0)]
	public class IDelayRemoveType
	{
		// Token: 0x06008BC1 RID: 35777 RVA: 0x0014859C File Offset: 0x0014679C
		private IDelayRemoveType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDelayRemoveType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDelayRemoveType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDelayRemoveType_SetValue());
			}
			return result;
		}

		// Token: 0x06008BC2 RID: 35778 RVA: 0x001485D4 File Offset: 0x001467D4
		public static IDelayRemoveType Create([Nullable(2)] IDelayRemoveType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDelayRemoveType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BC3 RID: 35779 RVA: 0x001485E7 File Offset: 0x001467E7
		public static IDelayRemoveType CreateFromSetValue([Nullable(2)] IDelayRemoveType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDelayRemoveType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BC4 RID: 35780 RVA: 0x001485FA File Offset: 0x001467FA
		public IDelayRemoveType_SetValue ToSetValue()
		{
			return new IDelayRemoveType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x06008BC5 RID: 35781 RVA: 0x0014860D File Offset: 0x0014680D
		// (set) Token: 0x06008BC6 RID: 35782 RVA: 0x00148638 File Offset: 0x00146838
		public virtual EDelayRemoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDelayRemoveType.DelayRemoveAfterSkillFinish;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400571D RID: 22301
		[Nullable(2)]
		protected IDelayRemoveType FbInstance;

		// Token: 0x0400571E RID: 22302
		[Nullable(2)]
		protected IDelayRemoveType_SetValue PocoInterface;
	}
}
