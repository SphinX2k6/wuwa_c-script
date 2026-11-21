using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DEB RID: 7659
	public class IMonsterStandByConfig
	{
		// Token: 0x0600A297 RID: 41623 RVA: 0x00173F60 File Offset: 0x00172160
		private IMonsterStandByConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterStandByConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterStandByConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterStandByConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x00173F98 File Offset: 0x00172198
		public static IMonsterStandByConfig Create([Nullable(2)] IMonsterStandByConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterStandByConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A299 RID: 41625 RVA: 0x00173FAB File Offset: 0x001721AB
		public static IMonsterStandByConfig CreateFromSetValue([Nullable(2)] IMonsterStandByConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterStandByConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x00173FBE File Offset: 0x001721BE
		public IMonsterStandByConfig_SetValue ToSetValue()
		{
			return new IMonsterStandByConfig_SetValue
			{
				Tag = this.Tag,
				Duration = this.Duration,
				RepeatTimes = this.RepeatTimes,
				EmotionId = this.EmotionId
			};
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600A29B RID: 41627 RVA: 0x00173FF5 File Offset: 0x001721F5
		// (set) Token: 0x0600A29C RID: 41628 RVA: 0x00174020 File Offset: 0x00172220
		public virtual string Tag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Tag;
			}
			set
			{
				this.GetOrCreatePoco().Tag = value;
			}
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600A29D RID: 41629 RVA: 0x00174030 File Offset: 0x00172230
		// (set) Token: 0x0600A29E RID: 41630 RVA: 0x0017406A File Offset: 0x0017226A
		public virtual float? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				IMonsterStandByConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600A29F RID: 41631 RVA: 0x00174078 File Offset: 0x00172278
		// (set) Token: 0x0600A2A0 RID: 41632 RVA: 0x001740B2 File Offset: 0x001722B2
		public virtual int? RepeatTimes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RepeatTimes;
				}
				IMonsterStandByConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RepeatTimes;
			}
			set
			{
				this.GetOrCreatePoco().RepeatTimes = value;
			}
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600A2A1 RID: 41633 RVA: 0x001740C0 File Offset: 0x001722C0
		// (set) Token: 0x0600A2A2 RID: 41634 RVA: 0x001740FA File Offset: 0x001722FA
		public virtual int? EmotionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EmotionId;
				}
				IMonsterStandByConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EmotionId;
			}
			set
			{
				this.GetOrCreatePoco().EmotionId = value;
			}
		}

		// Token: 0x0400628C RID: 25228
		[Nullable(2)]
		protected IMonsterStandByConfig FbInstance;

		// Token: 0x0400628D RID: 25229
		[Nullable(2)]
		protected IMonsterStandByConfig_SetValue PocoInterface;
	}
}
