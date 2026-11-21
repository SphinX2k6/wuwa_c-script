using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B09 RID: 6921
	public class IDelayRemoveType
	{
		// Token: 0x060092F9 RID: 37625 RVA: 0x0015802C File Offset: 0x0015622C
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

		// Token: 0x060092FA RID: 37626 RVA: 0x00158064 File Offset: 0x00156264
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

		// Token: 0x060092FB RID: 37627 RVA: 0x00158077 File Offset: 0x00156277
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

		// Token: 0x060092FC RID: 37628 RVA: 0x0015808A File Offset: 0x0015628A
		public IDelayRemoveType_SetValue ToSetValue()
		{
			return new IDelayRemoveType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x060092FD RID: 37629 RVA: 0x0015809D File Offset: 0x0015629D
		// (set) Token: 0x060092FE RID: 37630 RVA: 0x001580C8 File Offset: 0x001562C8
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

		// Token: 0x04005B72 RID: 23410
		[Nullable(2)]
		protected IDelayRemoveType FbInstance;

		// Token: 0x04005B73 RID: 23411
		[Nullable(2)]
		protected IDelayRemoveType_SetValue PocoInterface;
	}
}
