using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067C1 RID: 26561
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlShopServerData
	{
		// Token: 0x170096B4 RID: 38580
		// (get) Token: 0x06042270 RID: 270960 RVA: 0x0100ABD8 File Offset: 0x01008DD8
		public DangoBrawlShopInfo MyShopInfo
		{
			get
			{
				return this.ShopInfo;
			}
		}

		// Token: 0x06042271 RID: 270961 RVA: 0x0100ABE0 File Offset: 0x01008DE0
		[NullableContext(1)]
		public void Init(DangoBrawlShopInfo val)
		{
			this.UpdateShopInfo(val);
		}

		// Token: 0x06042272 RID: 270962 RVA: 0x0100ABEC File Offset: 0x01008DEC
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

		// Token: 0x06042273 RID: 270963 RVA: 0x0100AC5C File Offset: 0x01008E5C
		public DangoBrawlShopSlotInfo GetSlotInfo(int uid)
		{
			DangoBrawlShopSlotInfo result;
			if (!this.SlotMap.TryGetValue(uid, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06042274 RID: 270964 RVA: 0x0100AC7C File Offset: 0x01008E7C
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

		// Token: 0x06042275 RID: 270965 RVA: 0x0100ACC4 File Offset: 0x01008EC4
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

		// Token: 0x06042276 RID: 270966 RVA: 0x0100ACEC File Offset: 0x01008EEC
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

		// Token: 0x0402289F RID: 141471
		private DangoBrawlShopInfo ShopInfo;

		// Token: 0x040228A0 RID: 141472
		[Nullable(1)]
		private readonly Dictionary<int, DangoBrawlShopSlotInfo> SlotMap = new Dictionary<int, DangoBrawlShopSlotInfo>();
	}
}
