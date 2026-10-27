using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D1C RID: 7452
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayRegisteredMontageRender
	{
		// Token: 0x06009FDD RID: 40925 RVA: 0x0016CF30 File Offset: 0x0016B130
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

		// Token: 0x06009FDE RID: 40926 RVA: 0x0016CF68 File Offset: 0x0016B168
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

		// Token: 0x06009FDF RID: 40927 RVA: 0x0016CF7B File Offset: 0x0016B17B
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

		// Token: 0x06009FE0 RID: 40928 RVA: 0x0016CF90 File Offset: 0x0016B190
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

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x06009FE1 RID: 40929 RVA: 0x0016D002 File Offset: 0x0016B202
		// (set) Token: 0x06009FE2 RID: 40930 RVA: 0x0016D02D File Offset: 0x0016B22D
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

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x06009FE3 RID: 40931 RVA: 0x0016D03C File Offset: 0x0016B23C
		// (set) Token: 0x06009FE4 RID: 40932 RVA: 0x0016D076 File Offset: 0x0016B276
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

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x06009FE5 RID: 40933 RVA: 0x0016D084 File Offset: 0x0016B284
		// (set) Token: 0x06009FE6 RID: 40934 RVA: 0x0016D0E5 File Offset: 0x0016B2E5
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

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x06009FE7 RID: 40935 RVA: 0x0016D0FC File Offset: 0x0016B2FC
		// (set) Token: 0x06009FE8 RID: 40936 RVA: 0x0016D136 File Offset: 0x0016B336
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

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x06009FE9 RID: 40937 RVA: 0x0016D144 File Offset: 0x0016B344
		// (set) Token: 0x06009FEA RID: 40938 RVA: 0x0016D17E File Offset: 0x0016B37E
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

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x06009FEB RID: 40939 RVA: 0x0016D18C File Offset: 0x0016B38C
		// (set) Token: 0x06009FEC RID: 40940 RVA: 0x0016D1C6 File Offset: 0x0016B3C6
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

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x06009FED RID: 40941 RVA: 0x0016D1D4 File Offset: 0x0016B3D4
		// (set) Token: 0x06009FEE RID: 40942 RVA: 0x0016D20E File Offset: 0x0016B40E
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

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x06009FEF RID: 40943 RVA: 0x0016D21C File Offset: 0x0016B41C
		// (set) Token: 0x06009FF0 RID: 40944 RVA: 0x0016D256 File Offset: 0x0016B456
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

		// Token: 0x0400606C RID: 24684
		[Nullable(2)]
		protected IPlayRegisteredMontageRender FbInstance;

		// Token: 0x0400606D RID: 24685
		[Nullable(2)]
		protected IPlayRegisteredMontageRender_SetValue PocoInterface;

		// Token: 0x0400606E RID: 24686
		private IMontageId _MontageIdCache;

		// Token: 0x0400606F RID: 24687
		private bool _MontageIdInited;
	}
}
