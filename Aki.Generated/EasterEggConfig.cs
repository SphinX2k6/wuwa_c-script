using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFB RID: 3323
	public struct EasterEggConfig : IFlatbufferObject
	{
		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06006CDF RID: 27871 RVA: 0x0023DF22 File Offset: 0x0023C122
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006CE0 RID: 27872 RVA: 0x0023DF2F File Offset: 0x0023C12F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006CE1 RID: 27873 RVA: 0x0023DF38 File Offset: 0x0023C138
		public static EasterEggConfig GetRootAsEasterEggConfig(ByteBuffer _bb)
		{
			return EasterEggConfig.GetRootAsEasterEggConfig(_bb, default(EasterEggConfig));
		}

		// Token: 0x06006CE2 RID: 27874 RVA: 0x0023DF54 File Offset: 0x0023C154
		public static EasterEggConfig GetRootAsEasterEggConfig(ByteBuffer _bb, EasterEggConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x0023DF71 File Offset: 0x0023C171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x0023DF80 File Offset: 0x0023C180
		public EasterEggConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06006CE5 RID: 27877 RVA: 0x0023DF90 File Offset: 0x0023C190
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

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06006CE6 RID: 27878 RVA: 0x0023DFCC File Offset: 0x0023C1CC
		public string Description
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

		// Token: 0x06006CE7 RID: 27879 RVA: 0x0023E003 File Offset: 0x0023C203
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x0023E012 File Offset: 0x0023C212
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400523B RID: 21051
		private Table __p;
	}
}
