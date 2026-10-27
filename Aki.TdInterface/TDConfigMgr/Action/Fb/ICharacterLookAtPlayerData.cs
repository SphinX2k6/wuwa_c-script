using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200262C RID: 9772
	public class ICharacterLookAtPlayerData : ICharacterLookAtData
	{
		// Token: 0x0600DB50 RID: 56144 RVA: 0x0020A70F File Offset: 0x0020890F
		[NullableContext(1)]
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

		// Token: 0x170040BA RID: 16570
		// (get) Token: 0x0600DB51 RID: 56145 RVA: 0x0020A72E File Offset: 0x0020892E
		public override ECharacterLookAt Type
		{
			get
			{
				return (ECharacterLookAt)this.Instance.Type;
			}
		}

		// Token: 0x040079D4 RID: 31188
		private ICharacterLookAtPlayerData Instance;
	}
}
