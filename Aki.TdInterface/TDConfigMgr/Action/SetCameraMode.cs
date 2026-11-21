using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002412 RID: 9234
	public class SetCameraMode : ActionParams
	{
		// Token: 0x0600C8E6 RID: 51430 RVA: 0x001CB1D4 File Offset: 0x001C93D4
		private SetCameraMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetCameraMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetCameraMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetCameraMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600C8E7 RID: 51431 RVA: 0x001CB20C File Offset: 0x001C940C
		public static SetCameraMode Create([Nullable(2)] SetCameraMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetCameraMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C8E8 RID: 51432 RVA: 0x001CB21F File Offset: 0x001C941F
		public static SetCameraMode CreateFromSetValue([Nullable(2)] SetCameraMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetCameraMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C8E9 RID: 51433 RVA: 0x001CB232 File Offset: 0x001C9432
		public SetCameraMode_SetValue ToSetValue()
		{
			return new SetCameraMode_SetValue
			{
				Mode = this.Mode
			};
		}

		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x0600C8EA RID: 51434 RVA: 0x001CB245 File Offset: 0x001C9445
		// (set) Token: 0x0600C8EB RID: 51435 RVA: 0x001CB270 File Offset: 0x001C9470
		public virtual string Mode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mode;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mode;
			}
			set
			{
				this.GetOrCreatePoco().Mode = value;
			}
		}

		// Token: 0x0400772B RID: 30507
		[Nullable(2)]
		protected new SetCameraMode FbInstance;

		// Token: 0x0400772C RID: 30508
		[Nullable(2)]
		protected SetCameraMode_SetValue PocoInterface;
	}
}
