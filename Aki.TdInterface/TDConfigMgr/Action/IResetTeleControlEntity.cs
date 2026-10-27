using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB6 RID: 7606
	[NullableContext(1)]
	[Nullable(0)]
	public class IResetTeleControlEntity : IResetEntityConfig
	{
		// Token: 0x0600A2F1 RID: 41713 RVA: 0x001724A0 File Offset: 0x001706A0
		private IResetTeleControlEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetTeleControlEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetTeleControlEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetTeleControlEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x001724D8 File Offset: 0x001706D8
		public static IResetTeleControlEntity Create([Nullable(2)] IResetTeleControlEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetTeleControlEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2F3 RID: 41715 RVA: 0x001724EB File Offset: 0x001706EB
		public static IResetTeleControlEntity CreateFromSetValue([Nullable(2)] IResetTeleControlEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetTeleControlEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x001724FE File Offset: 0x001706FE
		public new IResetTeleControlEntity_SetValue ToSetValue()
		{
			return new IResetTeleControlEntity_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600A2F5 RID: 41717 RVA: 0x0017251D File Offset: 0x0017071D
		// (set) Token: 0x0600A2F6 RID: 41718 RVA: 0x00172548 File Offset: 0x00170748
		public override EResetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetEntityType.TeleControl;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600A2F7 RID: 41719 RVA: 0x00172556 File Offset: 0x00170756
		// (set) Token: 0x0600A2F8 RID: 41720 RVA: 0x0017257D File Offset: 0x0017077D
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IResetTeleControlEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x040061C9 RID: 25033
		[Nullable(2)]
		protected new IResetTeleControlEntity FbInstance;

		// Token: 0x040061CA RID: 25034
		[Nullable(2)]
		protected new IResetTeleControlEntity_SetValue PocoInterface;
	}
}
