using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200105A RID: 4186
	public class IDarkTideModule
	{
		// Token: 0x06005C3C RID: 23612 RVA: 0x000E0738 File Offset: 0x000DE938
		private IDarkTideModule_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideModule 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideModule_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideModule_SetValue());
			}
			return result;
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x000E0770 File Offset: 0x000DE970
		public static IDarkTideModule Create([Nullable(2)] IDarkTideModule instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideModule
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C3E RID: 23614 RVA: 0x000E0783 File Offset: 0x000DE983
		public static IDarkTideModule CreateFromSetValue([Nullable(2)] IDarkTideModule_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideModule
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C3F RID: 23615 RVA: 0x000E0796 File Offset: 0x000DE996
		public IDarkTideModule_SetValue ToSetValue()
		{
			return new IDarkTideModule_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06005C40 RID: 23616 RVA: 0x000E07A9 File Offset: 0x000DE9A9
		// (set) Token: 0x06005C41 RID: 23617 RVA: 0x000E07D4 File Offset: 0x000DE9D4
		public virtual EDarkTideModuleType Type
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

		// Token: 0x04003795 RID: 14229
		[Nullable(2)]
		protected IDarkTideModule FbInstance;

		// Token: 0x04003796 RID: 14230
		[Nullable(2)]
		protected IDarkTideModule_SetValue PocoInterface;
	}
}
