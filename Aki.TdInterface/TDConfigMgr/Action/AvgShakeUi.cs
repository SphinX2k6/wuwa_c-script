using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001600 RID: 5632
	public class AvgShakeUi : ActionParams
	{
		// Token: 0x06007F2F RID: 32559 RVA: 0x0012F6F4 File Offset: 0x0012D8F4
		private AvgShakeUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AvgShakeUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AvgShakeUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AvgShakeUi_SetValue());
			}
			return result;
		}

		// Token: 0x06007F30 RID: 32560 RVA: 0x0012F72C File Offset: 0x0012D92C
		public static AvgShakeUi Create([Nullable(2)] AvgShakeUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AvgShakeUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F31 RID: 32561 RVA: 0x0012F73F File Offset: 0x0012D93F
		public static AvgShakeUi CreateFromSetValue([Nullable(2)] AvgShakeUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AvgShakeUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x0012F752 File Offset: 0x0012D952
		public AvgShakeUi_SetValue ToSetValue()
		{
			return new AvgShakeUi_SetValue
			{
				Intensity = this.Intensity,
				RepeatCount = this.RepeatCount
			};
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x06007F33 RID: 32563 RVA: 0x0012F771 File Offset: 0x0012D971
		// (set) Token: 0x06007F34 RID: 32564 RVA: 0x0012F79C File Offset: 0x0012D99C
		public virtual EAvgShakeUiIntensity Intensity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Intensity;
				}
				if (this.PocoInterface == null)
				{
					return EAvgShakeUiIntensity.Weak;
				}
				return this.PocoInterface.Intensity;
			}
			set
			{
				this.GetOrCreatePoco().Intensity = value;
			}
		}

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x06007F35 RID: 32565 RVA: 0x0012F7AA File Offset: 0x0012D9AA
		// (set) Token: 0x06007F36 RID: 32566 RVA: 0x0012F7D5 File Offset: 0x0012D9D5
		public virtual int RepeatCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RepeatCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RepeatCount;
			}
			set
			{
				this.GetOrCreatePoco().RepeatCount = value;
			}
		}

		// Token: 0x04004993 RID: 18835
		[Nullable(2)]
		protected new AvgShakeUi FbInstance;

		// Token: 0x04004994 RID: 18836
		[Nullable(2)]
		protected AvgShakeUi_SetValue PocoInterface;
	}
}
