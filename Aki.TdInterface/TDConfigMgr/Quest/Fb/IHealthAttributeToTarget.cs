using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200138E RID: 5006
	public class IHealthAttributeToTarget : IAttributeToTarget
	{
		// Token: 0x0600727F RID: 29311 RVA: 0x00113505 File Offset: 0x00111705
		[NullableContext(1)]
		public static IHealthAttributeToTarget Create(IHealthAttributeToTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHealthAttributeToTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x06007280 RID: 29312 RVA: 0x00113524 File Offset: 0x00111724
		public override EAttributeToTarget Type
		{
			get
			{
				return (EAttributeToTarget)this.Instance.Type;
			}
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x06007281 RID: 29313 RVA: 0x00113531 File Offset: 0x00111731
		public virtual float Min
		{
			get
			{
				return this.Instance.Min;
			}
		}

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x06007282 RID: 29314 RVA: 0x0011353E File Offset: 0x0011173E
		public virtual float Max
		{
			get
			{
				return this.Instance.Max;
			}
		}

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x06007283 RID: 29315 RVA: 0x0011354C File Offset: 0x0011174C
		public virtual bool? ZeroHealthOnDeath
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ZeroHealthOnDeath);
			}
		}

		// Token: 0x0400422C RID: 16940
		private IHealthAttributeToTarget Instance;
	}
}
