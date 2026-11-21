using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E8 RID: 10472
	public class ICharacterLookAtData
	{
		// Token: 0x0600E910 RID: 59664 RVA: 0x00226DCA File Offset: 0x00224FCA
		public static ICharacterLookAtData Create(ICharacterLookAtData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043EE RID: 17390
		// (get) Token: 0x0600E911 RID: 59665 RVA: 0x00226DE9 File Offset: 0x00224FE9
		public virtual ECharacterLookAt Type
		{
			get
			{
				return (ECharacterLookAt)this.Instance.Type;
			}
		}

		// Token: 0x0400806A RID: 32874
		private ICharacterLookAtData Instance;
	}
}
