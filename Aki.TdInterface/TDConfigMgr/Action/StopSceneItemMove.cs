using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002222 RID: 8738
	[NullableContext(1)]
	[Nullable(0)]
	public class StopSceneItemMove : ActionParams
	{
		// Token: 0x0600BFD0 RID: 49104 RVA: 0x001B8E58 File Offset: 0x001B7058
		private StopSceneItemMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("StopSceneItemMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			StopSceneItemMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new StopSceneItemMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600BFD1 RID: 49105 RVA: 0x001B8E90 File Offset: 0x001B7090
		public static StopSceneItemMove Create([Nullable(2)] StopSceneItemMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopSceneItemMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BFD2 RID: 49106 RVA: 0x001B8EA3 File Offset: 0x001B70A3
		public static StopSceneItemMove CreateFromSetValue([Nullable(2)] StopSceneItemMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new StopSceneItemMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BFD3 RID: 49107 RVA: 0x001B8EB6 File Offset: 0x001B70B6
		public StopSceneItemMove_SetValue ToSetValue()
		{
			return new StopSceneItemMove_SetValue
			{
				EntityIds = this.EntityIds,
				StopType = this.StopType
			};
		}

		// Token: 0x17003A1A RID: 14874
		// (get) Token: 0x0600BFD4 RID: 49108 RVA: 0x001B8ED5 File Offset: 0x001B70D5
		// (set) Token: 0x0600BFD5 RID: 49109 RVA: 0x001B8EFC File Offset: 0x001B70FC
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				StopSceneItemMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x0600BFD6 RID: 49110 RVA: 0x001B8F0C File Offset: 0x001B710C
		// (set) Token: 0x0600BFD7 RID: 49111 RVA: 0x001B8F46 File Offset: 0x001B7146
		public virtual EStopSceneItemMoveType? StopType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StopType;
				}
				StopSceneItemMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StopType;
			}
			set
			{
				this.GetOrCreatePoco().StopType = value;
			}
		}

		// Token: 0x04007262 RID: 29282
		[Nullable(2)]
		protected new StopSceneItemMove FbInstance;

		// Token: 0x04007263 RID: 29283
		[Nullable(2)]
		protected StopSceneItemMove_SetValue PocoInterface;
	}
}
