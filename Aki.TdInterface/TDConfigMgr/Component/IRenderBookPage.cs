using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000715 RID: 1813
	public class IRenderBookPage : IRenderSpecifiedRangeType
	{
		// Token: 0x0600266E RID: 9838 RVA: 0x0006786C File Offset: 0x00065A6C
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

		// Token: 0x0600266F RID: 9839 RVA: 0x000678A4 File Offset: 0x00065AA4
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

		// Token: 0x06002670 RID: 9840 RVA: 0x000678B7 File Offset: 0x00065AB7
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

		// Token: 0x06002671 RID: 9841 RVA: 0x000678CA File Offset: 0x00065ACA
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

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x00067901 File Offset: 0x00065B01
		// (set) Token: 0x06002673 RID: 9843 RVA: 0x0006792C File Offset: 0x00065B2C
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

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x0006793A File Offset: 0x00065B3A
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x00067965 File Offset: 0x00065B65
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

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x00067973 File Offset: 0x00065B73
		// (set) Token: 0x06002677 RID: 9847 RVA: 0x0006799A File Offset: 0x00065B9A
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

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x000679A8 File Offset: 0x00065BA8
		// (set) Token: 0x06002679 RID: 9849 RVA: 0x000679D3 File Offset: 0x00065BD3
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

		// Token: 0x04001A69 RID: 6761
		[Nullable(2)]
		protected new IRenderBookPage FbInstance;

		// Token: 0x04001A6A RID: 6762
		[Nullable(2)]
		protected new IRenderBookPage_SetValue PocoInterface;
	}
}
