using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012BA RID: 4794
	public struct UiNormalConfig : IFlatbufferObject
	{
		// Token: 0x1700409E RID: 16542
		// (get) Token: 0x0600F3B0 RID: 62384 RVA: 0x00369958 File Offset: 0x00367B58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F3B1 RID: 62385 RVA: 0x00369965 File Offset: 0x00367B65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F3B2 RID: 62386 RVA: 0x0036996C File Offset: 0x00367B6C
		public static UiNormalConfig GetRootAsUiNormalConfig(ByteBuffer _bb)
		{
			return UiNormalConfig.GetRootAsUiNormalConfig(_bb, default(UiNormalConfig));
		}

		// Token: 0x0600F3B3 RID: 62387 RVA: 0x00369988 File Offset: 0x00367B88
		public static UiNormalConfig GetRootAsUiNormalConfig(ByteBuffer _bb, UiNormalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F3B4 RID: 62388 RVA: 0x003699A5 File Offset: 0x00367BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F3B5 RID: 62389 RVA: 0x003699B4 File Offset: 0x00367BB4
		public UiNormalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700409F RID: 16543
		// (get) Token: 0x0600F3B6 RID: 62390 RVA: 0x003699C4 File Offset: 0x00367BC4
		public string ViewName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F3B7 RID: 62391 RVA: 0x003699FB File Offset: 0x00367BFB
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F3B8 RID: 62392 RVA: 0x00369A0A File Offset: 0x00367C0A
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170040A0 RID: 16544
		// (get) Token: 0x0600F3B9 RID: 62393 RVA: 0x00369A24 File Offset: 0x00367C24
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005910 RID: 22800
		private Table __p;
	}
}
