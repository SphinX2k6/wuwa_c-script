using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001320 RID: 4896
	public class IUseSkillCheckByFollowShooterSkillId : IUseSkillCheckBase
	{
		// Token: 0x06006E43 RID: 28227 RVA: 0x00106380 File Offset: 0x00104580
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

		// Token: 0x06006E44 RID: 28228 RVA: 0x001063B8 File Offset: 0x001045B8
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

		// Token: 0x06006E45 RID: 28229 RVA: 0x001063CB File Offset: 0x001045CB
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

		// Token: 0x06006E46 RID: 28230 RVA: 0x001063DE File Offset: 0x001045DE
		public new IUseSkillCheckByFollowShooterSkillId_SetValue ToSetValue()
		{
			return new IUseSkillCheckByFollowShooterSkillId_SetValue
			{
				Type = this.Type,
				SkillId = this.SkillId
			};
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x06006E47 RID: 28231 RVA: 0x001063FD File Offset: 0x001045FD
		// (set) Token: 0x06006E48 RID: 28232 RVA: 0x00106428 File Offset: 0x00104628
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

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x06006E49 RID: 28233 RVA: 0x00106436 File Offset: 0x00104636
		// (set) Token: 0x06006E4A RID: 28234 RVA: 0x00106461 File Offset: 0x00104661
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

		// Token: 0x040041C7 RID: 16839
		[Nullable(2)]
		protected new IUseSkillCheckByFollowShooterSkillId FbInstance;

		// Token: 0x040041C8 RID: 16840
		[Nullable(2)]
		protected new IUseSkillCheckByFollowShooterSkillId_SetValue PocoInterface;
	}
}
