using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DA RID: 10714
	public class IOpenPanelQteQte : IOpenQteConfig
	{
		// Token: 0x0600ECB9 RID: 60601 RVA: 0x00228ED0 File Offset: 0x002270D0
		[NullableContext(1)]
		public static IOpenPanelQteQte Create(IOpenPanelQteQte? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenPanelQteQte
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AC7 RID: 19143
		// (get) Token: 0x0600ECBA RID: 60602 RVA: 0x00228EEF File Offset: 0x002270EF
		public override EOpenQteType Type
		{
			get
			{
				return (EOpenQteType)this.Instance.Type;
			}
		}

		// Token: 0x17004AC8 RID: 19144
		// (get) Token: 0x0600ECBB RID: 60603 RVA: 0x00228EFC File Offset: 0x002270FC
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x0400825E RID: 33374
		private IOpenPanelQteQte Instance;
	}
}
