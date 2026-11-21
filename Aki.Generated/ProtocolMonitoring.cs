using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001045 RID: 4165
	public struct ProtocolMonitoring : IFlatbufferObject
	{
		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x0600B9FA RID: 47610 RVA: 0x002E8F64 File Offset: 0x002E7164
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B9FB RID: 47611 RVA: 0x002E8F71 File Offset: 0x002E7171
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B9FC RID: 47612 RVA: 0x002E8F78 File Offset: 0x002E7178
		public static ProtocolMonitoring GetRootAsProtocolMonitoring(ByteBuffer _bb)
		{
			return ProtocolMonitoring.GetRootAsProtocolMonitoring(_bb, default(ProtocolMonitoring));
		}

		// Token: 0x0600B9FD RID: 47613 RVA: 0x002E8F94 File Offset: 0x002E7194
		public static ProtocolMonitoring GetRootAsProtocolMonitoring(ByteBuffer _bb, ProtocolMonitoring obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B9FE RID: 47614 RVA: 0x002E8FB1 File Offset: 0x002E71B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B9FF RID: 47615 RVA: 0x002E8FC0 File Offset: 0x002E71C0
		public ProtocolMonitoring __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x0600BA00 RID: 47616 RVA: 0x002E8FD0 File Offset: 0x002E71D0
		public int ProtocolId
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

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x0600BA01 RID: 47617 RVA: 0x002E900C File Offset: 0x002E720C
		public int ActionId
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

		// Token: 0x04005613 RID: 22035
		private Table __p;
	}
}
