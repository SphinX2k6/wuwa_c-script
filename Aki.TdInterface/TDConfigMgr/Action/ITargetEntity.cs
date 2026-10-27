using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F8A RID: 8074
	[NullableContext(1)]
	[Nullable(0)]
	public class ITargetEntity : ITargetEntityType
	{
		// Token: 0x0600B19C RID: 45468 RVA: 0x0019E5FC File Offset: 0x0019C7FC
		private ITargetEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITargetEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITargetEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITargetEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600B19D RID: 45469 RVA: 0x0019E634 File Offset: 0x0019C834
		public static ITargetEntity Create([Nullable(2)] ITargetEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x0019E647 File Offset: 0x0019C847
		public static ITargetEntity CreateFromSetValue([Nullable(2)] ITargetEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITargetEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B19F RID: 45471 RVA: 0x0019E65A File Offset: 0x0019C85A
		public new ITargetEntity_SetValue ToSetValue()
		{
			return new ITargetEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x0600B1A0 RID: 45472 RVA: 0x0019E679 File Offset: 0x0019C879
		// (set) Token: 0x0600B1A1 RID: 45473 RVA: 0x0019E6A4 File Offset: 0x0019C8A4
		public override ETargetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetEntityType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x0600B1A2 RID: 45474 RVA: 0x0019E6B2 File Offset: 0x0019C8B2
		// (set) Token: 0x0600B1A3 RID: 45475 RVA: 0x0019E6DD File Offset: 0x0019C8DD
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

		// Token: 0x04006B60 RID: 27488
		[Nullable(2)]
		protected new ITargetEntity FbInstance;

		// Token: 0x04006B61 RID: 27489
		[Nullable(2)]
		protected new ITargetEntity_SetValue PocoInterface;
	}
}
