using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200248D RID: 9357
	public class StopSceneItemMove : ActionParams
	{
		// Token: 0x0600CB8E RID: 52110 RVA: 0x001D0524 File Offset: 0x001CE724
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

		// Token: 0x0600CB8F RID: 52111 RVA: 0x001D055C File Offset: 0x001CE75C
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

		// Token: 0x0600CB90 RID: 52112 RVA: 0x001D056F File Offset: 0x001CE76F
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

		// Token: 0x0600CB91 RID: 52113 RVA: 0x001D0582 File Offset: 0x001CE782
		public StopSceneItemMove_SetValue ToSetValue()
		{
			return new StopSceneItemMove_SetValue
			{
				EntityIds = this.EntityIds,
				StopType = this.StopType
			};
		}

		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x0600CB92 RID: 52114 RVA: 0x001D05A1 File Offset: 0x001CE7A1
		// (set) Token: 0x0600CB93 RID: 52115 RVA: 0x001D05C8 File Offset: 0x001CE7C8
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

		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x0600CB94 RID: 52116 RVA: 0x001D05D8 File Offset: 0x001CE7D8
		// (set) Token: 0x0600CB95 RID: 52117 RVA: 0x001D0612 File Offset: 0x001CE812
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

		// Token: 0x040078AC RID: 30892
		[Nullable(2)]
		protected new StopSceneItemMove FbInstance;

		// Token: 0x040078AD RID: 30893
		[Nullable(2)]
		protected StopSceneItemMove_SetValue PocoInterface;
	}
}
