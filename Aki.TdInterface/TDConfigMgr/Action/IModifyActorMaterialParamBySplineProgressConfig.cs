using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DCD RID: 7629
	public class IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x0600A1F3 RID: 41459 RVA: 0x00172DC8 File Offset: 0x00170FC8
		private IModifyActorMaterialParamBySplineProgressConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyActorMaterialParamBySplineProgressConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyActorMaterialParamBySplineProgressConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyActorMaterialParamBySplineProgressConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x00172E00 File Offset: 0x00171000
		public static IModifyActorMaterialParamBySplineProgressConfig Create([Nullable(2)] IModifyActorMaterialParamBySplineProgressConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1F5 RID: 41461 RVA: 0x00172E13 File Offset: 0x00171013
		public static IModifyActorMaterialParamBySplineProgressConfig CreateFromSetValue([Nullable(2)] IModifyActorMaterialParamBySplineProgressConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x00172E26 File Offset: 0x00171026
		public IModifyActorMaterialParamBySplineProgressConfig_SetValue ToSetValue()
		{
			return new IModifyActorMaterialParamBySplineProgressConfig_SetValue
			{
				Type = this.Type,
				MoveTarget = this.MoveTarget,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600A1F7 RID: 41463 RVA: 0x00172E51 File Offset: 0x00171051
		// (set) Token: 0x0600A1F8 RID: 41464 RVA: 0x00172E7C File Offset: 0x0017107C
		public virtual EModifyActorMaterialParamBySplineProgressType Type
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

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600A1F9 RID: 41465 RVA: 0x00172E8A File Offset: 0x0017108A
		// (set) Token: 0x0600A1FA RID: 41466 RVA: 0x00172EB1 File Offset: 0x001710B1
		[Nullable(2)]
		public virtual IModifyActorMaterialParamBySplineProgressTarget MoveTarget
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveTarget;
				}
				IModifyActorMaterialParamBySplineProgressConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600A1FB RID: 41467 RVA: 0x00172EBF File Offset: 0x001710BF
		// (set) Token: 0x0600A1FC RID: 41468 RVA: 0x00172EEA File Offset: 0x001710EA
		public virtual int SplineEntityId
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

		// Token: 0x04006245 RID: 25157
		[Nullable(2)]
		protected IModifyActorMaterialParamBySplineProgressConfig FbInstance;

		// Token: 0x04006246 RID: 25158
		[Nullable(2)]
		protected IModifyActorMaterialParamBySplineProgressConfig_SetValue PocoInterface;
	}
}
