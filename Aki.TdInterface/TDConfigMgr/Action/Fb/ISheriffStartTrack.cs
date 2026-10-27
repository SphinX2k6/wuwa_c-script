using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200275D RID: 10077
	public class ISheriffStartTrack : ICommonTipType
	{
		// Token: 0x0600E085 RID: 57477 RVA: 0x00213195 File Offset: 0x00211395
		[NullableContext(1)]
		public static ISheriffStartTrack Create(ISheriffStartTrack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffStartTrack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700438D RID: 17293
		// (get) Token: 0x0600E086 RID: 57478 RVA: 0x002131B4 File Offset: 0x002113B4
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700438E RID: 17294
		// (get) Token: 0x0600E087 RID: 57479 RVA: 0x002131C1 File Offset: 0x002113C1
		public virtual int AnomalyId
		{
			get
			{
				return this.Instance.AnomalyId;
			}
		}

		// Token: 0x04007C5B RID: 31835
		private ISheriffStartTrack Instance;
	}
}
