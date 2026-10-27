using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D2C RID: 7468
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlotModeUiStyleBase
	{
		// Token: 0x0600A043 RID: 41027 RVA: 0x0016DB58 File Offset: 0x0016BD58
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

		// Token: 0x0600A044 RID: 41028 RVA: 0x0016DB90 File Offset: 0x0016BD90
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

		// Token: 0x0600A045 RID: 41029 RVA: 0x0016DBA3 File Offset: 0x0016BDA3
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

		// Token: 0x0600A046 RID: 41030 RVA: 0x0016DBB6 File Offset: 0x0016BDB6
		public IPlotModeUiStyleBase_SetValue ToSetValue()
		{
			return new IPlotModeUiStyleBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x0600A047 RID: 41031 RVA: 0x0016DBC9 File Offset: 0x0016BDC9
		// (set) Token: 0x0600A048 RID: 41032 RVA: 0x0016DBF4 File Offset: 0x0016BDF4
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

		// Token: 0x0400609D RID: 24733
		[Nullable(2)]
		protected IPlotModeUiStyleBase FbInstance;

		// Token: 0x0400609E RID: 24734
		[Nullable(2)]
		protected IPlotModeUiStyleBase_SetValue PocoInterface;
	}
}
