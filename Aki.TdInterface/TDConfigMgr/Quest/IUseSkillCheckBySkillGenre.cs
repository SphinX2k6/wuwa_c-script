using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001322 RID: 4898
	public class IUseSkillCheckBySkillGenre : IUseSkillCheckBase
	{
		// Token: 0x06006E4D RID: 28237 RVA: 0x00106480 File Offset: 0x00104680
		private IUseSkillCheckBySkillGenre_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseSkillCheckBySkillGenre 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseSkillCheckBySkillGenre_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseSkillCheckBySkillGenre_SetValue());
			}
			return result;
		}

		// Token: 0x06006E4E RID: 28238 RVA: 0x001064B8 File Offset: 0x001046B8
		public static IUseSkillCheckBySkillGenre Create([Nullable(2)] IUseSkillCheckBySkillGenre instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckBySkillGenre
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006E4F RID: 28239 RVA: 0x001064CB File Offset: 0x001046CB
		public static IUseSkillCheckBySkillGenre CreateFromSetValue([Nullable(2)] IUseSkillCheckBySkillGenre_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseSkillCheckBySkillGenre
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006E50 RID: 28240 RVA: 0x001064DE File Offset: 0x001046DE
		public new IUseSkillCheckBySkillGenre_SetValue ToSetValue()
		{
			return new IUseSkillCheckBySkillGenre_SetValue
			{
				Type = this.Type,
				SkillGenre = this.SkillGenre
			};
		}

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x06006E51 RID: 28241 RVA: 0x001064FD File Offset: 0x001046FD
		// (set) Token: 0x06006E52 RID: 28242 RVA: 0x00106528 File Offset: 0x00104728
		public override EUseSkillCheckType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUseSkillCheckType.CheckSkillGenre;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x06006E53 RID: 28243 RVA: 0x00106536 File Offset: 0x00104736
		// (set) Token: 0x06006E54 RID: 28244 RVA: 0x00106561 File Offset: 0x00104761
		public virtual ESkillCategory SkillGenre
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillGenre;
				}
				if (this.PocoInterface == null)
				{
					return ESkillCategory.Normal;
				}
				return this.PocoInterface.SkillGenre;
			}
			set
			{
				this.GetOrCreatePoco().SkillGenre = value;
			}
		}

		// Token: 0x040041CB RID: 16843
		[Nullable(2)]
		protected new IUseSkillCheckBySkillGenre FbInstance;

		// Token: 0x040041CC RID: 16844
		[Nullable(2)]
		protected new IUseSkillCheckBySkillGenre_SetValue PocoInterface;
	}
}
