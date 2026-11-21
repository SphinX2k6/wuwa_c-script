using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021CD RID: 8653
	public class ITeachAutoShowEnd : ICommonTipType
	{
		// Token: 0x0600BC9A RID: 48282 RVA: 0x001B4908 File Offset: 0x001B2B08
		private ITeachAutoShowEnd_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeachAutoShowEnd 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeachAutoShowEnd_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeachAutoShowEnd_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC9B RID: 48283 RVA: 0x001B4940 File Offset: 0x001B2B40
		public static ITeachAutoShowEnd Create([Nullable(2)] ITeachAutoShowEnd instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeachAutoShowEnd
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC9C RID: 48284 RVA: 0x001B4953 File Offset: 0x001B2B53
		public static ITeachAutoShowEnd CreateFromSetValue([Nullable(2)] ITeachAutoShowEnd_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeachAutoShowEnd
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC9D RID: 48285 RVA: 0x001B4966 File Offset: 0x001B2B66
		public new ITeachAutoShowEnd_SetValue ToSetValue()
		{
			return new ITeachAutoShowEnd_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				EdTidMainText = this.EdTidMainText
			};
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x0600BC9E RID: 48286 RVA: 0x001B4991 File Offset: 0x001B2B91
		// (set) Token: 0x0600BC9F RID: 48287 RVA: 0x001B49BC File Offset: 0x001B2BBC
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

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x0600BCA0 RID: 48288 RVA: 0x001B49CA File Offset: 0x001B2BCA
		// (set) Token: 0x0600BCA1 RID: 48289 RVA: 0x001B49F5 File Offset: 0x001B2BF5
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

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0600BCA2 RID: 48290 RVA: 0x001B4A03 File Offset: 0x001B2C03
		// (set) Token: 0x0600BCA3 RID: 48291 RVA: 0x001B4A1A File Offset: 0x001B2C1A
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

		// Token: 0x04007158 RID: 29016
		[Nullable(2)]
		protected new ITeachAutoShowEnd FbInstance;

		// Token: 0x04007159 RID: 29017
		[Nullable(2)]
		protected new ITeachAutoShowEnd_SetValue PocoInterface;
	}
}
