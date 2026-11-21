using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B47 RID: 2887
	public class IInteractEntityPartPrefabOptionPoint
	{
		// Token: 0x060041F4 RID: 16884 RVA: 0x000A7BBA File Offset: 0x000A5DBA
		public static IInteractEntityPartPrefabOptionPoint Create(IInteractEntityPartPrefabOptionPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartPrefabOptionPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x000A7BD9 File Offset: 0x000A5DD9
		public virtual string UiStyle
		{
			get
			{
				return this.Instance.UiStyle;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x000A7BE6 File Offset: 0x000A5DE6
		public virtual string BindName
		{
			get
			{
				return this.Instance.BindName;
			}
		}

		// Token: 0x04002482 RID: 9346
		private IInteractEntityPartPrefabOptionPoint Instance;
	}
}
