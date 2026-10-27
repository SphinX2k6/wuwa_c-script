using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100C RID: 4108
	public struct RogueResMoodRule : IFlatbufferObject
	{
		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x0600C36B RID: 50027 RVA: 0x002EEB46 File Offset: 0x002ECD46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C36C RID: 50028 RVA: 0x002EEB53 File Offset: 0x002ECD53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C36D RID: 50029 RVA: 0x002EEB5C File Offset: 0x002ECD5C
		public static RogueResMoodRule GetRootAsRogueResMoodRule(ByteBuffer _bb)
		{
			return RogueResMoodRule.GetRootAsRogueResMoodRule(_bb, default(RogueResMoodRule));
		}

		// Token: 0x0600C36E RID: 50030 RVA: 0x002EEB78 File Offset: 0x002ECD78
		public static RogueResMoodRule GetRootAsRogueResMoodRule(ByteBuffer _bb, RogueResMoodRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C36F RID: 50031 RVA: 0x002EEB95 File Offset: 0x002ECD95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C370 RID: 50032 RVA: 0x002EEBA4 File Offset: 0x002ECDA4
		public RogueResMoodRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x0600C371 RID: 50033 RVA: 0x002EEBB4 File Offset: 0x002ECDB4
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

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x0600C372 RID: 50034 RVA: 0x002EEBF0 File Offset: 0x002ECDF0
		public int Type
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

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x0600C373 RID: 50035 RVA: 0x002EEC2C File Offset: 0x002ECE2C
		public string FloatTips
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

		// Token: 0x0600C374 RID: 50036 RVA: 0x002EEC63 File Offset: 0x002ECE63
		public Span<byte> GetFloatTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C375 RID: 50037 RVA: 0x002EEC72 File Offset: 0x002ECE72
		public byte[] GetFloatTipsArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x0600C376 RID: 50038 RVA: 0x002EEC8C File Offset: 0x002ECE8C
		public string MapMusicStateSwitch
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

		// Token: 0x0600C377 RID: 50039 RVA: 0x002EECC4 File Offset: 0x002ECEC4
		public Span<byte> GetMapMusicStateSwitchBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C378 RID: 50040 RVA: 0x002EECD4 File Offset: 0x002ECED4
		public byte[] GetMapMusicStateSwitchArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040050F9 RID: 20729
		private Table __p;
	}
}
