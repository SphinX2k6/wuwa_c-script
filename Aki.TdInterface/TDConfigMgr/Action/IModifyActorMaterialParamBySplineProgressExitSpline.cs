using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE4 RID: 7140
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyActorMaterialParamBySplineProgressExitSpline : IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x060098E9 RID: 39145 RVA: 0x00160300 File Offset: 0x0015E500
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

		// Token: 0x060098EA RID: 39146 RVA: 0x00160338 File Offset: 0x0015E538
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

		// Token: 0x060098EB RID: 39147 RVA: 0x0016034B File Offset: 0x0015E54B
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

		// Token: 0x060098EC RID: 39148 RVA: 0x0016035E File Offset: 0x0015E55E
		public new IModifyActorMaterialParamBySplineProgressExitSpline_SetValue ToSetValue()
		{
			return new IModifyActorMaterialParamBySplineProgressExitSpline_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x060098ED RID: 39149 RVA: 0x0016037D File Offset: 0x0015E57D
		// (set) Token: 0x060098EE RID: 39150 RVA: 0x001603A8 File Offset: 0x0015E5A8
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

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x060098EF RID: 39151 RVA: 0x001603B6 File Offset: 0x0015E5B6
		// (set) Token: 0x060098F0 RID: 39152 RVA: 0x001603E1 File Offset: 0x0015E5E1
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

		// Token: 0x04005D30 RID: 23856
		[Nullable(2)]
		protected new IModifyActorMaterialParamBySplineProgressExitSpline FbInstance;

		// Token: 0x04005D31 RID: 23857
		[Nullable(2)]
		protected new IModifyActorMaterialParamBySplineProgressExitSpline_SetValue PocoInterface;
	}
}
