using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012EC RID: 4844
	public struct DicIntFloat : IFlatbufferObject
	{
		// Token: 0x17004222 RID: 16930
		// (get) Token: 0x0600F766 RID: 63334 RVA: 0x00371FD0 File Offset: 0x003701D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F767 RID: 63335 RVA: 0x00371FDD File Offset: 0x003701DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F768 RID: 63336 RVA: 0x00371FE4 File Offset: 0x003701E4
		public static DicIntFloat GetRootAsDicIntFloat(ByteBuffer _bb)
		{
			return DicIntFloat.GetRootAsDicIntFloat(_bb, default(DicIntFloat));
		}

		// Token: 0x0600F769 RID: 63337 RVA: 0x00372000 File Offset: 0x00370200
		public static DicIntFloat GetRootAsDicIntFloat(ByteBuffer _bb, DicIntFloat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F76A RID: 63338 RVA: 0x0037201D File Offset: 0x0037021D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F76B RID: 63339 RVA: 0x0037202C File Offset: 0x0037022C
		public DicIntFloat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004223 RID: 16931
		// (get) Token: 0x0600F76C RID: 63340 RVA: 0x0037203C File Offset: 0x0037023C
		public int Key
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

		// Token: 0x17004224 RID: 16932
		// (get) Token: 0x0600F76D RID: 63341 RVA: 0x00372078 File Offset: 0x00370278
		public float Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400594A RID: 22858
		private Table __p;
	}
}
