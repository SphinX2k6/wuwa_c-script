using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DCF RID: 7631
	public class IModifyActorMaterialParamBySplineProgressEnterSpline : IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x0600A1FF RID: 41471 RVA: 0x00172F08 File Offset: 0x00171108
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

		// Token: 0x0600A200 RID: 41472 RVA: 0x00172F40 File Offset: 0x00171140
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

		// Token: 0x0600A201 RID: 41473 RVA: 0x00172F53 File Offset: 0x00171153
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

		// Token: 0x0600A202 RID: 41474 RVA: 0x00172F66 File Offset: 0x00171166
		public new IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue ToSetValue()
		{
			return new IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue
			{
				Type = this.Type,
				MoveTarget = this.MoveTarget,
				SplineEntityId = this.SplineEntityId,
				ActorRefs = this.ActorRefs
			};
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600A203 RID: 41475 RVA: 0x00172F9D File Offset: 0x0017119D
		// (set) Token: 0x0600A204 RID: 41476 RVA: 0x00172FC8 File Offset: 0x001711C8
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

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600A205 RID: 41477 RVA: 0x00172FD6 File Offset: 0x001711D6
		// (set) Token: 0x0600A206 RID: 41478 RVA: 0x00172FFD File Offset: 0x001711FD
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
				IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600A207 RID: 41479 RVA: 0x0017300B File Offset: 0x0017120B
		// (set) Token: 0x0600A208 RID: 41480 RVA: 0x00173036 File Offset: 0x00171236
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

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600A209 RID: 41481 RVA: 0x00173044 File Offset: 0x00171244
		// (set) Token: 0x0600A20A RID: 41482 RVA: 0x001730D7 File Offset: 0x001712D7
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

		// Token: 0x0400624A RID: 25162
		[Nullable(2)]
		protected new IModifyActorMaterialParamBySplineProgressEnterSpline FbInstance;

		// Token: 0x0400624B RID: 25163
		[Nullable(2)]
		protected new IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue PocoInterface;

		// Token: 0x0400624C RID: 25164
		private List<IActorRefWithMaterialParam> _ActorRefsCache;

		// Token: 0x0400624D RID: 25165
		private bool _ActorRefsInited;
	}
}
