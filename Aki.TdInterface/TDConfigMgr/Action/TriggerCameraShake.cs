using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024C3 RID: 9411
	public class TriggerCameraShake : ActionParams
	{
		// Token: 0x0600CC9A RID: 52378 RVA: 0x001D2300 File Offset: 0x001D0500
		private TriggerCameraShake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TriggerCameraShake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TriggerCameraShake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TriggerCameraShake_SetValue());
			}
			return result;
		}

		// Token: 0x0600CC9B RID: 52379 RVA: 0x001D2338 File Offset: 0x001D0538
		public static TriggerCameraShake Create([Nullable(2)] TriggerCameraShake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerCameraShake
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CC9C RID: 52380 RVA: 0x001D234B File Offset: 0x001D054B
		public static TriggerCameraShake CreateFromSetValue([Nullable(2)] TriggerCameraShake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TriggerCameraShake
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CC9D RID: 52381 RVA: 0x001D235E File Offset: 0x001D055E
		public TriggerCameraShake_SetValue ToSetValue()
		{
			return new TriggerCameraShake_SetValue
			{
				CameraShakeConfig = this.CameraShakeConfig,
				CameraShakeBp = this.CameraShakeBp
			};
		}

		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x0600CC9E RID: 52382 RVA: 0x001D237D File Offset: 0x001D057D
		// (set) Token: 0x0600CC9F RID: 52383 RVA: 0x001D23A4 File Offset: 0x001D05A4
		public virtual ICameraShakeConfig CameraShakeConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraShakeConfig;
				}
				TriggerCameraShake_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CameraShakeConfig;
			}
			set
			{
				this.GetOrCreatePoco().CameraShakeConfig = value;
			}
		}

		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x0600CCA0 RID: 52384 RVA: 0x001D23B2 File Offset: 0x001D05B2
		// (set) Token: 0x0600CCA1 RID: 52385 RVA: 0x001D23DD File Offset: 0x001D05DD
		public virtual string CameraShakeBp
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraShakeBp;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CameraShakeBp;
			}
			set
			{
				this.GetOrCreatePoco().CameraShakeBp = value;
			}
		}

		// Token: 0x04007939 RID: 31033
		[Nullable(2)]
		protected new TriggerCameraShake FbInstance;

		// Token: 0x0400793A RID: 31034
		[Nullable(2)]
		protected TriggerCameraShake_SetValue PocoInterface;
	}
}
