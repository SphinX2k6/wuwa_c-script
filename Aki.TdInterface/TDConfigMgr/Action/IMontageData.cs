using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF1 RID: 7665
	public class IMontageData
	{
		// Token: 0x0600A2B7 RID: 41655 RVA: 0x001742D4 File Offset: 0x001724D4
		private IMontageData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMontageData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMontageData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMontageData_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x0017430C File Offset: 0x0017250C
		public static IMontageData Create([Nullable(2)] IMontageData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2B9 RID: 41657 RVA: 0x0017431F File Offset: 0x0017251F
		public static IMontageData CreateFromSetValue([Nullable(2)] IMontageData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMontageData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2BA RID: 41658 RVA: 0x00174334 File Offset: 0x00172534
		public IMontageData_SetValue ToSetValue()
		{
			return new IMontageData_SetValue
			{
				ActorIndex = this.ActorIndex,
				MontageId = this.MontageId,
				IsAbpMontage = this.IsAbpMontage,
				IsLoop = this.IsLoop,
				KeepPose = this.KeepPose,
				DelayTime = this.DelayTime,
				EndLoopingMontage = this.EndLoopingMontage,
				EndMontageDirectly = this.EndMontageDirectly,
				StartFromLoop = this.StartFromLoop,
				OverlayMontage = this.OverlayMontage,
				FaceExpressionId = this.FaceExpressionId,
				KeepFaceExpression = this.KeepFaceExpression,
				FxEmote = this.FxEmote
			};
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600A2BB RID: 41659 RVA: 0x001743E2 File Offset: 0x001725E2
		// (set) Token: 0x0600A2BC RID: 41660 RVA: 0x0017440D File Offset: 0x0017260D
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

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600A2BD RID: 41661 RVA: 0x0017441C File Offset: 0x0017261C
		// (set) Token: 0x0600A2BE RID: 41662 RVA: 0x00174456 File Offset: 0x00172656
		public virtual int? MontageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageId;
				}
				IMontageData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MontageId;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
			}
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600A2BF RID: 41663 RVA: 0x00174464 File Offset: 0x00172664
		// (set) Token: 0x0600A2C0 RID: 41664 RVA: 0x0017449E File Offset: 0x0017269E
		public virtual bool? IsAbpMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAbpMontage;
				}
				IMontageData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAbpMontage;
			}
			set
			{
				this.GetOrCreatePoco().IsAbpMontage = value;
			}
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600A2C1 RID: 41665 RVA: 0x001744AC File Offset: 0x001726AC
		// (set) Token: 0x0600A2C2 RID: 41666 RVA: 0x001744E6 File Offset: 0x001726E6
		public virtual bool? IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				IMontageData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600A2C3 RID: 41667 RVA: 0x001744F4 File Offset: 0x001726F4
		// (set) Token: 0x0600A2C4 RID: 41668 RVA: 0x0017452E File Offset: 0x0017272E
		public virtual bool? KeepPose
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepPose;
				}
				IMontageData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepPose;
			}
			set
			{
				this.GetOrCreatePoco().KeepPose = value;
			}
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600A2C5 RID: 41669 RVA: 0x0017453C File Offset: 0x0017273C
		// (set) Token: 0x0600A2C6 RID: 41670 RVA: 0x00174576 File Offset: 0x00172776
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IMontageData_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600A2C7 RID: 41671 RVA: 0x00174584 File Offset: 0x00172784
		// (set) Token: 0x0600A2C8 RID: 41672 RVA: 0x001745BE File Offset: 0x001727BE
		public virtual bool? EndLoopingMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndLoopingMontage;
				}
				IMontageData_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600A2C9 RID: 41673 RVA: 0x001745CC File Offset: 0x001727CC
		// (set) Token: 0x0600A2CA RID: 41674 RVA: 0x00174606 File Offset: 0x00172806
		public virtual bool? EndMontageDirectly
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndMontageDirectly;
				}
				IMontageData_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600A2CB RID: 41675 RVA: 0x00174614 File Offset: 0x00172814
		// (set) Token: 0x0600A2CC RID: 41676 RVA: 0x0017464E File Offset: 0x0017284E
		public virtual bool? StartFromLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartFromLoop;
				}
				IMontageData_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600A2CD RID: 41677 RVA: 0x0017465C File Offset: 0x0017285C
		// (set) Token: 0x0600A2CE RID: 41678 RVA: 0x001746BD File Offset: 0x001728BD
		[Nullable(2)]
		public virtual IMontageParam OverlayMontage
		{
			[NullableContext(2)]
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
					IMontageData_SetValue pocoInterface = this.PocoInterface;
					this._OverlayMontageCache = ((pocoInterface != null) ? pocoInterface.OverlayMontage : null);
				}
				return this._OverlayMontageCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().OverlayMontage = value;
				this._OverlayMontageInited = false;
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600A2CF RID: 41679 RVA: 0x001746D4 File Offset: 0x001728D4
		// (set) Token: 0x0600A2D0 RID: 41680 RVA: 0x0017470E File Offset: 0x0017290E
		public virtual int? FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				IMontageData_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600A2D1 RID: 41681 RVA: 0x0017471C File Offset: 0x0017291C
		// (set) Token: 0x0600A2D2 RID: 41682 RVA: 0x00174756 File Offset: 0x00172956
		public virtual bool? KeepFaceExpression
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepFaceExpression;
				}
				IMontageData_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600A2D3 RID: 41683 RVA: 0x00174764 File Offset: 0x00172964
		// (set) Token: 0x0600A2D4 RID: 41684 RVA: 0x001747F7 File Offset: 0x001729F7
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
					IMontageData_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006299 RID: 25241
		[Nullable(2)]
		protected IMontageData FbInstance;

		// Token: 0x0400629A RID: 25242
		[Nullable(2)]
		protected IMontageData_SetValue PocoInterface;

		// Token: 0x0400629B RID: 25243
		private IMontageParam _OverlayMontageCache;

		// Token: 0x0400629C RID: 25244
		private bool _OverlayMontageInited;

		// Token: 0x0400629D RID: 25245
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmotePlay> _FxEmoteCache;

		// Token: 0x0400629E RID: 25246
		private bool _FxEmoteInited;
	}
}
