using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200052B RID: 1323
	public class ILookAtTargetEntity : ILookAtTargetBase
	{
		// Token: 0x06001AA6 RID: 6822 RVA: 0x0004E3D0 File Offset: 0x0004C5D0
		private ILookAtTargetEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILookAtTargetEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILookAtTargetEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILookAtTargetEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x0004E408 File Offset: 0x0004C608
		public static ILookAtTargetEntity Create([Nullable(2)] ILookAtTargetEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTargetEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0004E41B File Offset: 0x0004C61B
		public static ILookAtTargetEntity CreateFromSetValue([Nullable(2)] ILookAtTargetEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILookAtTargetEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0004E42E File Offset: 0x0004C62E
		public new ILookAtTargetEntity_SetValue ToSetValue()
		{
			return new ILookAtTargetEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0004E44D File Offset: 0x0004C64D
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x0004E478 File Offset: 0x0004C678
		public override ELookAtTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELookAtTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0004E486 File Offset: 0x0004C686
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x0004E4B1 File Offset: 0x0004C6B1
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

		// Token: 0x04001398 RID: 5016
		[Nullable(2)]
		protected new ILookAtTargetEntity FbInstance;

		// Token: 0x04001399 RID: 5017
		[Nullable(2)]
		protected new ILookAtTargetEntity_SetValue PocoInterface;
	}
}
