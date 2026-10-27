using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BB RID: 4283
	public struct SkillButtonText : IFlatbufferObject
	{
		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x0600D417 RID: 54295 RVA: 0x00314B8C File Offset: 0x00312D8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D418 RID: 54296 RVA: 0x00314B99 File Offset: 0x00312D99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D419 RID: 54297 RVA: 0x00314BA0 File Offset: 0x00312DA0
		public static SkillButtonText GetRootAsSkillButtonText(ByteBuffer _bb)
		{
			return SkillButtonText.GetRootAsSkillButtonText(_bb, default(SkillButtonText));
		}

		// Token: 0x0600D41A RID: 54298 RVA: 0x00314BBC File Offset: 0x00312DBC
		public static SkillButtonText GetRootAsSkillButtonText(ByteBuffer _bb, SkillButtonText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D41B RID: 54299 RVA: 0x00314BD9 File Offset: 0x00312DD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D41C RID: 54300 RVA: 0x00314BE8 File Offset: 0x00312DE8
		public SkillButtonText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0600D41D RID: 54301 RVA: 0x00314BF8 File Offset: 0x00312DF8
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

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0600D41E RID: 54302 RVA: 0x00314C34 File Offset: 0x00312E34
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

		// Token: 0x0600D41F RID: 54303 RVA: 0x00314C6B File Offset: 0x00312E6B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D420 RID: 54304 RVA: 0x00314C7A File Offset: 0x00312E7A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040051DA RID: 20954
		private Table __p;
	}
}
