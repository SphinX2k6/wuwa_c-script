using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E91 RID: 3729
	public struct NewTowerScoreReward : IFlatbufferObject
	{
		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x06009FC6 RID: 40902 RVA: 0x0029F43C File Offset: 0x0029D63C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009FC7 RID: 40903 RVA: 0x0029F449 File Offset: 0x0029D649
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009FC8 RID: 40904 RVA: 0x0029F450 File Offset: 0x0029D650
		public static NewTowerScoreReward GetRootAsNewTowerScoreReward(ByteBuffer _bb)
		{
			return NewTowerScoreReward.GetRootAsNewTowerScoreReward(_bb, default(NewTowerScoreReward));
		}

		// Token: 0x06009FC9 RID: 40905 RVA: 0x0029F46C File Offset: 0x0029D66C
		public static NewTowerScoreReward GetRootAsNewTowerScoreReward(ByteBuffer _bb, NewTowerScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009FCA RID: 40906 RVA: 0x0029F489 File Offset: 0x0029D689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009FCB RID: 40907 RVA: 0x0029F498 File Offset: 0x0029D698
		public NewTowerScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x06009FCC RID: 40908 RVA: 0x0029F4A8 File Offset: 0x0029D6A8
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

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x06009FCD RID: 40909 RVA: 0x0029F4E4 File Offset: 0x0029D6E4
		public int Level
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

		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x06009FCE RID: 40910 RVA: 0x0029F520 File Offset: 0x0029D720
		public int Index
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

		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x06009FCF RID: 40911 RVA: 0x0029F55C File Offset: 0x0029D75C
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x06009FD0 RID: 40912 RVA: 0x0029F59C File Offset: 0x0029D79C
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009FD1 RID: 40913 RVA: 0x0029F5D4 File Offset: 0x0029D7D4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009FD2 RID: 40914 RVA: 0x0029F5E4 File Offset: 0x0029D7E4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F44 RID: 20292
		private Table __p;
	}
}
