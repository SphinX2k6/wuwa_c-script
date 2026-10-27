using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107C RID: 4220
	public struct RoverRogueIncreaseType : IFlatbufferObject
	{
		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0600CDD9 RID: 52697 RVA: 0x0030625D File Offset: 0x0030445D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CDDA RID: 52698 RVA: 0x0030626A File Offset: 0x0030446A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CDDB RID: 52699 RVA: 0x00306274 File Offset: 0x00304474
		public static RoverRogueIncreaseType GetRootAsRoverRogueIncreaseType(ByteBuffer _bb)
		{
			return RoverRogueIncreaseType.GetRootAsRoverRogueIncreaseType(_bb, default(RoverRogueIncreaseType));
		}

		// Token: 0x0600CDDC RID: 52700 RVA: 0x00306290 File Offset: 0x00304490
		public static RoverRogueIncreaseType GetRootAsRoverRogueIncreaseType(ByteBuffer _bb, RoverRogueIncreaseType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDDD RID: 52701 RVA: 0x003062AD File Offset: 0x003044AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDDE RID: 52702 RVA: 0x003062BC File Offset: 0x003044BC
		public RoverRogueIncreaseType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0600CDDF RID: 52703 RVA: 0x003062CC File Offset: 0x003044CC
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

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x0600CDE0 RID: 52704 RVA: 0x00306308 File Offset: 0x00304508
		public string Icon
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

		// Token: 0x0600CDE1 RID: 52705 RVA: 0x0030633F File Offset: 0x0030453F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CDE2 RID: 52706 RVA: 0x0030634E File Offset: 0x0030454E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005186 RID: 20870
		private Table __p;
	}
}
