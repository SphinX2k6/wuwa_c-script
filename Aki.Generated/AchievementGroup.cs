using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABE RID: 2750
	public struct AchievementGroup : IFlatbufferObject
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600427F RID: 17023 RVA: 0x001CA0E0 File Offset: 0x001C82E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x001CA0ED File Offset: 0x001C82ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x001CA0F4 File Offset: 0x001C82F4
		public static AchievementGroup GetRootAsAchievementGroup(ByteBuffer _bb)
		{
			return AchievementGroup.GetRootAsAchievementGroup(_bb, default(AchievementGroup));
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x001CA110 File Offset: 0x001C8310
		public static AchievementGroup GetRootAsAchievementGroup(ByteBuffer _bb, AchievementGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x001CA12D File Offset: 0x001C832D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x001CA13C File Offset: 0x001C833C
		public AchievementGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06004285 RID: 17029 RVA: 0x001CA14C File Offset: 0x001C834C
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06004286 RID: 17030 RVA: 0x001CA188 File Offset: 0x001C8388
		public int Category
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06004287 RID: 17031 RVA: 0x001CA1C4 File Offset: 0x001C83C4
		public int Sort
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

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06004288 RID: 17032 RVA: 0x001CA200 File Offset: 0x001C8400
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x001CA238 File Offset: 0x001C8438
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x001CA248 File Offset: 0x001C8448
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x001CA260 File Offset: 0x001C8460
		public string SmallIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x001CA298 File Offset: 0x001C8498
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x001CA2A8 File Offset: 0x001C84A8
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600428E RID: 17038 RVA: 0x001CA2C0 File Offset: 0x001C84C0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x001CA2F8 File Offset: 0x001C84F8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x001CA308 File Offset: 0x001C8508
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x001CA320 File Offset: 0x001C8520
		public string BackgroundIcon
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

		// Token: 0x06004292 RID: 17042 RVA: 0x001CA358 File Offset: 0x001C8558
		public Span<byte> GetBackgroundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x001CA368 File Offset: 0x001C8568
		public byte[] GetBackgroundIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x001CA380 File Offset: 0x001C8580
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x001CA3C0 File Offset: 0x001C85C0
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004A98 RID: 19096
		private Table __p;
	}
}
