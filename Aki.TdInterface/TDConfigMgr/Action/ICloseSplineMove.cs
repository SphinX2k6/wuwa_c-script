using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A75 RID: 6773
	public class ICloseSplineMove : ISplineMoveConfig
	{
		// Token: 0x06008FE7 RID: 36839 RVA: 0x00152C44 File Offset: 0x00150E44
		private ICloseSplineMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseSplineMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseSplineMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseSplineMove_SetValue());
			}
			return result;
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x00152C7C File Offset: 0x00150E7C
		public static ICloseSplineMove Create([Nullable(2)] ICloseSplineMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSplineMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x00152C8F File Offset: 0x00150E8F
		public static ICloseSplineMove CreateFromSetValue([Nullable(2)] ICloseSplineMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseSplineMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x00152CA2 File Offset: 0x00150EA2
		public new ICloseSplineMove_SetValue ToSetValue()
		{
			return new ICloseSplineMove_SetValue
			{
				Type = this.Type,
				Target = this.Target,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x06008FEB RID: 36843 RVA: 0x00152CCD File Offset: 0x00150ECD
		// (set) Token: 0x06008FEC RID: 36844 RVA: 0x00152CF8 File Offset: 0x00150EF8
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

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x06008FED RID: 36845 RVA: 0x00152D06 File Offset: 0x00150F06
		// (set) Token: 0x06008FEE RID: 36846 RVA: 0x00152D2D File Offset: 0x00150F2D
		public override ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				ICloseSplineMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x06008FEF RID: 36847 RVA: 0x00152D3B File Offset: 0x00150F3B
		// (set) Token: 0x06008FF0 RID: 36848 RVA: 0x00152D66 File Offset: 0x00150F66
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

		// Token: 0x04005A1B RID: 23067
		[Nullable(2)]
		protected new ICloseSplineMove FbInstance;

		// Token: 0x04005A1C RID: 23068
		[Nullable(2)]
		protected new ICloseSplineMove_SetValue PocoInterface;
	}
}
