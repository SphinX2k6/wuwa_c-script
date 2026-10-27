using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017BA RID: 6074
	[NullableContext(1)]
	[Nullable(0)]
	public class IAdjustFixedCameraRotateConfig
	{
		// Token: 0x0600817F RID: 33151 RVA: 0x00135674 File Offset: 0x00133874
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

		// Token: 0x06008180 RID: 33152 RVA: 0x001356AC File Offset: 0x001338AC
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

		// Token: 0x06008181 RID: 33153 RVA: 0x001356BF File Offset: 0x001338BF
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

		// Token: 0x06008182 RID: 33154 RVA: 0x001356D4 File Offset: 0x001338D4
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

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x06008183 RID: 33155 RVA: 0x0013572E File Offset: 0x0013392E
		// (set) Token: 0x06008184 RID: 33156 RVA: 0x0013575D File Offset: 0x0013395D
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

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x06008185 RID: 33157 RVA: 0x0013576B File Offset: 0x0013396B
		// (set) Token: 0x06008186 RID: 33158 RVA: 0x0013579A File Offset: 0x0013399A
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

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x06008187 RID: 33159 RVA: 0x001357A8 File Offset: 0x001339A8
		// (set) Token: 0x06008188 RID: 33160 RVA: 0x001357D7 File Offset: 0x001339D7
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

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x06008189 RID: 33161 RVA: 0x001357E5 File Offset: 0x001339E5
		// (set) Token: 0x0600818A RID: 33162 RVA: 0x00135814 File Offset: 0x00133A14
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

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x0600818B RID: 33163 RVA: 0x00135822 File Offset: 0x00133A22
		// (set) Token: 0x0600818C RID: 33164 RVA: 0x00135851 File Offset: 0x00133A51
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

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x0600818D RID: 33165 RVA: 0x0013585F File Offset: 0x00133A5F
		// (set) Token: 0x0600818E RID: 33166 RVA: 0x0013588E File Offset: 0x00133A8E
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

		// Token: 0x04005242 RID: 21058
		[Nullable(2)]
		protected IAdjustFixedCameraRotateConfig FbInstance;

		// Token: 0x04005243 RID: 21059
		[Nullable(2)]
		protected IAdjustFixedCameraRotateConfig_SetValue PocoInterface;
	}
}
