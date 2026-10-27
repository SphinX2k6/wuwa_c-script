using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200067A RID: 1658
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenderFlowerBridge : IRenderSpecifiedRangeType
	{
		// Token: 0x06002374 RID: 9076 RVA: 0x00060C30 File Offset: 0x0005EE30
		private IRenderFlowerBridge_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRenderFlowerBridge 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRenderFlowerBridge_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRenderFlowerBridge_SetValue());
			}
			return result;
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00060C68 File Offset: 0x0005EE68
		public static IRenderFlowerBridge Create([Nullable(2)] IRenderFlowerBridge instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderFlowerBridge
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00060C7B File Offset: 0x0005EE7B
		public static IRenderFlowerBridge CreateFromSetValue([Nullable(2)] IRenderFlowerBridge_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRenderFlowerBridge
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00060C8E File Offset: 0x0005EE8E
		public new IRenderFlowerBridge_SetValue ToSetValue()
		{
			return new IRenderFlowerBridge_SetValue
			{
				Type = this.Type,
				Radius = this.Radius,
				CenterTarget = this.CenterTarget,
				AkEvent = this.AkEvent
			};
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x00060CC5 File Offset: 0x0005EEC5
		// (set) Token: 0x06002379 RID: 9081 RVA: 0x00060CF0 File Offset: 0x0005EEF0
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

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x00060CFE File Offset: 0x0005EEFE
		// (set) Token: 0x0600237B RID: 9083 RVA: 0x00060D29 File Offset: 0x0005EF29
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

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x00060D37 File Offset: 0x0005EF37
		// (set) Token: 0x0600237D RID: 9085 RVA: 0x00060D5E File Offset: 0x0005EF5E
		public virtual ITargetEntityType CenterTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CenterTarget;
				}
				IRenderFlowerBridge_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x00060D6C File Offset: 0x0005EF6C
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x00060D97 File Offset: 0x0005EF97
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

		// Token: 0x0400187A RID: 6266
		[Nullable(2)]
		protected new IRenderFlowerBridge FbInstance;

		// Token: 0x0400187B RID: 6267
		[Nullable(2)]
		protected new IRenderFlowerBridge_SetValue PocoInterface;
	}
}
