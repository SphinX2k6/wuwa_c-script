using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028FB RID: 10491
	public class IItemGetUiConfigSpecialQuest : IItemGetUiConfigBase
	{
		// Token: 0x0600E96B RID: 59755 RVA: 0x00227875 File Offset: 0x00225A75
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

		// Token: 0x17004423 RID: 17443
		// (get) Token: 0x0600E96C RID: 59756 RVA: 0x00227894 File Offset: 0x00225A94
		public override EItemGetUiType Type
		{
			get
			{
				return (EItemGetUiType)this.Instance.Type;
			}
		}

		// Token: 0x17004424 RID: 17444
		// (get) Token: 0x0600E96D RID: 59757 RVA: 0x002278A1 File Offset: 0x00225AA1
		[Nullable(2)]
		public virtual string Title
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.Title;
			}
		}

		// Token: 0x17004425 RID: 17445
		// (get) Token: 0x0600E96E RID: 59758 RVA: 0x002278B0 File Offset: 0x00225AB0
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

		// Token: 0x040080A7 RID: 32935
		private IItemGetUiConfigSpecialQuest Instance;
	}
}
