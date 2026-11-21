using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BE5 RID: 11237
	[NullableContext(2)]
	[Nullable(0)]
	public class IMaskTransition : ILevelSequenceTransitionType
	{
		// Token: 0x0600F783 RID: 63363 RVA: 0x00240576 File Offset: 0x0023E776
		[NullableContext(0)]
		public static IMaskTransition Create(IMaskTransition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMaskTransition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C67 RID: 19559
		// (get) Token: 0x0600F784 RID: 63364 RVA: 0x00240595 File Offset: 0x0023E795
		public override ELevelSequenceTransition Type
		{
			get
			{
				return (ELevelSequenceTransition)this.Instance.Type;
			}
		}

		// Token: 0x17004C68 RID: 19560
		// (get) Token: 0x0600F785 RID: 63365 RVA: 0x002405A4 File Offset: 0x0023E7A4
		public override float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x17004C69 RID: 19561
		// (get) Token: 0x0600F786 RID: 63366 RVA: 0x002405DA File Offset: 0x0023E7DA
		public virtual ETransitionMask Mask
		{
			get
			{
				return (ETransitionMask)this.Instance.Mask;
			}
		}

		// Token: 0x17004C6A RID: 19562
		// (get) Token: 0x0600F787 RID: 63367 RVA: 0x002405E7 File Offset: 0x0023E7E7
		public virtual IEaseData FadeIn
		{
			get
			{
				if (this._FadeInInited)
				{
					return this._FadeInCache;
				}
				this._FadeInInited = true;
				this._FadeInCache = IEaseData.Create(this.Instance.FadeIn);
				return this._FadeInCache;
			}
		}

		// Token: 0x17004C6B RID: 19563
		// (get) Token: 0x0600F788 RID: 63368 RVA: 0x0024061B File Offset: 0x0023E81B
		public virtual IEaseData FadeOut
		{
			get
			{
				if (this._FadeOutInited)
				{
					return this._FadeOutCache;
				}
				this._FadeOutInited = true;
				this._FadeOutCache = IEaseData.Create(this.Instance.FadeOut);
				return this._FadeOutCache;
			}
		}

		// Token: 0x04008789 RID: 34697
		private IMaskTransition Instance;

		// Token: 0x0400878A RID: 34698
		private IEaseData _FadeInCache;

		// Token: 0x0400878B RID: 34699
		private bool _FadeInInited;

		// Token: 0x0400878C RID: 34700
		private IEaseData _FadeOutCache;

		// Token: 0x0400878D RID: 34701
		private bool _FadeOutInited;
	}
}
