using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EDF RID: 7903
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenModeInit : ISubScreenModeConfig
	{
		// Token: 0x0600A916 RID: 43286 RVA: 0x0017D7C8 File Offset: 0x0017B9C8
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

		// Token: 0x0600A917 RID: 43287 RVA: 0x0017D800 File Offset: 0x0017BA00
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

		// Token: 0x0600A918 RID: 43288 RVA: 0x0017D813 File Offset: 0x0017BA13
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

		// Token: 0x0600A919 RID: 43289 RVA: 0x0017D826 File Offset: 0x0017BA26
		public new ISubScreenModeInit_SetValue ToSetValue()
		{
			return new ISubScreenModeInit_SetValue
			{
				Type = this.Type,
				InitConfigs = this.InitConfigs
			};
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600A91A RID: 43290 RVA: 0x0017D845 File Offset: 0x0017BA45
		// (set) Token: 0x0600A91B RID: 43291 RVA: 0x0017D870 File Offset: 0x0017BA70
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

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600A91C RID: 43292 RVA: 0x0017D87E File Offset: 0x0017BA7E
		// (set) Token: 0x0600A91D RID: 43293 RVA: 0x0017D8A5 File Offset: 0x0017BAA5
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

		// Token: 0x040064A9 RID: 25769
		[Nullable(2)]
		protected new ISubScreenModeInit FbInstance;

		// Token: 0x040064AA RID: 25770
		[Nullable(2)]
		protected new ISubScreenModeInit_SetValue PocoInterface;
	}
}
