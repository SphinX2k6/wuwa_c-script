using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000676 RID: 1654
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenderBookPage : IRenderSpecifiedRangeType
	{
		// Token: 0x0600235C RID: 9052 RVA: 0x000609A8 File Offset: 0x0005EBA8
		private IRenderBookPage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRenderBookPage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRenderBookPage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRenderBookPage_SetValue());
			}
			return result;
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x000609E0 File Offset: 0x0005EBE0
		public static IRenderBookPage Create([Nullable(2)] IRenderBookPage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderBookPage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x000609F3 File Offset: 0x0005EBF3
		public static IRenderBookPage CreateFromSetValue([Nullable(2)] IRenderBookPage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRenderBookPage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00060A06 File Offset: 0x0005EC06
		public new IRenderBookPage_SetValue ToSetValue()
		{
			return new IRenderBookPage_SetValue
			{
				Type = this.Type,
				Radius = this.Radius,
				CenterTarget = this.CenterTarget,
				AkEvent = this.AkEvent
			};
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x00060A3D File Offset: 0x0005EC3D
		// (set) Token: 0x06002361 RID: 9057 RVA: 0x00060A68 File Offset: 0x0005EC68
		public override ERenderSpecifiedRangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERenderSpecifiedRangeType.FlowerBridge;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x00060A76 File Offset: 0x0005EC76
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x00060AA1 File Offset: 0x0005ECA1
		public virtual int Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x00060AAF File Offset: 0x0005ECAF
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x00060AD6 File Offset: 0x0005ECD6
		public virtual ITargetEntityType CenterTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CenterTarget;
				}
				IRenderBookPage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CenterTarget;
			}
			set
			{
				this.GetOrCreatePoco().CenterTarget = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x00060AE4 File Offset: 0x0005ECE4
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x00060B0F File Offset: 0x0005ED0F
		public virtual string AkEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AkEvent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AkEvent;
			}
			set
			{
				this.GetOrCreatePoco().AkEvent = value;
			}
		}

		// Token: 0x04001870 RID: 6256
		[Nullable(2)]
		protected new IRenderBookPage FbInstance;

		// Token: 0x04001871 RID: 6257
		[Nullable(2)]
		protected new IRenderBookPage_SetValue PocoInterface;
	}
}
