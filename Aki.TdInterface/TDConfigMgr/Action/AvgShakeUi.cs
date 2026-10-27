using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014A7 RID: 5287
	[NullableContext(1)]
	[Nullable(0)]
	public class AvgShakeUi : ActionParams
	{
		// Token: 0x06007862 RID: 30818 RVA: 0x00120AA8 File Offset: 0x0011ECA8
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

		// Token: 0x06007863 RID: 30819 RVA: 0x00120AE0 File Offset: 0x0011ECE0
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

		// Token: 0x06007864 RID: 30820 RVA: 0x00120AF3 File Offset: 0x0011ECF3
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

		// Token: 0x06007865 RID: 30821 RVA: 0x00120B06 File Offset: 0x0011ED06
		public AvgShakeUi_SetValue ToSetValue()
		{
			return new AvgShakeUi_SetValue
			{
				Intensity = this.Intensity,
				RepeatCount = this.RepeatCount
			};
		}

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x06007866 RID: 30822 RVA: 0x00120B25 File Offset: 0x0011ED25
		// (set) Token: 0x06007867 RID: 30823 RVA: 0x00120B50 File Offset: 0x0011ED50
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

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x06007868 RID: 30824 RVA: 0x00120B5E File Offset: 0x0011ED5E
		// (set) Token: 0x06007869 RID: 30825 RVA: 0x00120B89 File Offset: 0x0011ED89
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

		// Token: 0x040045F8 RID: 17912
		[Nullable(2)]
		protected new AvgShakeUi FbInstance;

		// Token: 0x040045F9 RID: 17913
		[Nullable(2)]
		protected AvgShakeUi_SetValue PocoInterface;
	}
}
