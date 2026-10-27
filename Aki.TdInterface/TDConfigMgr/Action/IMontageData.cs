using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C02 RID: 7170
	[NullableContext(1)]
	[Nullable(0)]
	public class IMontageData
	{
		// Token: 0x06009987 RID: 39303 RVA: 0x00161388 File Offset: 0x0015F588
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

		// Token: 0x06009988 RID: 39304 RVA: 0x001613C0 File Offset: 0x0015F5C0
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

		// Token: 0x06009989 RID: 39305 RVA: 0x001613D3 File Offset: 0x0015F5D3
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

		// Token: 0x0600998A RID: 39306 RVA: 0x001613E8 File Offset: 0x0015F5E8
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

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x0600998B RID: 39307 RVA: 0x00161496 File Offset: 0x0015F696
		// (set) Token: 0x0600998C RID: 39308 RVA: 0x001614C1 File Offset: 0x0015F6C1
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

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x0600998D RID: 39309 RVA: 0x001614D0 File Offset: 0x0015F6D0
		// (set) Token: 0x0600998E RID: 39310 RVA: 0x0016150A File Offset: 0x0015F70A
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

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x0600998F RID: 39311 RVA: 0x00161518 File Offset: 0x0015F718
		// (set) Token: 0x06009990 RID: 39312 RVA: 0x00161552 File Offset: 0x0015F752
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

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x06009991 RID: 39313 RVA: 0x00161560 File Offset: 0x0015F760
		// (set) Token: 0x06009992 RID: 39314 RVA: 0x0016159A File Offset: 0x0015F79A
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

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x06009993 RID: 39315 RVA: 0x001615A8 File Offset: 0x0015F7A8
		// (set) Token: 0x06009994 RID: 39316 RVA: 0x001615E2 File Offset: 0x0015F7E2
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

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x06009995 RID: 39317 RVA: 0x001615F0 File Offset: 0x0015F7F0
		// (set) Token: 0x06009996 RID: 39318 RVA: 0x0016162A File Offset: 0x0015F82A
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

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x06009997 RID: 39319 RVA: 0x00161638 File Offset: 0x0015F838
		// (set) Token: 0x06009998 RID: 39320 RVA: 0x00161672 File Offset: 0x0015F872
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

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x06009999 RID: 39321 RVA: 0x00161680 File Offset: 0x0015F880
		// (set) Token: 0x0600999A RID: 39322 RVA: 0x001616BA File Offset: 0x0015F8BA
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

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x0600999B RID: 39323 RVA: 0x001616C8 File Offset: 0x0015F8C8
		// (set) Token: 0x0600999C RID: 39324 RVA: 0x00161702 File Offset: 0x0015F902
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

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x0600999D RID: 39325 RVA: 0x00161710 File Offset: 0x0015F910
		// (set) Token: 0x0600999E RID: 39326 RVA: 0x00161771 File Offset: 0x0015F971
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

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x0600999F RID: 39327 RVA: 0x00161788 File Offset: 0x0015F988
		// (set) Token: 0x060099A0 RID: 39328 RVA: 0x001617C2 File Offset: 0x0015F9C2
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

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x060099A1 RID: 39329 RVA: 0x001617D0 File Offset: 0x0015F9D0
		// (set) Token: 0x060099A2 RID: 39330 RVA: 0x0016180A File Offset: 0x0015FA0A
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

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x060099A3 RID: 39331 RVA: 0x00161818 File Offset: 0x0015FA18
		// (set) Token: 0x060099A4 RID: 39332 RVA: 0x001618AB File Offset: 0x0015FAAB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IActorFxEmotePlay> FxEmote
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().FxEmote = value;
				this._FxEmoteInited = false;
			}
		}

		// Token: 0x04005D72 RID: 23922
		[Nullable(2)]
		protected IMontageData FbInstance;

		// Token: 0x04005D73 RID: 23923
		[Nullable(2)]
		protected IMontageData_SetValue PocoInterface;

		// Token: 0x04005D74 RID: 23924
		private IMontageParam _OverlayMontageCache;

		// Token: 0x04005D75 RID: 23925
		private bool _OverlayMontageInited;

		// Token: 0x04005D76 RID: 23926
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmotePlay> _FxEmoteCache;

		// Token: 0x04005D77 RID: 23927
		private bool _FxEmoteInited;
	}
}
