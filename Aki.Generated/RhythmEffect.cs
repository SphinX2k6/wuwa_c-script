using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC1 RID: 4033
	public struct RhythmEffect : IFlatbufferObject
	{
		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x0600BC50 RID: 48208 RVA: 0x002DED14 File Offset: 0x002DCF14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC51 RID: 48209 RVA: 0x002DED21 File Offset: 0x002DCF21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC52 RID: 48210 RVA: 0x002DED28 File Offset: 0x002DCF28
		public static RhythmEffect GetRootAsRhythmEffect(ByteBuffer _bb)
		{
			return RhythmEffect.GetRootAsRhythmEffect(_bb, default(RhythmEffect));
		}

		// Token: 0x0600BC53 RID: 48211 RVA: 0x002DED44 File Offset: 0x002DCF44
		public static RhythmEffect GetRootAsRhythmEffect(ByteBuffer _bb, RhythmEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC54 RID: 48212 RVA: 0x002DED61 File Offset: 0x002DCF61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC55 RID: 48213 RVA: 0x002DED70 File Offset: 0x002DCF70
		public RhythmEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x0600BC56 RID: 48214 RVA: 0x002DED80 File Offset: 0x002DCF80
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

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x0600BC57 RID: 48215 RVA: 0x002DEDBC File Offset: 0x002DCFBC
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

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x0600BC58 RID: 48216 RVA: 0x002DEDF8 File Offset: 0x002DCFF8
		public string Param1
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

		// Token: 0x0600BC59 RID: 48217 RVA: 0x002DEE2F File Offset: 0x002DD02F
		public Span<byte> GetParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BC5A RID: 48218 RVA: 0x002DEE3E File Offset: 0x002DD03E
		public byte[] GetParam1Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x0600BC5B RID: 48219 RVA: 0x002DEE58 File Offset: 0x002DD058
		public string Param2
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

		// Token: 0x0600BC5C RID: 48220 RVA: 0x002DEE90 File Offset: 0x002DD090
		public Span<byte> GetParam2Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BC5D RID: 48221 RVA: 0x002DEEA0 File Offset: 0x002DD0A0
		public byte[] GetParam2Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x0600BC5E RID: 48222 RVA: 0x002DEEB8 File Offset: 0x002DD0B8
		public string Param3
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

		// Token: 0x0600BC5F RID: 48223 RVA: 0x002DEEF0 File Offset: 0x002DD0F0
		public Span<byte> GetParam3Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BC60 RID: 48224 RVA: 0x002DEF00 File Offset: 0x002DD100
		public byte[] GetParam3Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400509B RID: 20635
		private Table __p;
	}
}
