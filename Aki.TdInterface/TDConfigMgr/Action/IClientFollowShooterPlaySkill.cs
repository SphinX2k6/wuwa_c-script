using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A49 RID: 6729
	public class IClientFollowShooterPlaySkill : IClientFollowShooterLeisureInteractType
	{
		// Token: 0x06008F0D RID: 36621 RVA: 0x00151574 File Offset: 0x0014F774
		private IClientFollowShooterPlaySkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientFollowShooterPlaySkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientFollowShooterPlaySkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientFollowShooterPlaySkill_SetValue());
			}
			return result;
		}

		// Token: 0x06008F0E RID: 36622 RVA: 0x001515AC File Offset: 0x0014F7AC
		public static IClientFollowShooterPlaySkill Create([Nullable(2)] IClientFollowShooterPlaySkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientFollowShooterPlaySkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008F0F RID: 36623 RVA: 0x001515BF File Offset: 0x0014F7BF
		public static IClientFollowShooterPlaySkill CreateFromSetValue([Nullable(2)] IClientFollowShooterPlaySkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientFollowShooterPlaySkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008F10 RID: 36624 RVA: 0x001515D2 File Offset: 0x0014F7D2
		public new IClientFollowShooterPlaySkill_SetValue ToSetValue()
		{
			return new IClientFollowShooterPlaySkill_SetValue
			{
				Type = this.Type,
				SkillId = this.SkillId
			};
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x06008F11 RID: 36625 RVA: 0x001515F1 File Offset: 0x0014F7F1
		// (set) Token: 0x06008F12 RID: 36626 RVA: 0x0015161C File Offset: 0x0014F81C
		public override EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientFollowShooterLeisureInteractType.PlayAnimation;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x06008F13 RID: 36627 RVA: 0x0015162A File Offset: 0x0014F82A
		// (set) Token: 0x06008F14 RID: 36628 RVA: 0x00151655 File Offset: 0x0014F855
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

		// Token: 0x040059BE RID: 22974
		[Nullable(2)]
		protected new IClientFollowShooterPlaySkill FbInstance;

		// Token: 0x040059BF RID: 22975
		[Nullable(2)]
		protected new IClientFollowShooterPlaySkill_SetValue PocoInterface;
	}
}
