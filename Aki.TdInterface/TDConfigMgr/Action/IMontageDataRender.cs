using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C04 RID: 7172
	[NullableContext(2)]
	[Nullable(0)]
	public class IMontageDataRender
	{
		// Token: 0x060099A7 RID: 39335 RVA: 0x001618D0 File Offset: 0x0015FAD0
		[NullableContext(1)]
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

		// Token: 0x060099A8 RID: 39336 RVA: 0x00161908 File Offset: 0x0015FB08
		[NullableContext(1)]
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

		// Token: 0x060099A9 RID: 39337 RVA: 0x0016191B File Offset: 0x0015FB1B
		[NullableContext(1)]
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

		// Token: 0x060099AA RID: 39338 RVA: 0x00161930 File Offset: 0x0015FB30
		[NullableContext(1)]
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

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x060099AB RID: 39339 RVA: 0x001619BA File Offset: 0x0015FBBA
		// (set) Token: 0x060099AC RID: 39340 RVA: 0x001619E5 File Offset: 0x0015FBE5
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

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x060099AD RID: 39341 RVA: 0x001619F4 File Offset: 0x0015FBF4
		// (set) Token: 0x060099AE RID: 39342 RVA: 0x00161A55 File Offset: 0x0015FC55
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

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x060099AF RID: 39343 RVA: 0x00161A6C File Offset: 0x0015FC6C
		// (set) Token: 0x060099B0 RID: 39344 RVA: 0x00161AA6 File Offset: 0x0015FCA6
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

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x060099B1 RID: 39345 RVA: 0x00161AB4 File Offset: 0x0015FCB4
		// (set) Token: 0x060099B2 RID: 39346 RVA: 0x00161AEE File Offset: 0x0015FCEE
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

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x060099B3 RID: 39347 RVA: 0x00161AFC File Offset: 0x0015FCFC
		// (set) Token: 0x060099B4 RID: 39348 RVA: 0x00161B36 File Offset: 0x0015FD36
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

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x060099B5 RID: 39349 RVA: 0x00161B44 File Offset: 0x0015FD44
		// (set) Token: 0x060099B6 RID: 39350 RVA: 0x00161BA5 File Offset: 0x0015FDA5
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

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x060099B7 RID: 39351 RVA: 0x00161BBC File Offset: 0x0015FDBC
		// (set) Token: 0x060099B8 RID: 39352 RVA: 0x00161BF6 File Offset: 0x0015FDF6
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

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x060099B9 RID: 39353 RVA: 0x00161C04 File Offset: 0x0015FE04
		// (set) Token: 0x060099BA RID: 39354 RVA: 0x00161C3E File Offset: 0x0015FE3E
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

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x060099BB RID: 39355 RVA: 0x00161C4C File Offset: 0x0015FE4C
		// (set) Token: 0x060099BC RID: 39356 RVA: 0x00161C86 File Offset: 0x0015FE86
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

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x060099BD RID: 39357 RVA: 0x00161C94 File Offset: 0x0015FE94
		// (set) Token: 0x060099BE RID: 39358 RVA: 0x00161D27 File Offset: 0x0015FF27
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
					IMontageDataRender_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005D85 RID: 23941
		protected IMontageDataRender FbInstance;

		// Token: 0x04005D86 RID: 23942
		protected IMontageDataRender_SetValue PocoInterface;

		// Token: 0x04005D87 RID: 23943
		[Nullable(1)]
		private IMontageParam _BaseMontageCache;

		// Token: 0x04005D88 RID: 23944
		private bool _BaseMontageInited;

		// Token: 0x04005D89 RID: 23945
		[Nullable(1)]
		private IMontageParam _OverlayMontageCache;

		// Token: 0x04005D8A RID: 23946
		private bool _OverlayMontageInited;

		// Token: 0x04005D8B RID: 23947
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmotePlay> _FxEmoteCache;

		// Token: 0x04005D8C RID: 23948
		private bool _FxEmoteInited;
	}
}
