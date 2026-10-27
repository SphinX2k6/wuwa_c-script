using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019C4 RID: 6596
	[NullableContext(1)]
	[Nullable(0)]
	public class IDreamlessWarning : ICommonTipType
	{
		// Token: 0x06008D4F RID: 36175 RVA: 0x0014B2E4 File Offset: 0x001494E4
		private IDreamlessWarning_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDreamlessWarning 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDreamlessWarning_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDreamlessWarning_SetValue());
			}
			return result;
		}

		// Token: 0x06008D50 RID: 36176 RVA: 0x0014B31C File Offset: 0x0014951C
		public static IDreamlessWarning Create([Nullable(2)] IDreamlessWarning instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDreamlessWarning
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D51 RID: 36177 RVA: 0x0014B32F File Offset: 0x0014952F
		public static IDreamlessWarning CreateFromSetValue([Nullable(2)] IDreamlessWarning_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDreamlessWarning
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D52 RID: 36178 RVA: 0x0014B342 File Offset: 0x00149542
		public new IDreamlessWarning_SetValue ToSetValue()
		{
			return new IDreamlessWarning_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x06008D53 RID: 36179 RVA: 0x0014B361 File Offset: 0x00149561
		// (set) Token: 0x06008D54 RID: 36180 RVA: 0x0014B38C File Offset: 0x0014958C
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

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x06008D55 RID: 36181 RVA: 0x0014B39A File Offset: 0x0014959A
		// (set) Token: 0x06008D56 RID: 36182 RVA: 0x0014B3C5 File Offset: 0x001495C5
		public virtual string WarningText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WarningText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.WarningText;
			}
			set
			{
				this.GetOrCreatePoco().WarningText = value;
			}
		}

		// Token: 0x040057CF RID: 22479
		[Nullable(2)]
		protected new IDreamlessWarning FbInstance;

		// Token: 0x040057D0 RID: 22480
		[Nullable(2)]
		protected new IDreamlessWarning_SetValue PocoInterface;
	}
}
