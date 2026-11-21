using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200161B RID: 5659
	public class CaptureElementalBox : ActionParams
	{
		// Token: 0x06007FD7 RID: 32727 RVA: 0x00130C3C File Offset: 0x0012EE3C
		private CaptureElementalBox_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CaptureElementalBox 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CaptureElementalBox_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CaptureElementalBox_SetValue());
			}
			return result;
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x00130C74 File Offset: 0x0012EE74
		public static CaptureElementalBox Create([Nullable(2)] CaptureElementalBox instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CaptureElementalBox
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007FD9 RID: 32729 RVA: 0x00130C87 File Offset: 0x0012EE87
		public static CaptureElementalBox CreateFromSetValue([Nullable(2)] CaptureElementalBox_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CaptureElementalBox
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007FDA RID: 32730 RVA: 0x00130C9A File Offset: 0x0012EE9A
		public CaptureElementalBox_SetValue ToSetValue()
		{
			return new CaptureElementalBox_SetValue
			{
				CtrlConfig = this.CtrlConfig,
				TargetPosConfig = this.TargetPosConfig,
				MoveSpeed = this.MoveSpeed
			};
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x06007FDB RID: 32731 RVA: 0x00130CC5 File Offset: 0x0012EEC5
		// (set) Token: 0x06007FDC RID: 32732 RVA: 0x00130CEC File Offset: 0x0012EEEC
		public virtual IControlElementalBoxTypeBase CtrlConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CtrlConfig;
				}
				CaptureElementalBox_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CtrlConfig;
			}
			set
			{
				this.GetOrCreatePoco().CtrlConfig = value;
			}
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x06007FDD RID: 32733 RVA: 0x00130CFA File Offset: 0x0012EEFA
		// (set) Token: 0x06007FDE RID: 32734 RVA: 0x00130D21 File Offset: 0x0012EF21
		public virtual IElementalBoxTargetPosTypeBase TargetPosConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetPosConfig;
				}
				CaptureElementalBox_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetPosConfig;
			}
			set
			{
				this.GetOrCreatePoco().TargetPosConfig = value;
			}
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x06007FDF RID: 32735 RVA: 0x00130D2F File Offset: 0x0012EF2F
		// (set) Token: 0x06007FE0 RID: 32736 RVA: 0x00130D5E File Offset: 0x0012EF5E
		public virtual float MoveSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MoveSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MoveSpeed = value;
			}
		}

		// Token: 0x040049E8 RID: 18920
		[Nullable(2)]
		protected new CaptureElementalBox FbInstance;

		// Token: 0x040049E9 RID: 18921
		[Nullable(2)]
		protected CaptureElementalBox_SetValue PocoInterface;
	}
}
