using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001713 RID: 5907
	[NullableContext(1)]
	[Nullable(0)]
	public class ExitDungeon : ActionParams
	{
		// Token: 0x06007D27 RID: 32039 RVA: 0x0012C6B0 File Offset: 0x0012A8B0
		private ExitDungeon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExitDungeon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExitDungeon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExitDungeon_SetValue());
			}
			return result;
		}

		// Token: 0x06007D28 RID: 32040 RVA: 0x0012C6E8 File Offset: 0x0012A8E8
		public static ExitDungeon Create([Nullable(2)] ExitDungeon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExitDungeon
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007D29 RID: 32041 RVA: 0x0012C6FB File Offset: 0x0012A8FB
		public static ExitDungeon CreateFromSetValue([Nullable(2)] ExitDungeon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExitDungeon
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007D2A RID: 32042 RVA: 0x0012C70E File Offset: 0x0012A90E
		public ExitDungeon_SetValue ToSetValue()
		{
			return new ExitDungeon_SetValue
			{
				IsNeedSecondaryConfirmation = this.IsNeedSecondaryConfirmation
			};
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x06007D2B RID: 32043 RVA: 0x0012C724 File Offset: 0x0012A924
		// (set) Token: 0x06007D2C RID: 32044 RVA: 0x0012C75E File Offset: 0x0012A95E
		public virtual bool? IsNeedSecondaryConfirmation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNeedSecondaryConfirmation;
				}
				ExitDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsNeedSecondaryConfirmation;
			}
			set
			{
				this.GetOrCreatePoco().IsNeedSecondaryConfirmation = value;
			}
		}

		// Token: 0x04004FE8 RID: 20456
		[Nullable(2)]
		protected new ExitDungeon FbInstance;

		// Token: 0x04004FE9 RID: 20457
		[Nullable(2)]
		protected ExitDungeon_SetValue PocoInterface;
	}
}
