using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE7 RID: 4071
	public struct RogueLimitTimeReward : IFlatbufferObject
	{
		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x0600BFBE RID: 49086 RVA: 0x002E66BC File Offset: 0x002E48BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BFBF RID: 49087 RVA: 0x002E66C9 File Offset: 0x002E48C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BFC0 RID: 49088 RVA: 0x002E66D0 File Offset: 0x002E48D0
		public static RogueLimitTimeReward GetRootAsRogueLimitTimeReward(ByteBuffer _bb)
		{
			return RogueLimitTimeReward.GetRootAsRogueLimitTimeReward(_bb, default(RogueLimitTimeReward));
		}

		// Token: 0x0600BFC1 RID: 49089 RVA: 0x002E66EC File Offset: 0x002E48EC
		public static RogueLimitTimeReward GetRootAsRogueLimitTimeReward(ByteBuffer _bb, RogueLimitTimeReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BFC2 RID: 49090 RVA: 0x002E6709 File Offset: 0x002E4909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BFC3 RID: 49091 RVA: 0x002E6718 File Offset: 0x002E4918
		public RogueLimitTimeReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x0600BFC4 RID: 49092 RVA: 0x002E6728 File Offset: 0x002E4928
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

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x0600BFC5 RID: 49093 RVA: 0x002E6764 File Offset: 0x002E4964
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

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x0600BFC6 RID: 49094 RVA: 0x002E67A0 File Offset: 0x002E49A0
		public string TargetName
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

		// Token: 0x0600BFC7 RID: 49095 RVA: 0x002E67D7 File Offset: 0x002E49D7
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BFC8 RID: 49096 RVA: 0x002E67E6 File Offset: 0x002E49E6
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x0600BFC9 RID: 49097 RVA: 0x002E6800 File Offset: 0x002E4A00
		public int Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x0600BFCA RID: 49098 RVA: 0x002E6840 File Offset: 0x002E4A40
		public int TargetReward
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

		// Token: 0x040050C6 RID: 20678
		private Table __p;
	}
}
