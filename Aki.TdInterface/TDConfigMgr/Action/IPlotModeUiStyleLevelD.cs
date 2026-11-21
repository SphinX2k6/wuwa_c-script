using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F3F RID: 7999
	public class IPlotModeUiStyleLevelD : IPlotModeUiStyleBase
	{
		// Token: 0x0600AA37 RID: 43575 RVA: 0x00182038 File Offset: 0x00180238
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

		// Token: 0x0600AA38 RID: 43576 RVA: 0x00182070 File Offset: 0x00180270
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

		// Token: 0x0600AA39 RID: 43577 RVA: 0x00182083 File Offset: 0x00180283
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

		// Token: 0x0600AA3A RID: 43578 RVA: 0x00182096 File Offset: 0x00180296
		public new IPlotModeUiStyleLevelD_SetValue ToSetValue()
		{
			return new IPlotModeUiStyleLevelD_SetValue
			{
				Type = this.Type,
				UiStyle = this.UiStyle
			};
		}

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0600AA3B RID: 43579 RVA: 0x001820B5 File Offset: 0x001802B5
		// (set) Token: 0x0600AA3C RID: 43580 RVA: 0x001820E0 File Offset: 0x001802E0
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

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0600AA3D RID: 43581 RVA: 0x001820EE File Offset: 0x001802EE
		// (set) Token: 0x0600AA3E RID: 43582 RVA: 0x00182115 File Offset: 0x00180315
		[Nullable(2)]
		public virtual IUiStyleBaseOfLevelD UiStyle
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().UiStyle = value;
			}
		}

		// Token: 0x0400661C RID: 26140
		[Nullable(2)]
		protected new IPlotModeUiStyleLevelD FbInstance;

		// Token: 0x0400661D RID: 26141
		[Nullable(2)]
		protected new IPlotModeUiStyleLevelD_SetValue PocoInterface;
	}
}
