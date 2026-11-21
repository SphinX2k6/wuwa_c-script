using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B11 RID: 6929
	public class IDestroyDynamicEntitiesType
	{
		// Token: 0x0600931D RID: 37661 RVA: 0x001583F4 File Offset: 0x001565F4
		private IDestroyDynamicEntitiesType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDestroyDynamicEntitiesType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDestroyDynamicEntitiesType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDestroyDynamicEntitiesType_SetValue());
			}
			return result;
		}

		// Token: 0x0600931E RID: 37662 RVA: 0x0015842C File Offset: 0x0015662C
		public static IDestroyDynamicEntitiesType Create([Nullable(2)] IDestroyDynamicEntitiesType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyDynamicEntitiesType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x0015843F File Offset: 0x0015663F
		public static IDestroyDynamicEntitiesType CreateFromSetValue([Nullable(2)] IDestroyDynamicEntitiesType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDestroyDynamicEntitiesType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x00158452 File Offset: 0x00156652
		public IDestroyDynamicEntitiesType_SetValue ToSetValue()
		{
			return new IDestroyDynamicEntitiesType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x06009321 RID: 37665 RVA: 0x00158465 File Offset: 0x00156665
		// (set) Token: 0x06009322 RID: 37666 RVA: 0x00158490 File Offset: 0x00156690
		public virtual EDynamicEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDynamicEntityType.VisionDisplay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B82 RID: 23426
		[Nullable(2)]
		protected IDestroyDynamicEntitiesType FbInstance;

		// Token: 0x04005B83 RID: 23427
		[Nullable(2)]
		protected IDestroyDynamicEntitiesType_SetValue PocoInterface;
	}
}
