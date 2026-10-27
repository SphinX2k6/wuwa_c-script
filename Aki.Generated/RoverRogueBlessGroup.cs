using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001073 RID: 4211
	public struct RoverRogueBlessGroup : IFlatbufferObject
	{
		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x0600CD21 RID: 52513 RVA: 0x00304A50 File Offset: 0x00302C50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD22 RID: 52514 RVA: 0x00304A5D File Offset: 0x00302C5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD23 RID: 52515 RVA: 0x00304A64 File Offset: 0x00302C64
		public static RoverRogueBlessGroup GetRootAsRoverRogueBlessGroup(ByteBuffer _bb)
		{
			return RoverRogueBlessGroup.GetRootAsRoverRogueBlessGroup(_bb, default(RoverRogueBlessGroup));
		}

		// Token: 0x0600CD24 RID: 52516 RVA: 0x00304A80 File Offset: 0x00302C80
		public static RoverRogueBlessGroup GetRootAsRoverRogueBlessGroup(ByteBuffer _bb, RoverRogueBlessGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD25 RID: 52517 RVA: 0x00304A9D File Offset: 0x00302C9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD26 RID: 52518 RVA: 0x00304AAC File Offset: 0x00302CAC
		public RoverRogueBlessGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x0600CD27 RID: 52519 RVA: 0x00304ABC File Offset: 0x00302CBC
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

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x0600CD28 RID: 52520 RVA: 0x00304AF8 File Offset: 0x00302CF8
		public int BlessRoleId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400517C RID: 20860
		private Table __p;
	}
}
