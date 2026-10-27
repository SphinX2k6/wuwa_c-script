using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002886 RID: 10374
	[NullableContext(2)]
	[Nullable(0)]
	public class IMontageData
	{
		// Token: 0x0600E5C5 RID: 58821 RVA: 0x0021C542 File Offset: 0x0021A742
		[NullableContext(1)]
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

		// Token: 0x1700467B RID: 18043
		// (get) Token: 0x0600E5C6 RID: 58822 RVA: 0x0021C561 File Offset: 0x0021A761
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x1700467C RID: 18044
		// (get) Token: 0x0600E5C7 RID: 58823 RVA: 0x0021C570 File Offset: 0x0021A770
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

		// Token: 0x1700467D RID: 18045
		// (get) Token: 0x0600E5C8 RID: 58824 RVA: 0x0021C5A8 File Offset: 0x0021A7A8
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

		// Token: 0x1700467E RID: 18046
		// (get) Token: 0x0600E5C9 RID: 58825 RVA: 0x0021C5E0 File Offset: 0x0021A7E0
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

		// Token: 0x1700467F RID: 18047
		// (get) Token: 0x0600E5CA RID: 58826 RVA: 0x0021C618 File Offset: 0x0021A818
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

		// Token: 0x17004680 RID: 18048
		// (get) Token: 0x0600E5CB RID: 58827 RVA: 0x0021C650 File Offset: 0x0021A850
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

		// Token: 0x17004681 RID: 18049
		// (get) Token: 0x0600E5CC RID: 58828 RVA: 0x0021C688 File Offset: 0x0021A888
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

		// Token: 0x17004682 RID: 18050
		// (get) Token: 0x0600E5CD RID: 58829 RVA: 0x0021C6C0 File Offset: 0x0021A8C0
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

		// Token: 0x17004683 RID: 18051
		// (get) Token: 0x0600E5CE RID: 58830 RVA: 0x0021C6F8 File Offset: 0x0021A8F8
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

		// Token: 0x17004684 RID: 18052
		// (get) Token: 0x0600E5CF RID: 58831 RVA: 0x0021C732 File Offset: 0x0021A932
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

		// Token: 0x17004685 RID: 18053
		// (get) Token: 0x0600E5D0 RID: 58832 RVA: 0x0021C768 File Offset: 0x0021A968
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

		// Token: 0x17004686 RID: 18054
		// (get) Token: 0x0600E5D1 RID: 58833 RVA: 0x0021C7A4 File Offset: 0x0021A9A4
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

		// Token: 0x17004687 RID: 18055
		// (get) Token: 0x0600E5D2 RID: 58834 RVA: 0x0021C7E0 File Offset: 0x0021A9E0
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

		// Token: 0x04007F0C RID: 32524
		private IMontageData Instance;

		// Token: 0x04007F0D RID: 32525
		private IMontageParam _OverlayMontageCache;

		// Token: 0x04007F0E RID: 32526
		private bool _OverlayMontageInited;

		// Token: 0x04007F0F RID: 32527
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IActorFxEmotePlay> _FxEmoteCache;

		// Token: 0x04007F10 RID: 32528
		private bool _FxEmoteInited;
	}
}
