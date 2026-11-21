using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CD3 RID: 11475
	public class IRemovePreloadResourceTrialCharacter : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600FB7B RID: 64379 RVA: 0x00246C63 File Offset: 0x00244E63
		public static IRemovePreloadResourceTrialCharacter Create(IRemovePreloadResourceTrialCharacter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadResourceTrialCharacter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E83 RID: 20099
		// (get) Token: 0x0600FB7C RID: 64380 RVA: 0x00246C82 File Offset: 0x00244E82
		public override ERemovePreloadResourceObjectType Type
		{
			get
			{
				return (ERemovePreloadResourceObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004E84 RID: 20100
		// (get) Token: 0x0600FB7D RID: 64381 RVA: 0x00246C90 File Offset: 0x00244E90
		public virtual List<int> CharacterGroup
		{
			get
			{
				if (this._CharacterGroupInited)
				{
					return this._CharacterGroupCache;
				}
				this._CharacterGroupInited = true;
				int characterGroupLength = this.Instance.CharacterGroupLength;
				this._CharacterGroupCache = new List<int>(characterGroupLength);
				for (int i = 0; i < characterGroupLength; i++)
				{
					this._CharacterGroupCache.Add(this.Instance.CharacterGroup(i));
				}
				return this._CharacterGroupCache;
			}
		}

		// Token: 0x04008967 RID: 35175
		private IRemovePreloadResourceTrialCharacter Instance;

		// Token: 0x04008968 RID: 35176
		private List<int> _CharacterGroupCache;

		// Token: 0x04008969 RID: 35177
		private bool _CharacterGroupInited;
	}
}
