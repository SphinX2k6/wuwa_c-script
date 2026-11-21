using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B5C RID: 11100
	[NullableContext(2)]
	[Nullable(0)]
	public class IMontageDataRender
	{
		// Token: 0x0600F403 RID: 62467 RVA: 0x002397E6 File Offset: 0x002379E6
		[NullableContext(0)]
		public static IMontageDataRender Create(IMontageDataRender? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageDataRender
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049F9 RID: 18937
		// (get) Token: 0x0600F404 RID: 62468 RVA: 0x00239805 File Offset: 0x00237A05
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x170049FA RID: 18938
		// (get) Token: 0x0600F405 RID: 62469 RVA: 0x00239812 File Offset: 0x00237A12
		public virtual IMontageParam BaseMontage
		{
			get
			{
				if (this._BaseMontageInited)
				{
					return this._BaseMontageCache;
				}
				this._BaseMontageInited = true;
				this._BaseMontageCache = IMontageParam.Create(this.Instance.BaseMontage);
				return this._BaseMontageCache;
			}
		}

		// Token: 0x170049FB RID: 18939
		// (get) Token: 0x0600F406 RID: 62470 RVA: 0x00239848 File Offset: 0x00237A48
		public virtual bool? EndLoopingMontage
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EndLoopingMontage);
			}
		}

		// Token: 0x170049FC RID: 18940
		// (get) Token: 0x0600F407 RID: 62471 RVA: 0x00239880 File Offset: 0x00237A80
		public virtual bool? EndMontageDirectly
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EndMontageDirectly);
			}
		}

		// Token: 0x170049FD RID: 18941
		// (get) Token: 0x0600F408 RID: 62472 RVA: 0x002398B8 File Offset: 0x00237AB8
		public virtual bool? StartFromLoop
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.StartFromLoop);
			}
		}

		// Token: 0x170049FE RID: 18942
		// (get) Token: 0x0600F409 RID: 62473 RVA: 0x002398EE File Offset: 0x00237AEE
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

		// Token: 0x170049FF RID: 18943
		// (get) Token: 0x0600F40A RID: 62474 RVA: 0x00239924 File Offset: 0x00237B24
		public virtual int? FaceExpressionId
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FaceExpressionId);
			}
		}

		// Token: 0x17004A00 RID: 18944
		// (get) Token: 0x0600F40B RID: 62475 RVA: 0x0023995C File Offset: 0x00237B5C
		public virtual bool? KeepFaceExpression
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepFaceExpression);
			}
		}

		// Token: 0x17004A01 RID: 18945
		// (get) Token: 0x0600F40C RID: 62476 RVA: 0x00239994 File Offset: 0x00237B94
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x17004A02 RID: 18946
		// (get) Token: 0x0600F40D RID: 62477 RVA: 0x002399CC File Offset: 0x00237BCC
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
				if ((this.Instance.NullMask & 64) == 0)
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

		// Token: 0x040085D0 RID: 34256
		private IMontageDataRender Instance;

		// Token: 0x040085D1 RID: 34257
		private IMontageParam _BaseMontageCache;

		// Token: 0x040085D2 RID: 34258
		private bool _BaseMontageInited;

		// Token: 0x040085D3 RID: 34259
		private IMontageParam _OverlayMontageCache;

		// Token: 0x040085D4 RID: 34260
		private bool _OverlayMontageInited;

		// Token: 0x040085D5 RID: 34261
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IActorFxEmotePlay> _FxEmoteCache;

		// Token: 0x040085D6 RID: 34262
		private bool _FxEmoteInited;
	}
}
