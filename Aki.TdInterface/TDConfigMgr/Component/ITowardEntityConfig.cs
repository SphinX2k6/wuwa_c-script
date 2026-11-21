using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000836 RID: 2102
	public class ITowardEntityConfig
	{
		// Token: 0x06002D36 RID: 11574 RVA: 0x00075C20 File Offset: 0x00073E20
		private ITowardEntityConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITowardEntityConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITowardEntityConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITowardEntityConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00075C58 File Offset: 0x00073E58
		public static ITowardEntityConfig Create([Nullable(2)] ITowardEntityConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITowardEntityConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00075C6B File Offset: 0x00073E6B
		public static ITowardEntityConfig CreateFromSetValue([Nullable(2)] ITowardEntityConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITowardEntityConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00075C7E File Offset: 0x00073E7E
		public ITowardEntityConfig_SetValue ToSetValue()
		{
			return new ITowardEntityConfig_SetValue
			{
				ReferenceActorKey = this.ReferenceActorKey,
				TargetEntityId = this.TargetEntityId
			};
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002D3A RID: 11578 RVA: 0x00075C9D File Offset: 0x00073E9D
		// (set) Token: 0x06002D3B RID: 11579 RVA: 0x00075CC8 File Offset: 0x00073EC8
		public virtual string ReferenceActorKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReferenceActorKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ReferenceActorKey;
			}
			set
			{
				this.GetOrCreatePoco().ReferenceActorKey = value;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x00075CD6 File Offset: 0x00073ED6
		// (set) Token: 0x06002D3D RID: 11581 RVA: 0x00075D01 File Offset: 0x00073F01
		public virtual int TargetEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntityId = value;
			}
		}

		// Token: 0x04001E2F RID: 7727
		[Nullable(2)]
		protected ITowardEntityConfig FbInstance;

		// Token: 0x04001E30 RID: 7728
		[Nullable(2)]
		protected ITowardEntityConfig_SetValue PocoInterface;
	}
}
