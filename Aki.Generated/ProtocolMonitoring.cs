using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5E RID: 3934
	public struct ProtocolMonitoring : IFlatbufferObject
	{
		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x0600B3BD RID: 46013 RVA: 0x002CC2B0 File Offset: 0x002CA4B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B3BE RID: 46014 RVA: 0x002CC2BD File Offset: 0x002CA4BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B3BF RID: 46015 RVA: 0x002CC2C4 File Offset: 0x002CA4C4
		public static ProtocolMonitoring GetRootAsProtocolMonitoring(ByteBuffer _bb)
		{
			return ProtocolMonitoring.GetRootAsProtocolMonitoring(_bb, default(ProtocolMonitoring));
		}

		// Token: 0x0600B3C0 RID: 46016 RVA: 0x002CC2E0 File Offset: 0x002CA4E0
		public static ProtocolMonitoring GetRootAsProtocolMonitoring(ByteBuffer _bb, ProtocolMonitoring obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B3C1 RID: 46017 RVA: 0x002CC2FD File Offset: 0x002CA4FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B3C2 RID: 46018 RVA: 0x002CC30C File Offset: 0x002CA50C
		public ProtocolMonitoring __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x0600B3C3 RID: 46019 RVA: 0x002CC31C File Offset: 0x002CA51C
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

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x0600B3C4 RID: 46020 RVA: 0x002CC358 File Offset: 0x002CA558
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

		// Token: 0x0400502C RID: 20524
		private Table __p;
	}
}
