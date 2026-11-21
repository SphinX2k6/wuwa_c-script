using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAE RID: 2990
	public struct AdventureTaskChapter : IFlatbufferObject
	{
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060049B8 RID: 18872 RVA: 0x001EE1D0 File Offset: 0x001EC3D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x001EE1DD File Offset: 0x001EC3DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x001EE1E4 File Offset: 0x001EC3E4
		public static AdventureTaskChapter GetRootAsAdventureTaskChapter(ByteBuffer _bb)
		{
			return AdventureTaskChapter.GetRootAsAdventureTaskChapter(_bb, default(AdventureTaskChapter));
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x001EE200 File Offset: 0x001EC400
		public static AdventureTaskChapter GetRootAsAdventureTaskChapter(ByteBuffer _bb, AdventureTaskChapter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x001EE21D File Offset: 0x001EC41D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x001EE22C File Offset: 0x001EC42C
		public AdventureTaskChapter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060049BE RID: 18878 RVA: 0x001EE23C File Offset: 0x001EC43C
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

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060049BF RID: 18879 RVA: 0x001EE278 File Offset: 0x001EC478
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x001EE2AF File Offset: 0x001EC4AF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x001EE2BE File Offset: 0x001EC4BE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060049C2 RID: 18882 RVA: 0x001EE2D8 File Offset: 0x001EC4D8
		public int DropIds
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x001EE314 File Offset: 0x001EC514
		public int UnLockCondition
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

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060049C4 RID: 18884 RVA: 0x001EE354 File Offset: 0x001EC554
		public int LevelUnlockCount
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

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060049C5 RID: 18885 RVA: 0x001EE394 File Offset: 0x001EC594
		public int RewardUnlockCount
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

		// Token: 0x0400508C RID: 20620
		private Table __p;
	}
}
