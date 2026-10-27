using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F07 RID: 7943
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchSeason : IClientSetSeasonStateConfig
	{
		// Token: 0x0600A9DA RID: 43482 RVA: 0x0017EB78 File Offset: 0x0017CD78
		private ISwitchSeason_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwitchSeason 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwitchSeason_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwitchSeason_SetValue());
			}
			return result;
		}

		// Token: 0x0600A9DB RID: 43483 RVA: 0x0017EBB0 File Offset: 0x0017CDB0
		public static ISwitchSeason Create([Nullable(2)] ISwitchSeason instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchSeason
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x0017EBC3 File Offset: 0x0017CDC3
		public static ISwitchSeason CreateFromSetValue([Nullable(2)] ISwitchSeason_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwitchSeason
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x0017EBD6 File Offset: 0x0017CDD6
		public new ISwitchSeason_SetValue ToSetValue()
		{
			return new ISwitchSeason_SetValue
			{
				Type = this.Type,
				Season = this.Season,
				TransitionSpeed = this.TransitionSpeed
			};
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600A9DE RID: 43486 RVA: 0x0017EC01 File Offset: 0x0017CE01
		// (set) Token: 0x0600A9DF RID: 43487 RVA: 0x0017EC2C File Offset: 0x0017CE2C
		public override EClientSetSeasonStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientSetSeasonStateType.SwitchSeason;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600A9E0 RID: 43488 RVA: 0x0017EC3A File Offset: 0x0017CE3A
		// (set) Token: 0x0600A9E1 RID: 43489 RVA: 0x0017EC65 File Offset: 0x0017CE65
		public virtual ESeason Season
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Season;
				}
				if (this.PocoInterface == null)
				{
					return ESeason.Spring;
				}
				return this.PocoInterface.Season;
			}
			set
			{
				this.GetOrCreatePoco().Season = value;
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600A9E2 RID: 43490 RVA: 0x0017EC73 File Offset: 0x0017CE73
		// (set) Token: 0x0600A9E3 RID: 43491 RVA: 0x0017ECA2 File Offset: 0x0017CEA2
		public virtual float TransitionSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TransitionSpeed;
			}
			set
			{
				this.GetOrCreatePoco().TransitionSpeed = value;
			}
		}

		// Token: 0x040064F9 RID: 25849
		[Nullable(2)]
		protected new ISwitchSeason FbInstance;

		// Token: 0x040064FA RID: 25850
		[Nullable(2)]
		protected new ISwitchSeason_SetValue PocoInterface;
	}
}
