using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D04 RID: 3332
	public struct EffectCsvConfig : IFlatbufferObject
	{
		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06006D87 RID: 28039 RVA: 0x0023F4E9 File Offset: 0x0023D6E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x0023F4F6 File Offset: 0x0023D6F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x0023F500 File Offset: 0x0023D700
		public static EffectCsvConfig GetRootAsEffectCsvConfig(ByteBuffer _bb)
		{
			return EffectCsvConfig.GetRootAsEffectCsvConfig(_bb, default(EffectCsvConfig));
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x0023F51C File Offset: 0x0023D71C
		public static EffectCsvConfig GetRootAsEffectCsvConfig(ByteBuffer _bb, EffectCsvConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x0023F539 File Offset: 0x0023D739
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x0023F548 File Offset: 0x0023D748
		public EffectCsvConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06006D8D RID: 28045 RVA: 0x0023F558 File Offset: 0x0023D758
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

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06006D8E RID: 28046 RVA: 0x0023F594 File Offset: 0x0023D794
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

		// Token: 0x06006D8F RID: 28047 RVA: 0x0023F5CB File Offset: 0x0023D7CB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x0023F5DA File Offset: 0x0023D7DA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06006D91 RID: 28049 RVA: 0x0023F5F4 File Offset: 0x0023D7F4
		public int Type
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

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06006D92 RID: 28050 RVA: 0x0023F630 File Offset: 0x0023D830
		public string Data
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

		// Token: 0x06006D93 RID: 28051 RVA: 0x0023F668 File Offset: 0x0023D868
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x0023F678 File Offset: 0x0023D878
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005244 RID: 21060
		private Table __p;
	}
}
