using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D15 RID: 7445
	public class IJigsawItemEntity : IResetEntityConfig
	{
		// Token: 0x06009E25 RID: 40485 RVA: 0x0016BED8 File Offset: 0x0016A0D8
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

		// Token: 0x06009E26 RID: 40486 RVA: 0x0016BF10 File Offset: 0x0016A110
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

		// Token: 0x06009E27 RID: 40487 RVA: 0x0016BF23 File Offset: 0x0016A123
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

		// Token: 0x06009E28 RID: 40488 RVA: 0x0016BF36 File Offset: 0x0016A136
		public new IJigsawItemEntity_SetValue ToSetValue()
		{
			return new IJigsawItemEntity_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x06009E29 RID: 40489 RVA: 0x0016BF55 File Offset: 0x0016A155
		// (set) Token: 0x06009E2A RID: 40490 RVA: 0x0016BF80 File Offset: 0x0016A180
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

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x06009E2B RID: 40491 RVA: 0x0016BF8E File Offset: 0x0016A18E
		// (set) Token: 0x06009E2C RID: 40492 RVA: 0x0016BFB5 File Offset: 0x0016A1B5
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

		// Token: 0x04006080 RID: 24704
		[Nullable(2)]
		protected new IJigsawItemEntity FbInstance;

		// Token: 0x04006081 RID: 24705
		[Nullable(2)]
		protected new IJigsawItemEntity_SetValue PocoInterface;
	}
}
