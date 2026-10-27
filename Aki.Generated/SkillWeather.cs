using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C9 RID: 4297
	public struct SkillWeather : IFlatbufferObject
	{
		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x0600D636 RID: 54838 RVA: 0x0031A3E6 File Offset: 0x003185E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D637 RID: 54839 RVA: 0x0031A3F3 File Offset: 0x003185F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D638 RID: 54840 RVA: 0x0031A3FC File Offset: 0x003185FC
		public static SkillWeather GetRootAsSkillWeather(ByteBuffer _bb)
		{
			return SkillWeather.GetRootAsSkillWeather(_bb, default(SkillWeather));
		}

		// Token: 0x0600D639 RID: 54841 RVA: 0x0031A418 File Offset: 0x00318618
		public static SkillWeather GetRootAsSkillWeather(ByteBuffer _bb, SkillWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D63A RID: 54842 RVA: 0x0031A435 File Offset: 0x00318635
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D63B RID: 54843 RVA: 0x0031A444 File Offset: 0x00318644
		public SkillWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x0600D63C RID: 54844 RVA: 0x0031A454 File Offset: 0x00318654
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

		// Token: 0x040051FB RID: 20987
		private Table __p;
	}
}
