using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004B2 RID: 1202
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelAIBehaviourSpline : ILevelAIBehaviourBase
	{
		// Token: 0x06001844 RID: 6212 RVA: 0x00048BE4 File Offset: 0x00046DE4
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

		// Token: 0x06001845 RID: 6213 RVA: 0x00048C1C File Offset: 0x00046E1C
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

		// Token: 0x06001846 RID: 6214 RVA: 0x00048C2F File Offset: 0x00046E2F
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

		// Token: 0x06001847 RID: 6215 RVA: 0x00048C42 File Offset: 0x00046E42
		public new ILevelAIBehaviourSpline_SetValue ToSetValue()
		{
			return new ILevelAIBehaviourSpline_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x00048C61 File Offset: 0x00046E61
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x00048C8C File Offset: 0x00046E8C
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

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x00048C9C File Offset: 0x00046E9C
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x00048CD6 File Offset: 0x00046ED6
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

		// Token: 0x04001206 RID: 4614
		[Nullable(2)]
		protected new ILevelAIBehaviourSpline FbInstance;

		// Token: 0x04001207 RID: 4615
		[Nullable(2)]
		protected new ILevelAIBehaviourSpline_SetValue PocoInterface;
	}
}
