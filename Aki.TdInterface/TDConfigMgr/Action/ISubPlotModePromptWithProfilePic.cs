using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002108 RID: 8456
	public class ISubPlotModePromptWithProfilePic : ISubPlotModeBase
	{
		// Token: 0x0600B398 RID: 45976 RVA: 0x00192E10 File Offset: 0x00191010
		private ISubPlotModePromptWithProfilePic_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubPlotModePromptWithProfilePic 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubPlotModePromptWithProfilePic_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubPlotModePromptWithProfilePic_SetValue());
			}
			return result;
		}

		// Token: 0x0600B399 RID: 45977 RVA: 0x00192E48 File Offset: 0x00191048
		public static ISubPlotModePromptWithProfilePic Create([Nullable(2)] ISubPlotModePromptWithProfilePic instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubPlotModePromptWithProfilePic
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B39A RID: 45978 RVA: 0x00192E5B File Offset: 0x0019105B
		public static ISubPlotModePromptWithProfilePic CreateFromSetValue([Nullable(2)] ISubPlotModePromptWithProfilePic_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubPlotModePromptWithProfilePic
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B39B RID: 45979 RVA: 0x00192E6E File Offset: 0x0019106E
		public new ISubPlotModePromptWithProfilePic_SetValue ToSetValue()
		{
			return new ISubPlotModePromptWithProfilePic_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x0600B39C RID: 45980 RVA: 0x00192E81 File Offset: 0x00191081
		// (set) Token: 0x0600B39D RID: 45981 RVA: 0x00192EAC File Offset: 0x001910AC
		public override ESubPlotModeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubPlotModeType.PromptWithProfilePic;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006A6E RID: 27246
		[Nullable(2)]
		protected new ISubPlotModePromptWithProfilePic FbInstance;

		// Token: 0x04006A6F RID: 27247
		[Nullable(2)]
		protected new ISubPlotModePromptWithProfilePic_SetValue PocoInterface;
	}
}
