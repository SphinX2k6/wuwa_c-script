using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E96 RID: 3734
	public struct NewTowerTeamFeature : IFlatbufferObject
	{
		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x0600A037 RID: 41015 RVA: 0x002A0318 File Offset: 0x0029E518
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A038 RID: 41016 RVA: 0x002A0325 File Offset: 0x0029E525
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x002A032C File Offset: 0x0029E52C
		public static NewTowerTeamFeature GetRootAsNewTowerTeamFeature(ByteBuffer _bb)
		{
			return NewTowerTeamFeature.GetRootAsNewTowerTeamFeature(_bb, default(NewTowerTeamFeature));
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x002A0348 File Offset: 0x0029E548
		public static NewTowerTeamFeature GetRootAsNewTowerTeamFeature(ByteBuffer _bb, NewTowerTeamFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x002A0365 File Offset: 0x0029E565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x002A0374 File Offset: 0x0029E574
		public NewTowerTeamFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x0600A03D RID: 41021 RVA: 0x002A0384 File Offset: 0x0029E584
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

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x0600A03E RID: 41022 RVA: 0x002A03C0 File Offset: 0x0029E5C0
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

		// Token: 0x0600A03F RID: 41023 RVA: 0x002A03F7 File Offset: 0x0029E5F7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A040 RID: 41024 RVA: 0x002A0406 File Offset: 0x0029E606
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x0600A041 RID: 41025 RVA: 0x002A0420 File Offset: 0x0029E620
		public string Icon
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

		// Token: 0x0600A042 RID: 41026 RVA: 0x002A0457 File Offset: 0x0029E657
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A043 RID: 41027 RVA: 0x002A0466 File Offset: 0x0029E666
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F49 RID: 20297
		private Table __p;
	}
}
