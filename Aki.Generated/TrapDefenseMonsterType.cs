using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012A1 RID: 4769
	public struct TrapDefenseMonsterType : IFlatbufferObject
	{
		// Token: 0x17003FCD RID: 16333
		// (get) Token: 0x0600F1C8 RID: 61896 RVA: 0x00365371 File Offset: 0x00363571
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F1C9 RID: 61897 RVA: 0x0036537E File Offset: 0x0036357E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F1CA RID: 61898 RVA: 0x00365388 File Offset: 0x00363588
		public static TrapDefenseMonsterType GetRootAsTrapDefenseMonsterType(ByteBuffer _bb)
		{
			return TrapDefenseMonsterType.GetRootAsTrapDefenseMonsterType(_bb, default(TrapDefenseMonsterType));
		}

		// Token: 0x0600F1CB RID: 61899 RVA: 0x003653A4 File Offset: 0x003635A4
		public static TrapDefenseMonsterType GetRootAsTrapDefenseMonsterType(ByteBuffer _bb, TrapDefenseMonsterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F1CC RID: 61900 RVA: 0x003653C1 File Offset: 0x003635C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F1CD RID: 61901 RVA: 0x003653D0 File Offset: 0x003635D0
		public TrapDefenseMonsterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FCE RID: 16334
		// (get) Token: 0x0600F1CE RID: 61902 RVA: 0x003653E0 File Offset: 0x003635E0
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

		// Token: 0x17003FCF RID: 16335
		// (get) Token: 0x0600F1CF RID: 61903 RVA: 0x0036541C File Offset: 0x0036361C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F1D0 RID: 61904 RVA: 0x00365453 File Offset: 0x00363653
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F1D1 RID: 61905 RVA: 0x00365462 File Offset: 0x00363662
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003FD0 RID: 16336
		// (get) Token: 0x0600F1D2 RID: 61906 RVA: 0x0036547C File Offset: 0x0036367C
		public int TemplateId
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

		// Token: 0x17003FD1 RID: 16337
		// (get) Token: 0x0600F1D3 RID: 61907 RVA: 0x003654B8 File Offset: 0x003636B8
		public int RiskType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003FD2 RID: 16338
		// (get) Token: 0x0600F1D4 RID: 61908 RVA: 0x003654F8 File Offset: 0x003636F8
		public int BodyType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003FD3 RID: 16339
		// (get) Token: 0x0600F1D5 RID: 61909 RVA: 0x00365538 File Offset: 0x00363738
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

		// Token: 0x0600F1D6 RID: 61910 RVA: 0x00365570 File Offset: 0x00363770
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600F1D7 RID: 61911 RVA: 0x00365580 File Offset: 0x00363780
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040058F4 RID: 22772
		private Table __p;
	}
}
