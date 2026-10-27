using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D50 RID: 7504
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreloadTrialCharacterForSkill : IPreloadCharacterType
	{
		// Token: 0x0600A0FB RID: 41211 RVA: 0x0016EF68 File Offset: 0x0016D168
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

		// Token: 0x0600A0FC RID: 41212 RVA: 0x0016EFA0 File Offset: 0x0016D1A0
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

		// Token: 0x0600A0FD RID: 41213 RVA: 0x0016EFB3 File Offset: 0x0016D1B3
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

		// Token: 0x0600A0FE RID: 41214 RVA: 0x0016EFC6 File Offset: 0x0016D1C6
		public new IPreloadTrialCharacterForSkill_SetValue ToSetValue()
		{
			return new IPreloadTrialCharacterForSkill_SetValue
			{
				Type = this.Type,
				CharacterGroupNew = this.CharacterGroupNew
			};
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600A0FF RID: 41215 RVA: 0x0016EFE5 File Offset: 0x0016D1E5
		// (set) Token: 0x0600A100 RID: 41216 RVA: 0x0016F010 File Offset: 0x0016D210
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

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600A101 RID: 41217 RVA: 0x0016F020 File Offset: 0x0016D220
		// (set) Token: 0x0600A102 RID: 41218 RVA: 0x0016F0B3 File Offset: 0x0016D2B3
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

		// Token: 0x040060F1 RID: 24817
		[Nullable(2)]
		protected new IPreloadTrialCharacterForSkill FbInstance;

		// Token: 0x040060F2 RID: 24818
		[Nullable(2)]
		protected new IPreloadTrialCharacterForSkill_SetValue PocoInterface;

		// Token: 0x040060F3 RID: 24819
		private List<ICharacterGroupNew> _CharacterGroupNewCache;

		// Token: 0x040060F4 RID: 24820
		private bool _CharacterGroupNewInited;
	}
}
