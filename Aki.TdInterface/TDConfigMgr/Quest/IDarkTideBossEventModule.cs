using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001050 RID: 4176
	public class IDarkTideBossEventModule : IDarkTideModule
	{
		// Token: 0x06005C12 RID: 23570 RVA: 0x000E034C File Offset: 0x000DE54C
		private IDarkTideBossEventModule_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideBossEventModule 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideBossEventModule_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideBossEventModule_SetValue());
			}
			return result;
		}

		// Token: 0x06005C13 RID: 23571 RVA: 0x000E0384 File Offset: 0x000DE584
		public static IDarkTideBossEventModule Create([Nullable(2)] IDarkTideBossEventModule instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideBossEventModule
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C14 RID: 23572 RVA: 0x000E0397 File Offset: 0x000DE597
		public static IDarkTideBossEventModule CreateFromSetValue([Nullable(2)] IDarkTideBossEventModule_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideBossEventModule
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C15 RID: 23573 RVA: 0x000E03AA File Offset: 0x000DE5AA
		public new IDarkTideBossEventModule_SetValue ToSetValue()
		{
			return new IDarkTideBossEventModule_SetValue
			{
				Type = this.Type,
				EventType = this.EventType
			};
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x06005C16 RID: 23574 RVA: 0x000E03C9 File Offset: 0x000DE5C9
		// (set) Token: 0x06005C17 RID: 23575 RVA: 0x000E03F4 File Offset: 0x000DE5F4
		public override EDarkTideModuleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDarkTideModuleType.BossEvent;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x06005C18 RID: 23576 RVA: 0x000E0402 File Offset: 0x000DE602
		// (set) Token: 0x06005C19 RID: 23577 RVA: 0x000E0429 File Offset: 0x000DE629
		public virtual IDarkTideBossEvent EventType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventType;
				}
				IDarkTideBossEventModule_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EventType;
			}
			set
			{
				this.GetOrCreatePoco().EventType = value;
			}
		}

		// Token: 0x04003785 RID: 14213
		[Nullable(2)]
		protected new IDarkTideBossEventModule FbInstance;

		// Token: 0x04003786 RID: 14214
		[Nullable(2)]
		protected new IDarkTideBossEventModule_SetValue PocoInterface;
	}
}
