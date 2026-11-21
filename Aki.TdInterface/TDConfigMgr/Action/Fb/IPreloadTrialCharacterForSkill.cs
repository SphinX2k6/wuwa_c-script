using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CCC RID: 11468
	public class IPreloadTrialCharacterForSkill : IPreloadCharacterType
	{
		// Token: 0x0600FB61 RID: 64353 RVA: 0x002469B6 File Offset: 0x00244BB6
		public static IPreloadTrialCharacterForSkill Create(IPreloadTrialCharacterForSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadTrialCharacterForSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E77 RID: 20087
		// (get) Token: 0x0600FB62 RID: 64354 RVA: 0x002469D5 File Offset: 0x00244BD5
		public override EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004E78 RID: 20088
		// (get) Token: 0x0600FB63 RID: 64355 RVA: 0x002469E4 File Offset: 0x00244BE4
		public virtual List<ICharacterGroupNew> CharacterGroupNew
		{
			get
			{
				if (this._CharacterGroupNewInited)
				{
					return this._CharacterGroupNewCache;
				}
				this._CharacterGroupNewInited = true;
				int characterGroupNewLength = this.Instance.CharacterGroupNewLength;
				this._CharacterGroupNewCache = new List<ICharacterGroupNew>(characterGroupNewLength);
				for (int i = 0; i < characterGroupNewLength; i++)
				{
					this._CharacterGroupNewCache.Add(ICharacterGroupNew.Create(this.Instance.CharacterGroupNew(i)));
				}
				return this._CharacterGroupNewCache;
			}
		}

		// Token: 0x04008958 RID: 35160
		private IPreloadTrialCharacterForSkill Instance;

		// Token: 0x04008959 RID: 35161
		private List<ICharacterGroupNew> _CharacterGroupNewCache;

		// Token: 0x0400895A RID: 35162
		private bool _CharacterGroupNewInited;
	}
}
