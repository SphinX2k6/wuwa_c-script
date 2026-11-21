using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C0A RID: 7178
	public class IFlipperTip : ICommonTipType
	{
		// Token: 0x06009870 RID: 39024 RVA: 0x00161BE0 File Offset: 0x0015FDE0
		private IFlipperTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlipperTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlipperTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlipperTip_SetValue());
			}
			return result;
		}

		// Token: 0x06009871 RID: 39025 RVA: 0x00161C18 File Offset: 0x0015FE18
		public static IFlipperTip Create([Nullable(2)] IFlipperTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009872 RID: 39026 RVA: 0x00161C2B File Offset: 0x0015FE2B
		public static IFlipperTip CreateFromSetValue([Nullable(2)] IFlipperTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlipperTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009873 RID: 39027 RVA: 0x00161C40 File Offset: 0x0015FE40
		public new IFlipperTip_SetValue ToSetValue()
		{
			return new IFlipperTip_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x06009874 RID: 39028 RVA: 0x00161C8E File Offset: 0x0015FE8E
		// (set) Token: 0x06009875 RID: 39029 RVA: 0x00161CB9 File Offset: 0x0015FEB9
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

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x06009876 RID: 39030 RVA: 0x00161CC7 File Offset: 0x0015FEC7
		// (set) Token: 0x06009877 RID: 39031 RVA: 0x00161CF2 File Offset: 0x0015FEF2
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

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x06009878 RID: 39032 RVA: 0x00161D00 File Offset: 0x0015FF00
		// (set) Token: 0x06009879 RID: 39033 RVA: 0x00161D2B File Offset: 0x0015FF2B
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

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x0600987A RID: 39034 RVA: 0x00161D39 File Offset: 0x0015FF39
		// (set) Token: 0x0600987B RID: 39035 RVA: 0x00161D50 File Offset: 0x0015FF50
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

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x0600987C RID: 39036 RVA: 0x00161D5E File Offset: 0x0015FF5E
		// (set) Token: 0x0600987D RID: 39037 RVA: 0x00161D75 File Offset: 0x0015FF75
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

		// Token: 0x04005DE3 RID: 24035
		[Nullable(2)]
		protected new IFlipperTip FbInstance;

		// Token: 0x04005DE4 RID: 24036
		[Nullable(2)]
		protected new IFlipperTip_SetValue PocoInterface;
	}
}
