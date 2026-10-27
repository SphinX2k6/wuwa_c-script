using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002909 RID: 10505
	[NullableContext(2)]
	[Nullable(0)]
	public class IMaskTransition : ILevelSequenceTransitionType
	{
		// Token: 0x0600E932 RID: 59698 RVA: 0x00223256 File Offset: 0x00221456
		[NullableContext(1)]
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

		// Token: 0x170048E2 RID: 18658
		// (get) Token: 0x0600E933 RID: 59699 RVA: 0x00223275 File Offset: 0x00221475
		public override ELevelSequenceTransition Type
		{
			get
			{
				return (ELevelSequenceTransition)this.Instance.Type;
			}
		}

		// Token: 0x170048E3 RID: 18659
		// (get) Token: 0x0600E934 RID: 59700 RVA: 0x00223284 File Offset: 0x00221484
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

		// Token: 0x170048E4 RID: 18660
		// (get) Token: 0x0600E935 RID: 59701 RVA: 0x002232BA File Offset: 0x002214BA
		public virtual ETransitionMask Mask
		{
			get
			{
				return (ETransitionMask)this.Instance.Mask;
			}
		}

		// Token: 0x170048E5 RID: 18661
		// (get) Token: 0x0600E936 RID: 59702 RVA: 0x002232C7 File Offset: 0x002214C7
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

		// Token: 0x170048E6 RID: 18662
		// (get) Token: 0x0600E937 RID: 59703 RVA: 0x002232FB File Offset: 0x002214FB
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

		// Token: 0x040080BB RID: 32955
		private IMaskTransition Instance;

		// Token: 0x040080BC RID: 32956
		private IEaseData _FadeInCache;

		// Token: 0x040080BD RID: 32957
		private bool _FadeInInited;

		// Token: 0x040080BE RID: 32958
		private IEaseData _FadeOutCache;

		// Token: 0x040080BF RID: 32959
		private bool _FadeOutInited;
	}
}
