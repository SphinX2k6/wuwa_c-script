using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE7 RID: 3303
	public struct GachaWeaponSeqConfig : IFlatbufferObject
	{
		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x060078C8 RID: 30920 RVA: 0x0024745C File Offset: 0x0024565C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060078C9 RID: 30921 RVA: 0x00247469 File Offset: 0x00245669
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060078CA RID: 30922 RVA: 0x00247470 File Offset: 0x00245670
		public static GachaWeaponSeqConfig GetRootAsGachaWeaponSeqConfig(ByteBuffer _bb)
		{
			return GachaWeaponSeqConfig.GetRootAsGachaWeaponSeqConfig(_bb, default(GachaWeaponSeqConfig));
		}

		// Token: 0x060078CB RID: 30923 RVA: 0x0024748C File Offset: 0x0024568C
		public static GachaWeaponSeqConfig GetRootAsGachaWeaponSeqConfig(ByteBuffer _bb, GachaWeaponSeqConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060078CC RID: 30924 RVA: 0x002474A9 File Offset: 0x002456A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060078CD RID: 30925 RVA: 0x002474B8 File Offset: 0x002456B8
		public GachaWeaponSeqConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x060078CE RID: 30926 RVA: 0x002474C8 File Offset: 0x002456C8
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

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x060078CF RID: 30927 RVA: 0x00247504 File Offset: 0x00245704
		public string SequencePath
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

		// Token: 0x060078D0 RID: 30928 RVA: 0x0024753B File Offset: 0x0024573B
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x0024754A File Offset: 0x0024574A
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x060078D2 RID: 30930 RVA: 0x00247564 File Offset: 0x00245764
		public int BeforeEndFrame
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 150;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D58 RID: 19800
		private Table __p;
	}
}
