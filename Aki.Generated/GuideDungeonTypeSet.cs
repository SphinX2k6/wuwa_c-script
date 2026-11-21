using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFC RID: 3580
	public struct GuideDungeonTypeSet : IFlatbufferObject
	{
		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x060082A6 RID: 33446 RVA: 0x0026E58B File Offset: 0x0026C78B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x0026E598 File Offset: 0x0026C798
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x0026E5A0 File Offset: 0x0026C7A0
		public static GuideDungeonTypeSet GetRootAsGuideDungeonTypeSet(ByteBuffer _bb)
		{
			return GuideDungeonTypeSet.GetRootAsGuideDungeonTypeSet(_bb, default(GuideDungeonTypeSet));
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x0026E5BC File Offset: 0x0026C7BC
		public static GuideDungeonTypeSet GetRootAsGuideDungeonTypeSet(ByteBuffer _bb, GuideDungeonTypeSet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x0026E5D9 File Offset: 0x0026C7D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x0026E5E8 File Offset: 0x0026C7E8
		public GuideDungeonTypeSet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x060082AC RID: 33452 RVA: 0x0026E5F8 File Offset: 0x0026C7F8
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

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x060082AD RID: 33453 RVA: 0x0026E634 File Offset: 0x0026C834
		public int InstType
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

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x060082AE RID: 33454 RVA: 0x0026E670 File Offset: 0x0026C870
		public int InstSubType
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

		// Token: 0x04005374 RID: 21364
		private Table __p;
	}
}
