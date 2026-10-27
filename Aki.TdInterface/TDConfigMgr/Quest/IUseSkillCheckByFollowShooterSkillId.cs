using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011E4 RID: 4580
	[NullableContext(1)]
	[Nullable(0)]
	public class IUseSkillCheckByFollowShooterSkillId : IUseSkillCheckBase
	{
		// Token: 0x06006802 RID: 26626 RVA: 0x000F8A74 File Offset: 0x000F6C74
		private IUseSkillCheckByFollowShooterSkillId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseSkillCheckByFollowShooterSkillId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseSkillCheckByFollowShooterSkillId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseSkillCheckByFollowShooterSkillId_SetValue());
			}
			return result;
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x000F8AAC File Offset: 0x000F6CAC
		public static IUseSkillCheckByFollowShooterSkillId Create([Nullable(2)] IUseSkillCheckByFollowShooterSkillId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckByFollowShooterSkillId
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x000F8ABF File Offset: 0x000F6CBF
		public static IUseSkillCheckByFollowShooterSkillId CreateFromSetValue([Nullable(2)] IUseSkillCheckByFollowShooterSkillId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseSkillCheckByFollowShooterSkillId
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x000F8AD2 File Offset: 0x000F6CD2
		public new IUseSkillCheckByFollowShooterSkillId_SetValue ToSetValue()
		{
			return new IUseSkillCheckByFollowShooterSkillId_SetValue
			{
				Type = this.Type,
				SkillId = this.SkillId
			};
		}

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x06006806 RID: 26630 RVA: 0x000F8AF1 File Offset: 0x000F6CF1
		// (set) Token: 0x06006807 RID: 26631 RVA: 0x000F8B1C File Offset: 0x000F6D1C
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

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x06006808 RID: 26632 RVA: 0x000F8B2A File Offset: 0x000F6D2A
		// (set) Token: 0x06006809 RID: 26633 RVA: 0x000F8B55 File Offset: 0x000F6D55
		public virtual int SkillId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SkillId;
			}
			set
			{
				this.GetOrCreatePoco().SkillId = value;
			}
		}

		// Token: 0x04003E59 RID: 15961
		[Nullable(2)]
		protected new IUseSkillCheckByFollowShooterSkillId FbInstance;

		// Token: 0x04003E5A RID: 15962
		[Nullable(2)]
		protected new IUseSkillCheckByFollowShooterSkillId_SetValue PocoInterface;
	}
}
