using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028F1 RID: 10481
	[NullableContext(1)]
	[Nullable(0)]
	public class IAccelerateSkiConfig : ISkiConfigType
	{
		// Token: 0x0600E8D2 RID: 59602 RVA: 0x002228FF File Offset: 0x00220AFF
		public static IAccelerateSkiConfig Create(IAccelerateSkiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAccelerateSkiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048B2 RID: 18610
		// (get) Token: 0x0600E8D3 RID: 59603 RVA: 0x0022291E File Offset: 0x00220B1E
		public override ESkiConfig Type
		{
			get
			{
				return (ESkiConfig)this.Instance.Type;
			}
		}

		// Token: 0x170048B3 RID: 18611
		// (get) Token: 0x0600E8D4 RID: 59604 RVA: 0x0022292B File Offset: 0x00220B2B
		public override ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadIAccelerateSkiConfig_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x170048B4 RID: 18612
		// (get) Token: 0x0600E8D5 RID: 59605 RVA: 0x0022295A File Offset: 0x00220B5A
		public virtual int Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x170048B5 RID: 18613
		// (get) Token: 0x0600E8D6 RID: 59606 RVA: 0x00222967 File Offset: 0x00220B67
		public virtual int LimitSpeed
		{
			get
			{
				return this.Instance.LimitSpeed;
			}
		}

		// Token: 0x170048B6 RID: 18614
		// (get) Token: 0x0600E8D7 RID: 59607 RVA: 0x00222974 File Offset: 0x00220B74
		public virtual int Acceleration
		{
			get
			{
				return this.Instance.Acceleration;
			}
		}

		// Token: 0x170048B7 RID: 18615
		// (get) Token: 0x0600E8D8 RID: 59608 RVA: 0x00222984 File Offset: 0x00220B84
		public virtual int? InstantSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.InstantSpeed);
			}
		}

		// Token: 0x04008089 RID: 32905
		private IAccelerateSkiConfig Instance;

		// Token: 0x0400808A RID: 32906
		private ITargetEntityType _TargetCache;

		// Token: 0x0400808B RID: 32907
		private bool _TargetInited;
	}
}
