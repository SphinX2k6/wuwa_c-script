using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001914 RID: 6420
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipChallengeSuccess : ICommonTipType
	{
		// Token: 0x0600899B RID: 35227 RVA: 0x00144BB4 File Offset: 0x00142DB4
		private ICommonTipChallengeSuccess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipChallengeSuccess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipChallengeSuccess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipChallengeSuccess_SetValue());
			}
			return result;
		}

		// Token: 0x0600899C RID: 35228 RVA: 0x00144BEC File Offset: 0x00142DEC
		public static ICommonTipChallengeSuccess Create([Nullable(2)] ICommonTipChallengeSuccess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipChallengeSuccess
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600899D RID: 35229 RVA: 0x00144BFF File Offset: 0x00142DFF
		public static ICommonTipChallengeSuccess CreateFromSetValue([Nullable(2)] ICommonTipChallengeSuccess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipChallengeSuccess
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600899E RID: 35230 RVA: 0x00144C12 File Offset: 0x00142E12
		public new ICommonTipChallengeSuccess_SetValue ToSetValue()
		{
			return new ICommonTipChallengeSuccess_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				EdTidMainText = this.EdTidMainText
			};
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x0600899F RID: 35231 RVA: 0x00144C3D File Offset: 0x00142E3D
		// (set) Token: 0x060089A0 RID: 35232 RVA: 0x00144C68 File Offset: 0x00142E68
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

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x060089A1 RID: 35233 RVA: 0x00144C76 File Offset: 0x00142E76
		// (set) Token: 0x060089A2 RID: 35234 RVA: 0x00144CA1 File Offset: 0x00142EA1
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

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x060089A3 RID: 35235 RVA: 0x00144CAF File Offset: 0x00142EAF
		// (set) Token: 0x060089A4 RID: 35236 RVA: 0x00144CC6 File Offset: 0x00142EC6
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

		// Token: 0x0400562F RID: 22063
		[Nullable(2)]
		protected new ICommonTipChallengeSuccess FbInstance;

		// Token: 0x04005630 RID: 22064
		[Nullable(2)]
		protected new ICommonTipChallengeSuccess_SetValue PocoInterface;
	}
}
