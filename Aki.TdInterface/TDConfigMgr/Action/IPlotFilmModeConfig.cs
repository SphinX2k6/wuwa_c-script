using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D2A RID: 7466
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlotFilmModeConfig
	{
		// Token: 0x0600A03B RID: 41019 RVA: 0x0016DA8C File Offset: 0x0016BC8C
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

		// Token: 0x0600A03C RID: 41020 RVA: 0x0016DAC4 File Offset: 0x0016BCC4
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

		// Token: 0x0600A03D RID: 41021 RVA: 0x0016DAD7 File Offset: 0x0016BCD7
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

		// Token: 0x0600A03E RID: 41022 RVA: 0x0016DAEA File Offset: 0x0016BCEA
		public IPlotFilmModeConfig_SetValue ToSetValue()
		{
			return new IPlotFilmModeConfig_SetValue
			{
				IsAdaptFilmAspectRatio = this.IsAdaptFilmAspectRatio
			};
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x0600A03F RID: 41023 RVA: 0x0016DB00 File Offset: 0x0016BD00
		// (set) Token: 0x0600A040 RID: 41024 RVA: 0x0016DB3A File Offset: 0x0016BD3A
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

		// Token: 0x0400609A RID: 24730
		[Nullable(2)]
		protected IPlotFilmModeConfig FbInstance;

		// Token: 0x0400609B RID: 24731
		[Nullable(2)]
		protected IPlotFilmModeConfig_SetValue PocoInterface;
	}
}
