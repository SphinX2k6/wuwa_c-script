using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113B RID: 4411
	public struct TowerDefencePhantom : IFlatbufferObject
	{
		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x0600DFEC RID: 57324 RVA: 0x003304E4 File Offset: 0x0032E6E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DFED RID: 57325 RVA: 0x003304F1 File Offset: 0x0032E6F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DFEE RID: 57326 RVA: 0x003304F8 File Offset: 0x0032E6F8
		public static TowerDefencePhantom GetRootAsTowerDefencePhantom(ByteBuffer _bb)
		{
			return TowerDefencePhantom.GetRootAsTowerDefencePhantom(_bb, default(TowerDefencePhantom));
		}

		// Token: 0x0600DFEF RID: 57327 RVA: 0x00330514 File Offset: 0x0032E714
		public static TowerDefencePhantom GetRootAsTowerDefencePhantom(ByteBuffer _bb, TowerDefencePhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DFF0 RID: 57328 RVA: 0x00330531 File Offset: 0x0032E731
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DFF1 RID: 57329 RVA: 0x00330540 File Offset: 0x0032E740
		public TowerDefencePhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AD6 RID: 15062
		// (get) Token: 0x0600DFF2 RID: 57330 RVA: 0x00330550 File Offset: 0x0032E750
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

		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x0600DFF3 RID: 57331 RVA: 0x0033058C File Offset: 0x0032E78C
		public int PhantomItemId
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

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x0600DFF4 RID: 57332 RVA: 0x003305C8 File Offset: 0x0032E7C8
		public string PhantomName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFF5 RID: 57333 RVA: 0x003305FF File Offset: 0x0032E7FF
		public Span<byte> GetPhantomNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DFF6 RID: 57334 RVA: 0x0033060E File Offset: 0x0032E80E
		public byte[] GetPhantomNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x0600DFF7 RID: 57335 RVA: 0x00330628 File Offset: 0x0032E828
		public string TypeTextId
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

		// Token: 0x0600DFF8 RID: 57336 RVA: 0x00330660 File Offset: 0x0032E860
		public Span<byte> GetTypeTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DFF9 RID: 57337 RVA: 0x00330670 File Offset: 0x0032E870
		public byte[] GetTypeTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x0600DFFA RID: 57338 RVA: 0x00330688 File Offset: 0x0032E888
		public string TypeIcon
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

		// Token: 0x0600DFFB RID: 57339 RVA: 0x003306C0 File Offset: 0x0032E8C0
		public Span<byte> GetTypeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DFFC RID: 57340 RVA: 0x003306D0 File Offset: 0x0032E8D0
		public byte[] GetTypeIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003ADB RID: 15067
		// (get) Token: 0x0600DFFD RID: 57341 RVA: 0x003306E8 File Offset: 0x0032E8E8
		public string MarkHex
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

		// Token: 0x0600DFFE RID: 57342 RVA: 0x00330720 File Offset: 0x0032E920
		public Span<byte> GetMarkHexBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DFFF RID: 57343 RVA: 0x00330730 File Offset: 0x0032E930
		public byte[] GetMarkHexArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x0600E000 RID: 57344 RVA: 0x00330748 File Offset: 0x0032E948
		public int SkillGroup
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

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x0600E001 RID: 57345 RVA: 0x00330788 File Offset: 0x0032E988
		public int BuffApplyPlan
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x0600E002 RID: 57346 RVA: 0x003307C8 File Offset: 0x0032E9C8
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x0600E003 RID: 57347 RVA: 0x00330808 File Offset: 0x0032EA08
		public bool IsSurvivalType
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400527C RID: 21116
		private Table __p;
	}
}
