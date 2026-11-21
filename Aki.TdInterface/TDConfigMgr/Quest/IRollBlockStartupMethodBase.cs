using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200124C RID: 4684
	public class IRollBlockStartupMethodBase
	{
		// Token: 0x060068E5 RID: 26853 RVA: 0x000FAEE4 File Offset: 0x000F90E4
		private IRollBlockStartupMethodBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRollBlockStartupMethodBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRollBlockStartupMethodBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRollBlockStartupMethodBase_SetValue());
			}
			return result;
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x000FAF1C File Offset: 0x000F911C
		public static IRollBlockStartupMethodBase Create([Nullable(2)] IRollBlockStartupMethodBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRollBlockStartupMethodBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060068E7 RID: 26855 RVA: 0x000FAF2F File Offset: 0x000F912F
		public static IRollBlockStartupMethodBase CreateFromSetValue([Nullable(2)] IRollBlockStartupMethodBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRollBlockStartupMethodBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x000FAF42 File Offset: 0x000F9142
		public IRollBlockStartupMethodBase_SetValue ToSetValue()
		{
			return new IRollBlockStartupMethodBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x060068E9 RID: 26857 RVA: 0x000FAF55 File Offset: 0x000F9155
		// (set) Token: 0x060068EA RID: 26858 RVA: 0x000FAF80 File Offset: 0x000F9180
		public virtual ERollBlockLaunchMethod Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERollBlockLaunchMethod.Interact;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003E9D RID: 16029
		[Nullable(2)]
		protected IRollBlockStartupMethodBase FbInstance;

		// Token: 0x04003E9E RID: 16030
		[Nullable(2)]
		protected IRollBlockStartupMethodBase_SetValue PocoInterface;
	}
}
