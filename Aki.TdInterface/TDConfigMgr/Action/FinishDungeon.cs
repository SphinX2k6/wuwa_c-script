using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001721 RID: 5921
	[NullableContext(1)]
	[Nullable(0)]
	public class FinishDungeon : ActionParams
	{
		// Token: 0x06007D69 RID: 32105 RVA: 0x0012CEBC File Offset: 0x0012B0BC
		private FinishDungeon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FinishDungeon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FinishDungeon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FinishDungeon_SetValue());
			}
			return result;
		}

		// Token: 0x06007D6A RID: 32106 RVA: 0x0012CEF4 File Offset: 0x0012B0F4
		public static FinishDungeon Create([Nullable(2)] FinishDungeon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishDungeon
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007D6B RID: 32107 RVA: 0x0012CF07 File Offset: 0x0012B107
		public static FinishDungeon CreateFromSetValue([Nullable(2)] FinishDungeon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FinishDungeon
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x0012CF1A File Offset: 0x0012B11A
		public FinishDungeon_SetValue ToSetValue()
		{
			return new FinishDungeon_SetValue
			{
				IsSuccess = this.IsSuccess
			};
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x06007D6D RID: 32109 RVA: 0x0012CF2D File Offset: 0x0012B12D
		// (set) Token: 0x06007D6E RID: 32110 RVA: 0x0012CF58 File Offset: 0x0012B158
		public virtual bool IsSuccess
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSuccess;
				}
				return this.PocoInterface != null && this.PocoInterface.IsSuccess;
			}
			set
			{
				this.GetOrCreatePoco().IsSuccess = value;
			}
		}

		// Token: 0x0400500C RID: 20492
		[Nullable(2)]
		protected new FinishDungeon FbInstance;

		// Token: 0x0400500D RID: 20493
		[Nullable(2)]
		protected FinishDungeon_SetValue PocoInterface;
	}
}
