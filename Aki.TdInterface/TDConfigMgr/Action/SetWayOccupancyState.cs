using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002458 RID: 9304
	public class SetWayOccupancyState : ActionParams
	{
		// Token: 0x0600CA7F RID: 51839 RVA: 0x001CE62C File Offset: 0x001CC82C
		private SetWayOccupancyState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetWayOccupancyState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetWayOccupancyState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetWayOccupancyState_SetValue());
			}
			return result;
		}

		// Token: 0x0600CA80 RID: 51840 RVA: 0x001CE664 File Offset: 0x001CC864
		public static SetWayOccupancyState Create([Nullable(2)] SetWayOccupancyState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWayOccupancyState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CA81 RID: 51841 RVA: 0x001CE677 File Offset: 0x001CC877
		public static SetWayOccupancyState CreateFromSetValue([Nullable(2)] SetWayOccupancyState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetWayOccupancyState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CA82 RID: 51842 RVA: 0x001CE68A File Offset: 0x001CC88A
		public SetWayOccupancyState_SetValue ToSetValue()
		{
			return new SetWayOccupancyState_SetValue
			{
				Occupy = this.Occupy,
				TargetWay = this.TargetWay
			};
		}

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x0600CA83 RID: 51843 RVA: 0x001CE6A9 File Offset: 0x001CC8A9
		// (set) Token: 0x0600CA84 RID: 51844 RVA: 0x001CE6D4 File Offset: 0x001CC8D4
		public virtual bool Occupy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Occupy;
				}
				return this.PocoInterface != null && this.PocoInterface.Occupy;
			}
			set
			{
				this.GetOrCreatePoco().Occupy = value;
			}
		}

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x0600CA85 RID: 51845 RVA: 0x001CE6E2 File Offset: 0x001CC8E2
		// (set) Token: 0x0600CA86 RID: 51846 RVA: 0x001CE709 File Offset: 0x001CC909
		public virtual List<int> TargetWay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetWay;
				}
				SetWayOccupancyState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetWay;
			}
			set
			{
				this.GetOrCreatePoco().TargetWay = value;
			}
		}

		// Token: 0x04007814 RID: 30740
		[Nullable(2)]
		protected new SetWayOccupancyState FbInstance;

		// Token: 0x04007815 RID: 30741
		[Nullable(2)]
		protected SetWayOccupancyState_SetValue PocoInterface;
	}
}
