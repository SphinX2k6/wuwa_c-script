using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2E RID: 3374
	public struct HonamiStoryArea : IFlatbufferObject
	{
		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06007EE1 RID: 32481 RVA: 0x002551D4 File Offset: 0x002533D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007EE2 RID: 32482 RVA: 0x002551E1 File Offset: 0x002533E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007EE3 RID: 32483 RVA: 0x002551E8 File Offset: 0x002533E8
		public static HonamiStoryArea GetRootAsHonamiStoryArea(ByteBuffer _bb)
		{
			return HonamiStoryArea.GetRootAsHonamiStoryArea(_bb, default(HonamiStoryArea));
		}

		// Token: 0x06007EE4 RID: 32484 RVA: 0x00255204 File Offset: 0x00253404
		public static HonamiStoryArea GetRootAsHonamiStoryArea(ByteBuffer _bb, HonamiStoryArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007EE5 RID: 32485 RVA: 0x00255221 File Offset: 0x00253421
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007EE6 RID: 32486 RVA: 0x00255230 File Offset: 0x00253430
		public HonamiStoryArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06007EE7 RID: 32487 RVA: 0x00255240 File Offset: 0x00253440
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06007EE8 RID: 32488 RVA: 0x0025527C File Offset: 0x0025347C
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06007EE9 RID: 32489 RVA: 0x002552B8 File Offset: 0x002534B8
		public int Order
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06007EEA RID: 32490 RVA: 0x002552F4 File Offset: 0x002534F4
		public int MainBTId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06007EEB RID: 32491 RVA: 0x00255334 File Offset: 0x00253534
		public int DangerLevel
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06007EEC RID: 32492 RVA: 0x00255374 File Offset: 0x00253574
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06007EED RID: 32493 RVA: 0x002553B4 File Offset: 0x002535B4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007EEE RID: 32494 RVA: 0x002553EC File Offset: 0x002535EC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007EEF RID: 32495 RVA: 0x002553FC File Offset: 0x002535FC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06007EF0 RID: 32496 RVA: 0x00255414 File Offset: 0x00253614
		public string LvSelectName
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007EF1 RID: 32497 RVA: 0x0025544C File Offset: 0x0025364C
		public Span<byte> GetLvSelectNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007EF2 RID: 32498 RVA: 0x0025545C File Offset: 0x0025365C
		public byte[] GetLvSelectNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06007EF3 RID: 32499 RVA: 0x00255474 File Offset: 0x00253674
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007EF4 RID: 32500 RVA: 0x002554AC File Offset: 0x002536AC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007EF5 RID: 32501 RVA: 0x002554BC File Offset: 0x002536BC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06007EF6 RID: 32502 RVA: 0x002554D4 File Offset: 0x002536D4
		public string ToggleBgPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007EF7 RID: 32503 RVA: 0x0025550C File Offset: 0x0025370C
		public Span<byte> GetToggleBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007EF8 RID: 32504 RVA: 0x0025551C File Offset: 0x0025371C
		public byte[] GetToggleBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06007EF9 RID: 32505 RVA: 0x00255534 File Offset: 0x00253734
		public string LvSelectBgPath
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007EFA RID: 32506 RVA: 0x0025556C File Offset: 0x0025376C
		public Span<byte> GetLvSelectBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x0025557C File Offset: 0x0025377C
		public byte[] GetLvSelectBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06007EFC RID: 32508 RVA: 0x00255594 File Offset: 0x00253794
		public string UnLockTips
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007EFD RID: 32509 RVA: 0x002555CC File Offset: 0x002537CC
		public Span<byte> GetUnLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007EFE RID: 32510 RVA: 0x002555DC File Offset: 0x002537DC
		public byte[] GetUnLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06007EFF RID: 32511 RVA: 0x002555F4 File Offset: 0x002537F4
		public bool IsNeedTips
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004DA7 RID: 19879
		private Table __p;
	}
}
