using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FCD RID: 8141
	public class IResetTeleControlEntity : IResetEntityConfig
	{
		// Token: 0x0600ACFB RID: 44283 RVA: 0x00186BC8 File Offset: 0x00184DC8
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

		// Token: 0x0600ACFC RID: 44284 RVA: 0x00186C00 File Offset: 0x00184E00
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

		// Token: 0x0600ACFD RID: 44285 RVA: 0x00186C13 File Offset: 0x00184E13
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

		// Token: 0x0600ACFE RID: 44286 RVA: 0x00186C26 File Offset: 0x00184E26
		public new IResetTeleControlEntity_SetValue ToSetValue()
		{
			return new IResetTeleControlEntity_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x0600ACFF RID: 44287 RVA: 0x00186C45 File Offset: 0x00184E45
		// (set) Token: 0x0600AD00 RID: 44288 RVA: 0x00186C70 File Offset: 0x00184E70
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

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x0600AD01 RID: 44289 RVA: 0x00186C7E File Offset: 0x00184E7E
		// (set) Token: 0x0600AD02 RID: 44290 RVA: 0x00186CA5 File Offset: 0x00184EA5
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

		// Token: 0x04006751 RID: 26449
		[Nullable(2)]
		protected new IResetTeleControlEntity FbInstance;

		// Token: 0x04006752 RID: 26450
		[Nullable(2)]
		protected new IResetTeleControlEntity_SetValue PocoInterface;
	}
}
