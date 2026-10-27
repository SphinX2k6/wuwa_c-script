using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002887 RID: 10375
	[NullableContext(2)]
	[Nullable(0)]
	public class IMontageDataRender
	{
		// Token: 0x0600E5D4 RID: 58836 RVA: 0x0021C866 File Offset: 0x0021AA66
		[NullableContext(1)]
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

		// Token: 0x17004688 RID: 18056
		// (get) Token: 0x0600E5D5 RID: 58837 RVA: 0x0021C885 File Offset: 0x0021AA85
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17004689 RID: 18057
		// (get) Token: 0x0600E5D6 RID: 58838 RVA: 0x0021C892 File Offset: 0x0021AA92
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

		// Token: 0x1700468A RID: 18058
		// (get) Token: 0x0600E5D7 RID: 58839 RVA: 0x0021C8C8 File Offset: 0x0021AAC8
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

		// Token: 0x1700468B RID: 18059
		// (get) Token: 0x0600E5D8 RID: 58840 RVA: 0x0021C900 File Offset: 0x0021AB00
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

		// Token: 0x1700468C RID: 18060
		// (get) Token: 0x0600E5D9 RID: 58841 RVA: 0x0021C938 File Offset: 0x0021AB38
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

		// Token: 0x1700468D RID: 18061
		// (get) Token: 0x0600E5DA RID: 58842 RVA: 0x0021C96E File Offset: 0x0021AB6E
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

		// Token: 0x1700468E RID: 18062
		// (get) Token: 0x0600E5DB RID: 58843 RVA: 0x0021C9A4 File Offset: 0x0021ABA4
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

		// Token: 0x1700468F RID: 18063
		// (get) Token: 0x0600E5DC RID: 58844 RVA: 0x0021C9DC File Offset: 0x0021ABDC
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

		// Token: 0x17004690 RID: 18064
		// (get) Token: 0x0600E5DD RID: 58845 RVA: 0x0021CA14 File Offset: 0x0021AC14
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

		// Token: 0x17004691 RID: 18065
		// (get) Token: 0x0600E5DE RID: 58846 RVA: 0x0021CA4C File Offset: 0x0021AC4C
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

		// Token: 0x04007F11 RID: 32529
		private IMontageDataRender Instance;

		// Token: 0x04007F12 RID: 32530
		private IMontageParam _BaseMontageCache;

		// Token: 0x04007F13 RID: 32531
		private bool _BaseMontageInited;

		// Token: 0x04007F14 RID: 32532
		private IMontageParam _OverlayMontageCache;

		// Token: 0x04007F15 RID: 32533
		private bool _OverlayMontageInited;

		// Token: 0x04007F16 RID: 32534
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmotePlay> _FxEmoteCache;

		// Token: 0x04007F17 RID: 32535
		private bool _FxEmoteInited;
	}
}
