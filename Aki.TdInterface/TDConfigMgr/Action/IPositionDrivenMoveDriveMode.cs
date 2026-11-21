using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F43 RID: 8003
	public class IPositionDrivenMoveDriveMode : ISplineMoveDriveMode
	{
		// Token: 0x0600AA4B RID: 43595 RVA: 0x00182248 File Offset: 0x00180448
		private IPositionDrivenMoveDriveMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPositionDrivenMoveDriveMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPositionDrivenMoveDriveMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPositionDrivenMoveDriveMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA4C RID: 43596 RVA: 0x00182280 File Offset: 0x00180480
		public static IPositionDrivenMoveDriveMode Create([Nullable(2)] IPositionDrivenMoveDriveMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPositionDrivenMoveDriveMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA4D RID: 43597 RVA: 0x00182293 File Offset: 0x00180493
		public static IPositionDrivenMoveDriveMode CreateFromSetValue([Nullable(2)] IPositionDrivenMoveDriveMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPositionDrivenMoveDriveMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA4E RID: 43598 RVA: 0x001822A6 File Offset: 0x001804A6
		public new IPositionDrivenMoveDriveMode_SetValue ToSetValue()
		{
			return new IPositionDrivenMoveDriveMode_SetValue
			{
				Type = this.Type,
				IsFixedPitch = this.IsFixedPitch
			};
		}

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0600AA4F RID: 43599 RVA: 0x001822C5 File Offset: 0x001804C5
		// (set) Token: 0x0600AA50 RID: 43600 RVA: 0x001822F0 File Offset: 0x001804F0
		public override ESplineMoveDriveMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveDriveMode.InputDriven;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0600AA51 RID: 43601 RVA: 0x00182300 File Offset: 0x00180500
		// (set) Token: 0x0600AA52 RID: 43602 RVA: 0x0018233A File Offset: 0x0018053A
		public virtual bool? IsFixedPitch
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFixedPitch;
				}
				IPositionDrivenMoveDriveMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFixedPitch;
			}
			set
			{
				this.GetOrCreatePoco().IsFixedPitch = value;
			}
		}

		// Token: 0x04006624 RID: 26148
		[Nullable(2)]
		protected new IPositionDrivenMoveDriveMode FbInstance;

		// Token: 0x04006625 RID: 26149
		[Nullable(2)]
		protected new IPositionDrivenMoveDriveMode_SetValue PocoInterface;
	}
}
