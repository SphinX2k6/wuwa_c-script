using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200233C RID: 9020
	public class MotorSoarInWindField : ActionParams
	{
		// Token: 0x0600C456 RID: 50262 RVA: 0x001C26F0 File Offset: 0x001C08F0
		private MotorSoarInWindField_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("MotorSoarInWindField 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			MotorSoarInWindField_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new MotorSoarInWindField_SetValue());
			}
			return result;
		}

		// Token: 0x0600C457 RID: 50263 RVA: 0x001C2728 File Offset: 0x001C0928
		public static MotorSoarInWindField Create([Nullable(2)] MotorSoarInWindField instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MotorSoarInWindField
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C458 RID: 50264 RVA: 0x001C273B File Offset: 0x001C093B
		public static MotorSoarInWindField CreateFromSetValue([Nullable(2)] MotorSoarInWindField_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new MotorSoarInWindField
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C459 RID: 50265 RVA: 0x001C274E File Offset: 0x001C094E
		public MotorSoarInWindField_SetValue ToSetValue()
		{
			return new MotorSoarInWindField_SetValue
			{
				ControlType = this.ControlType
			};
		}

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x0600C45A RID: 50266 RVA: 0x001C2761 File Offset: 0x001C0961
		// (set) Token: 0x0600C45B RID: 50267 RVA: 0x001C2788 File Offset: 0x001C0988
		public virtual IMotorSoarInWindFieldControlType ControlType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ControlType;
				}
				MotorSoarInWindField_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ControlType;
			}
			set
			{
				this.GetOrCreatePoco().ControlType = value;
			}
		}

		// Token: 0x040074E4 RID: 29924
		[Nullable(2)]
		protected new MotorSoarInWindField FbInstance;

		// Token: 0x040074E5 RID: 29925
		[Nullable(2)]
		protected MotorSoarInWindField_SetValue PocoInterface;
	}
}
