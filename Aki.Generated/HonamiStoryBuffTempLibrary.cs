using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E17 RID: 3607
	public struct HonamiStoryBuffTempLibrary : IFlatbufferObject
	{
		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x0600855D RID: 34141 RVA: 0x00274760 File Offset: 0x00272960
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600855E RID: 34142 RVA: 0x0027476D File Offset: 0x0027296D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600855F RID: 34143 RVA: 0x00274774 File Offset: 0x00272974
		public static HonamiStoryBuffTempLibrary GetRootAsHonamiStoryBuffTempLibrary(ByteBuffer _bb)
		{
			return HonamiStoryBuffTempLibrary.GetRootAsHonamiStoryBuffTempLibrary(_bb, default(HonamiStoryBuffTempLibrary));
		}

		// Token: 0x06008560 RID: 34144 RVA: 0x00274790 File Offset: 0x00272990
		public static HonamiStoryBuffTempLibrary GetRootAsHonamiStoryBuffTempLibrary(ByteBuffer _bb, HonamiStoryBuffTempLibrary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008561 RID: 34145 RVA: 0x002747AD File Offset: 0x002729AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008562 RID: 34146 RVA: 0x002747BC File Offset: 0x002729BC
		public HonamiStoryBuffTempLibrary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06008563 RID: 34147 RVA: 0x002747CC File Offset: 0x002729CC
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

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06008564 RID: 34148 RVA: 0x00274808 File Offset: 0x00272A08
		public int BuffTermpId
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

		// Token: 0x04005390 RID: 21392
		private Table __p;
	}
}
