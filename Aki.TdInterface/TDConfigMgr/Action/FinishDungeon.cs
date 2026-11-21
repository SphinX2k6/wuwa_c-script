using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200189E RID: 6302
	public class FinishDungeon : ActionParams
	{
		// Token: 0x06008447 RID: 33863 RVA: 0x0013BF68 File Offset: 0x0013A168
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

		// Token: 0x06008448 RID: 33864 RVA: 0x0013BFA0 File Offset: 0x0013A1A0
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

		// Token: 0x06008449 RID: 33865 RVA: 0x0013BFB3 File Offset: 0x0013A1B3
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

		// Token: 0x0600844A RID: 33866 RVA: 0x0013BFC6 File Offset: 0x0013A1C6
		public FinishDungeon_SetValue ToSetValue()
		{
			return new FinishDungeon_SetValue
			{
				IsSuccess = this.IsSuccess
			};
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x0600844B RID: 33867 RVA: 0x0013BFD9 File Offset: 0x0013A1D9
		// (set) Token: 0x0600844C RID: 33868 RVA: 0x0013C004 File Offset: 0x0013A204
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

		// Token: 0x0400543B RID: 21563
		[Nullable(2)]
		protected new FinishDungeon FbInstance;

		// Token: 0x0400543C RID: 21564
		[Nullable(2)]
		protected FinishDungeon_SetValue PocoInterface;
	}
}
