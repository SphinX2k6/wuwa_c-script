using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021ED RID: 8685
	[NullableContext(1)]
	[Nullable(0)]
	public class SetWayOccupancyState : ActionParams
	{
		// Token: 0x0600BEC3 RID: 48835 RVA: 0x001B6FA0 File Offset: 0x001B51A0
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

		// Token: 0x0600BEC4 RID: 48836 RVA: 0x001B6FD8 File Offset: 0x001B51D8
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

		// Token: 0x0600BEC5 RID: 48837 RVA: 0x001B6FEB File Offset: 0x001B51EB
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

		// Token: 0x0600BEC6 RID: 48838 RVA: 0x001B6FFE File Offset: 0x001B51FE
		public SetWayOccupancyState_SetValue ToSetValue()
		{
			return new SetWayOccupancyState_SetValue
			{
				Occupy = this.Occupy,
				TargetWay = this.TargetWay
			};
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x0600BEC7 RID: 48839 RVA: 0x001B701D File Offset: 0x001B521D
		// (set) Token: 0x0600BEC8 RID: 48840 RVA: 0x001B7048 File Offset: 0x001B5248
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

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x0600BEC9 RID: 48841 RVA: 0x001B7056 File Offset: 0x001B5256
		// (set) Token: 0x0600BECA RID: 48842 RVA: 0x001B707D File Offset: 0x001B527D
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

		// Token: 0x040071CB RID: 29131
		[Nullable(2)]
		protected new SetWayOccupancyState FbInstance;

		// Token: 0x040071CC RID: 29132
		[Nullable(2)]
		protected SetWayOccupancyState_SetValue PocoInterface;
	}
}
