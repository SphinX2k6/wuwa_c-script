using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001066 RID: 4198
	public struct QuestType : IFlatbufferObject
	{
		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x0600BD71 RID: 48497 RVA: 0x002EFD89 File Offset: 0x002EDF89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD72 RID: 48498 RVA: 0x002EFD96 File Offset: 0x002EDF96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD73 RID: 48499 RVA: 0x002EFDA0 File Offset: 0x002EDFA0
		public static QuestType GetRootAsQuestType(ByteBuffer _bb)
		{
			return QuestType.GetRootAsQuestType(_bb, default(QuestType));
		}

		// Token: 0x0600BD74 RID: 48500 RVA: 0x002EFDBC File Offset: 0x002EDFBC
		public static QuestType GetRootAsQuestType(ByteBuffer _bb, QuestType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD75 RID: 48501 RVA: 0x002EFDD9 File Offset: 0x002EDFD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD76 RID: 48502 RVA: 0x002EFDE8 File Offset: 0x002EDFE8
		public QuestType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x0600BD77 RID: 48503 RVA: 0x002EFDF8 File Offset: 0x002EDFF8
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

		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x0600BD78 RID: 48504 RVA: 0x002EFE34 File Offset: 0x002EE034
		public int MainId
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

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x0600BD79 RID: 48505 RVA: 0x002EFE70 File Offset: 0x002EE070
		public string QuestTypeName
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

		// Token: 0x0600BD7A RID: 48506 RVA: 0x002EFEA7 File Offset: 0x002EE0A7
		public Span<byte> GetQuestTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BD7B RID: 48507 RVA: 0x002EFEB6 File Offset: 0x002EE0B6
		public byte[] GetQuestTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x0600BD7C RID: 48508 RVA: 0x002EFED0 File Offset: 0x002EE0D0
		public bool IsShowInQuestPanel
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x0600BD7D RID: 48509 RVA: 0x002EFF10 File Offset: 0x002EE110
		public string TypeColor
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

		// Token: 0x0600BD7E RID: 48510 RVA: 0x002EFF48 File Offset: 0x002EE148
		public Span<byte> GetTypeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BD7F RID: 48511 RVA: 0x002EFF58 File Offset: 0x002EE158
		public byte[] GetTypeColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x0600BD80 RID: 48512 RVA: 0x002EFF70 File Offset: 0x002EE170
		public string TextColor
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

		// Token: 0x0600BD81 RID: 48513 RVA: 0x002EFFA8 File Offset: 0x002EE1A8
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BD82 RID: 48514 RVA: 0x002EFFB8 File Offset: 0x002EE1B8
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x0600BD83 RID: 48515 RVA: 0x002EFFD0 File Offset: 0x002EE1D0
		public bool NeedRedDot
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600BD84 RID: 48516 RVA: 0x002F0010 File Offset: 0x002EE210
		public int MapId(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x0600BD85 RID: 48517 RVA: 0x002F0050 File Offset: 0x002EE250
		public int MapIdLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BD86 RID: 48518 RVA: 0x002F007C File Offset: 0x002EE27C
		public Span<int> GetMapIdBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600BD87 RID: 48519 RVA: 0x002F008C File Offset: 0x002EE28C
		public int[] GetMapIdArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x0600BD88 RID: 48520 RVA: 0x002F00A4 File Offset: 0x002EE2A4
		public int IsHide
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

		// Token: 0x0600BD89 RID: 48521 RVA: 0x002F00E1 File Offset: 0x002EE2E1
		[NullableContext(1)]
		public int[] MapId()
		{
			return this.GetMapIdArray();
		}

		// Token: 0x0600BD8A RID: 48522 RVA: 0x002F00E9 File Offset: 0x002EE2E9
		[NullableContext(1)]
		public IEnumerable<int> MapIdIter()
		{
			QuestType.<MapIdIter>d__36 <MapIdIter>d__ = new QuestType.<MapIdIter>d__36(-2);
			<MapIdIter>d__.<>3__<>4__this = this;
			return <MapIdIter>d__;
		}

		// Token: 0x04005634 RID: 22068
		private Table __p;
	}
}
