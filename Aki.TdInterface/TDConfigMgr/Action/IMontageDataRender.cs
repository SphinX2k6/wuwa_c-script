using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF3 RID: 7667
	[NullableContext(2)]
	[Nullable(0)]
	public class IMontageDataRender
	{
		// Token: 0x0600A2D7 RID: 41687 RVA: 0x0017481C File Offset: 0x00172A1C
		[NullableContext(0)]
		private IMontageDataRender_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMontageDataRender 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMontageDataRender_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMontageDataRender_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x00174854 File Offset: 0x00172A54
		[NullableContext(0)]
		public static IMontageDataRender Create([Nullable(2)] IMontageDataRender instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageDataRender
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x00174867 File Offset: 0x00172A67
		[NullableContext(0)]
		public static IMontageDataRender CreateFromSetValue([Nullable(2)] IMontageDataRender_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMontageDataRender
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x0017487C File Offset: 0x00172A7C
		[NullableContext(0)]
		public IMontageDataRender_SetValue ToSetValue()
		{
			return new IMontageDataRender_SetValue
			{
				ActorIndex = this.ActorIndex,
				BaseMontage = this.BaseMontage,
				EndLoopingMontage = this.EndLoopingMontage,
				EndMontageDirectly = this.EndMontageDirectly,
				StartFromLoop = this.StartFromLoop,
				OverlayMontage = this.OverlayMontage,
				FaceExpressionId = this.FaceExpressionId,
				KeepFaceExpression = this.KeepFaceExpression,
				DelayTime = this.DelayTime,
				FxEmote = this.FxEmote
			};
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600A2DB RID: 41691 RVA: 0x00174906 File Offset: 0x00172B06
		// (set) Token: 0x0600A2DC RID: 41692 RVA: 0x00174931 File Offset: 0x00172B31
		public virtual int ActorIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActorIndex;
			}
			set
			{
				this.GetOrCreatePoco().ActorIndex = value;
			}
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600A2DD RID: 41693 RVA: 0x00174940 File Offset: 0x00172B40
		// (set) Token: 0x0600A2DE RID: 41694 RVA: 0x001749A1 File Offset: 0x00172BA1
		public virtual IMontageParam BaseMontage
		{
			get
			{
				if (this._BaseMontageInited)
				{
					return this._BaseMontageCache;
				}
				this._BaseMontageInited = true;
				if (this.FbInstance != null)
				{
					this._BaseMontageCache = IMontageParam.Create(this.FbInstance.BaseMontage);
				}
				else
				{
					IMontageDataRender_SetValue pocoInterface = this.PocoInterface;
					this._BaseMontageCache = ((pocoInterface != null) ? pocoInterface.BaseMontage : null);
				}
				return this._BaseMontageCache;
			}
			set
			{
				this.GetOrCreatePoco().BaseMontage = value;
				this._BaseMontageInited = false;
			}
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600A2DF RID: 41695 RVA: 0x001749B8 File Offset: 0x00172BB8
		// (set) Token: 0x0600A2E0 RID: 41696 RVA: 0x001749F2 File Offset: 0x00172BF2
		public virtual bool? EndLoopingMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndLoopingMontage;
				}
				IMontageDataRender_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndLoopingMontage;
			}
			set
			{
				this.GetOrCreatePoco().EndLoopingMontage = value;
			}
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600A2E1 RID: 41697 RVA: 0x00174A00 File Offset: 0x00172C00
		// (set) Token: 0x0600A2E2 RID: 41698 RVA: 0x00174A3A File Offset: 0x00172C3A
		public virtual bool? EndMontageDirectly
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndMontageDirectly;
				}
				IMontageDataRender_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndMontageDirectly;
			}
			set
			{
				this.GetOrCreatePoco().EndMontageDirectly = value;
			}
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600A2E3 RID: 41699 RVA: 0x00174A48 File Offset: 0x00172C48
		// (set) Token: 0x0600A2E4 RID: 41700 RVA: 0x00174A82 File Offset: 0x00172C82
		public virtual bool? StartFromLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartFromLoop;
				}
				IMontageDataRender_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartFromLoop;
			}
			set
			{
				this.GetOrCreatePoco().StartFromLoop = value;
			}
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600A2E5 RID: 41701 RVA: 0x00174A90 File Offset: 0x00172C90
		// (set) Token: 0x0600A2E6 RID: 41702 RVA: 0x00174AF1 File Offset: 0x00172CF1
		public virtual IMontageParam OverlayMontage
		{
			get
			{
				if (this._OverlayMontageInited)
				{
					return this._OverlayMontageCache;
				}
				this._OverlayMontageInited = true;
				if (this.FbInstance != null)
				{
					this._OverlayMontageCache = IMontageParam.Create(this.FbInstance.OverlayMontage);
				}
				else
				{
					IMontageDataRender_SetValue pocoInterface = this.PocoInterface;
					this._OverlayMontageCache = ((pocoInterface != null) ? pocoInterface.OverlayMontage : null);
				}
				return this._OverlayMontageCache;
			}
			set
			{
				this.GetOrCreatePoco().OverlayMontage = value;
				this._OverlayMontageInited = false;
			}
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600A2E7 RID: 41703 RVA: 0x00174B08 File Offset: 0x00172D08
		// (set) Token: 0x0600A2E8 RID: 41704 RVA: 0x00174B42 File Offset: 0x00172D42
		public virtual int? FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				IMontageDataRender_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600A2E9 RID: 41705 RVA: 0x00174B50 File Offset: 0x00172D50
		// (set) Token: 0x0600A2EA RID: 41706 RVA: 0x00174B8A File Offset: 0x00172D8A
		public virtual bool? KeepFaceExpression
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepFaceExpression;
				}
				IMontageDataRender_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepFaceExpression;
			}
			set
			{
				this.GetOrCreatePoco().KeepFaceExpression = value;
			}
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600A2EB RID: 41707 RVA: 0x00174B98 File Offset: 0x00172D98
		// (set) Token: 0x0600A2EC RID: 41708 RVA: 0x00174BD2 File Offset: 0x00172DD2
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IMontageDataRender_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600A2ED RID: 41709 RVA: 0x00174BE0 File Offset: 0x00172DE0
		// (set) Token: 0x0600A2EE RID: 41710 RVA: 0x00174C73 File Offset: 0x00172E73
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IActorFxEmotePlay> FxEmote
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._FxEmoteInited)
				{
					return this._FxEmoteCache;
				}
				this._FxEmoteInited = true;
				if (this.FbInstance != null)
				{
					List<IActorFxEmotePlay> fxEmote = this.FbInstance.FxEmote;
					if (fxEmote != null)
					{
						this._FxEmoteCache = new List<IActorFxEmotePlay>(fxEmote.Count);
						for (int i = 0; i < fxEmote.Count; i++)
						{
							this._FxEmoteCache.Add(IActorFxEmotePlay.Create(fxEmote[i]));
						}
					}
				}
				else
				{
					IMontageDataRender_SetValue pocoInterface = this.PocoInterface;
					this._FxEmoteCache = ((pocoInterface != null) ? pocoInterface.FxEmote : null);
				}
				return this._FxEmoteCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().FxEmote = value;
				this._FxEmoteInited = false;
			}
		}

		// Token: 0x040062AC RID: 25260
		protected IMontageDataRender FbInstance;

		// Token: 0x040062AD RID: 25261
		protected IMontageDataRender_SetValue PocoInterface;

		// Token: 0x040062AE RID: 25262
		[Nullable(0)]
		private IMontageParam _BaseMontageCache;

		// Token: 0x040062AF RID: 25263
		private bool _BaseMontageInited;

		// Token: 0x040062B0 RID: 25264
		[Nullable(0)]
		private IMontageParam _OverlayMontageCache;

		// Token: 0x040062B1 RID: 25265
		private bool _OverlayMontageInited;

		// Token: 0x040062B2 RID: 25266
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmotePlay> _FxEmoteCache;

		// Token: 0x040062B3 RID: 25267
		private bool _FxEmoteInited;
	}
}
