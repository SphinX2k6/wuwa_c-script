using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200050B RID: 1291
	public class ILevelAIBehaviourSpline : ILevelAIBehaviourBase
	{
		// Token: 0x060019DE RID: 6622 RVA: 0x0004C92C File Offset: 0x0004AB2C
		private ILevelAIBehaviourSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelAIBehaviourSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelAIBehaviourSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelAIBehaviourSpline_SetValue());
			}
			return result;
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0004C964 File Offset: 0x0004AB64
		public static ILevelAIBehaviourSpline Create([Nullable(2)] ILevelAIBehaviourSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelAIBehaviourSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0004C977 File Offset: 0x0004AB77
		public static ILevelAIBehaviourSpline CreateFromSetValue([Nullable(2)] ILevelAIBehaviourSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelAIBehaviourSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0004C98A File Offset: 0x0004AB8A
		public new ILevelAIBehaviourSpline_SetValue ToSetValue()
		{
			return new ILevelAIBehaviourSpline_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x0004C9A9 File Offset: 0x0004ABA9
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0004C9D4 File Offset: 0x0004ABD4
		public override ELevelAIBehaviourType Type
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

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x0004C9E4 File Offset: 0x0004ABE4
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x0004CA1E File Offset: 0x0004AC1E
		public virtual int? SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				ILevelAIBehaviourSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x04001328 RID: 4904
		[Nullable(2)]
		protected new ILevelAIBehaviourSpline FbInstance;

		// Token: 0x04001329 RID: 4905
		[Nullable(2)]
		protected new ILevelAIBehaviourSpline_SetValue PocoInterface;
	}
}
