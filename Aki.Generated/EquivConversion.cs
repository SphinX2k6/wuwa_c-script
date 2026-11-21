using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D22 RID: 3362
	public struct EquivConversion : IFlatbufferObject
	{
		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06007046 RID: 28742 RVA: 0x00244A55 File Offset: 0x00242C55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007047 RID: 28743 RVA: 0x00244A62 File Offset: 0x00242C62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007048 RID: 28744 RVA: 0x00244A6C File Offset: 0x00242C6C
		public static EquivConversion GetRootAsEquivConversion(ByteBuffer _bb)
		{
			return EquivConversion.GetRootAsEquivConversion(_bb, default(EquivConversion));
		}

		// Token: 0x06007049 RID: 28745 RVA: 0x00244A88 File Offset: 0x00242C88
		public static EquivConversion GetRootAsEquivConversion(ByteBuffer _bb, EquivConversion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600704A RID: 28746 RVA: 0x00244AA5 File Offset: 0x00242CA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600704B RID: 28747 RVA: 0x00244AB4 File Offset: 0x00242CB4
		public EquivConversion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x0600704C RID: 28748 RVA: 0x00244AC4 File Offset: 0x00242CC4
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

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x0600704D RID: 28749 RVA: 0x00244B00 File Offset: 0x00242D00
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

		// Token: 0x04005262 RID: 21090
		private Table __p;
	}
}
