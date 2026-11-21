using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A23 RID: 10787
	public class IGreatSwordChallenge : ICommonTipType
	{
		// Token: 0x0600EE62 RID: 61026 RVA: 0x0022FAF4 File Offset: 0x0022DCF4
		public static IGreatSwordChallenge Create(IGreatSwordChallenge? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGreatSwordChallenge
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046CA RID: 18122
		// (get) Token: 0x0600EE63 RID: 61027 RVA: 0x0022FB13 File Offset: 0x0022DD13
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046CB RID: 18123
		// (get) Token: 0x0600EE64 RID: 61028 RVA: 0x0022FB20 File Offset: 0x0022DD20
		public virtual string MainText
		{
			get
			{
				return this.Instance.MainText;
			}
		}

		// Token: 0x170046CC RID: 18124
		// (get) Token: 0x0600EE65 RID: 61029 RVA: 0x0022FB2D File Offset: 0x0022DD2D
		public virtual string SubText
		{
			get
			{
				return this.Instance.SubText;
			}
		}

		// Token: 0x04008303 RID: 33539
		private IGreatSwordChallenge Instance;
	}
}
