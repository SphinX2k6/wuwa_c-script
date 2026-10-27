using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE2 RID: 7138
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyActorMaterialParamBySplineProgressEnterSpline : IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x060098DD RID: 39133 RVA: 0x0016014C File Offset: 0x0015E34C
		private IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyActorMaterialParamBySplineProgressEnterSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue());
			}
			return result;
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x00160184 File Offset: 0x0015E384
		public static IModifyActorMaterialParamBySplineProgressEnterSpline Create([Nullable(2)] IModifyActorMaterialParamBySplineProgressEnterSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressEnterSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x00160197 File Offset: 0x0015E397
		public static IModifyActorMaterialParamBySplineProgressEnterSpline CreateFromSetValue([Nullable(2)] IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressEnterSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098E0 RID: 39136 RVA: 0x001601AA File Offset: 0x0015E3AA
		public new IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue ToSetValue()
		{
			return new IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId,
				ActorRefs = this.ActorRefs
			};
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x060098E1 RID: 39137 RVA: 0x001601D5 File Offset: 0x0015E3D5
		// (set) Token: 0x060098E2 RID: 39138 RVA: 0x00160200 File Offset: 0x0015E400
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

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x060098E3 RID: 39139 RVA: 0x0016020E File Offset: 0x0015E40E
		// (set) Token: 0x060098E4 RID: 39140 RVA: 0x00160239 File Offset: 0x0015E439
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

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x060098E5 RID: 39141 RVA: 0x00160248 File Offset: 0x0015E448
		// (set) Token: 0x060098E6 RID: 39142 RVA: 0x001602DB File Offset: 0x0015E4DB
		public virtual List<IActorRefWithMaterialParam> ActorRefs
		{
			get
			{
				if (this._ActorRefsInited)
				{
					return this._ActorRefsCache;
				}
				this._ActorRefsInited = true;
				if (this.FbInstance != null)
				{
					List<IActorRefWithMaterialParam> actorRefs = this.FbInstance.ActorRefs;
					if (actorRefs != null)
					{
						this._ActorRefsCache = new List<IActorRefWithMaterialParam>(actorRefs.Count);
						for (int i = 0; i < actorRefs.Count; i++)
						{
							this._ActorRefsCache.Add(IActorRefWithMaterialParam.Create(actorRefs[i]));
						}
					}
				}
				else
				{
					IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue pocoInterface = this.PocoInterface;
					this._ActorRefsCache = ((pocoInterface != null) ? pocoInterface.ActorRefs : null);
				}
				return this._ActorRefsCache;
			}
			set
			{
				this.GetOrCreatePoco().ActorRefs = value;
				this._ActorRefsInited = false;
			}
		}

		// Token: 0x04005D29 RID: 23849
		[Nullable(2)]
		protected new IModifyActorMaterialParamBySplineProgressEnterSpline FbInstance;

		// Token: 0x04005D2A RID: 23850
		[Nullable(2)]
		protected new IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue PocoInterface;

		// Token: 0x04005D2B RID: 23851
		private List<IActorRefWithMaterialParam> _ActorRefsCache;

		// Token: 0x04005D2C RID: 23852
		private bool _ActorRefsInited;
	}
}
