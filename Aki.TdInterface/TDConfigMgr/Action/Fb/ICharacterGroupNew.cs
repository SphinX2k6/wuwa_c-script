using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A83 RID: 10883
	public class ICharacterGroupNew
	{
		// Token: 0x0600F028 RID: 61480 RVA: 0x00233026 File Offset: 0x00231226
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

		// Token: 0x170047D0 RID: 18384
		// (get) Token: 0x0600F029 RID: 61481 RVA: 0x00233045 File Offset: 0x00231245
		public virtual int CharacterId
		{
			get
			{
				return this.Instance.CharacterId;
			}
		}

		// Token: 0x170047D1 RID: 18385
		// (get) Token: 0x0600F02A RID: 61482 RVA: 0x00233052 File Offset: 0x00231252
		public virtual bool IsAiCharacter
		{
			get
			{
				return this.Instance.IsAiCharacter;
			}
		}

		// Token: 0x0400840D RID: 33805
		private ICharacterGroupNew Instance;
	}
}
