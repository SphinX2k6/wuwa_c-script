using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020B2 RID: 8370
	public class ISkillBtnEffectBase
	{
		// Token: 0x0600B1C0 RID: 45504 RVA: 0x0018F924 File Offset: 0x0018DB24
		private ISkillBtnEffectBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkillBtnEffectBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkillBtnEffectBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkillBtnEffectBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x0018F95C File Offset: 0x0018DB5C
		public static ISkillBtnEffectBase Create([Nullable(2)] ISkillBtnEffectBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkillBtnEffectBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1C2 RID: 45506 RVA: 0x0018F96F File Offset: 0x0018DB6F
		public static ISkillBtnEffectBase CreateFromSetValue([Nullable(2)] ISkillBtnEffectBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkillBtnEffectBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1C3 RID: 45507 RVA: 0x0018F982 File Offset: 0x0018DB82
		public ISkillBtnEffectBase_SetValue ToSetValue()
		{
			return new ISkillBtnEffectBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x0600B1C4 RID: 45508 RVA: 0x0018F995 File Offset: 0x0018DB95
		// (set) Token: 0x0600B1C5 RID: 45509 RVA: 0x0018F9C0 File Offset: 0x0018DBC0
		public virtual ESkillBtnEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESkillBtnEffectType.MusicBattleBtnEffect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006999 RID: 27033
		[Nullable(2)]
		protected ISkillBtnEffectBase FbInstance;

		// Token: 0x0400699A RID: 27034
		[Nullable(2)]
		protected ISkillBtnEffectBase_SetValue PocoInterface;
	}
}
