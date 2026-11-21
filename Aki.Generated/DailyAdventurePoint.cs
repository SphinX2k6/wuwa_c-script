using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C93 RID: 3219
	public struct DailyAdventurePoint : IFlatbufferObject
	{
		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060060C7 RID: 24775 RVA: 0x00222D3F File Offset: 0x00220F3F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x00222D4C File Offset: 0x00220F4C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x00222D54 File Offset: 0x00220F54
		public static DailyAdventurePoint GetRootAsDailyAdventurePoint(ByteBuffer _bb)
		{
			return DailyAdventurePoint.GetRootAsDailyAdventurePoint(_bb, default(DailyAdventurePoint));
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x00222D70 File Offset: 0x00220F70
		public static DailyAdventurePoint GetRootAsDailyAdventurePoint(ByteBuffer _bb, DailyAdventurePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x00222D8D File Offset: 0x00220F8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x00222D9C File Offset: 0x00220F9C
		public DailyAdventurePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x060060CD RID: 24781 RVA: 0x00222DAC File Offset: 0x00220FAC
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

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x060060CE RID: 24782 RVA: 0x00222DE8 File Offset: 0x00220FE8
		public int NeedPt
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

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060060CF RID: 24783 RVA: 0x00222E24 File Offset: 0x00221024
		public int Drop
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

		// Token: 0x040051B6 RID: 20918
		private Table __p;
	}
}
