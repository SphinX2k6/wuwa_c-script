using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200262D RID: 9773
	public class ICharacterLookAtUnlockData : ICharacterLookAtData
	{
		// Token: 0x0600DB53 RID: 56147 RVA: 0x0020A743 File Offset: 0x00208943
		[NullableContext(1)]
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

		// Token: 0x170040BB RID: 16571
		// (get) Token: 0x0600DB54 RID: 56148 RVA: 0x0020A762 File Offset: 0x00208962
		public override ECharacterLookAt Type
		{
			get
			{
				return (ECharacterLookAt)this.Instance.Type;
			}
		}

		// Token: 0x040079D5 RID: 31189
		private ICharacterLookAtUnlockData Instance;
	}
}
