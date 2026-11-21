using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000719 RID: 1817
	public class IRenderFlowerBridge : IRenderSpecifiedRangeType
	{
		// Token: 0x06002686 RID: 9862 RVA: 0x00067AF4 File Offset: 0x00065CF4
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

		// Token: 0x06002687 RID: 9863 RVA: 0x00067B2C File Offset: 0x00065D2C
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

		// Token: 0x06002688 RID: 9864 RVA: 0x00067B3F File Offset: 0x00065D3F
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

		// Token: 0x06002689 RID: 9865 RVA: 0x00067B52 File Offset: 0x00065D52
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

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x00067B89 File Offset: 0x00065D89
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x00067BB4 File Offset: 0x00065DB4
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

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x00067BC2 File Offset: 0x00065DC2
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x00067BED File Offset: 0x00065DED
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

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x00067BFB File Offset: 0x00065DFB
		// (set) Token: 0x0600268F RID: 9871 RVA: 0x00067C22 File Offset: 0x00065E22
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

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x00067C30 File Offset: 0x00065E30
		// (set) Token: 0x06002691 RID: 9873 RVA: 0x00067C5B File Offset: 0x00065E5B
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

		// Token: 0x04001A73 RID: 6771
		[Nullable(2)]
		protected new IRenderFlowerBridge FbInstance;

		// Token: 0x04001A74 RID: 6772
		[Nullable(2)]
		protected new IRenderFlowerBridge_SetValue PocoInterface;
	}
}
