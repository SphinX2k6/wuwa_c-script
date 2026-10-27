using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CC8 RID: 7368
	[NullableContext(2)]
	[Nullable(0)]
	public class IPathLineMove : ISplineMovePattern
	{
		// Token: 0x06009E27 RID: 40487 RVA: 0x00169D10 File Offset: 0x00167F10
		[NullableContext(1)]
		private IPathLineMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathLineMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathLineMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathLineMove_SetValue());
			}
			return result;
		}

		// Token: 0x06009E28 RID: 40488 RVA: 0x00169D48 File Offset: 0x00167F48
		[NullableContext(1)]
		public static IPathLineMove Create([Nullable(2)] IPathLineMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E29 RID: 40489 RVA: 0x00169D5B File Offset: 0x00167F5B
		[NullableContext(1)]
		public static IPathLineMove CreateFromSetValue([Nullable(2)] IPathLineMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathLineMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E2A RID: 40490 RVA: 0x00169D70 File Offset: 0x00167F70
		[NullableContext(1)]
		public new IPathLineMove_SetValue ToSetValue()
		{
			return new IPathLineMove_SetValue
			{
				Type = this.Type,
				MaxOffsetDistance = this.MaxOffsetDistance,
				IsOneWay = this.IsOneWay,
				LayerVerticalLimit = this.LayerVerticalLimit,
				DynamicGravity = this.DynamicGravity,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity,
				AutoExitDistance = this.AutoExitDistance,
				FacingConfig = this.FacingConfig,
				SplineMoveConfigDaPath = this.SplineMoveConfigDaPath,
				IsAdaptiveClimbInput = this.IsAdaptiveClimbInput,
				IsDisableStopAnim = this.IsDisableStopAnim,
				IsAllowEarlyExitClimb = this.IsAllowEarlyExitClimb
			};
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x06009E2B RID: 40491 RVA: 0x00169E12 File Offset: 0x00168012
		// (set) Token: 0x06009E2C RID: 40492 RVA: 0x00169E3D File Offset: 0x0016803D
		public override ESplineMovePattern Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMovePattern.PathLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x06009E2D RID: 40493 RVA: 0x00169E4C File Offset: 0x0016804C
		// (set) Token: 0x06009E2E RID: 40494 RVA: 0x00169E86 File Offset: 0x00168086
		public override float? MaxOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxOffsetDistance;
				}
				IPathLineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxOffsetDistance = value;
			}
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x06009E2F RID: 40495 RVA: 0x00169E94 File Offset: 0x00168094
		// (set) Token: 0x06009E30 RID: 40496 RVA: 0x00169ECE File Offset: 0x001680CE
		public override bool? IsOneWay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOneWay;
				}
				IPathLineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOneWay;
			}
			set
			{
				this.GetOrCreatePoco().IsOneWay = value;
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x06009E31 RID: 40497 RVA: 0x00169EDC File Offset: 0x001680DC
		// (set) Token: 0x06009E32 RID: 40498 RVA: 0x00169F16 File Offset: 0x00168116
		public override float? LayerVerticalLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LayerVerticalLimit;
				}
				IPathLineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LayerVerticalLimit;
			}
			set
			{
				this.GetOrCreatePoco().LayerVerticalLimit = value;
			}
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x06009E33 RID: 40499 RVA: 0x00169F24 File Offset: 0x00168124
		// (set) Token: 0x06009E34 RID: 40500 RVA: 0x00169F5E File Offset: 0x0016815E
		public override bool? DynamicGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicGravity;
				}
				IPathLineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DynamicGravity;
			}
			set
			{
				this.GetOrCreatePoco().DynamicGravity = value;
			}
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x06009E35 RID: 40501 RVA: 0x00169F6C File Offset: 0x0016816C
		// (set) Token: 0x06009E36 RID: 40502 RVA: 0x00169FA6 File Offset: 0x001681A6
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				IPathLineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravitySwitchAngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().GravitySwitchAngularVelocity = value;
			}
		}

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x06009E37 RID: 40503 RVA: 0x00169FB4 File Offset: 0x001681B4
		// (set) Token: 0x06009E38 RID: 40504 RVA: 0x00169FEE File Offset: 0x001681EE
		public override int? AutoExitDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExitDistance;
				}
				IPathLineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoExitDistance;
			}
			set
			{
				this.GetOrCreatePoco().AutoExitDistance = value;
			}
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x06009E39 RID: 40505 RVA: 0x00169FFC File Offset: 0x001681FC
		// (set) Token: 0x06009E3A RID: 40506 RVA: 0x0016A023 File Offset: 0x00168223
		public virtual IPathLineFacingType FacingConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FacingConfig;
				}
				IPathLineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FacingConfig;
			}
			set
			{
				this.GetOrCreatePoco().FacingConfig = value;
			}
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x06009E3B RID: 40507 RVA: 0x0016A031 File Offset: 0x00168231
		// (set) Token: 0x06009E3C RID: 40508 RVA: 0x0016A058 File Offset: 0x00168258
		public virtual string SplineMoveConfigDaPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineMoveConfigDaPath;
				}
				IPathLineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SplineMoveConfigDaPath;
			}
			set
			{
				this.GetOrCreatePoco().SplineMoveConfigDaPath = value;
			}
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x06009E3D RID: 40509 RVA: 0x0016A068 File Offset: 0x00168268
		// (set) Token: 0x06009E3E RID: 40510 RVA: 0x0016A0A2 File Offset: 0x001682A2
		public virtual bool? IsAdaptiveClimbInput
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAdaptiveClimbInput;
				}
				IPathLineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAdaptiveClimbInput;
			}
			set
			{
				this.GetOrCreatePoco().IsAdaptiveClimbInput = value;
			}
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x06009E3F RID: 40511 RVA: 0x0016A0B0 File Offset: 0x001682B0
		// (set) Token: 0x06009E40 RID: 40512 RVA: 0x0016A0EA File Offset: 0x001682EA
		public virtual bool? IsDisableStopAnim
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDisableStopAnim;
				}
				IPathLineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDisableStopAnim;
			}
			set
			{
				this.GetOrCreatePoco().IsDisableStopAnim = value;
			}
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x06009E41 RID: 40513 RVA: 0x0016A0F8 File Offset: 0x001682F8
		// (set) Token: 0x06009E42 RID: 40514 RVA: 0x0016A132 File Offset: 0x00168332
		public virtual bool? IsAllowEarlyExitClimb
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAllowEarlyExitClimb;
				}
				IPathLineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAllowEarlyExitClimb;
			}
			set
			{
				this.GetOrCreatePoco().IsAllowEarlyExitClimb = value;
			}
		}

		// Token: 0x04005F9F RID: 24479
		protected new IPathLineMove FbInstance;

		// Token: 0x04005FA0 RID: 24480
		protected new IPathLineMove_SetValue PocoInterface;
	}
}
