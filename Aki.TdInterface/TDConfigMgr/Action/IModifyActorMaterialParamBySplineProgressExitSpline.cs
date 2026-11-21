using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DD1 RID: 7633
	public class IModifyActorMaterialParamBySplineProgressExitSpline : IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x0600A20D RID: 41485 RVA: 0x001730FC File Offset: 0x001712FC
		private IModifyActorMaterialParamBySplineProgressExitSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyActorMaterialParamBySplineProgressExitSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyActorMaterialParamBySplineProgressExitSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyActorMaterialParamBySplineProgressExitSpline_SetValue());
			}
			return result;
		}

		// Token: 0x0600A20E RID: 41486 RVA: 0x00173134 File Offset: 0x00171334
		public static IModifyActorMaterialParamBySplineProgressExitSpline Create([Nullable(2)] IModifyActorMaterialParamBySplineProgressExitSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressExitSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A20F RID: 41487 RVA: 0x00173147 File Offset: 0x00171347
		public static IModifyActorMaterialParamBySplineProgressExitSpline CreateFromSetValue([Nullable(2)] IModifyActorMaterialParamBySplineProgressExitSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressExitSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x0017315A File Offset: 0x0017135A
		public new IModifyActorMaterialParamBySplineProgressExitSpline_SetValue ToSetValue()
		{
			return new IModifyActorMaterialParamBySplineProgressExitSpline_SetValue
			{
				Type = this.Type,
				MoveTarget = this.MoveTarget,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600A211 RID: 41489 RVA: 0x00173185 File Offset: 0x00171385
		// (set) Token: 0x0600A212 RID: 41490 RVA: 0x001731B0 File Offset: 0x001713B0
		public override EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModifyActorMaterialParamBySplineProgressType.EnterSpline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0600A213 RID: 41491 RVA: 0x001731BE File Offset: 0x001713BE
		// (set) Token: 0x0600A214 RID: 41492 RVA: 0x001731E5 File Offset: 0x001713E5
		[Nullable(2)]
		public override IModifyActorMaterialParamBySplineProgressTarget MoveTarget
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveTarget;
				}
				IModifyActorMaterialParamBySplineProgressExitSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveTarget;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MoveTarget = value;
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0600A215 RID: 41493 RVA: 0x001731F3 File Offset: 0x001713F3
		// (set) Token: 0x0600A216 RID: 41494 RVA: 0x0017321E File Offset: 0x0017141E
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

		// Token: 0x04006252 RID: 25170
		[Nullable(2)]
		protected new IModifyActorMaterialParamBySplineProgressExitSpline FbInstance;

		// Token: 0x04006253 RID: 25171
		[Nullable(2)]
		protected new IModifyActorMaterialParamBySplineProgressExitSpline_SetValue PocoInterface;
	}
}
