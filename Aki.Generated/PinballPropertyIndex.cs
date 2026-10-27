using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F34 RID: 3892
	public struct PinballPropertyIndex : IFlatbufferObject
	{
		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x0600AFCA RID: 45002 RVA: 0x002C3AE1 File Offset: 0x002C1CE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x002C3AEE File Offset: 0x002C1CEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x002C3AF8 File Offset: 0x002C1CF8
		public static PinballPropertyIndex GetRootAsPinballPropertyIndex(ByteBuffer _bb)
		{
			return PinballPropertyIndex.GetRootAsPinballPropertyIndex(_bb, default(PinballPropertyIndex));
		}

		// Token: 0x0600AFCD RID: 45005 RVA: 0x002C3B14 File Offset: 0x002C1D14
		public static PinballPropertyIndex GetRootAsPinballPropertyIndex(ByteBuffer _bb, PinballPropertyIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AFCE RID: 45006 RVA: 0x002C3B31 File Offset: 0x002C1D31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AFCF RID: 45007 RVA: 0x002C3B40 File Offset: 0x002C1D40
		public PinballPropertyIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x0600AFD0 RID: 45008 RVA: 0x002C3B50 File Offset: 0x002C1D50
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

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x0600AFD1 RID: 45009 RVA: 0x002C3B8C File Offset: 0x002C1D8C
		public string Key
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

		// Token: 0x0600AFD2 RID: 45010 RVA: 0x002C3BC3 File Offset: 0x002C1DC3
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AFD3 RID: 45011 RVA: 0x002C3BD2 File Offset: 0x002C1DD2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x0600AFD4 RID: 45012 RVA: 0x002C3BEC File Offset: 0x002C1DEC
		public string Name
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

		// Token: 0x0600AFD5 RID: 45013 RVA: 0x002C3C23 File Offset: 0x002C1E23
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x002C3C32 File Offset: 0x002C1E32
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x0600AFD7 RID: 45015 RVA: 0x002C3C4C File Offset: 0x002C1E4C
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x0600AFD8 RID: 45016 RVA: 0x002C3C8C File Offset: 0x002C1E8C
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

		// Token: 0x0600AFD9 RID: 45017 RVA: 0x002C3CC4 File Offset: 0x002C1EC4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AFDA RID: 45018 RVA: 0x002C3CD4 File Offset: 0x002C1ED4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x0600AFDB RID: 45019 RVA: 0x002C3CEC File Offset: 0x002C1EEC
		public string Desc
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

		// Token: 0x0600AFDC RID: 45020 RVA: 0x002C3D24 File Offset: 0x002C1F24
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AFDD RID: 45021 RVA: 0x002C3D34 File Offset: 0x002C1F34
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x0600AFDE RID: 45022 RVA: 0x002C3D4C File Offset: 0x002C1F4C
		public int KscAttrType
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

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x0600AFDF RID: 45023 RVA: 0x002C3D8C File Offset: 0x002C1F8C
		public int ShowCoefficient
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004FFE RID: 20478
		private Table __p;
	}
}
