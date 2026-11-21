using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B5B RID: 11099
	[NullableContext(2)]
	[Nullable(0)]
	public class IMontageData
	{
		// Token: 0x0600F3F4 RID: 62452 RVA: 0x002394C2 File Offset: 0x002376C2
		[NullableContext(0)]
		public static IMontageData Create(IMontageData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049EC RID: 18924
		// (get) Token: 0x0600F3F5 RID: 62453 RVA: 0x002394E1 File Offset: 0x002376E1
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x170049ED RID: 18925
		// (get) Token: 0x0600F3F6 RID: 62454 RVA: 0x002394F0 File Offset: 0x002376F0
		public virtual int? MontageId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MontageId);
			}
		}

		// Token: 0x170049EE RID: 18926
		// (get) Token: 0x0600F3F7 RID: 62455 RVA: 0x00239528 File Offset: 0x00237728
		public virtual bool? IsAbpMontage
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAbpMontage);
			}
		}

		// Token: 0x170049EF RID: 18927
		// (get) Token: 0x0600F3F8 RID: 62456 RVA: 0x00239560 File Offset: 0x00237760
		public virtual bool? IsLoop
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsLoop);
			}
		}

		// Token: 0x170049F0 RID: 18928
		// (get) Token: 0x0600F3F9 RID: 62457 RVA: 0x00239598 File Offset: 0x00237798
		public virtual bool? KeepPose
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepPose);
			}
		}

		// Token: 0x170049F1 RID: 18929
		// (get) Token: 0x0600F3FA RID: 62458 RVA: 0x002395D0 File Offset: 0x002377D0
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x170049F2 RID: 18930
		// (get) Token: 0x0600F3FB RID: 62459 RVA: 0x00239608 File Offset: 0x00237808
		public virtual bool? EndLoopingMontage
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EndLoopingMontage);
			}
		}

		// Token: 0x170049F3 RID: 18931
		// (get) Token: 0x0600F3FC RID: 62460 RVA: 0x00239640 File Offset: 0x00237840
		public virtual bool? EndMontageDirectly
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EndMontageDirectly);
			}
		}

		// Token: 0x170049F4 RID: 18932
		// (get) Token: 0x0600F3FD RID: 62461 RVA: 0x00239678 File Offset: 0x00237878
		public virtual bool? StartFromLoop
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.StartFromLoop);
			}
		}

		// Token: 0x170049F5 RID: 18933
		// (get) Token: 0x0600F3FE RID: 62462 RVA: 0x002396B2 File Offset: 0x002378B2
		public virtual IMontageParam OverlayMontage
		{
			get
			{
				if (this._OverlayMontageInited)
				{
					return this._OverlayMontageCache;
				}
				this._OverlayMontageInited = true;
				this._OverlayMontageCache = IMontageParam.Create(this.Instance.OverlayMontage);
				return this._OverlayMontageCache;
			}
		}

		// Token: 0x170049F6 RID: 18934
		// (get) Token: 0x0600F3FF RID: 62463 RVA: 0x002396E8 File Offset: 0x002378E8
		public virtual int? FaceExpressionId
		{
			get
			{
				if ((this.Instance.NullMask & 256) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FaceExpressionId);
			}
		}

		// Token: 0x170049F7 RID: 18935
		// (get) Token: 0x0600F400 RID: 62464 RVA: 0x00239724 File Offset: 0x00237924
		public virtual bool? KeepFaceExpression
		{
			get
			{
				if ((this.Instance.NullMask & 512) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepFaceExpression);
			}
		}

		// Token: 0x170049F8 RID: 18936
		// (get) Token: 0x0600F401 RID: 62465 RVA: 0x00239760 File Offset: 0x00237960
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
				if ((this.Instance.NullMask & 1024) == 0)
				{
					return null;
				}
				int fxEmoteLength = this.Instance.FxEmoteLength;
				this._FxEmoteCache = new List<IActorFxEmotePlay>(fxEmoteLength);
				for (int i = 0; i < fxEmoteLength; i++)
				{
					this._FxEmoteCache.Add(IActorFxEmotePlay.Create(this.Instance.FxEmote(i)));
				}
				return this._FxEmoteCache;
			}
		}

		// Token: 0x040085CB RID: 34251
		private IMontageData Instance;

		// Token: 0x040085CC RID: 34252
		private IMontageParam _OverlayMontageCache;

		// Token: 0x040085CD RID: 34253
		private bool _OverlayMontageInited;

		// Token: 0x040085CE RID: 34254
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmotePlay> _FxEmoteCache;

		// Token: 0x040085CF RID: 34255
		private bool _FxEmoteInited;
	}
}
