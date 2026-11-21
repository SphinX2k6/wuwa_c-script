using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000509 RID: 1289
	public class ILevelAIBehaviourBase
	{
		// Token: 0x060019D6 RID: 6614 RVA: 0x0004C870 File Offset: 0x0004AA70
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

		// Token: 0x060019D7 RID: 6615 RVA: 0x0004C8A8 File Offset: 0x0004AAA8
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

		// Token: 0x060019D8 RID: 6616 RVA: 0x0004C8BB File Offset: 0x0004AABB
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

		// Token: 0x060019D9 RID: 6617 RVA: 0x0004C8CE File Offset: 0x0004AACE
		public ILevelAIBehaviourBase_SetValue ToSetValue()
		{
			return new ILevelAIBehaviourBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x0004C8E1 File Offset: 0x0004AAE1
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x0004C90C File Offset: 0x0004AB0C
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

		// Token: 0x04001325 RID: 4901
		[Nullable(2)]
		protected ILevelAIBehaviourBase FbInstance;

		// Token: 0x04001326 RID: 4902
		[Nullable(2)]
		protected ILevelAIBehaviourBase_SetValue PocoInterface;
	}
}
