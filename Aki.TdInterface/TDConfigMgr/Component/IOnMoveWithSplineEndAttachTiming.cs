using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000619 RID: 1561
	public class IOnMoveWithSplineEndAttachTiming : IAttachTiming
	{
		// Token: 0x060020C2 RID: 8386 RVA: 0x0005BBC8 File Offset: 0x00059DC8
		private IOnMoveWithSplineEndAttachTiming_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnMoveWithSplineEndAttachTiming 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnMoveWithSplineEndAttachTiming_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnMoveWithSplineEndAttachTiming_SetValue());
			}
			return result;
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x0005BC00 File Offset: 0x00059E00
		public static IOnMoveWithSplineEndAttachTiming Create([Nullable(2)] IOnMoveWithSplineEndAttachTiming instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnMoveWithSplineEndAttachTiming
			{
				FbInstance = instance
			};
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x0005BC13 File Offset: 0x00059E13
		public static IOnMoveWithSplineEndAttachTiming CreateFromSetValue([Nullable(2)] IOnMoveWithSplineEndAttachTiming_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnMoveWithSplineEndAttachTiming
			{
				PocoInterface = value
			};
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x0005BC26 File Offset: 0x00059E26
		public new IOnMoveWithSplineEndAttachTiming_SetValue ToSetValue()
		{
			return new IOnMoveWithSplineEndAttachTiming_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x0005BC45 File Offset: 0x00059E45
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x0005BC70 File Offset: 0x00059E70
		public override EAttachTimingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttachTimingType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x0005BC7E File Offset: 0x00059E7E
		// (set) Token: 0x060020C9 RID: 8393 RVA: 0x0005BCA9 File Offset: 0x00059EA9
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x04001749 RID: 5961
		[Nullable(2)]
		protected new IOnMoveWithSplineEndAttachTiming FbInstance;

		// Token: 0x0400174A RID: 5962
		[Nullable(2)]
		protected new IOnMoveWithSplineEndAttachTiming_SetValue PocoInterface;
	}
}
