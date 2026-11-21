using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E33 RID: 3635
	public struct HonamiStoryScanMachine : IFlatbufferObject
	{
		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06008751 RID: 34641 RVA: 0x00278B00 File Offset: 0x00276D00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x00278B0D File Offset: 0x00276D0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008753 RID: 34643 RVA: 0x00278B14 File Offset: 0x00276D14
		public static HonamiStoryScanMachine GetRootAsHonamiStoryScanMachine(ByteBuffer _bb)
		{
			return HonamiStoryScanMachine.GetRootAsHonamiStoryScanMachine(_bb, default(HonamiStoryScanMachine));
		}

		// Token: 0x06008754 RID: 34644 RVA: 0x00278B30 File Offset: 0x00276D30
		public static HonamiStoryScanMachine GetRootAsHonamiStoryScanMachine(ByteBuffer _bb, HonamiStoryScanMachine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008755 RID: 34645 RVA: 0x00278B4D File Offset: 0x00276D4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008756 RID: 34646 RVA: 0x00278B5C File Offset: 0x00276D5C
		public HonamiStoryScanMachine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06008757 RID: 34647 RVA: 0x00278B6C File Offset: 0x00276D6C
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

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06008758 RID: 34648 RVA: 0x00278BA8 File Offset: 0x00276DA8
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

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06008759 RID: 34649 RVA: 0x00278BE4 File Offset: 0x00276DE4
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

		// Token: 0x040053B0 RID: 21424
		private Table __p;
	}
}
