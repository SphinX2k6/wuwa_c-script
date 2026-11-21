using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021CF RID: 8655
	public class ITeachAutoShowStart : ICommonTipType
	{
		// Token: 0x0600BCA6 RID: 48294 RVA: 0x001B4A38 File Offset: 0x001B2C38
		private ITeachAutoShowStart_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeachAutoShowStart 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeachAutoShowStart_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeachAutoShowStart_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCA7 RID: 48295 RVA: 0x001B4A70 File Offset: 0x001B2C70
		public static ITeachAutoShowStart Create([Nullable(2)] ITeachAutoShowStart instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeachAutoShowStart
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCA8 RID: 48296 RVA: 0x001B4A83 File Offset: 0x001B2C83
		public static ITeachAutoShowStart CreateFromSetValue([Nullable(2)] ITeachAutoShowStart_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeachAutoShowStart
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCA9 RID: 48297 RVA: 0x001B4A96 File Offset: 0x001B2C96
		public new ITeachAutoShowStart_SetValue ToSetValue()
		{
			return new ITeachAutoShowStart_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				EdTidMainText = this.EdTidMainText
			};
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0600BCAA RID: 48298 RVA: 0x001B4AC1 File Offset: 0x001B2CC1
		// (set) Token: 0x0600BCAB RID: 48299 RVA: 0x001B4AEC File Offset: 0x001B2CEC
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

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0600BCAC RID: 48300 RVA: 0x001B4AFA File Offset: 0x001B2CFA
		// (set) Token: 0x0600BCAD RID: 48301 RVA: 0x001B4B25 File Offset: 0x001B2D25
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

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0600BCAE RID: 48302 RVA: 0x001B4B33 File Offset: 0x001B2D33
		// (set) Token: 0x0600BCAF RID: 48303 RVA: 0x001B4B4A File Offset: 0x001B2D4A
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

		// Token: 0x0400715D RID: 29021
		[Nullable(2)]
		protected new ITeachAutoShowStart FbInstance;

		// Token: 0x0400715E RID: 29022
		[Nullable(2)]
		protected new ITeachAutoShowStart_SetValue PocoInterface;
	}
}
