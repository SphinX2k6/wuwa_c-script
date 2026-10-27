using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200270C RID: 9996
	public class IUnlockCookSystemType
	{
		// Token: 0x0600DF0A RID: 57098 RVA: 0x00211014 File Offset: 0x0020F214
		[NullableContext(1)]
		public static IUnlockCookSystemType Create(IUnlockCookSystemType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockCookSystemType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042B4 RID: 17076
		// (get) Token: 0x0600DF0B RID: 57099 RVA: 0x00211033 File Offset: 0x0020F233
		public virtual EUnlockCookSystemType Type
		{
			get
			{
				return (EUnlockCookSystemType)this.Instance.Type;
			}
		}

		// Token: 0x04007BC8 RID: 31688
		private IUnlockCookSystemType Instance;
	}
}
