using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C3 RID: 10179
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayMontage : ActionParams
	{
		// Token: 0x0600E144 RID: 57668 RVA: 0x00211E5A File Offset: 0x0021005A
		[NullableContext(0)]
		public static PlayMontage Create(IPlayMontage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayMontage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x0600E145 RID: 57669 RVA: 0x00211E79 File Offset: 0x00210079
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x0600E146 RID: 57670 RVA: 0x00211E86 File Offset: 0x00210086
		[Nullable(0)]
		public virtual IActionMontage ActionMontage
		{
			[NullableContext(0)]
			get
			{
				if (this._ActionMontageInited)
				{
					return this._ActionMontageCache;
				}
				this._ActionMontageInited = true;
				this._ActionMontageCache = IActionMontage.Create(this.Instance.ActionMontage);
				return this._ActionMontageCache;
			}
		}

		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x0600E147 RID: 57671 RVA: 0x00211EBA File Offset: 0x002100BA
		public virtual string ExpressionMontage
		{
			get
			{
				return this.Instance.ExpressionMontage;
			}
		}

		// Token: 0x17003E6F RID: 15983
		// (get) Token: 0x0600E148 RID: 57672 RVA: 0x00211EC7 File Offset: 0x002100C7
		public virtual string MouthSequence
		{
			get
			{
				return this.Instance.MouthSequence;
			}
		}

		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x0600E149 RID: 57673 RVA: 0x00211ED4 File Offset: 0x002100D4
		public virtual int? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Duration);
			}
		}

		// Token: 0x04007A71 RID: 31345
		private IPlayMontage Instance;

		// Token: 0x04007A72 RID: 31346
		private IActionMontage _ActionMontageCache;

		// Token: 0x04007A73 RID: 31347
		private bool _ActionMontageInited;
	}
}
