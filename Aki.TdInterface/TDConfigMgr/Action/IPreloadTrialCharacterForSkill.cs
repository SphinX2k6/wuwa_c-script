using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F61 RID: 8033
	public class IPreloadTrialCharacterForSkill : IPreloadCharacterType
	{
		// Token: 0x0600AAE7 RID: 43751 RVA: 0x0018338C File Offset: 0x0018158C
		private IPreloadTrialCharacterForSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreloadTrialCharacterForSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreloadTrialCharacterForSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreloadTrialCharacterForSkill_SetValue());
			}
			return result;
		}

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x001833C4 File Offset: 0x001815C4
		public static IPreloadTrialCharacterForSkill Create([Nullable(2)] IPreloadTrialCharacterForSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadTrialCharacterForSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x001833D7 File Offset: 0x001815D7
		public static IPreloadTrialCharacterForSkill CreateFromSetValue([Nullable(2)] IPreloadTrialCharacterForSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreloadTrialCharacterForSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AAEA RID: 43754 RVA: 0x001833EA File Offset: 0x001815EA
		public new IPreloadTrialCharacterForSkill_SetValue ToSetValue()
		{
			return new IPreloadTrialCharacterForSkill_SetValue
			{
				Type = this.Type,
				CharacterGroupNew = this.CharacterGroupNew
			};
		}

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x0600AAEB RID: 43755 RVA: 0x00183409 File Offset: 0x00181609
		// (set) Token: 0x0600AAEC RID: 43756 RVA: 0x00183434 File Offset: 0x00181634
		public override EPreloadObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x0600AAED RID: 43757 RVA: 0x00183444 File Offset: 0x00181644
		// (set) Token: 0x0600AAEE RID: 43758 RVA: 0x001834D7 File Offset: 0x001816D7
		public virtual List<ICharacterGroupNew> CharacterGroupNew
		{
			get
			{
				if (this._CharacterGroupNewInited)
				{
					return this._CharacterGroupNewCache;
				}
				this._CharacterGroupNewInited = true;
				if (this.FbInstance != null)
				{
					List<ICharacterGroupNew> characterGroupNew = this.FbInstance.CharacterGroupNew;
					if (characterGroupNew != null)
					{
						this._CharacterGroupNewCache = new List<ICharacterGroupNew>(characterGroupNew.Count);
						for (int i = 0; i < characterGroupNew.Count; i++)
						{
							this._CharacterGroupNewCache.Add(ICharacterGroupNew.Create(characterGroupNew[i]));
						}
					}
				}
				else
				{
					IPreloadTrialCharacterForSkill_SetValue pocoInterface = this.PocoInterface;
					this._CharacterGroupNewCache = ((pocoInterface != null) ? pocoInterface.CharacterGroupNew : null);
				}
				return this._CharacterGroupNewCache;
			}
			set
			{
				this.GetOrCreatePoco().CharacterGroupNew = value;
				this._CharacterGroupNewInited = false;
			}
		}

		// Token: 0x0400666D RID: 26221
		[Nullable(2)]
		protected new IPreloadTrialCharacterForSkill FbInstance;

		// Token: 0x0400666E RID: 26222
		[Nullable(2)]
		protected new IPreloadTrialCharacterForSkill_SetValue PocoInterface;

		// Token: 0x0400666F RID: 26223
		private List<ICharacterGroupNew> _CharacterGroupNewCache;

		// Token: 0x04006670 RID: 26224
		private bool _CharacterGroupNewInited;
	}
}
