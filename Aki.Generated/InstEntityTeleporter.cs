using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5B RID: 3675
	public struct InstEntityTeleporter : IFlatbufferObject
	{
		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06008BE4 RID: 35812 RVA: 0x00282DAC File Offset: 0x00280FAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008BE5 RID: 35813 RVA: 0x00282DB9 File Offset: 0x00280FB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008BE6 RID: 35814 RVA: 0x00282DC0 File Offset: 0x00280FC0
		public static InstEntityTeleporter GetRootAsInstEntityTeleporter(ByteBuffer _bb)
		{
			return InstEntityTeleporter.GetRootAsInstEntityTeleporter(_bb, default(InstEntityTeleporter));
		}

		// Token: 0x06008BE7 RID: 35815 RVA: 0x00282DDC File Offset: 0x00280FDC
		public static InstEntityTeleporter GetRootAsInstEntityTeleporter(ByteBuffer _bb, InstEntityTeleporter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008BE8 RID: 35816 RVA: 0x00282DF9 File Offset: 0x00280FF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008BE9 RID: 35817 RVA: 0x00282E08 File Offset: 0x00281008
		public InstEntityTeleporter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x06008BEA RID: 35818 RVA: 0x00282E18 File Offset: 0x00281018
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

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06008BEB RID: 35819 RVA: 0x00282E54 File Offset: 0x00281054
		public int InstId
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

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x06008BEC RID: 35820 RVA: 0x00282E90 File Offset: 0x00281090
		public bool IsUnlockDefault
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06008BED RID: 35821 RVA: 0x00282ED0 File Offset: 0x002810D0
		public int EntityConfigId
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

		// Token: 0x040053E3 RID: 21475
		private Table __p;
	}
}
