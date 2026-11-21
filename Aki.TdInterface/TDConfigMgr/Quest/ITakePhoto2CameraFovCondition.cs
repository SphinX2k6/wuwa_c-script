using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200129A RID: 4762
	public class ITakePhoto2CameraFovCondition
	{
		// Token: 0x06006B2F RID: 27439 RVA: 0x000FFE80 File Offset: 0x000FE080
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

		// Token: 0x06006B30 RID: 27440 RVA: 0x000FFEB8 File Offset: 0x000FE0B8
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

		// Token: 0x06006B31 RID: 27441 RVA: 0x000FFECB File Offset: 0x000FE0CB
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

		// Token: 0x06006B32 RID: 27442 RVA: 0x000FFEDE File Offset: 0x000FE0DE
		public ITakePhoto2CameraFovCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2CameraFovCondition_SetValue
			{
				MinFov = this.MinFov,
				MaxFov = this.MaxFov
			};
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x06006B33 RID: 27443 RVA: 0x000FFEFD File Offset: 0x000FE0FD
		// (set) Token: 0x06006B34 RID: 27444 RVA: 0x000FFF28 File Offset: 0x000FE128
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

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x06006B35 RID: 27445 RVA: 0x000FFF36 File Offset: 0x000FE136
		// (set) Token: 0x06006B36 RID: 27446 RVA: 0x000FFF61 File Offset: 0x000FE161
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

		// Token: 0x04003FFE RID: 16382
		[Nullable(2)]
		protected ITakePhoto2CameraFovCondition FbInstance;

		// Token: 0x04003FFF RID: 16383
		[Nullable(2)]
		protected ITakePhoto2CameraFovCondition_SetValue PocoInterface;
	}
}
