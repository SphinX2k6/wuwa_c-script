using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F9 RID: 8697
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffUnlockClue : ActionParams
	{
		// Token: 0x0600BEFF RID: 48895 RVA: 0x001B7594 File Offset: 0x001B5794
		private SheriffUnlockClue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SheriffUnlockClue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SheriffUnlockClue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SheriffUnlockClue_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF00 RID: 48896 RVA: 0x001B75CC File Offset: 0x001B57CC
		public static SheriffUnlockClue Create([Nullable(2)] SheriffUnlockClue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffUnlockClue
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF01 RID: 48897 RVA: 0x001B75DF File Offset: 0x001B57DF
		public static SheriffUnlockClue CreateFromSetValue([Nullable(2)] SheriffUnlockClue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SheriffUnlockClue
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x001B75F2 File Offset: 0x001B57F2
		public SheriffUnlockClue_SetValue ToSetValue()
		{
			return new SheriffUnlockClue_SetValue
			{
				ClueId = this.ClueId
			};
		}

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x0600BF03 RID: 48899 RVA: 0x001B7605 File Offset: 0x001B5805
		// (set) Token: 0x0600BF04 RID: 48900 RVA: 0x001B7630 File Offset: 0x001B5830
		public virtual int ClueId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ClueId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ClueId;
			}
			set
			{
				this.GetOrCreatePoco().ClueId = value;
			}
		}

		// Token: 0x040071E3 RID: 29155
		[Nullable(2)]
		protected new SheriffUnlockClue FbInstance;

		// Token: 0x040071E4 RID: 29156
		[Nullable(2)]
		protected SheriffUnlockClue_SetValue PocoInterface;
	}
}
