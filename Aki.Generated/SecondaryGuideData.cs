using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001093 RID: 4243
	public struct SecondaryGuideData : IFlatbufferObject
	{
		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0600CFF7 RID: 53239 RVA: 0x0030ACD1 File Offset: 0x00308ED1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CFF8 RID: 53240 RVA: 0x0030ACDE File Offset: 0x00308EDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CFF9 RID: 53241 RVA: 0x0030ACE8 File Offset: 0x00308EE8
		public static SecondaryGuideData GetRootAsSecondaryGuideData(ByteBuffer _bb)
		{
			return SecondaryGuideData.GetRootAsSecondaryGuideData(_bb, default(SecondaryGuideData));
		}

		// Token: 0x0600CFFA RID: 53242 RVA: 0x0030AD04 File Offset: 0x00308F04
		public static SecondaryGuideData GetRootAsSecondaryGuideData(ByteBuffer _bb, SecondaryGuideData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CFFB RID: 53243 RVA: 0x0030AD21 File Offset: 0x00308F21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CFFC RID: 53244 RVA: 0x0030AD30 File Offset: 0x00308F30
		public SecondaryGuideData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0600CFFD RID: 53245 RVA: 0x0030AD40 File Offset: 0x00308F40
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

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0600CFFE RID: 53246 RVA: 0x0030AD7C File Offset: 0x00308F7C
		public int SortNumber
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

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0600CFFF RID: 53247 RVA: 0x0030ADB8 File Offset: 0x00308FB8
		public int ConditionGroupId
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

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x0600D000 RID: 53248 RVA: 0x0030ADF4 File Offset: 0x00308FF4
		public string Text
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

		// Token: 0x0600D001 RID: 53249 RVA: 0x0030AE2C File Offset: 0x0030902C
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D002 RID: 53250 RVA: 0x0030AE3C File Offset: 0x0030903C
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x0600D003 RID: 53251 RVA: 0x0030AE54 File Offset: 0x00309054
		public string SubText
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

		// Token: 0x0600D004 RID: 53252 RVA: 0x0030AE8C File Offset: 0x0030908C
		public Span<byte> GetSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D005 RID: 53253 RVA: 0x0030AE9C File Offset: 0x0030909C
		public byte[] GetSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x0600D006 RID: 53254 RVA: 0x0030AEB4 File Offset: 0x003090B4
		public string Icon
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

		// Token: 0x0600D007 RID: 53255 RVA: 0x0030AEEC File Offset: 0x003090EC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D008 RID: 53256 RVA: 0x0030AEFC File Offset: 0x003090FC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x0600D009 RID: 53257 RVA: 0x0030AF14 File Offset: 0x00309114
		public int HelpGroupId
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

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x0600D00A RID: 53258 RVA: 0x0030AF54 File Offset: 0x00309154
		public bool ShowDropDown
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0600D00B RID: 53259 RVA: 0x0030AF94 File Offset: 0x00309194
		public int DropDownTypeId
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

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x0600D00C RID: 53260 RVA: 0x0030AFD4 File Offset: 0x003091D4
		public int TimeOutDay
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0600D00D RID: 53261 RVA: 0x0030B014 File Offset: 0x00309214
		public bool Shield
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040051A0 RID: 20896
		private Table __p;
	}
}
