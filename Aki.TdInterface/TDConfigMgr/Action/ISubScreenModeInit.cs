using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002118 RID: 8472
	public class ISubScreenModeInit : ISubScreenModeConfig
	{
		// Token: 0x0600B3E8 RID: 46056 RVA: 0x001937C0 File Offset: 0x001919C0
		private ISubScreenModeInit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreenModeInit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreenModeInit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreenModeInit_SetValue());
			}
			return result;
		}

		// Token: 0x0600B3E9 RID: 46057 RVA: 0x001937F8 File Offset: 0x001919F8
		public static ISubScreenModeInit Create([Nullable(2)] ISubScreenModeInit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenModeInit
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B3EA RID: 46058 RVA: 0x0019380B File Offset: 0x00191A0B
		public static ISubScreenModeInit CreateFromSetValue([Nullable(2)] ISubScreenModeInit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreenModeInit
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B3EB RID: 46059 RVA: 0x0019381E File Offset: 0x00191A1E
		public new ISubScreenModeInit_SetValue ToSetValue()
		{
			return new ISubScreenModeInit_SetValue
			{
				Type = this.Type,
				InitConfigs = this.InitConfigs
			};
		}

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x0600B3EC RID: 46060 RVA: 0x0019383D File Offset: 0x00191A3D
		// (set) Token: 0x0600B3ED RID: 46061 RVA: 0x00193868 File Offset: 0x00191A68
		public override ESubScreenOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubScreenOperationType.Init;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x0600B3EE RID: 46062 RVA: 0x00193876 File Offset: 0x00191A76
		// (set) Token: 0x0600B3EF RID: 46063 RVA: 0x0019389D File Offset: 0x00191A9D
		public virtual List<ISubScreenInitData> InitConfigs
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitConfigs;
				}
				ISubScreenModeInit_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitConfigs;
			}
			set
			{
				this.GetOrCreatePoco().InitConfigs = value;
			}
		}

		// Token: 0x04006A98 RID: 27288
		[Nullable(2)]
		protected new ISubScreenModeInit FbInstance;

		// Token: 0x04006A99 RID: 27289
		[Nullable(2)]
		protected new ISubScreenModeInit_SetValue PocoInterface;
	}
}
