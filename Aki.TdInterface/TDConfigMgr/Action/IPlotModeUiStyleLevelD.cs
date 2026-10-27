using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D2E RID: 7470
	[NullableContext(2)]
	[Nullable(0)]
	public class IPlotModeUiStyleLevelD : IPlotModeUiStyleBase
	{
		// Token: 0x0600A04B RID: 41035 RVA: 0x0016DC14 File Offset: 0x0016BE14
		[NullableContext(1)]
		private IPlotModeUiStyleLevelD_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlotModeUiStyleLevelD 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlotModeUiStyleLevelD_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlotModeUiStyleLevelD_SetValue());
			}
			return result;
		}

		// Token: 0x0600A04C RID: 41036 RVA: 0x0016DC4C File Offset: 0x0016BE4C
		[NullableContext(1)]
		public static IPlotModeUiStyleLevelD Create([Nullable(2)] IPlotModeUiStyleLevelD instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotModeUiStyleLevelD
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A04D RID: 41037 RVA: 0x0016DC5F File Offset: 0x0016BE5F
		[NullableContext(1)]
		public static IPlotModeUiStyleLevelD CreateFromSetValue([Nullable(2)] IPlotModeUiStyleLevelD_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlotModeUiStyleLevelD
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A04E RID: 41038 RVA: 0x0016DC72 File Offset: 0x0016BE72
		[NullableContext(1)]
		public new IPlotModeUiStyleLevelD_SetValue ToSetValue()
		{
			return new IPlotModeUiStyleLevelD_SetValue
			{
				Type = this.Type,
				UiStyle = this.UiStyle
			};
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x0600A04F RID: 41039 RVA: 0x0016DC91 File Offset: 0x0016BE91
		// (set) Token: 0x0600A050 RID: 41040 RVA: 0x0016DCBC File Offset: 0x0016BEBC
		public override EPlotModeUiStyleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlotModeUiStyleType.LevelD;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x0600A051 RID: 41041 RVA: 0x0016DCCA File Offset: 0x0016BECA
		// (set) Token: 0x0600A052 RID: 41042 RVA: 0x0016DCF1 File Offset: 0x0016BEF1
		public virtual IUiStyleBaseOfLevelD UiStyle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiStyle;
				}
				IPlotModeUiStyleLevelD_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiStyle;
			}
			set
			{
				this.GetOrCreatePoco().UiStyle = value;
			}
		}

		// Token: 0x040060A0 RID: 24736
		protected new IPlotModeUiStyleLevelD FbInstance;

		// Token: 0x040060A1 RID: 24737
		protected new IPlotModeUiStyleLevelD_SetValue PocoInterface;
	}
}
