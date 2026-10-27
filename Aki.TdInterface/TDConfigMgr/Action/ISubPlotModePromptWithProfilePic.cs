using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ECF RID: 7887
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubPlotModePromptWithProfilePic : ISubPlotModeBase
	{
		// Token: 0x0600A8C6 RID: 43206 RVA: 0x0017CE18 File Offset: 0x0017B018
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

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x0017CE50 File Offset: 0x0017B050
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

		// Token: 0x0600A8C8 RID: 43208 RVA: 0x0017CE63 File Offset: 0x0017B063
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

		// Token: 0x0600A8C9 RID: 43209 RVA: 0x0017CE76 File Offset: 0x0017B076
		public new ISubPlotModePromptWithProfilePic_SetValue ToSetValue()
		{
			return new ISubPlotModePromptWithProfilePic_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600A8CA RID: 43210 RVA: 0x0017CE89 File Offset: 0x0017B089
		// (set) Token: 0x0600A8CB RID: 43211 RVA: 0x0017CEB4 File Offset: 0x0017B0B4
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

		// Token: 0x0400647F RID: 25727
		[Nullable(2)]
		protected new ISubPlotModePromptWithProfilePic FbInstance;

		// Token: 0x04006480 RID: 25728
		[Nullable(2)]
		protected new ISubPlotModePromptWithProfilePic_SetValue PocoInterface;
	}
}
