using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006A3 RID: 1699
	public class IPointAkEvent : IAkEventTypeConfig
	{
		// Token: 0x060023F0 RID: 9200 RVA: 0x00062450 File Offset: 0x00060650
		private IPointAkEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPointAkEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPointAkEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPointAkEvent_SetValue());
			}
			return result;
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x00062488 File Offset: 0x00060688
		public static IPointAkEvent Create([Nullable(2)] IPointAkEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointAkEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x0006249B File Offset: 0x0006069B
		public static IPointAkEvent CreateFromSetValue([Nullable(2)] IPointAkEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPointAkEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x000624AE File Offset: 0x000606AE
		public new IPointAkEvent_SetValue ToSetValue()
		{
			return new IPointAkEvent_SetValue
			{
				Type = this.Type,
				PointIds = this.PointIds,
				UseListenerCone = this.UseListenerCone,
				EnableOcclusion = this.EnableOcclusion
			};
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x000624E5 File Offset: 0x000606E5
		// (set) Token: 0x060023F5 RID: 9205 RVA: 0x00062510 File Offset: 0x00060710
		public override EAkEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAkEventType.Point;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x0006251E File Offset: 0x0006071E
		// (set) Token: 0x060023F7 RID: 9207 RVA: 0x00062545 File Offset: 0x00060745
		[Nullable(2)]
		public virtual List<int> PointIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PointIds;
				}
				IPointAkEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PointIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PointIds = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x00062554 File Offset: 0x00060754
		// (set) Token: 0x060023F9 RID: 9209 RVA: 0x0006258E File Offset: 0x0006078E
		public virtual bool? UseListenerCone
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseListenerCone;
				}
				IPointAkEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseListenerCone;
			}
			set
			{
				this.GetOrCreatePoco().UseListenerCone = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060023FA RID: 9210 RVA: 0x0006259C File Offset: 0x0006079C
		// (set) Token: 0x060023FB RID: 9211 RVA: 0x000625D6 File Offset: 0x000607D6
		public virtual bool? EnableOcclusion
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableOcclusion;
				}
				IPointAkEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableOcclusion;
			}
			set
			{
				this.GetOrCreatePoco().EnableOcclusion = value;
			}
		}

		// Token: 0x040018FF RID: 6399
		[Nullable(2)]
		protected new IPointAkEvent FbInstance;

		// Token: 0x04001900 RID: 6400
		[Nullable(2)]
		protected new IPointAkEvent_SetValue PocoInterface;
	}
}
