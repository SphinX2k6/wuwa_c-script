using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C42 RID: 3138
	public struct CatchSignalGameplay : IFlatbufferObject
	{
		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06005838 RID: 22584 RVA: 0x0020F6CA File Offset: 0x0020D8CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x0020F6D7 File Offset: 0x0020D8D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x0020F6E0 File Offset: 0x0020D8E0
		public static CatchSignalGameplay GetRootAsCatchSignalGameplay(ByteBuffer _bb)
		{
			return CatchSignalGameplay.GetRootAsCatchSignalGameplay(_bb, default(CatchSignalGameplay));
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x0020F6FC File Offset: 0x0020D8FC
		public static CatchSignalGameplay GetRootAsCatchSignalGameplay(ByteBuffer _bb, CatchSignalGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x0020F719 File Offset: 0x0020D919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x0020F728 File Offset: 0x0020D928
		public CatchSignalGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600583E RID: 22590 RVA: 0x0020F738 File Offset: 0x0020D938
		public string Id
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

		// Token: 0x0600583F RID: 22591 RVA: 0x0020F76F File Offset: 0x0020D96F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x0020F77E File Offset: 0x0020D97E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06005841 RID: 22593 RVA: 0x0020F798 File Offset: 0x0020D998
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

		// Token: 0x06005842 RID: 22594 RVA: 0x0020F7CF File Offset: 0x0020D9CF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x0020F7DE File Offset: 0x0020D9DE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06005844 RID: 22596 RVA: 0x0020F7F8 File Offset: 0x0020D9F8
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06005845 RID: 22597 RVA: 0x0020F834 File Offset: 0x0020DA34
		public string MorseCode
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x0020F86C File Offset: 0x0020DA6C
		public Span<byte> GetMorseCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x0020F87C File Offset: 0x0020DA7C
		public byte[] GetMorseCodeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06005848 RID: 22600 RVA: 0x0020F894 File Offset: 0x0020DA94
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005142 RID: 20802
		private Table __p;
	}
}
