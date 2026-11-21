using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C4 RID: 4548
	public struct SkillWeather : IFlatbufferObject
	{
		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0600DE13 RID: 56851 RVA: 0x003393DA File Offset: 0x003375DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE14 RID: 56852 RVA: 0x003393E7 File Offset: 0x003375E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE15 RID: 56853 RVA: 0x003393F0 File Offset: 0x003375F0
		public static SkillWeather GetRootAsSkillWeather(ByteBuffer _bb)
		{
			return SkillWeather.GetRootAsSkillWeather(_bb, default(SkillWeather));
		}

		// Token: 0x0600DE16 RID: 56854 RVA: 0x0033940C File Offset: 0x0033760C
		public static SkillWeather GetRootAsSkillWeather(ByteBuffer _bb, SkillWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE17 RID: 56855 RVA: 0x00339429 File Offset: 0x00337629
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE18 RID: 56856 RVA: 0x00339438 File Offset: 0x00337638
		public SkillWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0600DE19 RID: 56857 RVA: 0x00339448 File Offset: 0x00337648
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

		// Token: 0x040057FA RID: 22522
		private Table __p;
	}
}
