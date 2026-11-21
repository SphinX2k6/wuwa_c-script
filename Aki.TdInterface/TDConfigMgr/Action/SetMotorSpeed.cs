using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200242E RID: 9262
	public class SetMotorSpeed : ActionParams
	{
		// Token: 0x0600C98A RID: 51594 RVA: 0x001CC7F8 File Offset: 0x001CA9F8
		private SetMotorSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetMotorSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetMotorSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetMotorSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x0600C98B RID: 51595 RVA: 0x001CC830 File Offset: 0x001CAA30
		public static SetMotorSpeed Create([Nullable(2)] SetMotorSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetMotorSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C98C RID: 51596 RVA: 0x001CC843 File Offset: 0x001CAA43
		public static SetMotorSpeed CreateFromSetValue([Nullable(2)] SetMotorSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetMotorSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C98D RID: 51597 RVA: 0x001CC856 File Offset: 0x001CAA56
		public SetMotorSpeed_SetValue ToSetValue()
		{
			return new SetMotorSpeed_SetValue
			{
				MotorConstraint = this.MotorConstraint,
				SpeedConfig = this.SpeedConfig
			};
		}

		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x0600C98E RID: 51598 RVA: 0x001CC878 File Offset: 0x001CAA78
		// (set) Token: 0x0600C98F RID: 51599 RVA: 0x001CC8D9 File Offset: 0x001CAAD9
		[Nullable(2)]
		public virtual IMotorConstraintConfig MotorConstraint
		{
			[NullableContext(2)]
			get
			{
				if (this._MotorConstraintInited)
				{
					return this._MotorConstraintCache;
				}
				this._MotorConstraintInited = true;
				if (this.FbInstance != null)
				{
					this._MotorConstraintCache = IMotorConstraintConfig.Create(this.FbInstance.MotorConstraint);
				}
				else
				{
					SetMotorSpeed_SetValue pocoInterface = this.PocoInterface;
					this._MotorConstraintCache = ((pocoInterface != null) ? pocoInterface.MotorConstraint : null);
				}
				return this._MotorConstraintCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MotorConstraint = value;
				this._MotorConstraintInited = false;
			}
		}

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x0600C990 RID: 51600 RVA: 0x001CC8F0 File Offset: 0x001CAAF0
		// (set) Token: 0x0600C991 RID: 51601 RVA: 0x001CC951 File Offset: 0x001CAB51
		public virtual ISetMotorSpeedTargetSpeed SpeedConfig
		{
			get
			{
				if (this._SpeedConfigInited)
				{
					return this._SpeedConfigCache;
				}
				this._SpeedConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SpeedConfigCache = ISetMotorSpeedTargetSpeed.Create(this.FbInstance.SpeedConfig);
				}
				else
				{
					SetMotorSpeed_SetValue pocoInterface = this.PocoInterface;
					this._SpeedConfigCache = ((pocoInterface != null) ? pocoInterface.SpeedConfig : null);
				}
				return this._SpeedConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().SpeedConfig = value;
				this._SpeedConfigInited = false;
			}
		}

		// Token: 0x04007791 RID: 30609
		[Nullable(2)]
		protected new SetMotorSpeed FbInstance;

		// Token: 0x04007792 RID: 30610
		[Nullable(2)]
		protected SetMotorSpeed_SetValue PocoInterface;

		// Token: 0x04007793 RID: 30611
		private IMotorConstraintConfig _MotorConstraintCache;

		// Token: 0x04007794 RID: 30612
		private bool _MotorConstraintInited;

		// Token: 0x04007795 RID: 30613
		private ISetMotorSpeedTargetSpeed _SpeedConfigCache;

		// Token: 0x04007796 RID: 30614
		private bool _SpeedConfigInited;
	}
}
