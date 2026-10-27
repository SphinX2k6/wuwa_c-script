using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000795 RID: 1941
	[NullableContext(1)]
	[Nullable(0)]
	public class ITowardEntityConfig
	{
		// Token: 0x06002A0E RID: 10766 RVA: 0x0006E978 File Offset: 0x0006CB78
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

		// Token: 0x06002A0F RID: 10767 RVA: 0x0006E9B0 File Offset: 0x0006CBB0
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

		// Token: 0x06002A10 RID: 10768 RVA: 0x0006E9C3 File Offset: 0x0006CBC3
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

		// Token: 0x06002A11 RID: 10769 RVA: 0x0006E9D6 File Offset: 0x0006CBD6
		public ITowardEntityConfig_SetValue ToSetValue()
		{
			return new ITowardEntityConfig_SetValue
			{
				ReferenceActorKey = this.ReferenceActorKey,
				TargetEntityId = this.TargetEntityId
			};
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002A12 RID: 10770 RVA: 0x0006E9F5 File Offset: 0x0006CBF5
		// (set) Token: 0x06002A13 RID: 10771 RVA: 0x0006EA20 File Offset: 0x0006CC20
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

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002A14 RID: 10772 RVA: 0x0006EA2E File Offset: 0x0006CC2E
		// (set) Token: 0x06002A15 RID: 10773 RVA: 0x0006EA59 File Offset: 0x0006CC59
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

		// Token: 0x04001C26 RID: 7206
		[Nullable(2)]
		protected ITowardEntityConfig FbInstance;

		// Token: 0x04001C27 RID: 7207
		[Nullable(2)]
		protected ITowardEntityConfig_SetValue PocoInterface;
	}
}
