using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200270D RID: 9997
	public class IUnlockCookSystemCookBook : IUnlockCookSystemType
	{
		// Token: 0x0600DF0D RID: 57101 RVA: 0x00211048 File Offset: 0x0020F248
		[NullableContext(1)]
		public static IUnlockCookSystemCookBook Create(IUnlockCookSystemCookBook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockCookSystemCookBook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042B5 RID: 17077
		// (get) Token: 0x0600DF0E RID: 57102 RVA: 0x00211067 File Offset: 0x0020F267
		public override EUnlockCookSystemType Type
		{
			get
			{
				return (EUnlockCookSystemType)this.Instance.Type;
			}
		}

		// Token: 0x170042B6 RID: 17078
		// (get) Token: 0x0600DF0F RID: 57103 RVA: 0x00211074 File Offset: 0x0020F274
		public virtual int CookBookId
		{
			get
			{
				return this.Instance.CookBookId;
			}
		}

		// Token: 0x04007BC9 RID: 31689
		private IUnlockCookSystemCookBook Instance;
	}
}
