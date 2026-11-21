using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000834 RID: 2100
	public class ITimeStopTarget
	{
		// Token: 0x06002D2C RID: 11564 RVA: 0x00075AE4 File Offset: 0x00073CE4
		private ITimeStopTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeStopTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeStopTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeStopTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00075B1C File Offset: 0x00073D1C
		public static ITimeStopTarget Create([Nullable(2)] ITimeStopTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeStopTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x00075B2F File Offset: 0x00073D2F
		public static ITimeStopTarget CreateFromSetValue([Nullable(2)] ITimeStopTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeStopTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00075B42 File Offset: 0x00073D42
		public ITimeStopTarget_SetValue ToSetValue()
		{
			return new ITimeStopTarget_SetValue
			{
				EntityIds = this.EntityIds,
				EntityMatch = this.EntityMatch
			};
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002D30 RID: 11568 RVA: 0x00075B61 File Offset: 0x00073D61
		// (set) Token: 0x06002D31 RID: 11569 RVA: 0x00075B88 File Offset: 0x00073D88
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				ITimeStopTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x00075B98 File Offset: 0x00073D98
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x00075BF9 File Offset: 0x00073DF9
		[Nullable(2)]
		public virtual IDynamicEntityMatch EntityMatch
		{
			[NullableContext(2)]
			get
			{
				if (this._EntityMatchInited)
				{
					return this._EntityMatchCache;
				}
				this._EntityMatchInited = true;
				if (this.FbInstance != null)
				{
					this._EntityMatchCache = IDynamicEntityMatch.Create(this.FbInstance.EntityMatch);
				}
				else
				{
					ITimeStopTarget_SetValue pocoInterface = this.PocoInterface;
					this._EntityMatchCache = ((pocoInterface != null) ? pocoInterface.EntityMatch : null);
				}
				return this._EntityMatchCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EntityMatch = value;
				this._EntityMatchInited = false;
			}
		}

		// Token: 0x04001E29 RID: 7721
		[Nullable(2)]
		protected ITimeStopTarget FbInstance;

		// Token: 0x04001E2A RID: 7722
		[Nullable(2)]
		protected ITimeStopTarget_SetValue PocoInterface;

		// Token: 0x04001E2B RID: 7723
		private IDynamicEntityMatch _EntityMatchCache;

		// Token: 0x04001E2C RID: 7724
		private bool _EntityMatchInited;
	}
}
