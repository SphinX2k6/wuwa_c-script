using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EF3 RID: 7923
	[NullableContext(1)]
	[Nullable(0)]
	public class ISunSpiritDifficultyReduction
	{
		// Token: 0x0600A972 RID: 43378 RVA: 0x0017E0B8 File Offset: 0x0017C2B8
		private ISunSpiritDifficultyReduction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISunSpiritDifficultyReduction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISunSpiritDifficultyReduction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISunSpiritDifficultyReduction_SetValue());
			}
			return result;
		}

		// Token: 0x0600A973 RID: 43379 RVA: 0x0017E0F0 File Offset: 0x0017C2F0
		public static ISunSpiritDifficultyReduction Create([Nullable(2)] ISunSpiritDifficultyReduction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritDifficultyReduction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A974 RID: 43380 RVA: 0x0017E103 File Offset: 0x0017C303
		public static ISunSpiritDifficultyReduction CreateFromSetValue([Nullable(2)] ISunSpiritDifficultyReduction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISunSpiritDifficultyReduction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A975 RID: 43381 RVA: 0x0017E116 File Offset: 0x0017C316
		public ISunSpiritDifficultyReduction_SetValue ToSetValue()
		{
			return new ISunSpiritDifficultyReduction_SetValue
			{
				LoseTimes = this.LoseTimes,
				SubstituteId = this.SubstituteId
			};
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0600A976 RID: 43382 RVA: 0x0017E135 File Offset: 0x0017C335
		// (set) Token: 0x0600A977 RID: 43383 RVA: 0x0017E160 File Offset: 0x0017C360
		public virtual int LoseTimes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoseTimes;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LoseTimes;
			}
			set
			{
				this.GetOrCreatePoco().LoseTimes = value;
			}
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0600A978 RID: 43384 RVA: 0x0017E16E File Offset: 0x0017C36E
		// (set) Token: 0x0600A979 RID: 43385 RVA: 0x0017E199 File Offset: 0x0017C399
		public virtual int SubstituteId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubstituteId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SubstituteId;
			}
			set
			{
				this.GetOrCreatePoco().SubstituteId = value;
			}
		}

		// Token: 0x040064CD RID: 25805
		[Nullable(2)]
		protected ISunSpiritDifficultyReduction FbInstance;

		// Token: 0x040064CE RID: 25806
		[Nullable(2)]
		protected ISunSpiritDifficultyReduction_SetValue PocoInterface;
	}
}
