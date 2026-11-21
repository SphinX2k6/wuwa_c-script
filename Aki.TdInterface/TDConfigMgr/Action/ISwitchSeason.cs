using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002140 RID: 8512
	public class ISwitchSeason : IClientSetSeasonStateConfig
	{
		// Token: 0x0600B4AC RID: 46252 RVA: 0x00194B70 File Offset: 0x00192D70
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

		// Token: 0x0600B4AD RID: 46253 RVA: 0x00194BA8 File Offset: 0x00192DA8
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

		// Token: 0x0600B4AE RID: 46254 RVA: 0x00194BBB File Offset: 0x00192DBB
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

		// Token: 0x0600B4AF RID: 46255 RVA: 0x00194BCE File Offset: 0x00192DCE
		public new ISwitchSeason_SetValue ToSetValue()
		{
			return new ISwitchSeason_SetValue
			{
				Type = this.Type,
				Season = this.Season,
				TransitionSpeed = this.TransitionSpeed
			};
		}

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x0600B4B0 RID: 46256 RVA: 0x00194BF9 File Offset: 0x00192DF9
		// (set) Token: 0x0600B4B1 RID: 46257 RVA: 0x00194C24 File Offset: 0x00192E24
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

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x0600B4B2 RID: 46258 RVA: 0x00194C32 File Offset: 0x00192E32
		// (set) Token: 0x0600B4B3 RID: 46259 RVA: 0x00194C5D File Offset: 0x00192E5D
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

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x0600B4B4 RID: 46260 RVA: 0x00194C6B File Offset: 0x00192E6B
		// (set) Token: 0x0600B4B5 RID: 46261 RVA: 0x00194C9A File Offset: 0x00192E9A
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

		// Token: 0x04006AE8 RID: 27368
		[Nullable(2)]
		protected new ISwitchSeason FbInstance;

		// Token: 0x04006AE9 RID: 27369
		[Nullable(2)]
		protected new ISwitchSeason_SetValue PocoInterface;
	}
}
