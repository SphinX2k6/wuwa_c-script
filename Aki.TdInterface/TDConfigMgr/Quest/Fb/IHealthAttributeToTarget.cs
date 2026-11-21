using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014DF RID: 5343
	public class IHealthAttributeToTarget : IAttributeToTarget
	{
		// Token: 0x06007925 RID: 31013 RVA: 0x00121B89 File Offset: 0x0011FD89
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

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x06007926 RID: 31014 RVA: 0x00121BA8 File Offset: 0x0011FDA8
		public override EAttributeToTarget Type
		{
			get
			{
				return (EAttributeToTarget)this.Instance.Type;
			}
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x06007927 RID: 31015 RVA: 0x00121BB5 File Offset: 0x0011FDB5
		public virtual float Min
		{
			get
			{
				return this.Instance.Min;
			}
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x06007928 RID: 31016 RVA: 0x00121BC2 File Offset: 0x0011FDC2
		public virtual float Max
		{
			get
			{
				return this.Instance.Max;
			}
		}

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x06007929 RID: 31017 RVA: 0x00121BD0 File Offset: 0x0011FDD0
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

		// Token: 0x040045AD RID: 17837
		private IHealthAttributeToTarget Instance;
	}
}
