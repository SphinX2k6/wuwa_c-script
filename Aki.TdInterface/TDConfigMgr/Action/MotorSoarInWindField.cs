using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020DB RID: 8411
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorSoarInWindField : ActionParams
	{
		// Token: 0x0600B8CC RID: 47308 RVA: 0x001AB614 File Offset: 0x001A9814
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

		// Token: 0x0600B8CD RID: 47309 RVA: 0x001AB64C File Offset: 0x001A984C
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

		// Token: 0x0600B8CE RID: 47310 RVA: 0x001AB65F File Offset: 0x001A985F
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

		// Token: 0x0600B8CF RID: 47311 RVA: 0x001AB672 File Offset: 0x001A9872
		public MotorSoarInWindField_SetValue ToSetValue()
		{
			return new MotorSoarInWindField_SetValue
			{
				ControlType = this.ControlType
			};
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x0600B8D0 RID: 47312 RVA: 0x001AB685 File Offset: 0x001A9885
		// (set) Token: 0x0600B8D1 RID: 47313 RVA: 0x001AB6AC File Offset: 0x001A98AC
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

		// Token: 0x04006EB3 RID: 28339
		[Nullable(2)]
		protected new MotorSoarInWindField FbInstance;

		// Token: 0x04006EB4 RID: 28340
		[Nullable(2)]
		protected MotorSoarInWindField_SetValue PocoInterface;
	}
}
