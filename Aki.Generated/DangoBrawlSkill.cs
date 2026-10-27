using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD4 RID: 3028
	public struct DangoBrawlSkill : IFlatbufferObject
	{
		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x0600601D RID: 24605 RVA: 0x0020EE74 File Offset: 0x0020D074
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600601E RID: 24606 RVA: 0x0020EE81 File Offset: 0x0020D081
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x0020EE88 File Offset: 0x0020D088
		public static DangoBrawlSkill GetRootAsDangoBrawlSkill(ByteBuffer _bb)
		{
			return DangoBrawlSkill.GetRootAsDangoBrawlSkill(_bb, default(DangoBrawlSkill));
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x0020EEA4 File Offset: 0x0020D0A4
		public static DangoBrawlSkill GetRootAsDangoBrawlSkill(ByteBuffer _bb, DangoBrawlSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x0020EEC1 File Offset: 0x0020D0C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x0020EED0 File Offset: 0x0020D0D0
		public DangoBrawlSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06006023 RID: 24611 RVA: 0x0020EEE0 File Offset: 0x0020D0E0
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

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06006024 RID: 24612 RVA: 0x0020EF1C File Offset: 0x0020D11C
		public bool IsOnly
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06006025 RID: 24613 RVA: 0x0020EF5C File Offset: 0x0020D15C
		public int PlayEffectId
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

		// Token: 0x04004C01 RID: 19457
		private Table __p;
	}
}
