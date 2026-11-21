using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C66 RID: 7270
	public class IFrontAxleTrackingSplineMove : INewSplineMoveType
	{
		// Token: 0x06009A98 RID: 39576 RVA: 0x00165AFC File Offset: 0x00163CFC
		private IFrontAxleTrackingSplineMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFrontAxleTrackingSplineMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFrontAxleTrackingSplineMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFrontAxleTrackingSplineMove_SetValue());
			}
			return result;
		}

		// Token: 0x06009A99 RID: 39577 RVA: 0x00165B34 File Offset: 0x00163D34
		public static IFrontAxleTrackingSplineMove Create([Nullable(2)] IFrontAxleTrackingSplineMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrontAxleTrackingSplineMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x00165B47 File Offset: 0x00163D47
		public static IFrontAxleTrackingSplineMove CreateFromSetValue([Nullable(2)] IFrontAxleTrackingSplineMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFrontAxleTrackingSplineMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x00165B5A File Offset: 0x00163D5A
		public new IFrontAxleTrackingSplineMove_SetValue ToSetValue()
		{
			return new IFrontAxleTrackingSplineMove_SetValue
			{
				Type = this.Type,
				EntityAxisLength = this.EntityAxisLength
			};
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x06009A9C RID: 39580 RVA: 0x00165B79 File Offset: 0x00163D79
		// (set) Token: 0x06009A9D RID: 39581 RVA: 0x00165BA4 File Offset: 0x00163DA4
		public override ENewSplineMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveType.FrontAxleTracking;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x06009A9E RID: 39582 RVA: 0x00165BB2 File Offset: 0x00163DB2
		// (set) Token: 0x06009A9F RID: 39583 RVA: 0x00165BE1 File Offset: 0x00163DE1
		public virtual float EntityAxisLength
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityAxisLength;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.EntityAxisLength;
			}
			set
			{
				this.GetOrCreatePoco().EntityAxisLength = value;
			}
		}

		// Token: 0x04005EE5 RID: 24293
		[Nullable(2)]
		protected new IFrontAxleTrackingSplineMove FbInstance;

		// Token: 0x04005EE6 RID: 24294
		[Nullable(2)]
		protected new IFrontAxleTrackingSplineMove_SetValue PocoInterface;
	}
}
