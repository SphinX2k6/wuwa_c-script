using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE8 RID: 7144
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyMaterialConfig
	{
		// Token: 0x06009901 RID: 39169 RVA: 0x00160584 File Offset: 0x0015E784
		private IModifyMaterialConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyMaterialConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyMaterialConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyMaterialConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009902 RID: 39170 RVA: 0x001605BC File Offset: 0x0015E7BC
		public static IModifyMaterialConfig Create([Nullable(2)] IModifyMaterialConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyMaterialConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x001605CF File Offset: 0x0015E7CF
		public static IModifyMaterialConfig CreateFromSetValue([Nullable(2)] IModifyMaterialConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyMaterialConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x001605E2 File Offset: 0x0015E7E2
		public IModifyMaterialConfig_SetValue ToSetValue()
		{
			return new IModifyMaterialConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x06009905 RID: 39173 RVA: 0x001605F5 File Offset: 0x0015E7F5
		// (set) Token: 0x06009906 RID: 39174 RVA: 0x00160620 File Offset: 0x0015E820
		public virtual EModifyActorMaterialType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModifyActorMaterialType.ChangeMaterialData;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D3A RID: 23866
		[Nullable(2)]
		protected IModifyMaterialConfig FbInstance;

		// Token: 0x04005D3B RID: 23867
		[Nullable(2)]
		protected IModifyMaterialConfig_SetValue PocoInterface;
	}
}
