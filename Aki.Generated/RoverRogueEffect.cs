using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001171 RID: 4465
	public struct RoverRogueEffect : IFlatbufferObject
	{
		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x0600D563 RID: 54627 RVA: 0x003250DE File Offset: 0x003232DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D564 RID: 54628 RVA: 0x003250EB File Offset: 0x003232EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D565 RID: 54629 RVA: 0x003250F4 File Offset: 0x003232F4
		public static RoverRogueEffect GetRootAsRoverRogueEffect(ByteBuffer _bb)
		{
			return RoverRogueEffect.GetRootAsRoverRogueEffect(_bb, default(RoverRogueEffect));
		}

		// Token: 0x0600D566 RID: 54630 RVA: 0x00325110 File Offset: 0x00323310
		public static RoverRogueEffect GetRootAsRoverRogueEffect(ByteBuffer _bb, RoverRogueEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D567 RID: 54631 RVA: 0x0032512D File Offset: 0x0032332D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D568 RID: 54632 RVA: 0x0032513C File Offset: 0x0032333C
		public RoverRogueEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x0600D569 RID: 54633 RVA: 0x0032514C File Offset: 0x0032334C
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

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x0600D56A RID: 54634 RVA: 0x00325188 File Offset: 0x00323388
		public string Type
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

		// Token: 0x0600D56B RID: 54635 RVA: 0x003251BF File Offset: 0x003233BF
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D56C RID: 54636 RVA: 0x003251CE File Offset: 0x003233CE
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x0600D56D RID: 54637 RVA: 0x003251E8 File Offset: 0x003233E8
		public int Desc
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

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x0600D56E RID: 54638 RVA: 0x00325224 File Offset: 0x00323424
		public bool ClientDisplay
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400577F RID: 22399
		private Table __p;
	}
}
