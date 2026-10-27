using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B68 RID: 7016
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawItemEntity : IResetEntityConfig
	{
		// Token: 0x06009643 RID: 38467 RVA: 0x0015B32C File Offset: 0x0015952C
		private IJigsawItemEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IJigsawItemEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IJigsawItemEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IJigsawItemEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x0015B364 File Offset: 0x00159564
		public static IJigsawItemEntity Create([Nullable(2)] IJigsawItemEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawItemEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x0015B377 File Offset: 0x00159577
		public static IJigsawItemEntity CreateFromSetValue([Nullable(2)] IJigsawItemEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IJigsawItemEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x0015B38A File Offset: 0x0015958A
		public new IJigsawItemEntity_SetValue ToSetValue()
		{
			return new IJigsawItemEntity_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x06009647 RID: 38471 RVA: 0x0015B3A9 File Offset: 0x001595A9
		// (set) Token: 0x06009648 RID: 38472 RVA: 0x0015B3D4 File Offset: 0x001595D4
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

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x06009649 RID: 38473 RVA: 0x0015B3E2 File Offset: 0x001595E2
		// (set) Token: 0x0600964A RID: 38474 RVA: 0x0015B409 File Offset: 0x00159609
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IJigsawItemEntity_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005BE7 RID: 23527
		[Nullable(2)]
		protected new IJigsawItemEntity FbInstance;

		// Token: 0x04005BE8 RID: 23528
		[Nullable(2)]
		protected new IJigsawItemEntity_SetValue PocoInterface;
	}
}
