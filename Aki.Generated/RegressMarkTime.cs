using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAF RID: 4015
	public struct RegressMarkTime : IFlatbufferObject
	{
		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x0600BB08 RID: 47880 RVA: 0x002DC15C File Offset: 0x002DA35C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB09 RID: 47881 RVA: 0x002DC169 File Offset: 0x002DA369
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB0A RID: 47882 RVA: 0x002DC170 File Offset: 0x002DA370
		public static RegressMarkTime GetRootAsRegressMarkTime(ByteBuffer _bb)
		{
			return RegressMarkTime.GetRootAsRegressMarkTime(_bb, default(RegressMarkTime));
		}

		// Token: 0x0600BB0B RID: 47883 RVA: 0x002DC18C File Offset: 0x002DA38C
		public static RegressMarkTime GetRootAsRegressMarkTime(ByteBuffer _bb, RegressMarkTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB0C RID: 47884 RVA: 0x002DC1A9 File Offset: 0x002DA3A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB0D RID: 47885 RVA: 0x002DC1B8 File Offset: 0x002DA3B8
		public RegressMarkTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x0600BB0E RID: 47886 RVA: 0x002DC1C8 File Offset: 0x002DA3C8
		public int ActivityId
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

		// Token: 0x04005088 RID: 20616
		private Table __p;
	}
}
