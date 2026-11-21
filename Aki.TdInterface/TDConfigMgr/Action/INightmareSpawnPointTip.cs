using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E59 RID: 7769
	public class INightmareSpawnPointTip : ICommonTipType
	{
		// Token: 0x0600A529 RID: 42281 RVA: 0x00178D98 File Offset: 0x00176F98
		private INightmareSpawnPointTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INightmareSpawnPointTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INightmareSpawnPointTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INightmareSpawnPointTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x00178DD0 File Offset: 0x00176FD0
		public static INightmareSpawnPointTip Create([Nullable(2)] INightmareSpawnPointTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INightmareSpawnPointTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A52B RID: 42283 RVA: 0x00178DE3 File Offset: 0x00176FE3
		public static INightmareSpawnPointTip CreateFromSetValue([Nullable(2)] INightmareSpawnPointTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INightmareSpawnPointTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A52C RID: 42284 RVA: 0x00178DF8 File Offset: 0x00176FF8
		public new INightmareSpawnPointTip_SetValue ToSetValue()
		{
			return new INightmareSpawnPointTip_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600A52D RID: 42285 RVA: 0x00178E46 File Offset: 0x00177046
		// (set) Token: 0x0600A52E RID: 42286 RVA: 0x00178E71 File Offset: 0x00177071
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600A52F RID: 42287 RVA: 0x00178E7F File Offset: 0x0017707F
		// (set) Token: 0x0600A530 RID: 42288 RVA: 0x00178EAA File Offset: 0x001770AA
		public virtual string TidMainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidMainText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidMainText;
			}
			set
			{
				this.GetOrCreatePoco().TidMainText = value;
			}
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600A531 RID: 42289 RVA: 0x00178EB8 File Offset: 0x001770B8
		// (set) Token: 0x0600A532 RID: 42290 RVA: 0x00178EE3 File Offset: 0x001770E3
		public virtual string TidSubText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidSubText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidSubText;
			}
			set
			{
				this.GetOrCreatePoco().TidSubText = value;
			}
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600A533 RID: 42291 RVA: 0x00178EF1 File Offset: 0x001770F1
		// (set) Token: 0x0600A534 RID: 42292 RVA: 0x00178F08 File Offset: 0x00177108
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidMainText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidMainText = value;
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600A535 RID: 42293 RVA: 0x00178F16 File Offset: 0x00177116
		// (set) Token: 0x0600A536 RID: 42294 RVA: 0x00178F2D File Offset: 0x0017712D
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidSubText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidSubText = value;
			}
		}

		// Token: 0x040063C8 RID: 25544
		[Nullable(2)]
		protected new INightmareSpawnPointTip FbInstance;

		// Token: 0x040063C9 RID: 25545
		[Nullable(2)]
		protected new INightmareSpawnPointTip_SetValue PocoInterface;
	}
}
