using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E48 RID: 7752
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetTeleControlConfig
	{
		// Token: 0x0600A5DD RID: 42461 RVA: 0x00177978 File Offset: 0x00175B78
		private ISetTeleControlConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetTeleControlConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetTeleControlConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetTeleControlConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A5DE RID: 42462 RVA: 0x001779B0 File Offset: 0x00175BB0
		public static ISetTeleControlConfig Create([Nullable(2)] ISetTeleControlConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetTeleControlConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x001779C3 File Offset: 0x00175BC3
		public static ISetTeleControlConfig CreateFromSetValue([Nullable(2)] ISetTeleControlConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetTeleControlConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A5E0 RID: 42464 RVA: 0x001779D6 File Offset: 0x00175BD6
		public ISetTeleControlConfig_SetValue ToSetValue()
		{
			return new ISetTeleControlConfig_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600A5E1 RID: 42465 RVA: 0x001779F5 File Offset: 0x00175BF5
		// (set) Token: 0x0600A5E2 RID: 42466 RVA: 0x00177A20 File Offset: 0x00175C20
		public virtual ESetTeleControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetTeleControlType.OpenGravity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600A5E3 RID: 42467 RVA: 0x00177A2E File Offset: 0x00175C2E
		// (set) Token: 0x0600A5E4 RID: 42468 RVA: 0x00177A59 File Offset: 0x00175C59
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04006326 RID: 25382
		[Nullable(2)]
		protected ISetTeleControlConfig FbInstance;

		// Token: 0x04006327 RID: 25383
		[Nullable(2)]
		protected ISetTeleControlConfig_SetValue PocoInterface;
	}
}
