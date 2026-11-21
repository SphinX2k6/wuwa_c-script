using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028EC RID: 10476
	public class ICharacterLookAtPlayerData : ICharacterLookAtData
	{
		// Token: 0x0600E91E RID: 59678 RVA: 0x00226EDB File Offset: 0x002250DB
		public static ICharacterLookAtPlayerData Create(ICharacterLookAtPlayerData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtPlayerData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043F4 RID: 17396
		// (get) Token: 0x0600E91F RID: 59679 RVA: 0x00226EFA File Offset: 0x002250FA
		public override ECharacterLookAt Type
		{
			get
			{
				return (ECharacterLookAt)this.Instance.Type;
			}
		}

		// Token: 0x04008070 RID: 32880
		private ICharacterLookAtPlayerData Instance;
	}
}
