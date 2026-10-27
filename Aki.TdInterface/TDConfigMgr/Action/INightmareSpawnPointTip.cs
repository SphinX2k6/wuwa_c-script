using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C60 RID: 7264
	[NullableContext(1)]
	[Nullable(0)]
	public class INightmareSpawnPointTip : ICommonTipType
	{
		// Token: 0x06009BC9 RID: 39881 RVA: 0x0016599C File Offset: 0x00163B9C
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

		// Token: 0x06009BCA RID: 39882 RVA: 0x001659D4 File Offset: 0x00163BD4
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

		// Token: 0x06009BCB RID: 39883 RVA: 0x001659E7 File Offset: 0x00163BE7
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

		// Token: 0x06009BCC RID: 39884 RVA: 0x001659FC File Offset: 0x00163BFC
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

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x06009BCD RID: 39885 RVA: 0x00165A4A File Offset: 0x00163C4A
		// (set) Token: 0x06009BCE RID: 39886 RVA: 0x00165A75 File Offset: 0x00163C75
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

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x06009BCF RID: 39887 RVA: 0x00165A83 File Offset: 0x00163C83
		// (set) Token: 0x06009BD0 RID: 39888 RVA: 0x00165AAE File Offset: 0x00163CAE
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

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x06009BD1 RID: 39889 RVA: 0x00165ABC File Offset: 0x00163CBC
		// (set) Token: 0x06009BD2 RID: 39890 RVA: 0x00165AE7 File Offset: 0x00163CE7
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

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x06009BD3 RID: 39891 RVA: 0x00165AF5 File Offset: 0x00163CF5
		// (set) Token: 0x06009BD4 RID: 39892 RVA: 0x00165B0C File Offset: 0x00163D0C
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

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x06009BD5 RID: 39893 RVA: 0x00165B1A File Offset: 0x00163D1A
		// (set) Token: 0x06009BD6 RID: 39894 RVA: 0x00165B31 File Offset: 0x00163D31
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

		// Token: 0x04005E8E RID: 24206
		[Nullable(2)]
		protected new INightmareSpawnPointTip FbInstance;

		// Token: 0x04005E8F RID: 24207
		[Nullable(2)]
		protected new INightmareSpawnPointTip_SetValue PocoInterface;
	}
}
