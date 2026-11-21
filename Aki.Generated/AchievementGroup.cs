using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B93 RID: 2963
	public struct AchievementGroup : IFlatbufferObject
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x001E9324 File Offset: 0x001E7524
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x001E9331 File Offset: 0x001E7531
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x001E9338 File Offset: 0x001E7538
		public static AchievementGroup GetRootAsAchievementGroup(ByteBuffer _bb)
		{
			return AchievementGroup.GetRootAsAchievementGroup(_bb, default(AchievementGroup));
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x001E9354 File Offset: 0x001E7554
		public static AchievementGroup GetRootAsAchievementGroup(ByteBuffer _bb, AchievementGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x001E9371 File Offset: 0x001E7571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x001E9380 File Offset: 0x001E7580
		public AchievementGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06004783 RID: 18307 RVA: 0x001E9390 File Offset: 0x001E7590
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
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x001E93CC File Offset: 0x001E75CC
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
		// (get) Token: 0x06004785 RID: 18309 RVA: 0x001E9408 File Offset: 0x001E7608
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
		// (get) Token: 0x06004786 RID: 18310 RVA: 0x001E9444 File Offset: 0x001E7644
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

		// Token: 0x06004787 RID: 18311 RVA: 0x001E947C File Offset: 0x001E767C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x001E948C File Offset: 0x001E768C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06004789 RID: 18313 RVA: 0x001E94A4 File Offset: 0x001E76A4
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

		// Token: 0x0600478A RID: 18314 RVA: 0x001E94DC File Offset: 0x001E76DC
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x001E94EC File Offset: 0x001E76EC
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x001E9504 File Offset: 0x001E7704
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

		// Token: 0x0600478D RID: 18317 RVA: 0x001E953C File Offset: 0x001E773C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x001E954C File Offset: 0x001E774C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600478F RID: 18319 RVA: 0x001E9564 File Offset: 0x001E7764
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

		// Token: 0x06004790 RID: 18320 RVA: 0x001E959C File Offset: 0x001E779C
		public Span<byte> GetBackgroundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x001E95AC File Offset: 0x001E77AC
		public byte[] GetBackgroundIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x001E95C4 File Offset: 0x001E77C4
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
		// (get) Token: 0x06004793 RID: 18323 RVA: 0x001E9604 File Offset: 0x001E7804
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400506B RID: 20587
		private Table __p;
	}
}
