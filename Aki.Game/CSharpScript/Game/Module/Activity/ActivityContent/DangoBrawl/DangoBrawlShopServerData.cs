using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005711 RID: 22289
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlShopServerData
	{
		// Token: 0x170069F5 RID: 27125
		// (get) Token: 0x06036DC6 RID: 224710 RVA: 0x00F4BFBC File Offset: 0x00F4A1BC
		public DangoBrawlShopInfo MyShopInfo
		{
			get
			{
				return this.ShopInfo;
			}
		}

		// Token: 0x06036DC7 RID: 224711 RVA: 0x00F4BFC4 File Offset: 0x00F4A1C4
		[NullableContext(1)]
		public void Init(DangoBrawlShopInfo val)
		{
			this.UpdateShopInfo(val);
		}

		// Token: 0x06036DC8 RID: 224712 RVA: 0x00F4BFD0 File Offset: 0x00F4A1D0
		[NullableContext(1)]
		public void UpdateShopInfo(DangoBrawlShopInfo val)
		{
			this.ShopInfo = val;
			this.SlotMap.Clear();
			foreach (DangoBrawlShopSlotInfo dangoBrawlShopSlotInfo in val.Slots)
			{
				this.SlotMap[dangoBrawlShopSlotInfo.Item.Uid] = dangoBrawlShopSlotInfo;
			}
		}

		// Token: 0x06036DC9 RID: 224713 RVA: 0x00F4C040 File Offset: 0x00F4A240
		public DangoBrawlShopSlotInfo GetSlotInfo(int uid)
		{
			DangoBrawlShopSlotInfo result;
			if (!this.SlotMap.TryGetValue(uid, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06036DCA RID: 224714 RVA: 0x00F4C060 File Offset: 0x00F4A260
		public int GetSlotIndex(int uid)
		{
			DangoBrawlShopSlotInfo item;
			if (!this.SlotMap.TryGetValue(uid, out item))
			{
				return -1;
			}
			DangoBrawlShopInfo shopInfo = this.ShopInfo;
			if (((shopInfo != null) ? shopInfo.Slots : null) == null)
			{
				return -1;
			}
			return this.ShopInfo.Slots.IndexOf(item);
		}

		// Token: 0x06036DCB RID: 224715 RVA: 0x00F4C0A8 File Offset: 0x00F4A2A8
		public bool SetSlotLocked(int uid, bool locked)
		{
			DangoBrawlShopSlotInfo dangoBrawlShopSlotInfo;
			if (!this.SlotMap.TryGetValue(uid, out dangoBrawlShopSlotInfo))
			{
				return false;
			}
			dangoBrawlShopSlotInfo.Locked = locked;
			return true;
		}

		// Token: 0x06036DCC RID: 224716 RVA: 0x00F4C0D0 File Offset: 0x00F4A2D0
		public int RemoveSlot(int uid)
		{
			DangoBrawlShopSlotInfo dangoBrawlShopSlotInfo;
			if (!this.SlotMap.TryGetValue(uid, out dangoBrawlShopSlotInfo))
			{
				return -1;
			}
			int slotIndex = this.GetSlotIndex(uid);
			dangoBrawlShopSlotInfo.Item = null;
			this.SlotMap.Remove(uid);
			return slotIndex;
		}

		// Token: 0x0401D0FC RID: 119036
		private DangoBrawlShopInfo ShopInfo;

		// Token: 0x0401D0FD RID: 119037
		[Nullable(1)]
		private readonly Dictionary<int, DangoBrawlShopSlotInfo> SlotMap = new Dictionary<int, DangoBrawlShopSlotInfo>();
	}
}
