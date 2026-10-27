using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017E4 RID: 6116
	[NullableContext(1)]
	[Nullable(0)]
	public class IAttenuatedGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x06008357 RID: 33623 RVA: 0x00139AD4 File Offset: 0x00137CD4
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

		// Token: 0x06008358 RID: 33624 RVA: 0x00139B0C File Offset: 0x00137D0C
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

		// Token: 0x06008359 RID: 33625 RVA: 0x00139B1F File Offset: 0x00137D1F
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

		// Token: 0x0600835A RID: 33626 RVA: 0x00139B34 File Offset: 0x00137D34
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

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x0600835B RID: 33627 RVA: 0x00139B8E File Offset: 0x00137D8E
		// (set) Token: 0x0600835C RID: 33628 RVA: 0x00139BB9 File Offset: 0x00137DB9
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

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x0600835D RID: 33629 RVA: 0x00139BC7 File Offset: 0x00137DC7
		// (set) Token: 0x0600835E RID: 33630 RVA: 0x00139BF2 File Offset: 0x00137DF2
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

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x0600835F RID: 33631 RVA: 0x00139C00 File Offset: 0x00137E00
		// (set) Token: 0x06008360 RID: 33632 RVA: 0x00139C2B File Offset: 0x00137E2B
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

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x06008361 RID: 33633 RVA: 0x00139C39 File Offset: 0x00137E39
		// (set) Token: 0x06008362 RID: 33634 RVA: 0x00139C64 File Offset: 0x00137E64
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

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x06008363 RID: 33635 RVA: 0x00139C72 File Offset: 0x00137E72
		// (set) Token: 0x06008364 RID: 33636 RVA: 0x00139CA1 File Offset: 0x00137EA1
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

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x06008365 RID: 33637 RVA: 0x00139CAF File Offset: 0x00137EAF
		// (set) Token: 0x06008366 RID: 33638 RVA: 0x00139CDA File Offset: 0x00137EDA
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

		// Token: 0x0400535D RID: 21341
		[Nullable(2)]
		protected new IAttenuatedGamepadShake FbInstance;

		// Token: 0x0400535E RID: 21342
		[Nullable(2)]
		protected new IAttenuatedGamepadShake_SetValue PocoInterface;
	}
}
