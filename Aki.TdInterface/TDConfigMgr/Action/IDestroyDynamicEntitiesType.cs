using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200198A RID: 6538
	[NullableContext(1)]
	[Nullable(0)]
	public class IDestroyDynamicEntitiesType
	{
		// Token: 0x06008BF9 RID: 35833 RVA: 0x00148BE4 File Offset: 0x00146DE4
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

		// Token: 0x06008BFA RID: 35834 RVA: 0x00148C1C File Offset: 0x00146E1C
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

		// Token: 0x06008BFB RID: 35835 RVA: 0x00148C2F File Offset: 0x00146E2F
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

		// Token: 0x06008BFC RID: 35836 RVA: 0x00148C42 File Offset: 0x00146E42
		public IDestroyDynamicEntitiesType_SetValue ToSetValue()
		{
			return new IDestroyDynamicEntitiesType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x06008BFD RID: 35837 RVA: 0x00148C55 File Offset: 0x00146E55
		// (set) Token: 0x06008BFE RID: 35838 RVA: 0x00148C80 File Offset: 0x00146E80
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

		// Token: 0x04005739 RID: 22329
		[Nullable(2)]
		protected IDestroyDynamicEntitiesType FbInstance;

		// Token: 0x0400573A RID: 22330
		[Nullable(2)]
		protected IDestroyDynamicEntitiesType_SetValue PocoInterface;
	}
}
