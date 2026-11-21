using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ECF RID: 7887
	[NullableContext(2)]
	[Nullable(0)]
	public class IPathLineMove : ISplineMovePattern
	{
		// Token: 0x0600A7D5 RID: 42965 RVA: 0x0017D970 File Offset: 0x0017BB70
		[NullableContext(0)]
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

		// Token: 0x0600A7D6 RID: 42966 RVA: 0x0017D9A8 File Offset: 0x0017BBA8
		[NullableContext(0)]
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

		// Token: 0x0600A7D7 RID: 42967 RVA: 0x0017D9BB File Offset: 0x0017BBBB
		[NullableContext(0)]
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

		// Token: 0x0600A7D8 RID: 42968 RVA: 0x0017D9D0 File Offset: 0x0017BBD0
		[NullableContext(0)]
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

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600A7D9 RID: 42969 RVA: 0x0017DA72 File Offset: 0x0017BC72
		// (set) Token: 0x0600A7DA RID: 42970 RVA: 0x0017DA9D File Offset: 0x0017BC9D
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

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600A7DB RID: 42971 RVA: 0x0017DAAC File Offset: 0x0017BCAC
		// (set) Token: 0x0600A7DC RID: 42972 RVA: 0x0017DAE6 File Offset: 0x0017BCE6
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

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600A7DD RID: 42973 RVA: 0x0017DAF4 File Offset: 0x0017BCF4
		// (set) Token: 0x0600A7DE RID: 42974 RVA: 0x0017DB2E File Offset: 0x0017BD2E
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

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600A7DF RID: 42975 RVA: 0x0017DB3C File Offset: 0x0017BD3C
		// (set) Token: 0x0600A7E0 RID: 42976 RVA: 0x0017DB76 File Offset: 0x0017BD76
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

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600A7E1 RID: 42977 RVA: 0x0017DB84 File Offset: 0x0017BD84
		// (set) Token: 0x0600A7E2 RID: 42978 RVA: 0x0017DBBE File Offset: 0x0017BDBE
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

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600A7E3 RID: 42979 RVA: 0x0017DBCC File Offset: 0x0017BDCC
		// (set) Token: 0x0600A7E4 RID: 42980 RVA: 0x0017DC06 File Offset: 0x0017BE06
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

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600A7E5 RID: 42981 RVA: 0x0017DC14 File Offset: 0x0017BE14
		// (set) Token: 0x0600A7E6 RID: 42982 RVA: 0x0017DC4E File Offset: 0x0017BE4E
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

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600A7E7 RID: 42983 RVA: 0x0017DC5C File Offset: 0x0017BE5C
		// (set) Token: 0x0600A7E8 RID: 42984 RVA: 0x0017DC83 File Offset: 0x0017BE83
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

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600A7E9 RID: 42985 RVA: 0x0017DC91 File Offset: 0x0017BE91
		// (set) Token: 0x0600A7EA RID: 42986 RVA: 0x0017DCB8 File Offset: 0x0017BEB8
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

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600A7EB RID: 42987 RVA: 0x0017DCC8 File Offset: 0x0017BEC8
		// (set) Token: 0x0600A7EC RID: 42988 RVA: 0x0017DD02 File Offset: 0x0017BF02
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

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600A7ED RID: 42989 RVA: 0x0017DD10 File Offset: 0x0017BF10
		// (set) Token: 0x0600A7EE RID: 42990 RVA: 0x0017DD4A File Offset: 0x0017BF4A
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

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600A7EF RID: 42991 RVA: 0x0017DD58 File Offset: 0x0017BF58
		// (set) Token: 0x0600A7F0 RID: 42992 RVA: 0x0017DD92 File Offset: 0x0017BF92
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

		// Token: 0x040064FB RID: 25851
		protected new IPathLineMove FbInstance;

		// Token: 0x040064FC RID: 25852
		protected new IPathLineMove_SetValue PocoInterface;
	}
}
