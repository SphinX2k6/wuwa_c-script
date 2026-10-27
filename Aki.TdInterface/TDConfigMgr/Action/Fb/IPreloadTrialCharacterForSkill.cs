using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DF RID: 10719
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreloadTrialCharacterForSkill : IPreloadCharacterType
	{
		// Token: 0x0600ECCA RID: 60618 RVA: 0x00229032 File Offset: 0x00227232
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

		// Token: 0x17004ACE RID: 19150
		// (get) Token: 0x0600ECCB RID: 60619 RVA: 0x00229051 File Offset: 0x00227251
		public override EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004ACF RID: 19151
		// (get) Token: 0x0600ECCC RID: 60620 RVA: 0x00229060 File Offset: 0x00227260
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

		// Token: 0x04008267 RID: 33383
		private IPreloadTrialCharacterForSkill Instance;

		// Token: 0x04008268 RID: 33384
		private List<ICharacterGroupNew> _CharacterGroupNewCache;

		// Token: 0x04008269 RID: 33385
		private bool _CharacterGroupNewInited;
	}
}
