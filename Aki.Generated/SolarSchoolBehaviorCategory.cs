using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D7 RID: 4567
	public struct SolarSchoolBehaviorCategory : IFlatbufferObject
	{
		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x0600DFEB RID: 57323 RVA: 0x0033DB3E File Offset: 0x0033BD3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DFEC RID: 57324 RVA: 0x0033DB4B File Offset: 0x0033BD4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DFED RID: 57325 RVA: 0x0033DB54 File Offset: 0x0033BD54
		public static SolarSchoolBehaviorCategory GetRootAsSolarSchoolBehaviorCategory(ByteBuffer _bb)
		{
			return SolarSchoolBehaviorCategory.GetRootAsSolarSchoolBehaviorCategory(_bb, default(SolarSchoolBehaviorCategory));
		}

		// Token: 0x0600DFEE RID: 57326 RVA: 0x0033DB70 File Offset: 0x0033BD70
		public static SolarSchoolBehaviorCategory GetRootAsSolarSchoolBehaviorCategory(ByteBuffer _bb, SolarSchoolBehaviorCategory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DFEF RID: 57327 RVA: 0x0033DB8D File Offset: 0x0033BD8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DFF0 RID: 57328 RVA: 0x0033DB9C File Offset: 0x0033BD9C
		public SolarSchoolBehaviorCategory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x0600DFF1 RID: 57329 RVA: 0x0033DBAC File Offset: 0x0033BDAC
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

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x0600DFF2 RID: 57330 RVA: 0x0033DBE8 File Offset: 0x0033BDE8
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

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0600DFF3 RID: 57331 RVA: 0x0033DC24 File Offset: 0x0033BE24
		public int Sort
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

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0600DFF4 RID: 57332 RVA: 0x0033DC60 File Offset: 0x0033BE60
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

		// Token: 0x0600DFF5 RID: 57333 RVA: 0x0033DC98 File Offset: 0x0033BE98
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DFF6 RID: 57334 RVA: 0x0033DCA8 File Offset: 0x0033BEA8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0600DFF7 RID: 57335 RVA: 0x0033DCC0 File Offset: 0x0033BEC0
		public string Icon
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

		// Token: 0x0600DFF8 RID: 57336 RVA: 0x0033DCF8 File Offset: 0x0033BEF8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DFF9 RID: 57337 RVA: 0x0033DD08 File Offset: 0x0033BF08
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x0600DFFA RID: 57338 RVA: 0x0033DD20 File Offset: 0x0033BF20
		public string BgNmlPath
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFFB RID: 57339 RVA: 0x0033DD58 File Offset: 0x0033BF58
		public Span<byte> GetBgNmlPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DFFC RID: 57340 RVA: 0x0033DD68 File Offset: 0x0033BF68
		public byte[] GetBgNmlPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x0600DFFD RID: 57341 RVA: 0x0033DD80 File Offset: 0x0033BF80
		public string BgHoldPath
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFFE RID: 57342 RVA: 0x0033DDB8 File Offset: 0x0033BFB8
		public Span<byte> GetBgHoldPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DFFF RID: 57343 RVA: 0x0033DDC8 File Offset: 0x0033BFC8
		public byte[] GetBgHoldPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005814 RID: 22548
		private Table __p;
	}
}
