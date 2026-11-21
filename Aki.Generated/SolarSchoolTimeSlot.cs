using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200120A RID: 4618
	public struct SolarSchoolTimeSlot : IFlatbufferObject
	{
		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x0600E455 RID: 58453 RVA: 0x00347985 File Offset: 0x00345B85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E456 RID: 58454 RVA: 0x00347992 File Offset: 0x00345B92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E457 RID: 58455 RVA: 0x0034799C File Offset: 0x00345B9C
		public static SolarSchoolTimeSlot GetRootAsSolarSchoolTimeSlot(ByteBuffer _bb)
		{
			return SolarSchoolTimeSlot.GetRootAsSolarSchoolTimeSlot(_bb, default(SolarSchoolTimeSlot));
		}

		// Token: 0x0600E458 RID: 58456 RVA: 0x003479B8 File Offset: 0x00345BB8
		public static SolarSchoolTimeSlot GetRootAsSolarSchoolTimeSlot(ByteBuffer _bb, SolarSchoolTimeSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E459 RID: 58457 RVA: 0x003479D5 File Offset: 0x00345BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E45A RID: 58458 RVA: 0x003479E4 File Offset: 0x00345BE4
		public SolarSchoolTimeSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x0600E45B RID: 58459 RVA: 0x003479F4 File Offset: 0x00345BF4
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

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x0600E45C RID: 58460 RVA: 0x00347A30 File Offset: 0x00345C30
		public int ActivityId
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

		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x0600E45D RID: 58461 RVA: 0x00347A6C File Offset: 0x00345C6C
		public int Order
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

		// Token: 0x17003AD6 RID: 15062
		// (get) Token: 0x0600E45E RID: 58462 RVA: 0x00347AA8 File Offset: 0x00345CA8
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E45F RID: 58463 RVA: 0x00347AE0 File Offset: 0x00345CE0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E460 RID: 58464 RVA: 0x00347AF0 File Offset: 0x00345CF0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x0600E461 RID: 58465 RVA: 0x00347B08 File Offset: 0x00345D08
		public string ShortName
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E462 RID: 58466 RVA: 0x00347B40 File Offset: 0x00345D40
		public Span<byte> GetShortNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E463 RID: 58467 RVA: 0x00347B50 File Offset: 0x00345D50
		public byte[] GetShortNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x0600E464 RID: 58468 RVA: 0x00347B68 File Offset: 0x00345D68
		public bool IsActionSlot
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x0600E465 RID: 58469 RVA: 0x00347BA8 File Offset: 0x00345DA8
		public int MapTimePhase
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x0600E466 RID: 58470 RVA: 0x00347BE8 File Offset: 0x00345DE8
		public string BgmState
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E467 RID: 58471 RVA: 0x00347C20 File Offset: 0x00345E20
		public Span<byte> GetBgmStateBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E468 RID: 58472 RVA: 0x00347C30 File Offset: 0x00345E30
		public byte[] GetBgmStateArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003ADB RID: 15067
		// (get) Token: 0x0600E469 RID: 58473 RVA: 0x00347C48 File Offset: 0x00345E48
		public string AudioState
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E46A RID: 58474 RVA: 0x00347C80 File Offset: 0x00345E80
		public Span<byte> GetAudioStateBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E46B RID: 58475 RVA: 0x00347C90 File Offset: 0x00345E90
		public byte[] GetAudioStateArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0400584A RID: 22602
		private Table __p;
	}
}
