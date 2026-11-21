using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117D RID: 4477
	public struct RoverRogueReward : IFlatbufferObject
	{
		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x0600D676 RID: 54902 RVA: 0x003274A8 File Offset: 0x003256A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D677 RID: 54903 RVA: 0x003274B5 File Offset: 0x003256B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D678 RID: 54904 RVA: 0x003274BC File Offset: 0x003256BC
		public static RoverRogueReward GetRootAsRoverRogueReward(ByteBuffer _bb)
		{
			return RoverRogueReward.GetRootAsRoverRogueReward(_bb, default(RoverRogueReward));
		}

		// Token: 0x0600D679 RID: 54905 RVA: 0x003274D8 File Offset: 0x003256D8
		public static RoverRogueReward GetRootAsRoverRogueReward(ByteBuffer _bb, RoverRogueReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D67A RID: 54906 RVA: 0x003274F5 File Offset: 0x003256F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D67B RID: 54907 RVA: 0x00327504 File Offset: 0x00325704
		public RoverRogueReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0600D67C RID: 54908 RVA: 0x00327514 File Offset: 0x00325714
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

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x0600D67D RID: 54909 RVA: 0x00327550 File Offset: 0x00325750
		public int ActivityId
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

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x0600D67E RID: 54910 RVA: 0x0032758C File Offset: 0x0032578C
		public int DropId
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

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x0600D67F RID: 54911 RVA: 0x003275C8 File Offset: 0x003257C8
		public string Name
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

		// Token: 0x0600D680 RID: 54912 RVA: 0x00327600 File Offset: 0x00325800
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D681 RID: 54913 RVA: 0x00327610 File Offset: 0x00325810
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x0600D682 RID: 54914 RVA: 0x00327628 File Offset: 0x00325828
		public int SortId
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

		// Token: 0x0400578C RID: 22412
		private Table __p;
	}
}
