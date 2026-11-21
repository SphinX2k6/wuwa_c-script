using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC9 RID: 3785
	public struct MailFilter : IFlatbufferObject
	{
		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x0600966F RID: 38511 RVA: 0x0029AEBC File Offset: 0x002990BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009670 RID: 38512 RVA: 0x0029AEC9 File Offset: 0x002990C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009671 RID: 38513 RVA: 0x0029AED0 File Offset: 0x002990D0
		public static MailFilter GetRootAsMailFilter(ByteBuffer _bb)
		{
			return MailFilter.GetRootAsMailFilter(_bb, default(MailFilter));
		}

		// Token: 0x06009672 RID: 38514 RVA: 0x0029AEEC File Offset: 0x002990EC
		public static MailFilter GetRootAsMailFilter(ByteBuffer _bb, MailFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009673 RID: 38515 RVA: 0x0029AF09 File Offset: 0x00299109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009674 RID: 38516 RVA: 0x0029AF18 File Offset: 0x00299118
		public MailFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x06009675 RID: 38517 RVA: 0x0029AF28 File Offset: 0x00299128
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

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x06009676 RID: 38518 RVA: 0x0029AF64 File Offset: 0x00299164
		public string IconPath
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

		// Token: 0x06009677 RID: 38519 RVA: 0x0029AF9B File Offset: 0x0029919B
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009678 RID: 38520 RVA: 0x0029AFAA File Offset: 0x002991AA
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x06009679 RID: 38521 RVA: 0x0029AFC4 File Offset: 0x002991C4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600967A RID: 38522 RVA: 0x0029AFFB File Offset: 0x002991FB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600967B RID: 38523 RVA: 0x0029B00A File Offset: 0x0029920A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005465 RID: 21605
		private Table __p;
	}
}
