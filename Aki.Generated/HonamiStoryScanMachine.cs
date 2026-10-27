using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4E RID: 3406
	public struct HonamiStoryScanMachine : IFlatbufferObject
	{
		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x06008137 RID: 33079 RVA: 0x0025A324 File Offset: 0x00258524
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008138 RID: 33080 RVA: 0x0025A331 File Offset: 0x00258531
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008139 RID: 33081 RVA: 0x0025A338 File Offset: 0x00258538
		public static HonamiStoryScanMachine GetRootAsHonamiStoryScanMachine(ByteBuffer _bb)
		{
			return HonamiStoryScanMachine.GetRootAsHonamiStoryScanMachine(_bb, default(HonamiStoryScanMachine));
		}

		// Token: 0x0600813A RID: 33082 RVA: 0x0025A354 File Offset: 0x00258554
		public static HonamiStoryScanMachine GetRootAsHonamiStoryScanMachine(ByteBuffer _bb, HonamiStoryScanMachine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600813B RID: 33083 RVA: 0x0025A371 File Offset: 0x00258571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600813C RID: 33084 RVA: 0x0025A380 File Offset: 0x00258580
		public HonamiStoryScanMachine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x0600813D RID: 33085 RVA: 0x0025A390 File Offset: 0x00258590
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

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x0600813E RID: 33086 RVA: 0x0025A3CC File Offset: 0x002585CC
		public int InstEntityTeleportId
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

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x0600813F RID: 33087 RVA: 0x0025A408 File Offset: 0x00258608
		public int FogId
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

		// Token: 0x04004DCB RID: 19915
		private Table __p;
	}
}
