using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C3 RID: 8643
	[NullableContext(1)]
	[Nullable(0)]
	public class SetMotorSpeed : ActionParams
	{
		// Token: 0x0600BDD0 RID: 48592 RVA: 0x001B51C0 File Offset: 0x001B33C0
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

		// Token: 0x0600BDD1 RID: 48593 RVA: 0x001B51F8 File Offset: 0x001B33F8
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

		// Token: 0x0600BDD2 RID: 48594 RVA: 0x001B520B File Offset: 0x001B340B
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

		// Token: 0x0600BDD3 RID: 48595 RVA: 0x001B521E File Offset: 0x001B341E
		public SetMotorSpeed_SetValue ToSetValue()
		{
			return new SetMotorSpeed_SetValue
			{
				MotorConstraint = this.MotorConstraint,
				SpeedConfig = this.SpeedConfig
			};
		}

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x0600BDD4 RID: 48596 RVA: 0x001B5240 File Offset: 0x001B3440
		// (set) Token: 0x0600BDD5 RID: 48597 RVA: 0x001B52A1 File Offset: 0x001B34A1
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

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x0600BDD6 RID: 48598 RVA: 0x001B52B8 File Offset: 0x001B34B8
		// (set) Token: 0x0600BDD7 RID: 48599 RVA: 0x001B5319 File Offset: 0x001B3519
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

		// Token: 0x04007149 RID: 29001
		[Nullable(2)]
		protected new SetMotorSpeed FbInstance;

		// Token: 0x0400714A RID: 29002
		[Nullable(2)]
		protected SetMotorSpeed_SetValue PocoInterface;

		// Token: 0x0400714B RID: 29003
		private IMotorConstraintConfig _MotorConstraintCache;

		// Token: 0x0400714C RID: 29004
		private bool _MotorConstraintInited;

		// Token: 0x0400714D RID: 29005
		private ISetMotorSpeedTargetSpeed _SpeedConfigCache;

		// Token: 0x0400714E RID: 29006
		private bool _SpeedConfigInited;
	}
}
