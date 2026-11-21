using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028ED RID: 10477
	public class ICharacterLookAtUnlockData : ICharacterLookAtData
	{
		// Token: 0x0600E921 RID: 59681 RVA: 0x00226F0F File Offset: 0x0022510F
		public static ICharacterLookAtUnlockData Create(ICharacterLookAtUnlockData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtUnlockData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043F5 RID: 17397
		// (get) Token: 0x0600E922 RID: 59682 RVA: 0x00226F2E File Offset: 0x0022512E
		public override ECharacterLookAt Type
		{
			get
			{
				return (ECharacterLookAt)this.Instance.Type;
			}
		}

		// Token: 0x04008071 RID: 32881
		private ICharacterLookAtUnlockData Instance;
	}
}
