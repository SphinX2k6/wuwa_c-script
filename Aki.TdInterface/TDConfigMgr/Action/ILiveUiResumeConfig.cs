using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D7B RID: 7547
	public class ILiveUiResumeConfig : ILiveUiConfig
	{
		// Token: 0x0600A033 RID: 41011 RVA: 0x0016F7DC File Offset: 0x0016D9DC
		private ILiveUiResumeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveUiResumeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveUiResumeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveUiResumeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A034 RID: 41012 RVA: 0x0016F814 File Offset: 0x0016DA14
		public static ILiveUiResumeConfig Create([Nullable(2)] ILiveUiResumeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiResumeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x0016F827 File Offset: 0x0016DA27
		public static ILiveUiResumeConfig CreateFromSetValue([Nullable(2)] ILiveUiResumeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveUiResumeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x0016F83A File Offset: 0x0016DA3A
		public new ILiveUiResumeConfig_SetValue ToSetValue()
		{
			return new ILiveUiResumeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600A037 RID: 41015 RVA: 0x0016F84D File Offset: 0x0016DA4D
		// (set) Token: 0x0600A038 RID: 41016 RVA: 0x0016F878 File Offset: 0x0016DA78
		public override ELiveUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveUiType.Start;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006164 RID: 24932
		[Nullable(2)]
		protected new ILiveUiResumeConfig FbInstance;

		// Token: 0x04006165 RID: 24933
		[Nullable(2)]
		protected new ILiveUiResumeConfig_SetValue PocoInterface;
	}
}
