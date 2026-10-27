using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AE RID: 4270
	public struct SignalDecodeGamePlay : IFlatbufferObject
	{
		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x0600D227 RID: 53799 RVA: 0x0030FD3F File Offset: 0x0030DF3F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D228 RID: 53800 RVA: 0x0030FD4C File Offset: 0x0030DF4C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D229 RID: 53801 RVA: 0x0030FD54 File Offset: 0x0030DF54
		public static SignalDecodeGamePlay GetRootAsSignalDecodeGamePlay(ByteBuffer _bb)
		{
			return SignalDecodeGamePlay.GetRootAsSignalDecodeGamePlay(_bb, default(SignalDecodeGamePlay));
		}

		// Token: 0x0600D22A RID: 53802 RVA: 0x0030FD70 File Offset: 0x0030DF70
		public static SignalDecodeGamePlay GetRootAsSignalDecodeGamePlay(ByteBuffer _bb, SignalDecodeGamePlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D22B RID: 53803 RVA: 0x0030FD8D File Offset: 0x0030DF8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D22C RID: 53804 RVA: 0x0030FD9C File Offset: 0x0030DF9C
		public SignalDecodeGamePlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x0600D22D RID: 53805 RVA: 0x0030FDAC File Offset: 0x0030DFAC
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

		// Token: 0x0600D22E RID: 53806 RVA: 0x0030FDE3 File Offset: 0x0030DFE3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600D22F RID: 53807 RVA: 0x0030FDF2 File Offset: 0x0030DFF2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0600D230 RID: 53808 RVA: 0x0030FE0C File Offset: 0x0030E00C
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

		// Token: 0x0600D231 RID: 53809 RVA: 0x0030FE43 File Offset: 0x0030E043
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D232 RID: 53810 RVA: 0x0030FE52 File Offset: 0x0030E052
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0600D233 RID: 53811 RVA: 0x0030FE6C File Offset: 0x0030E06C
		public int SignalData1
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

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0600D234 RID: 53812 RVA: 0x0030FEA8 File Offset: 0x0030E0A8
		public int SignalData2
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

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x0600D235 RID: 53813 RVA: 0x0030FEE8 File Offset: 0x0030E0E8
		public int SignalData3
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

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0600D236 RID: 53814 RVA: 0x0030FF28 File Offset: 0x0030E128
		public int SignalData4
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040051C1 RID: 20929
		private Table __p;
	}
}
