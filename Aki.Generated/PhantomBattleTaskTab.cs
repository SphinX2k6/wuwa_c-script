using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDD RID: 3805
	public struct PhantomBattleTaskTab : IFlatbufferObject
	{
		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x0600A7F3 RID: 42995 RVA: 0x002B1BD5 File Offset: 0x002AFDD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x002B1BE2 File Offset: 0x002AFDE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A7F5 RID: 42997 RVA: 0x002B1BEC File Offset: 0x002AFDEC
		public static PhantomBattleTaskTab GetRootAsPhantomBattleTaskTab(ByteBuffer _bb)
		{
			return PhantomBattleTaskTab.GetRootAsPhantomBattleTaskTab(_bb, default(PhantomBattleTaskTab));
		}

		// Token: 0x0600A7F6 RID: 42998 RVA: 0x002B1C08 File Offset: 0x002AFE08
		public static PhantomBattleTaskTab GetRootAsPhantomBattleTaskTab(ByteBuffer _bb, PhantomBattleTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A7F7 RID: 42999 RVA: 0x002B1C25 File Offset: 0x002AFE25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A7F8 RID: 43000 RVA: 0x002B1C34 File Offset: 0x002AFE34
		public PhantomBattleTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x0600A7F9 RID: 43001 RVA: 0x002B1C44 File Offset: 0x002AFE44
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

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x0600A7FA RID: 43002 RVA: 0x002B1C80 File Offset: 0x002AFE80
		public string Title
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

		// Token: 0x0600A7FB RID: 43003 RVA: 0x002B1CB7 File Offset: 0x002AFEB7
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A7FC RID: 43004 RVA: 0x002B1CC6 File Offset: 0x002AFEC6
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x0600A7FD RID: 43005 RVA: 0x002B1CE0 File Offset: 0x002AFEE0
		public int Order
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

		// Token: 0x04004F9B RID: 20379
		private Table __p;
	}
}
