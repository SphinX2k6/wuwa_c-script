using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B4 RID: 10164
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveTrialCharacter : ActionParams
	{
		// Token: 0x0600E228 RID: 57896 RVA: 0x002169C9 File Offset: 0x00214BC9
		public static RemoveTrialCharacter Create(IRemoveTrialCharacter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveTrialCharacter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004482 RID: 17538
		// (get) Token: 0x0600E229 RID: 57897 RVA: 0x002169E8 File Offset: 0x00214BE8
		public virtual int CharacterId
		{
			get
			{
				return this.Instance.CharacterId;
			}
		}

		// Token: 0x17004483 RID: 17539
		// (get) Token: 0x0600E22A RID: 57898 RVA: 0x002169F8 File Offset: 0x00214BF8
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

		// Token: 0x17004484 RID: 17540
		// (get) Token: 0x0600E22B RID: 57899 RVA: 0x00216A5C File Offset: 0x00214C5C
		public virtual bool? IsRemoveTips
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsRemoveTips);
			}
		}

		// Token: 0x17004485 RID: 17541
		// (get) Token: 0x0600E22C RID: 57900 RVA: 0x00216A94 File Offset: 0x00214C94
		public virtual bool? EnableSeamlessTeamSwitch
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EnableSeamlessTeamSwitch);
			}
		}

		// Token: 0x17004486 RID: 17542
		// (get) Token: 0x0600E22D RID: 57901 RVA: 0x00216ACC File Offset: 0x00214CCC
		public virtual bool? OnlyLowMemoryDeviceExecute
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.OnlyLowMemoryDeviceExecute);
			}
		}

		// Token: 0x04007D70 RID: 32112
		private IRemoveTrialCharacter Instance;

		// Token: 0x04007D71 RID: 32113
		private List<int> _CharacterGroupCache;

		// Token: 0x04007D72 RID: 32114
		private bool _CharacterGroupInited;
	}
}
