using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200263B RID: 9787
	[NullableContext(2)]
	[Nullable(0)]
	public class IItemGetUiConfigSpecialQuest : IItemGetUiConfigBase
	{
		// Token: 0x0600DB9D RID: 56221 RVA: 0x0020B0A9 File Offset: 0x002092A9
		[NullableContext(1)]
		public static IItemGetUiConfigSpecialQuest Create(IItemGetUiConfigSpecialQuest? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemGetUiConfigSpecialQuest
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040E9 RID: 16617
		// (get) Token: 0x0600DB9E RID: 56222 RVA: 0x0020B0C8 File Offset: 0x002092C8
		public override EItemGetUiType Type
		{
			get
			{
				return (EItemGetUiType)this.Instance.Type;
			}
		}

		// Token: 0x170040EA RID: 16618
		// (get) Token: 0x0600DB9F RID: 56223 RVA: 0x0020B0D5 File Offset: 0x002092D5
		public virtual string Title
		{
			get
			{
				return this.Instance.Title;
			}
		}

		// Token: 0x170040EB RID: 16619
		// (get) Token: 0x0600DBA0 RID: 56224 RVA: 0x0020B0E4 File Offset: 0x002092E4
		public virtual bool? ShowDetail
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowDetail);
			}
		}

		// Token: 0x04007A0B RID: 31243
		private IItemGetUiConfigSpecialQuest Instance;
	}
}
