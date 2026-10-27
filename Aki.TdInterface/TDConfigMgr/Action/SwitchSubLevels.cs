using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200222A RID: 8746
	[NullableContext(1)]
	[Nullable(0)]
	public class SwitchSubLevels : ActionParams
	{
		// Token: 0x0600BFFA RID: 49146 RVA: 0x001B9324 File Offset: 0x001B7524
		private SwitchSubLevels_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SwitchSubLevels 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SwitchSubLevels_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SwitchSubLevels_SetValue());
			}
			return result;
		}

		// Token: 0x0600BFFB RID: 49147 RVA: 0x001B935C File Offset: 0x001B755C
		public static SwitchSubLevels Create([Nullable(2)] SwitchSubLevels instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SwitchSubLevels
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BFFC RID: 49148 RVA: 0x001B936F File Offset: 0x001B756F
		public static SwitchSubLevels CreateFromSetValue([Nullable(2)] SwitchSubLevels_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SwitchSubLevels
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BFFD RID: 49149 RVA: 0x001B9382 File Offset: 0x001B7582
		public SwitchSubLevels_SetValue ToSetValue()
		{
			return new SwitchSubLevels_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x0600BFFE RID: 49150 RVA: 0x001B9395 File Offset: 0x001B7595
		// (set) Token: 0x0600BFFF RID: 49151 RVA: 0x001B93C0 File Offset: 0x001B75C0
		public virtual ESwitchSubLevelsType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESwitchSubLevelsType.Directly;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007277 RID: 29303
		[Nullable(2)]
		protected new SwitchSubLevels FbInstance;

		// Token: 0x04007278 RID: 29304
		[Nullable(2)]
		protected SwitchSubLevels_SetValue PocoInterface;
	}
}
