using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A99 RID: 6809
	public class ICommonTipChallengeCondition : ICommonTipType
	{
		// Token: 0x060090AB RID: 37035 RVA: 0x00154210 File Offset: 0x00152410
		private ICommonTipChallengeCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipChallengeCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipChallengeCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipChallengeCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060090AC RID: 37036 RVA: 0x00154248 File Offset: 0x00152448
		public static ICommonTipChallengeCondition Create([Nullable(2)] ICommonTipChallengeCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipChallengeCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090AD RID: 37037 RVA: 0x0015425B File Offset: 0x0015245B
		public static ICommonTipChallengeCondition CreateFromSetValue([Nullable(2)] ICommonTipChallengeCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipChallengeCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090AE RID: 37038 RVA: 0x00154270 File Offset: 0x00152470
		public new ICommonTipChallengeCondition_SetValue ToSetValue()
		{
			return new ICommonTipChallengeCondition_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x060090AF RID: 37039 RVA: 0x001542BE File Offset: 0x001524BE
		// (set) Token: 0x060090B0 RID: 37040 RVA: 0x001542E9 File Offset: 0x001524E9
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

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x060090B1 RID: 37041 RVA: 0x001542F7 File Offset: 0x001524F7
		// (set) Token: 0x060090B2 RID: 37042 RVA: 0x00154322 File Offset: 0x00152522
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

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x060090B3 RID: 37043 RVA: 0x00154330 File Offset: 0x00152530
		// (set) Token: 0x060090B4 RID: 37044 RVA: 0x0015435B File Offset: 0x0015255B
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

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x060090B5 RID: 37045 RVA: 0x00154369 File Offset: 0x00152569
		// (set) Token: 0x060090B6 RID: 37046 RVA: 0x00154380 File Offset: 0x00152580
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

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x060090B7 RID: 37047 RVA: 0x0015438E File Offset: 0x0015258E
		// (set) Token: 0x060090B8 RID: 37048 RVA: 0x001543A5 File Offset: 0x001525A5
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

		// Token: 0x04005A73 RID: 23155
		[Nullable(2)]
		protected new ICommonTipChallengeCondition FbInstance;

		// Token: 0x04005A74 RID: 23156
		[Nullable(2)]
		protected new ICommonTipChallengeCondition_SetValue PocoInterface;
	}
}
