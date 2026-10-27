using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004B0 RID: 1200
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelAIBehaviourBase
	{
		// Token: 0x0600183C RID: 6204 RVA: 0x00048B28 File Offset: 0x00046D28
		private ILevelAIBehaviourBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelAIBehaviourBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelAIBehaviourBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelAIBehaviourBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00048B60 File Offset: 0x00046D60
		public static ILevelAIBehaviourBase Create([Nullable(2)] ILevelAIBehaviourBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelAIBehaviourBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00048B73 File Offset: 0x00046D73
		public static ILevelAIBehaviourBase CreateFromSetValue([Nullable(2)] ILevelAIBehaviourBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelAIBehaviourBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00048B86 File Offset: 0x00046D86
		public ILevelAIBehaviourBase_SetValue ToSetValue()
		{
			return new ILevelAIBehaviourBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x00048B99 File Offset: 0x00046D99
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x00048BC4 File Offset: 0x00046DC4
		public virtual ELevelAIBehaviourType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELevelAIBehaviourType.Spline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001203 RID: 4611
		[Nullable(2)]
		protected ILevelAIBehaviourBase FbInstance;

		// Token: 0x04001204 RID: 4612
		[Nullable(2)]
		protected ILevelAIBehaviourBase_SetValue PocoInterface;
	}
}
