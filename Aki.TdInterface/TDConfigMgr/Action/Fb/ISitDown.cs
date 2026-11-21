using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA7 RID: 10919
	public class ISitDown : ILeisureInteractType
	{
		// Token: 0x0600F0C6 RID: 61638 RVA: 0x00234313 File Offset: 0x00232513
		public static ISitDown Create(ISitDown? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISitDown
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004826 RID: 18470
		// (get) Token: 0x0600F0C7 RID: 61639 RVA: 0x00234332 File Offset: 0x00232532
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004827 RID: 18471
		// (get) Token: 0x0600F0C8 RID: 61640 RVA: 0x00234340 File Offset: 0x00232540
		public virtual bool? OnlyAllowForwardStandUp
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.OnlyAllowForwardStandUp);
			}
		}

		// Token: 0x0400845F RID: 33887
		private ISitDown Instance;
	}
}
