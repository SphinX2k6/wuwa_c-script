using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002256 RID: 8790
	[NullableContext(1)]
	[Nullable(0)]
	public class TriggerCameraShake : ActionParams
	{
		// Token: 0x0600C0D4 RID: 49364 RVA: 0x001BAB7C File Offset: 0x001B8D7C
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

		// Token: 0x0600C0D5 RID: 49365 RVA: 0x001BABB4 File Offset: 0x001B8DB4
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

		// Token: 0x0600C0D6 RID: 49366 RVA: 0x001BABC7 File Offset: 0x001B8DC7
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

		// Token: 0x0600C0D7 RID: 49367 RVA: 0x001BABDA File Offset: 0x001B8DDA
		public TriggerCameraShake_SetValue ToSetValue()
		{
			return new TriggerCameraShake_SetValue
			{
				CameraShakeConfig = this.CameraShakeConfig,
				CameraShakeBp = this.CameraShakeBp
			};
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x0600C0D8 RID: 49368 RVA: 0x001BABF9 File Offset: 0x001B8DF9
		// (set) Token: 0x0600C0D9 RID: 49369 RVA: 0x001BAC20 File Offset: 0x001B8E20
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

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x0600C0DA RID: 49370 RVA: 0x001BAC2E File Offset: 0x001B8E2E
		// (set) Token: 0x0600C0DB RID: 49371 RVA: 0x001BAC59 File Offset: 0x001B8E59
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

		// Token: 0x040072EC RID: 29420
		[Nullable(2)]
		protected new TriggerCameraShake FbInstance;

		// Token: 0x040072ED RID: 29421
		[Nullable(2)]
		protected TriggerCameraShake_SetValue PocoInterface;
	}
}
