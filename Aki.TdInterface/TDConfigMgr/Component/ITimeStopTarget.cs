using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000793 RID: 1939
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeStopTarget
	{
		// Token: 0x06002A04 RID: 10756 RVA: 0x0006E83C File Offset: 0x0006CA3C
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

		// Token: 0x06002A05 RID: 10757 RVA: 0x0006E874 File Offset: 0x0006CA74
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

		// Token: 0x06002A06 RID: 10758 RVA: 0x0006E887 File Offset: 0x0006CA87
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

		// Token: 0x06002A07 RID: 10759 RVA: 0x0006E89A File Offset: 0x0006CA9A
		public ITimeStopTarget_SetValue ToSetValue()
		{
			return new ITimeStopTarget_SetValue
			{
				EntityIds = this.EntityIds,
				EntityMatch = this.EntityMatch
			};
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x0006E8B9 File Offset: 0x0006CAB9
		// (set) Token: 0x06002A09 RID: 10761 RVA: 0x0006E8E0 File Offset: 0x0006CAE0
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

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x0006E8F0 File Offset: 0x0006CAF0
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x0006E951 File Offset: 0x0006CB51
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

		// Token: 0x04001C20 RID: 7200
		[Nullable(2)]
		protected ITimeStopTarget FbInstance;

		// Token: 0x04001C21 RID: 7201
		[Nullable(2)]
		protected ITimeStopTarget_SetValue PocoInterface;

		// Token: 0x04001C22 RID: 7202
		private IDynamicEntityMatch _EntityMatchCache;

		// Token: 0x04001C23 RID: 7203
		private bool _EntityMatchInited;
	}
}
