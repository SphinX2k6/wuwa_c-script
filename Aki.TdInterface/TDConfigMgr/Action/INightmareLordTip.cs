using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C5E RID: 7262
	[NullableContext(1)]
	[Nullable(0)]
	public class INightmareLordTip : ICommonTipType
	{
		// Token: 0x06009BB9 RID: 39865 RVA: 0x001657E8 File Offset: 0x001639E8
		private INightmareLordTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INightmareLordTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INightmareLordTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INightmareLordTip_SetValue());
			}
			return result;
		}

		// Token: 0x06009BBA RID: 39866 RVA: 0x00165820 File Offset: 0x00163A20
		public static INightmareLordTip Create([Nullable(2)] INightmareLordTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INightmareLordTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BBB RID: 39867 RVA: 0x00165833 File Offset: 0x00163A33
		public static INightmareLordTip CreateFromSetValue([Nullable(2)] INightmareLordTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INightmareLordTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BBC RID: 39868 RVA: 0x00165848 File Offset: 0x00163A48
		public new INightmareLordTip_SetValue ToSetValue()
		{
			return new INightmareLordTip_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x06009BBD RID: 39869 RVA: 0x00165896 File Offset: 0x00163A96
		// (set) Token: 0x06009BBE RID: 39870 RVA: 0x001658C1 File Offset: 0x00163AC1
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

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x06009BBF RID: 39871 RVA: 0x001658CF File Offset: 0x00163ACF
		// (set) Token: 0x06009BC0 RID: 39872 RVA: 0x001658FA File Offset: 0x00163AFA
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

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x06009BC1 RID: 39873 RVA: 0x00165908 File Offset: 0x00163B08
		// (set) Token: 0x06009BC2 RID: 39874 RVA: 0x00165933 File Offset: 0x00163B33
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

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x06009BC3 RID: 39875 RVA: 0x00165941 File Offset: 0x00163B41
		// (set) Token: 0x06009BC4 RID: 39876 RVA: 0x00165958 File Offset: 0x00163B58
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

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x06009BC5 RID: 39877 RVA: 0x00165966 File Offset: 0x00163B66
		// (set) Token: 0x06009BC6 RID: 39878 RVA: 0x0016597D File Offset: 0x00163B7D
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

		// Token: 0x04005E87 RID: 24199
		[Nullable(2)]
		protected new INightmareLordTip FbInstance;

		// Token: 0x04005E88 RID: 24200
		[Nullable(2)]
		protected new INightmareLordTip_SetValue PocoInterface;
	}
}
