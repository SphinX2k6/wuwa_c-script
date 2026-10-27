using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111A RID: 4378
	public struct Teleporter : IFlatbufferObject
	{
		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x0600DD3C RID: 56636 RVA: 0x0032A560 File Offset: 0x00328760
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD3D RID: 56637 RVA: 0x0032A56D File Offset: 0x0032876D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD3E RID: 56638 RVA: 0x0032A574 File Offset: 0x00328774
		public static Teleporter GetRootAsTeleporter(ByteBuffer _bb)
		{
			return Teleporter.GetRootAsTeleporter(_bb, default(Teleporter));
		}

		// Token: 0x0600DD3F RID: 56639 RVA: 0x0032A590 File Offset: 0x00328790
		public static Teleporter GetRootAsTeleporter(ByteBuffer _bb, Teleporter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD40 RID: 56640 RVA: 0x0032A5AD File Offset: 0x003287AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD41 RID: 56641 RVA: 0x0032A5BC File Offset: 0x003287BC
		public Teleporter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x0600DD42 RID: 56642 RVA: 0x0032A5CC File Offset: 0x003287CC
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

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x0600DD43 RID: 56643 RVA: 0x0032A608 File Offset: 0x00328808
		public int MapId
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

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x0600DD44 RID: 56644 RVA: 0x0032A644 File Offset: 0x00328844
		public int ObjectId
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

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x0600DD45 RID: 56645 RVA: 0x0032A680 File Offset: 0x00328880
		public int FogId
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

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x0600DD46 RID: 56646 RVA: 0x0032A6C0 File Offset: 0x003288C0
		public int Type
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

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x0600DD47 RID: 56647 RVA: 0x0032A700 File Offset: 0x00328900
		public int TeleportEntityConfigId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x0600DD48 RID: 56648 RVA: 0x0032A740 File Offset: 0x00328940
		public string Plot
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

		// Token: 0x0600DD49 RID: 56649 RVA: 0x0032A778 File Offset: 0x00328978
		public Span<byte> GetPlotBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DD4A RID: 56650 RVA: 0x0032A788 File Offset: 0x00328988
		public byte[] GetPlotArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x0600DD4B RID: 56651 RVA: 0x0032A7A0 File Offset: 0x003289A0
		public int AfterNetworkAction
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

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x0600DD4C RID: 56652 RVA: 0x0032A7E0 File Offset: 0x003289E0
		public bool ShowWorldMap
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005257 RID: 21079
		private Table __p;
	}
}
