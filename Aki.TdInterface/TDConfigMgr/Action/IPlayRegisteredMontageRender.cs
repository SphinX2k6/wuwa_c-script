using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F2D RID: 7981
	public class IPlayRegisteredMontageRender
	{
		// Token: 0x0600A9C9 RID: 43465 RVA: 0x00181354 File Offset: 0x0017F554
		private IPlayRegisteredMontageRender_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayRegisteredMontageRender 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayRegisteredMontageRender_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayRegisteredMontageRender_SetValue());
			}
			return result;
		}

		// Token: 0x0600A9CA RID: 43466 RVA: 0x0018138C File Offset: 0x0017F58C
		public static IPlayRegisteredMontageRender Create([Nullable(2)] IPlayRegisteredMontageRender instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayRegisteredMontageRender
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A9CB RID: 43467 RVA: 0x0018139F File Offset: 0x0017F59F
		public static IPlayRegisteredMontageRender CreateFromSetValue([Nullable(2)] IPlayRegisteredMontageRender_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayRegisteredMontageRender
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A9CC RID: 43468 RVA: 0x001813B4 File Offset: 0x0017F5B4
		public IPlayRegisteredMontageRender_SetValue ToSetValue()
		{
			return new IPlayRegisteredMontageRender_SetValue
			{
				EntityId = this.EntityId,
				IsOverlayMontage = this.IsOverlayMontage,
				MontageId = this.MontageId,
				FaceExpressionId = this.FaceExpressionId,
				LoopDuration = this.LoopDuration,
				RepeatTimes = this.RepeatTimes,
				KeepMontageWhenEnd = this.KeepMontageWhenEnd,
				KeepMontageAfterFlow = this.KeepMontageAfterFlow
			};
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600A9CD RID: 43469 RVA: 0x00181426 File Offset: 0x0017F626
		// (set) Token: 0x0600A9CE RID: 43470 RVA: 0x00181451 File Offset: 0x0017F651
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600A9CF RID: 43471 RVA: 0x00181460 File Offset: 0x0017F660
		// (set) Token: 0x0600A9D0 RID: 43472 RVA: 0x0018149A File Offset: 0x0017F69A
		public virtual bool? IsOverlayMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOverlayMontage;
				}
				IPlayRegisteredMontageRender_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOverlayMontage;
			}
			set
			{
				this.GetOrCreatePoco().IsOverlayMontage = value;
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600A9D1 RID: 43473 RVA: 0x001814A8 File Offset: 0x0017F6A8
		// (set) Token: 0x0600A9D2 RID: 43474 RVA: 0x00181509 File Offset: 0x0017F709
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._MontageIdCache = IMontageId.Create(this.FbInstance.MontageId);
				}
				else
				{
					IPlayRegisteredMontageRender_SetValue pocoInterface = this.PocoInterface;
					this._MontageIdCache = ((pocoInterface != null) ? pocoInterface.MontageId : null);
				}
				return this._MontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
				this._MontageIdInited = false;
			}
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600A9D3 RID: 43475 RVA: 0x00181520 File Offset: 0x0017F720
		// (set) Token: 0x0600A9D4 RID: 43476 RVA: 0x0018155A File Offset: 0x0017F75A
		public virtual int? FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				IPlayRegisteredMontageRender_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FaceExpressionId;
			}
			set
			{
				this.GetOrCreatePoco().FaceExpressionId = value;
			}
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600A9D5 RID: 43477 RVA: 0x00181568 File Offset: 0x0017F768
		// (set) Token: 0x0600A9D6 RID: 43478 RVA: 0x001815A2 File Offset: 0x0017F7A2
		public virtual float? LoopDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoopDuration;
				}
				IPlayRegisteredMontageRender_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LoopDuration;
			}
			set
			{
				this.GetOrCreatePoco().LoopDuration = value;
			}
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600A9D7 RID: 43479 RVA: 0x001815B0 File Offset: 0x0017F7B0
		// (set) Token: 0x0600A9D8 RID: 43480 RVA: 0x001815EA File Offset: 0x0017F7EA
		public virtual int? RepeatTimes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RepeatTimes;
				}
				IPlayRegisteredMontageRender_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RepeatTimes;
			}
			set
			{
				this.GetOrCreatePoco().RepeatTimes = value;
			}
		}

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600A9D9 RID: 43481 RVA: 0x001815F8 File Offset: 0x0017F7F8
		// (set) Token: 0x0600A9DA RID: 43482 RVA: 0x00181632 File Offset: 0x0017F832
		public virtual bool? KeepMontageWhenEnd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepMontageWhenEnd;
				}
				IPlayRegisteredMontageRender_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepMontageWhenEnd;
			}
			set
			{
				this.GetOrCreatePoco().KeepMontageWhenEnd = value;
			}
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600A9DB RID: 43483 RVA: 0x00181640 File Offset: 0x0017F840
		// (set) Token: 0x0600A9DC RID: 43484 RVA: 0x0018167A File Offset: 0x0017F87A
		public virtual bool? KeepMontageAfterFlow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepMontageAfterFlow;
				}
				IPlayRegisteredMontageRender_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepMontageAfterFlow;
			}
			set
			{
				this.GetOrCreatePoco().KeepMontageAfterFlow = value;
			}
		}

		// Token: 0x040065E8 RID: 26088
		[Nullable(2)]
		protected IPlayRegisteredMontageRender FbInstance;

		// Token: 0x040065E9 RID: 26089
		[Nullable(2)]
		protected IPlayRegisteredMontageRender_SetValue PocoInterface;

		// Token: 0x040065EA RID: 26090
		private IMontageId _MontageIdCache;

		// Token: 0x040065EB RID: 26091
		private bool _MontageIdInited;
	}
}
