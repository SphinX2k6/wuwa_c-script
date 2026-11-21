using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A87 RID: 10887
	public class RemoveTrialCharacter : ActionParams
	{
		// Token: 0x0600F04A RID: 61514 RVA: 0x0023379D File Offset: 0x0023199D
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

		// Token: 0x170047EA RID: 18410
		// (get) Token: 0x0600F04B RID: 61515 RVA: 0x002337BC File Offset: 0x002319BC
		public virtual int CharacterId
		{
			get
			{
				return this.Instance.CharacterId;
			}
		}

		// Token: 0x170047EB RID: 18411
		// (get) Token: 0x0600F04C RID: 61516 RVA: 0x002337CC File Offset: 0x002319CC
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

		// Token: 0x170047EC RID: 18412
		// (get) Token: 0x0600F04D RID: 61517 RVA: 0x00233830 File Offset: 0x00231A30
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

		// Token: 0x170047ED RID: 18413
		// (get) Token: 0x0600F04E RID: 61518 RVA: 0x00233868 File Offset: 0x00231A68
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

		// Token: 0x170047EE RID: 18414
		// (get) Token: 0x0600F04F RID: 61519 RVA: 0x002338A0 File Offset: 0x00231AA0
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

		// Token: 0x04008427 RID: 33831
		private IRemoveTrialCharacter Instance;

		// Token: 0x04008428 RID: 33832
		private List<int> _CharacterGroupCache;

		// Token: 0x04008429 RID: 33833
		private bool _CharacterGroupInited;
	}
}
