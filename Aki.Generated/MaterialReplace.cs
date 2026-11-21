using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EEB RID: 3819
	public struct MaterialReplace : IFlatbufferObject
	{
		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x06009984 RID: 39300 RVA: 0x002A1A18 File Offset: 0x0029FC18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009985 RID: 39301 RVA: 0x002A1A25 File Offset: 0x0029FC25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009986 RID: 39302 RVA: 0x002A1A2C File Offset: 0x0029FC2C
		public static MaterialReplace GetRootAsMaterialReplace(ByteBuffer _bb)
		{
			return MaterialReplace.GetRootAsMaterialReplace(_bb, default(MaterialReplace));
		}

		// Token: 0x06009987 RID: 39303 RVA: 0x002A1A48 File Offset: 0x0029FC48
		public static MaterialReplace GetRootAsMaterialReplace(ByteBuffer _bb, MaterialReplace obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009988 RID: 39304 RVA: 0x002A1A65 File Offset: 0x0029FC65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009989 RID: 39305 RVA: 0x002A1A74 File Offset: 0x0029FC74
		public MaterialReplace __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x0600998A RID: 39306 RVA: 0x002A1A84 File Offset: 0x0029FC84
		public int ItemId
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

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x0600998B RID: 39307 RVA: 0x002A1AC0 File Offset: 0x0029FCC0
		public int GroupId
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

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x0600998C RID: 39308 RVA: 0x002A1AFC File Offset: 0x0029FCFC
		public int ShowGroupId
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

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x0600998D RID: 39309 RVA: 0x002A1B38 File Offset: 0x0029FD38
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x0600998E RID: 39310 RVA: 0x002A1B78 File Offset: 0x0029FD78
		public int ExchangeParam
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400548C RID: 21644
		private Table __p;
	}
}
