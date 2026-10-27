using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200251C RID: 9500
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayMontage : ActionParams
	{
		// Token: 0x0600D3E4 RID: 54244 RVA: 0x001F63FA File Offset: 0x001F45FA
		[NullableContext(1)]
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

		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x0600D3E5 RID: 54245 RVA: 0x001F6419 File Offset: 0x001F4619
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x0600D3E6 RID: 54246 RVA: 0x001F6426 File Offset: 0x001F4626
		[Nullable(1)]
		public virtual IActionMontage ActionMontage
		{
			[NullableContext(1)]
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

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x0600D3E7 RID: 54247 RVA: 0x001F645A File Offset: 0x001F465A
		public virtual string ExpressionMontage
		{
			get
			{
				return this.Instance.ExpressionMontage;
			}
		}

		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x0600D3E8 RID: 54248 RVA: 0x001F6467 File Offset: 0x001F4667
		public virtual string MouthSequence
		{
			get
			{
				return this.Instance.MouthSequence;
			}
		}

		// Token: 0x17003B72 RID: 15218
		// (get) Token: 0x0600D3E9 RID: 54249 RVA: 0x001F6474 File Offset: 0x001F4674
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

		// Token: 0x0400741C RID: 29724
		private IPlayMontage Instance;

		// Token: 0x0400741D RID: 29725
		private IActionMontage _ActionMontageCache;

		// Token: 0x0400741E RID: 29726
		private bool _ActionMontageInited;
	}
}
