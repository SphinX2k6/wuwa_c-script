using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED5 RID: 3797
	public struct MapMarkRelativeSubType : IFlatbufferObject
	{
		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x06009788 RID: 38792 RVA: 0x0029D713 File Offset: 0x0029B913
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009789 RID: 38793 RVA: 0x0029D720 File Offset: 0x0029B920
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x0029D728 File Offset: 0x0029B928
		public static MapMarkRelativeSubType GetRootAsMapMarkRelativeSubType(ByteBuffer _bb)
		{
			return MapMarkRelativeSubType.GetRootAsMapMarkRelativeSubType(_bb, default(MapMarkRelativeSubType));
		}

		// Token: 0x0600978B RID: 38795 RVA: 0x0029D744 File Offset: 0x0029B944
		public static MapMarkRelativeSubType GetRootAsMapMarkRelativeSubType(ByteBuffer _bb, MapMarkRelativeSubType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x0029D761 File Offset: 0x0029B961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x0029D770 File Offset: 0x0029B970
		public MapMarkRelativeSubType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x0600978E RID: 38798 RVA: 0x0029D780 File Offset: 0x0029B980
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

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x0600978F RID: 38799 RVA: 0x0029D7BC File Offset: 0x0029B9BC
		public int FunctionId
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

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x06009790 RID: 38800 RVA: 0x0029D7F8 File Offset: 0x0029B9F8
		public IntVector? Position
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IntVector?(default(IntVector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x06009791 RID: 38801 RVA: 0x0029D858 File Offset: 0x0029BA58
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005472 RID: 21618
		private Table __p;
	}
}
