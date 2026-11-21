using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D89 RID: 7561
	public class ILongPressInteractStyleConfig
	{
		// Token: 0x0600A087 RID: 41095 RVA: 0x00170350 File Offset: 0x0016E550
		private ILongPressInteractStyleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressInteractStyleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressInteractStyleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressInteractStyleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A088 RID: 41096 RVA: 0x00170388 File Offset: 0x0016E588
		public static ILongPressInteractStyleConfig Create([Nullable(2)] ILongPressInteractStyleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A089 RID: 41097 RVA: 0x0017039B File Offset: 0x0016E59B
		public static ILongPressInteractStyleConfig CreateFromSetValue([Nullable(2)] ILongPressInteractStyleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A08A RID: 41098 RVA: 0x001703AE File Offset: 0x0016E5AE
		public ILongPressInteractStyleConfig_SetValue ToSetValue()
		{
			return new ILongPressInteractStyleConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600A08B RID: 41099 RVA: 0x001703C1 File Offset: 0x0016E5C1
		// (set) Token: 0x0600A08C RID: 41100 RVA: 0x001703EC File Offset: 0x0016E5EC
		public virtual ELongPressInteractStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELongPressInteractStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006195 RID: 24981
		[Nullable(2)]
		protected ILongPressInteractStyleConfig FbInstance;

		// Token: 0x04006196 RID: 24982
		[Nullable(2)]
		protected ILongPressInteractStyleConfig_SetValue PocoInterface;
	}
}
