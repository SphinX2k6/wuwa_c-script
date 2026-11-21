using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002106 RID: 8454
	public class ISubPlotModeBase
	{
		// Token: 0x0600B390 RID: 45968 RVA: 0x00192D54 File Offset: 0x00190F54
		private ISubPlotModeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubPlotModeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubPlotModeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubPlotModeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B391 RID: 45969 RVA: 0x00192D8C File Offset: 0x00190F8C
		public static ISubPlotModeBase Create([Nullable(2)] ISubPlotModeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubPlotModeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B392 RID: 45970 RVA: 0x00192D9F File Offset: 0x00190F9F
		public static ISubPlotModeBase CreateFromSetValue([Nullable(2)] ISubPlotModeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubPlotModeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B393 RID: 45971 RVA: 0x00192DB2 File Offset: 0x00190FB2
		public ISubPlotModeBase_SetValue ToSetValue()
		{
			return new ISubPlotModeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0600B394 RID: 45972 RVA: 0x00192DC5 File Offset: 0x00190FC5
		// (set) Token: 0x0600B395 RID: 45973 RVA: 0x00192DF0 File Offset: 0x00190FF0
		public virtual ESubPlotModeType Type
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

		// Token: 0x04006A6B RID: 27243
		[Nullable(2)]
		protected ISubPlotModeBase FbInstance;

		// Token: 0x04006A6C RID: 27244
		[Nullable(2)]
		protected ISubPlotModeBase_SetValue PocoInterface;
	}
}
