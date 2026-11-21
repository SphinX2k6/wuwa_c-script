using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A1B RID: 10779
	public class IDreamlessWarning : ICommonTipType
	{
		// Token: 0x0600EE35 RID: 60981 RVA: 0x0022F82A File Offset: 0x0022DA2A
		public static IDreamlessWarning Create(IDreamlessWarning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDreamlessWarning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046AD RID: 18093
		// (get) Token: 0x0600EE36 RID: 60982 RVA: 0x0022F849 File Offset: 0x0022DA49
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046AE RID: 18094
		// (get) Token: 0x0600EE37 RID: 60983 RVA: 0x0022F856 File Offset: 0x0022DA56
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x040082FB RID: 33531
		private IDreamlessWarning Instance;
	}
}
