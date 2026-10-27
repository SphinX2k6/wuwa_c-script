using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001168 RID: 4456
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2CameraFovCondition
	{
		// Token: 0x0600651E RID: 25886 RVA: 0x000F2AC0 File Offset: 0x000F0CC0
		private ITakePhoto2CameraFovCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2CameraFovCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2CameraFovCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2CameraFovCondition_SetValue());
			}
			return result;
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x000F2AF8 File Offset: 0x000F0CF8
		public static ITakePhoto2CameraFovCondition Create([Nullable(2)] ITakePhoto2CameraFovCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2CameraFovCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x000F2B0B File Offset: 0x000F0D0B
		public static ITakePhoto2CameraFovCondition CreateFromSetValue([Nullable(2)] ITakePhoto2CameraFovCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2CameraFovCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x000F2B1E File Offset: 0x000F0D1E
		public ITakePhoto2CameraFovCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2CameraFovCondition_SetValue
			{
				MinFov = this.MinFov,
				MaxFov = this.MaxFov
			};
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x06006522 RID: 25890 RVA: 0x000F2B3D File Offset: 0x000F0D3D
		// (set) Token: 0x06006523 RID: 25891 RVA: 0x000F2B68 File Offset: 0x000F0D68
		public virtual int MinFov
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinFov;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MinFov;
			}
			set
			{
				this.GetOrCreatePoco().MinFov = value;
			}
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x06006524 RID: 25892 RVA: 0x000F2B76 File Offset: 0x000F0D76
		// (set) Token: 0x06006525 RID: 25893 RVA: 0x000F2BA1 File Offset: 0x000F0DA1
		public virtual int MaxFov
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxFov;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxFov;
			}
			set
			{
				this.GetOrCreatePoco().MaxFov = value;
			}
		}

		// Token: 0x04003CA7 RID: 15527
		[Nullable(2)]
		protected ITakePhoto2CameraFovCondition FbInstance;

		// Token: 0x04003CA8 RID: 15528
		[Nullable(2)]
		protected ITakePhoto2CameraFovCondition_SetValue PocoInterface;
	}
}
