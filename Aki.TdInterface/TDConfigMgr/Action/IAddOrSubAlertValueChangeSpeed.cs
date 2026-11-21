using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200192D RID: 6445
	public class IAddOrSubAlertValueChangeSpeed : IAlertValueSpeedChangeType
	{
		// Token: 0x0600872D RID: 34605 RVA: 0x00141374 File Offset: 0x0013F574
		private IAddOrSubAlertValueChangeSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAddOrSubAlertValueChangeSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAddOrSubAlertValueChangeSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAddOrSubAlertValueChangeSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x001413AC File Offset: 0x0013F5AC
		public static IAddOrSubAlertValueChangeSpeed Create([Nullable(2)] IAddOrSubAlertValueChangeSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddOrSubAlertValueChangeSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x001413BF File Offset: 0x0013F5BF
		public static IAddOrSubAlertValueChangeSpeed CreateFromSetValue([Nullable(2)] IAddOrSubAlertValueChangeSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAddOrSubAlertValueChangeSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x001413D2 File Offset: 0x0013F5D2
		public new IAddOrSubAlertValueChangeSpeed_SetValue ToSetValue()
		{
			return new IAddOrSubAlertValueChangeSpeed_SetValue
			{
				Type = this.Type,
				DeltaValue = this.DeltaValue
			};
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x06008731 RID: 34609 RVA: 0x001413F1 File Offset: 0x0013F5F1
		// (set) Token: 0x06008732 RID: 34610 RVA: 0x0014141C File Offset: 0x0013F61C
		public override EValueChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EValueChangeType.AddOrSub;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x06008733 RID: 34611 RVA: 0x0014142A File Offset: 0x0013F62A
		// (set) Token: 0x06008734 RID: 34612 RVA: 0x00141459 File Offset: 0x0013F659
		public virtual float DeltaValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DeltaValue;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DeltaValue;
			}
			set
			{
				this.GetOrCreatePoco().DeltaValue = value;
			}
		}

		// Token: 0x04005596 RID: 21910
		[Nullable(2)]
		protected new IAddOrSubAlertValueChangeSpeed FbInstance;

		// Token: 0x04005597 RID: 21911
		[Nullable(2)]
		protected new IAddOrSubAlertValueChangeSpeed_SetValue PocoInterface;
	}
}
