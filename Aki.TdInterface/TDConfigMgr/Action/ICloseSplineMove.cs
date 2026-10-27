using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018EA RID: 6378
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseSplineMove : ISplineMoveConfig
	{
		// Token: 0x060088B9 RID: 35001 RVA: 0x00143344 File Offset: 0x00141544
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

		// Token: 0x060088BA RID: 35002 RVA: 0x0014337C File Offset: 0x0014157C
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

		// Token: 0x060088BB RID: 35003 RVA: 0x0014338F File Offset: 0x0014158F
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

		// Token: 0x060088BC RID: 35004 RVA: 0x001433A2 File Offset: 0x001415A2
		public new ICloseSplineMove_SetValue ToSetValue()
		{
			return new ICloseSplineMove_SetValue
			{
				Type = this.Type,
				Target = this.Target,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x060088BD RID: 35005 RVA: 0x001433CD File Offset: 0x001415CD
		// (set) Token: 0x060088BE RID: 35006 RVA: 0x001433F8 File Offset: 0x001415F8
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

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x060088BF RID: 35007 RVA: 0x00143406 File Offset: 0x00141606
		// (set) Token: 0x060088C0 RID: 35008 RVA: 0x0014342D File Offset: 0x0014162D
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

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x060088C1 RID: 35009 RVA: 0x0014343B File Offset: 0x0014163B
		// (set) Token: 0x060088C2 RID: 35010 RVA: 0x00143466 File Offset: 0x00141666
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

		// Token: 0x040055CB RID: 21963
		[Nullable(2)]
		protected new ICloseSplineMove FbInstance;

		// Token: 0x040055CC RID: 21964
		[Nullable(2)]
		protected new ICloseSplineMove_SetValue PocoInterface;
	}
}
