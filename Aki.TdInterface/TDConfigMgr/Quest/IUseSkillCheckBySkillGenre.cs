using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011E6 RID: 4582
	[NullableContext(1)]
	[Nullable(0)]
	public class IUseSkillCheckBySkillGenre : IUseSkillCheckBase
	{
		// Token: 0x0600680C RID: 26636 RVA: 0x000F8B74 File Offset: 0x000F6D74
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

		// Token: 0x0600680D RID: 26637 RVA: 0x000F8BAC File Offset: 0x000F6DAC
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

		// Token: 0x0600680E RID: 26638 RVA: 0x000F8BBF File Offset: 0x000F6DBF
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

		// Token: 0x0600680F RID: 26639 RVA: 0x000F8BD2 File Offset: 0x000F6DD2
		public new IUseSkillCheckBySkillGenre_SetValue ToSetValue()
		{
			return new IUseSkillCheckBySkillGenre_SetValue
			{
				Type = this.Type,
				SkillGenre = this.SkillGenre
			};
		}

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x06006810 RID: 26640 RVA: 0x000F8BF1 File Offset: 0x000F6DF1
		// (set) Token: 0x06006811 RID: 26641 RVA: 0x000F8C1C File Offset: 0x000F6E1C
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

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06006812 RID: 26642 RVA: 0x000F8C2A File Offset: 0x000F6E2A
		// (set) Token: 0x06006813 RID: 26643 RVA: 0x000F8C55 File Offset: 0x000F6E55
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

		// Token: 0x04003E5D RID: 15965
		[Nullable(2)]
		protected new IUseSkillCheckBySkillGenre FbInstance;

		// Token: 0x04003E5E RID: 15966
		[Nullable(2)]
		protected new IUseSkillCheckBySkillGenre_SetValue PocoInterface;
	}
}
