using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFB RID: 4091
	public struct RogueResEffect : IFlatbufferObject
	{
		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x0600C1BD RID: 49597 RVA: 0x002EB081 File Offset: 0x002E9281
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C1BE RID: 49598 RVA: 0x002EB08E File Offset: 0x002E928E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C1BF RID: 49599 RVA: 0x002EB098 File Offset: 0x002E9298
		public static RogueResEffect GetRootAsRogueResEffect(ByteBuffer _bb)
		{
			return RogueResEffect.GetRootAsRogueResEffect(_bb, default(RogueResEffect));
		}

		// Token: 0x0600C1C0 RID: 49600 RVA: 0x002EB0B4 File Offset: 0x002E92B4
		public static RogueResEffect GetRootAsRogueResEffect(ByteBuffer _bb, RogueResEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C1C1 RID: 49601 RVA: 0x002EB0D1 File Offset: 0x002E92D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C1C2 RID: 49602 RVA: 0x002EB0E0 File Offset: 0x002E92E0
		public RogueResEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x0600C1C3 RID: 49603 RVA: 0x002EB0F0 File Offset: 0x002E92F0
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

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x0600C1C4 RID: 49604 RVA: 0x002EB12C File Offset: 0x002E932C
		public int Tag
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

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x0600C1C5 RID: 49605 RVA: 0x002EB168 File Offset: 0x002E9368
		public int DescIntParam
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

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x0600C1C6 RID: 49606 RVA: 0x002EB1A4 File Offset: 0x002E93A4
		public string DescParam
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

		// Token: 0x0600C1C7 RID: 49607 RVA: 0x002EB1DC File Offset: 0x002E93DC
		public Span<byte> GetDescParamBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C1C8 RID: 49608 RVA: 0x002EB1EC File Offset: 0x002E93EC
		public byte[] GetDescParamArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040050E3 RID: 20707
		private Table __p;
	}
}
