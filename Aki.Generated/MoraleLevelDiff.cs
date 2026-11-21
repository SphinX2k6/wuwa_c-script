using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0C RID: 3852
	public struct MoraleLevelDiff : IFlatbufferObject
	{
		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06009C52 RID: 40018 RVA: 0x002A7B4E File Offset: 0x002A5D4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C53 RID: 40019 RVA: 0x002A7B5B File Offset: 0x002A5D5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C54 RID: 40020 RVA: 0x002A7B64 File Offset: 0x002A5D64
		public static MoraleLevelDiff GetRootAsMoraleLevelDiff(ByteBuffer _bb)
		{
			return MoraleLevelDiff.GetRootAsMoraleLevelDiff(_bb, default(MoraleLevelDiff));
		}

		// Token: 0x06009C55 RID: 40021 RVA: 0x002A7B80 File Offset: 0x002A5D80
		public static MoraleLevelDiff GetRootAsMoraleLevelDiff(ByteBuffer _bb, MoraleLevelDiff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C56 RID: 40022 RVA: 0x002A7B9D File Offset: 0x002A5D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C57 RID: 40023 RVA: 0x002A7BAC File Offset: 0x002A5DAC
		public MoraleLevelDiff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06009C58 RID: 40024 RVA: 0x002A7BBC File Offset: 0x002A5DBC
		public int Level
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

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x06009C59 RID: 40025 RVA: 0x002A7BF8 File Offset: 0x002A5DF8
		public int DamageRatio
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

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x06009C5A RID: 40026 RVA: 0x002A7C34 File Offset: 0x002A5E34
		public int DropRatio
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040054B1 RID: 21681
		private Table __p;
	}
}
