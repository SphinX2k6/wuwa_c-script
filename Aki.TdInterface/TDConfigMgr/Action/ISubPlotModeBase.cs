using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ECD RID: 7885
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubPlotModeBase
	{
		// Token: 0x0600A8BE RID: 43198 RVA: 0x0017CD5C File Offset: 0x0017AF5C
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

		// Token: 0x0600A8BF RID: 43199 RVA: 0x0017CD94 File Offset: 0x0017AF94
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

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x0017CDA7 File Offset: 0x0017AFA7
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

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x0017CDBA File Offset: 0x0017AFBA
		public ISubPlotModeBase_SetValue ToSetValue()
		{
			return new ISubPlotModeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600A8C2 RID: 43202 RVA: 0x0017CDCD File Offset: 0x0017AFCD
		// (set) Token: 0x0600A8C3 RID: 43203 RVA: 0x0017CDF8 File Offset: 0x0017AFF8
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

		// Token: 0x0400647C RID: 25724
		[Nullable(2)]
		protected ISubPlotModeBase FbInstance;

		// Token: 0x0400647D RID: 25725
		[Nullable(2)]
		protected ISubPlotModeBase_SetValue PocoInterface;
	}
}
