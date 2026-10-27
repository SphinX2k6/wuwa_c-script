using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004D2 RID: 1234
	[NullableContext(1)]
	[Nullable(0)]
	public class ILookAtTargetEntity : ILookAtTargetBase
	{
		// Token: 0x0600190C RID: 6412 RVA: 0x0004A688 File Offset: 0x00048888
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

		// Token: 0x0600190D RID: 6413 RVA: 0x0004A6C0 File Offset: 0x000488C0
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

		// Token: 0x0600190E RID: 6414 RVA: 0x0004A6D3 File Offset: 0x000488D3
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

		// Token: 0x0600190F RID: 6415 RVA: 0x0004A6E6 File Offset: 0x000488E6
		public new ILookAtTargetEntity_SetValue ToSetValue()
		{
			return new ILookAtTargetEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x0004A705 File Offset: 0x00048905
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x0004A730 File Offset: 0x00048930
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

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x0004A73E File Offset: 0x0004893E
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x0004A769 File Offset: 0x00048969
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

		// Token: 0x04001276 RID: 4726
		[Nullable(2)]
		protected new ILookAtTargetEntity FbInstance;

		// Token: 0x04001277 RID: 4727
		[Nullable(2)]
		protected new ILookAtTargetEntity_SetValue PocoInterface;
	}
}
