using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B0 RID: 10160
	public class ICharacterGroupNew
	{
		// Token: 0x0600E206 RID: 57862 RVA: 0x00216252 File Offset: 0x00214452
		[NullableContext(1)]
		public static ICharacterGroupNew Create(ICharacterGroupNew? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterGroupNew
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004468 RID: 17512
		// (get) Token: 0x0600E207 RID: 57863 RVA: 0x00216271 File Offset: 0x00214471
		public virtual int CharacterId
		{
			get
			{
				return this.Instance.CharacterId;
			}
		}

		// Token: 0x17004469 RID: 17513
		// (get) Token: 0x0600E208 RID: 57864 RVA: 0x0021627E File Offset: 0x0021447E
		public virtual bool IsAiCharacter
		{
			get
			{
				return this.Instance.IsAiCharacter;
			}
		}

		// Token: 0x04007D56 RID: 32086
		private ICharacterGroupNew Instance;
	}
}
