using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000606 RID: 1542
	[NullableContext(2)]
	[Nullable(0)]
	public class IPointAkEvent : IAkEventTypeConfig
	{
		// Token: 0x060020EA RID: 8426 RVA: 0x0005B73C File Offset: 0x0005993C
		[NullableContext(1)]
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

		// Token: 0x060020EB RID: 8427 RVA: 0x0005B774 File Offset: 0x00059974
		[NullableContext(1)]
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

		// Token: 0x060020EC RID: 8428 RVA: 0x0005B787 File Offset: 0x00059987
		[NullableContext(1)]
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

		// Token: 0x060020ED RID: 8429 RVA: 0x0005B79A File Offset: 0x0005999A
		[NullableContext(1)]
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

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x0005B7D1 File Offset: 0x000599D1
		// (set) Token: 0x060020EF RID: 8431 RVA: 0x0005B7FC File Offset: 0x000599FC
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

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x0005B80A File Offset: 0x00059A0A
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x0005B831 File Offset: 0x00059A31
		public virtual List<int> PointIds
		{
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
			set
			{
				this.GetOrCreatePoco().PointIds = value;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x0005B840 File Offset: 0x00059A40
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x0005B87A File Offset: 0x00059A7A
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

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x0005B888 File Offset: 0x00059A88
		// (set) Token: 0x060020F5 RID: 8437 RVA: 0x0005B8C2 File Offset: 0x00059AC2
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

		// Token: 0x0400170D RID: 5901
		protected new IPointAkEvent FbInstance;

		// Token: 0x0400170E RID: 5902
		protected new IPointAkEvent_SetValue PocoInterface;
	}
}
