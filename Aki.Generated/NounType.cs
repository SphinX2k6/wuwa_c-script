using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7F RID: 3967
	public struct NounType : IFlatbufferObject
	{
		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x0600A6C1 RID: 42689 RVA: 0x002BE738 File Offset: 0x002BC938
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6C2 RID: 42690 RVA: 0x002BE745 File Offset: 0x002BC945
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A6C3 RID: 42691 RVA: 0x002BE74C File Offset: 0x002BC94C
		public static NounType GetRootAsNounType(ByteBuffer _bb)
		{
			return NounType.GetRootAsNounType(_bb, default(NounType));
		}

		// Token: 0x0600A6C4 RID: 42692 RVA: 0x002BE768 File Offset: 0x002BC968
		public static NounType GetRootAsNounType(ByteBuffer _bb, NounType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A6C5 RID: 42693 RVA: 0x002BE785 File Offset: 0x002BC985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A6C6 RID: 42694 RVA: 0x002BE794 File Offset: 0x002BC994
		public NounType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x0600A6C7 RID: 42695 RVA: 0x002BE7A4 File Offset: 0x002BC9A4
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

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x0600A6C8 RID: 42696 RVA: 0x002BE7E0 File Offset: 0x002BC9E0
		public string TypeDescription
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

		// Token: 0x0600A6C9 RID: 42697 RVA: 0x002BE817 File Offset: 0x002BCA17
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A6CA RID: 42698 RVA: 0x002BE826 File Offset: 0x002BCA26
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x0600A6CB RID: 42699 RVA: 0x002BE840 File Offset: 0x002BCA40
		public string Icon
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

		// Token: 0x0600A6CC RID: 42700 RVA: 0x002BE877 File Offset: 0x002BCA77
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A6CD RID: 42701 RVA: 0x002BE886 File Offset: 0x002BCA86
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005533 RID: 21811
		private Table __p;
	}
}
