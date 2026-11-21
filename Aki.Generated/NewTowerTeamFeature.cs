using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7B RID: 3963
	public struct NewTowerTeamFeature : IFlatbufferObject
	{
		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x0600A657 RID: 42583 RVA: 0x002BD89C File Offset: 0x002BBA9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A658 RID: 42584 RVA: 0x002BD8A9 File Offset: 0x002BBAA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A659 RID: 42585 RVA: 0x002BD8B0 File Offset: 0x002BBAB0
		public static NewTowerTeamFeature GetRootAsNewTowerTeamFeature(ByteBuffer _bb)
		{
			return NewTowerTeamFeature.GetRootAsNewTowerTeamFeature(_bb, default(NewTowerTeamFeature));
		}

		// Token: 0x0600A65A RID: 42586 RVA: 0x002BD8CC File Offset: 0x002BBACC
		public static NewTowerTeamFeature GetRootAsNewTowerTeamFeature(ByteBuffer _bb, NewTowerTeamFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A65B RID: 42587 RVA: 0x002BD8E9 File Offset: 0x002BBAE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A65C RID: 42588 RVA: 0x002BD8F8 File Offset: 0x002BBAF8
		public NewTowerTeamFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x0600A65D RID: 42589 RVA: 0x002BD908 File Offset: 0x002BBB08
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

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x0600A65E RID: 42590 RVA: 0x002BD944 File Offset: 0x002BBB44
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

		// Token: 0x0600A65F RID: 42591 RVA: 0x002BD97B File Offset: 0x002BBB7B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A660 RID: 42592 RVA: 0x002BD98A File Offset: 0x002BBB8A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x0600A661 RID: 42593 RVA: 0x002BD9A4 File Offset: 0x002BBBA4
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

		// Token: 0x0600A662 RID: 42594 RVA: 0x002BD9DB File Offset: 0x002BBBDB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A663 RID: 42595 RVA: 0x002BD9EA File Offset: 0x002BBBEA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400552E RID: 21806
		private Table __p;
	}
}
