using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002774 RID: 10100
	public class IFadeBackgroundUiPrefabType
	{
		// Token: 0x0600E0E6 RID: 57574 RVA: 0x00213AC9 File Offset: 0x00211CC9
		[NullableContext(1)]
		public static IFadeBackgroundUiPrefabType Create(IFadeBackgroundUiPrefabType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundUiPrefabType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043C0 RID: 17344
		// (get) Token: 0x0600E0E7 RID: 57575 RVA: 0x00213AE8 File Offset: 0x00211CE8
		public virtual EFadeBackgroundUiPrefabType Type
		{
			get
			{
				return (EFadeBackgroundUiPrefabType)this.Instance.Type;
			}
		}

		// Token: 0x04007C8A RID: 31882
		private IFadeBackgroundUiPrefabType Instance;
	}
}
