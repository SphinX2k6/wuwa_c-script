using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3F RID: 3391
	public struct HonamiStoryMarkWhiteList : IFlatbufferObject
	{
		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06008066 RID: 32870 RVA: 0x00258694 File Offset: 0x00256894
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008067 RID: 32871 RVA: 0x002586A1 File Offset: 0x002568A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008068 RID: 32872 RVA: 0x002586A8 File Offset: 0x002568A8
		public static HonamiStoryMarkWhiteList GetRootAsHonamiStoryMarkWhiteList(ByteBuffer _bb)
		{
			return HonamiStoryMarkWhiteList.GetRootAsHonamiStoryMarkWhiteList(_bb, default(HonamiStoryMarkWhiteList));
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x002586C4 File Offset: 0x002568C4
		public static HonamiStoryMarkWhiteList GetRootAsHonamiStoryMarkWhiteList(ByteBuffer _bb, HonamiStoryMarkWhiteList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x002586E1 File Offset: 0x002568E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600806B RID: 32875 RVA: 0x002586F0 File Offset: 0x002568F0
		public HonamiStoryMarkWhiteList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x0600806C RID: 32876 RVA: 0x00258700 File Offset: 0x00256900
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

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x0600806D RID: 32877 RVA: 0x0025873C File Offset: 0x0025693C
		public int AreaId
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

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x0600806E RID: 32878 RVA: 0x00258778 File Offset: 0x00256978
		public int MultiMapId
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

		// Token: 0x04004DBA RID: 19898
		private Table __p;
	}
}
