using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D7F RID: 7551
	public class ILiveUiStartConfig : ILiveUiConfig
	{
		// Token: 0x0600A043 RID: 41027 RVA: 0x0016F954 File Offset: 0x0016DB54
		private ILiveUiStartConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveUiStartConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveUiStartConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveUiStartConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A044 RID: 41028 RVA: 0x0016F98C File Offset: 0x0016DB8C
		public static ILiveUiStartConfig Create([Nullable(2)] ILiveUiStartConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiStartConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x0016F99F File Offset: 0x0016DB9F
		public static ILiveUiStartConfig CreateFromSetValue([Nullable(2)] ILiveUiStartConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveUiStartConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x0016F9B2 File Offset: 0x0016DBB2
		public new ILiveUiStartConfig_SetValue ToSetValue()
		{
			return new ILiveUiStartConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600A047 RID: 41031 RVA: 0x0016F9C5 File Offset: 0x0016DBC5
		// (set) Token: 0x0600A048 RID: 41032 RVA: 0x0016F9F0 File Offset: 0x0016DBF0
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

		// Token: 0x0400616A RID: 24938
		[Nullable(2)]
		protected new ILiveUiStartConfig FbInstance;

		// Token: 0x0400616B RID: 24939
		[Nullable(2)]
		protected new ILiveUiStartConfig_SetValue PocoInterface;
	}
}
