using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CC7 RID: 11463
	public class IOpenPanelQteQte : IOpenQteConfig
	{
		// Token: 0x0600FB50 RID: 64336 RVA: 0x00246854 File Offset: 0x00244A54
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

		// Token: 0x17004E70 RID: 20080
		// (get) Token: 0x0600FB51 RID: 64337 RVA: 0x00246873 File Offset: 0x00244A73
		public override EOpenQteType Type
		{
			get
			{
				return (EOpenQteType)this.Instance.Type;
			}
		}

		// Token: 0x17004E71 RID: 20081
		// (get) Token: 0x0600FB52 RID: 64338 RVA: 0x00246880 File Offset: 0x00244A80
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x0400894F RID: 35151
		private IOpenPanelQteQte Instance;
	}
}
