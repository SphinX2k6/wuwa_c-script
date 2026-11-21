using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AAD RID: 6829
	public class ICommonTipReachChallenge : ICommonTipType
	{
		// Token: 0x06009125 RID: 37157 RVA: 0x00154E68 File Offset: 0x00153068
		private ICommonTipReachChallenge_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipReachChallenge 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipReachChallenge_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipReachChallenge_SetValue());
			}
			return result;
		}

		// Token: 0x06009126 RID: 37158 RVA: 0x00154EA0 File Offset: 0x001530A0
		public static ICommonTipReachChallenge Create([Nullable(2)] ICommonTipReachChallenge instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipReachChallenge
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009127 RID: 37159 RVA: 0x00154EB3 File Offset: 0x001530B3
		public static ICommonTipReachChallenge CreateFromSetValue([Nullable(2)] ICommonTipReachChallenge_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipReachChallenge
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009128 RID: 37160 RVA: 0x00154EC6 File Offset: 0x001530C6
		public new ICommonTipReachChallenge_SetValue ToSetValue()
		{
			return new ICommonTipReachChallenge_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				EdTidMainText = this.EdTidMainText
			};
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x06009129 RID: 37161 RVA: 0x00154EF1 File Offset: 0x001530F1
		// (set) Token: 0x0600912A RID: 37162 RVA: 0x00154F1C File Offset: 0x0015311C
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

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x0600912B RID: 37163 RVA: 0x00154F2A File Offset: 0x0015312A
		// (set) Token: 0x0600912C RID: 37164 RVA: 0x00154F55 File Offset: 0x00153155
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

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x0600912D RID: 37165 RVA: 0x00154F63 File Offset: 0x00153163
		// (set) Token: 0x0600912E RID: 37166 RVA: 0x00154F7A File Offset: 0x0015317A
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

		// Token: 0x04005AA6 RID: 23206
		[Nullable(2)]
		protected new ICommonTipReachChallenge FbInstance;

		// Token: 0x04005AA7 RID: 23207
		[Nullable(2)]
		protected new ICommonTipReachChallenge_SetValue PocoInterface;
	}
}
