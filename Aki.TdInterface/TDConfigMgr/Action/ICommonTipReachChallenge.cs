using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001924 RID: 6436
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipReachChallenge : ICommonTipType
	{
		// Token: 0x060089F9 RID: 35321 RVA: 0x00145528 File Offset: 0x00143728
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

		// Token: 0x060089FA RID: 35322 RVA: 0x00145560 File Offset: 0x00143760
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

		// Token: 0x060089FB RID: 35323 RVA: 0x00145573 File Offset: 0x00143773
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

		// Token: 0x060089FC RID: 35324 RVA: 0x00145586 File Offset: 0x00143786
		public new ICommonTipReachChallenge_SetValue ToSetValue()
		{
			return new ICommonTipReachChallenge_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				EdTidMainText = this.EdTidMainText
			};
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x060089FD RID: 35325 RVA: 0x001455B1 File Offset: 0x001437B1
		// (set) Token: 0x060089FE RID: 35326 RVA: 0x001455DC File Offset: 0x001437DC
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

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x060089FF RID: 35327 RVA: 0x001455EA File Offset: 0x001437EA
		// (set) Token: 0x06008A00 RID: 35328 RVA: 0x00145615 File Offset: 0x00143815
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

		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x06008A01 RID: 35329 RVA: 0x00145623 File Offset: 0x00143823
		// (set) Token: 0x06008A02 RID: 35330 RVA: 0x0014563A File Offset: 0x0014383A
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

		// Token: 0x04005656 RID: 22102
		[Nullable(2)]
		protected new ICommonTipReachChallenge FbInstance;

		// Token: 0x04005657 RID: 22103
		[Nullable(2)]
		protected new ICommonTipReachChallenge_SetValue PocoInterface;
	}
}
