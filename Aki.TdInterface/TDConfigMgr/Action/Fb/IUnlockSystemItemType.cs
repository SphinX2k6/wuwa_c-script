using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200270B RID: 9995
	public class IUnlockSystemItemType
	{
		// Token: 0x0600DF07 RID: 57095 RVA: 0x00210FE0 File Offset: 0x0020F1E0
		[NullableContext(1)]
		public static IUnlockSystemItemType Create(IUnlockSystemItemType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockSystemItemType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042B3 RID: 17075
		// (get) Token: 0x0600DF08 RID: 57096 RVA: 0x00210FFF File Offset: 0x0020F1FF
		public virtual EUnlockSystemItemType Type
		{
			get
			{
				return (EUnlockSystemItemType)this.Instance.Type;
			}
		}

		// Token: 0x04007BC7 RID: 31687
		private IUnlockSystemItemType Instance;
	}
}
