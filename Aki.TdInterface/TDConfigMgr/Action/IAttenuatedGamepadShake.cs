using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200196D RID: 6509
	public class IAttenuatedGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x06008A73 RID: 35443 RVA: 0x001491BC File Offset: 0x001473BC
		private IAttenuatedGamepadShake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAttenuatedGamepadShake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAttenuatedGamepadShake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAttenuatedGamepadShake_SetValue());
			}
			return result;
		}

		// Token: 0x06008A74 RID: 35444 RVA: 0x001491F4 File Offset: 0x001473F4
		public static IAttenuatedGamepadShake Create([Nullable(2)] IAttenuatedGamepadShake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAttenuatedGamepadShake
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A75 RID: 35445 RVA: 0x00149207 File Offset: 0x00147407
		public static IAttenuatedGamepadShake CreateFromSetValue([Nullable(2)] IAttenuatedGamepadShake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAttenuatedGamepadShake
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A76 RID: 35446 RVA: 0x0014921C File Offset: 0x0014741C
		public new IAttenuatedGamepadShake_SetValue ToSetValue()
		{
			return new IAttenuatedGamepadShake_SetValue
			{
				Type = this.Type,
				CenterEntity = this.CenterEntity,
				IsFollowEntityMovement = this.IsFollowEntityMovement,
				ForceFeedbackAttenuation = this.ForceFeedbackAttenuation,
				Duration = this.Duration,
				IsLoop = this.IsLoop
			};
		}

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x06008A77 RID: 35447 RVA: 0x00149276 File Offset: 0x00147476
		// (set) Token: 0x06008A78 RID: 35448 RVA: 0x001492A1 File Offset: 0x001474A1
		public override EGamepadShakeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGamepadShakeType.Onetime;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x06008A79 RID: 35449 RVA: 0x001492AF File Offset: 0x001474AF
		// (set) Token: 0x06008A7A RID: 35450 RVA: 0x001492DA File Offset: 0x001474DA
		public virtual int CenterEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CenterEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CenterEntity;
			}
			set
			{
				this.GetOrCreatePoco().CenterEntity = value;
			}
		}

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x06008A7B RID: 35451 RVA: 0x001492E8 File Offset: 0x001474E8
		// (set) Token: 0x06008A7C RID: 35452 RVA: 0x00149313 File Offset: 0x00147513
		public virtual bool IsFollowEntityMovement
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFollowEntityMovement;
				}
				return this.PocoInterface != null && this.PocoInterface.IsFollowEntityMovement;
			}
			set
			{
				this.GetOrCreatePoco().IsFollowEntityMovement = value;
			}
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x06008A7D RID: 35453 RVA: 0x00149321 File Offset: 0x00147521
		// (set) Token: 0x06008A7E RID: 35454 RVA: 0x0014934C File Offset: 0x0014754C
		public virtual string ForceFeedbackAttenuation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForceFeedbackAttenuation;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ForceFeedbackAttenuation;
			}
			set
			{
				this.GetOrCreatePoco().ForceFeedbackAttenuation = value;
			}
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x06008A7F RID: 35455 RVA: 0x0014935A File Offset: 0x0014755A
		// (set) Token: 0x06008A80 RID: 35456 RVA: 0x00149389 File Offset: 0x00147589
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x06008A81 RID: 35457 RVA: 0x00149397 File Offset: 0x00147597
		// (set) Token: 0x06008A82 RID: 35458 RVA: 0x001493C2 File Offset: 0x001475C2
		public virtual bool IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				return this.PocoInterface != null && this.PocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x040057A5 RID: 22437
		[Nullable(2)]
		protected new IAttenuatedGamepadShake FbInstance;

		// Token: 0x040057A6 RID: 22438
		[Nullable(2)]
		protected new IAttenuatedGamepadShake_SetValue PocoInterface;
	}
}
