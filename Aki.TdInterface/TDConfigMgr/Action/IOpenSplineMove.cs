using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EB7 RID: 7863
	public class IOpenSplineMove : ISplineMoveConfig
	{
		// Token: 0x0600A755 RID: 42837 RVA: 0x0017CC54 File Offset: 0x0017AE54
		private IOpenSplineMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenSplineMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenSplineMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenSplineMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600A756 RID: 42838 RVA: 0x0017CC8C File Offset: 0x0017AE8C
		public static IOpenSplineMove Create([Nullable(2)] IOpenSplineMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenSplineMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A757 RID: 42839 RVA: 0x0017CC9F File Offset: 0x0017AE9F
		public static IOpenSplineMove CreateFromSetValue([Nullable(2)] IOpenSplineMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenSplineMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A758 RID: 42840 RVA: 0x0017CCB2 File Offset: 0x0017AEB2
		public new IOpenSplineMove_SetValue ToSetValue()
		{
			return new IOpenSplineMove_SetValue
			{
				Type = this.Type,
				Target = this.Target,
				SplineEntityId = this.SplineEntityId,
				Pattern = this.Pattern
			};
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600A759 RID: 42841 RVA: 0x0017CCE9 File Offset: 0x0017AEE9
		// (set) Token: 0x0600A75A RID: 42842 RVA: 0x0017CD14 File Offset: 0x0017AF14
		public override ESplineMoveConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveConfigType.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600A75B RID: 42843 RVA: 0x0017CD22 File Offset: 0x0017AF22
		// (set) Token: 0x0600A75C RID: 42844 RVA: 0x0017CD49 File Offset: 0x0017AF49
		public override ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IOpenSplineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600A75D RID: 42845 RVA: 0x0017CD57 File Offset: 0x0017AF57
		// (set) Token: 0x0600A75E RID: 42846 RVA: 0x0017CD82 File Offset: 0x0017AF82
		public override int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600A75F RID: 42847 RVA: 0x0017CD90 File Offset: 0x0017AF90
		// (set) Token: 0x0600A760 RID: 42848 RVA: 0x0017CDB7 File Offset: 0x0017AFB7
		public virtual ISplineMovePattern Pattern
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pattern;
				}
				IOpenSplineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pattern;
			}
			set
			{
				this.GetOrCreatePoco().Pattern = value;
			}
		}

		// Token: 0x040064C7 RID: 25799
		[Nullable(2)]
		protected new IOpenSplineMove FbInstance;

		// Token: 0x040064C8 RID: 25800
		[Nullable(2)]
		protected new IOpenSplineMove_SetValue PocoInterface;
	}
}
