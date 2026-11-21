using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200212C RID: 8492
	public class ISunSpiritDifficultyReduction
	{
		// Token: 0x0600B444 RID: 46148 RVA: 0x001940B0 File Offset: 0x001922B0
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

		// Token: 0x0600B445 RID: 46149 RVA: 0x001940E8 File Offset: 0x001922E8
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

		// Token: 0x0600B446 RID: 46150 RVA: 0x001940FB File Offset: 0x001922FB
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

		// Token: 0x0600B447 RID: 46151 RVA: 0x0019410E File Offset: 0x0019230E
		public ISunSpiritDifficultyReduction_SetValue ToSetValue()
		{
			return new ISunSpiritDifficultyReduction_SetValue
			{
				LoseTimes = this.LoseTimes,
				SubstituteId = this.SubstituteId
			};
		}

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x0600B448 RID: 46152 RVA: 0x0019412D File Offset: 0x0019232D
		// (set) Token: 0x0600B449 RID: 46153 RVA: 0x00194158 File Offset: 0x00192358
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

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x0600B44A RID: 46154 RVA: 0x00194166 File Offset: 0x00192366
		// (set) Token: 0x0600B44B RID: 46155 RVA: 0x00194191 File Offset: 0x00192391
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

		// Token: 0x04006ABC RID: 27324
		[Nullable(2)]
		protected ISunSpiritDifficultyReduction FbInstance;

		// Token: 0x04006ABD RID: 27325
		[Nullable(2)]
		protected ISunSpiritDifficultyReduction_SetValue PocoInterface;
	}
}
