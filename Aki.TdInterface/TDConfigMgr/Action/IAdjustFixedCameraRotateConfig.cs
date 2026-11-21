using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200193D RID: 6461
	public class IAdjustFixedCameraRotateConfig
	{
		// Token: 0x06008879 RID: 34937 RVA: 0x001449D4 File Offset: 0x00142BD4
		private IAdjustFixedCameraRotateConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAdjustFixedCameraRotateConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAdjustFixedCameraRotateConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAdjustFixedCameraRotateConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600887A RID: 34938 RVA: 0x00144A0C File Offset: 0x00142C0C
		public static IAdjustFixedCameraRotateConfig Create([Nullable(2)] IAdjustFixedCameraRotateConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAdjustFixedCameraRotateConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x00144A1F File Offset: 0x00142C1F
		public static IAdjustFixedCameraRotateConfig CreateFromSetValue([Nullable(2)] IAdjustFixedCameraRotateConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAdjustFixedCameraRotateConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600887C RID: 34940 RVA: 0x00144A34 File Offset: 0x00142C34
		public IAdjustFixedCameraRotateConfig_SetValue ToSetValue()
		{
			return new IAdjustFixedCameraRotateConfig_SetValue
			{
				YawLimitMin = this.YawLimitMin,
				YawLimitMax = this.YawLimitMax,
				PitchLimitMin = this.PitchLimitMin,
				PitchLimitMax = this.PitchLimitMax,
				YawRotateSpeed = this.YawRotateSpeed,
				PitchRotateSpeed = this.PitchRotateSpeed
			};
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x0600887D RID: 34941 RVA: 0x00144A8E File Offset: 0x00142C8E
		// (set) Token: 0x0600887E RID: 34942 RVA: 0x00144ABD File Offset: 0x00142CBD
		public virtual float YawLimitMin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.YawLimitMin;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.YawLimitMin;
			}
			set
			{
				this.GetOrCreatePoco().YawLimitMin = value;
			}
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x0600887F RID: 34943 RVA: 0x00144ACB File Offset: 0x00142CCB
		// (set) Token: 0x06008880 RID: 34944 RVA: 0x00144AFA File Offset: 0x00142CFA
		public virtual float YawLimitMax
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.YawLimitMax;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.YawLimitMax;
			}
			set
			{
				this.GetOrCreatePoco().YawLimitMax = value;
			}
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x06008881 RID: 34945 RVA: 0x00144B08 File Offset: 0x00142D08
		// (set) Token: 0x06008882 RID: 34946 RVA: 0x00144B37 File Offset: 0x00142D37
		public virtual float PitchLimitMin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PitchLimitMin;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.PitchLimitMin;
			}
			set
			{
				this.GetOrCreatePoco().PitchLimitMin = value;
			}
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x06008883 RID: 34947 RVA: 0x00144B45 File Offset: 0x00142D45
		// (set) Token: 0x06008884 RID: 34948 RVA: 0x00144B74 File Offset: 0x00142D74
		public virtual float PitchLimitMax
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PitchLimitMax;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.PitchLimitMax;
			}
			set
			{
				this.GetOrCreatePoco().PitchLimitMax = value;
			}
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x06008885 RID: 34949 RVA: 0x00144B82 File Offset: 0x00142D82
		// (set) Token: 0x06008886 RID: 34950 RVA: 0x00144BB1 File Offset: 0x00142DB1
		public virtual float YawRotateSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.YawRotateSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.YawRotateSpeed;
			}
			set
			{
				this.GetOrCreatePoco().YawRotateSpeed = value;
			}
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x06008887 RID: 34951 RVA: 0x00144BBF File Offset: 0x00142DBF
		// (set) Token: 0x06008888 RID: 34952 RVA: 0x00144BEE File Offset: 0x00142DEE
		public virtual float PitchRotateSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PitchRotateSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.PitchRotateSpeed;
			}
			set
			{
				this.GetOrCreatePoco().PitchRotateSpeed = value;
			}
		}

		// Token: 0x0400567C RID: 22140
		[Nullable(2)]
		protected IAdjustFixedCameraRotateConfig FbInstance;

		// Token: 0x0400567D RID: 22141
		[Nullable(2)]
		protected IAdjustFixedCameraRotateConfig_SetValue PocoInterface;
	}
}
