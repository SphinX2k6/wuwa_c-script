using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BEA RID: 7146
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyMediaConfig
	{
		// Token: 0x06009909 RID: 39177 RVA: 0x00160640 File Offset: 0x0015E840
		private IModifyMediaConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyMediaConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyMediaConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyMediaConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600990A RID: 39178 RVA: 0x00160678 File Offset: 0x0015E878
		public static IModifyMediaConfig Create([Nullable(2)] IModifyMediaConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyMediaConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600990B RID: 39179 RVA: 0x0016068B File Offset: 0x0015E88B
		public static IModifyMediaConfig CreateFromSetValue([Nullable(2)] IModifyMediaConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyMediaConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600990C RID: 39180 RVA: 0x0016069E File Offset: 0x0015E89E
		public IModifyMediaConfig_SetValue ToSetValue()
		{
			return new IModifyMediaConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x0600990D RID: 39181 RVA: 0x001606B1 File Offset: 0x0015E8B1
		// (set) Token: 0x0600990E RID: 39182 RVA: 0x001606DC File Offset: 0x0015E8DC
		public virtual EModifyActorMediaType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModifyActorMediaType.ChangeMediaPlayDA;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D3D RID: 23869
		[Nullable(2)]
		protected IModifyMediaConfig FbInstance;

		// Token: 0x04005D3E RID: 23870
		[Nullable(2)]
		protected IModifyMediaConfig_SetValue PocoInterface;
	}
}
