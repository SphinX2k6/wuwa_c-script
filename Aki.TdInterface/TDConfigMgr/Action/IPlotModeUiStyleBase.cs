using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F3D RID: 7997
	public class IPlotModeUiStyleBase
	{
		// Token: 0x0600AA2F RID: 43567 RVA: 0x00181F7C File Offset: 0x0018017C
		private IPlotModeUiStyleBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlotModeUiStyleBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlotModeUiStyleBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlotModeUiStyleBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x00181FB4 File Offset: 0x001801B4
		public static IPlotModeUiStyleBase Create([Nullable(2)] IPlotModeUiStyleBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotModeUiStyleBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA31 RID: 43569 RVA: 0x00181FC7 File Offset: 0x001801C7
		public static IPlotModeUiStyleBase CreateFromSetValue([Nullable(2)] IPlotModeUiStyleBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlotModeUiStyleBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA32 RID: 43570 RVA: 0x00181FDA File Offset: 0x001801DA
		public IPlotModeUiStyleBase_SetValue ToSetValue()
		{
			return new IPlotModeUiStyleBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0600AA33 RID: 43571 RVA: 0x00181FED File Offset: 0x001801ED
		// (set) Token: 0x0600AA34 RID: 43572 RVA: 0x00182018 File Offset: 0x00180218
		public virtual EPlotModeUiStyleType Type
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

		// Token: 0x04006619 RID: 26137
		[Nullable(2)]
		protected IPlotModeUiStyleBase FbInstance;

		// Token: 0x0400661A RID: 26138
		[Nullable(2)]
		protected IPlotModeUiStyleBase_SetValue PocoInterface;
	}
}
