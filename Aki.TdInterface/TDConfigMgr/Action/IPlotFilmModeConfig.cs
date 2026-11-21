using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F3B RID: 7995
	public class IPlotFilmModeConfig
	{
		// Token: 0x0600AA27 RID: 43559 RVA: 0x00181EB0 File Offset: 0x001800B0
		private IPlotFilmModeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlotFilmModeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlotFilmModeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlotFilmModeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA28 RID: 43560 RVA: 0x00181EE8 File Offset: 0x001800E8
		public static IPlotFilmModeConfig Create([Nullable(2)] IPlotFilmModeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotFilmModeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA29 RID: 43561 RVA: 0x00181EFB File Offset: 0x001800FB
		public static IPlotFilmModeConfig CreateFromSetValue([Nullable(2)] IPlotFilmModeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlotFilmModeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA2A RID: 43562 RVA: 0x00181F0E File Offset: 0x0018010E
		public IPlotFilmModeConfig_SetValue ToSetValue()
		{
			return new IPlotFilmModeConfig_SetValue
			{
				IsAdaptFilmAspectRatio = this.IsAdaptFilmAspectRatio
			};
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0600AA2B RID: 43563 RVA: 0x00181F24 File Offset: 0x00180124
		// (set) Token: 0x0600AA2C RID: 43564 RVA: 0x00181F5E File Offset: 0x0018015E
		public virtual bool? IsAdaptFilmAspectRatio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAdaptFilmAspectRatio;
				}
				IPlotFilmModeConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAdaptFilmAspectRatio;
			}
			set
			{
				this.GetOrCreatePoco().IsAdaptFilmAspectRatio = value;
			}
		}

		// Token: 0x04006616 RID: 26134
		[Nullable(2)]
		protected IPlotFilmModeConfig FbInstance;

		// Token: 0x04006617 RID: 26135
		[Nullable(2)]
		protected IPlotFilmModeConfig_SetValue PocoInterface;
	}
}
