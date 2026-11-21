using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E72 RID: 3698
	public struct KingShipAttribute : IFlatbufferObject
	{
		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06008DC9 RID: 36297 RVA: 0x002870FD File Offset: 0x002852FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x0028710A File Offset: 0x0028530A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008DCB RID: 36299 RVA: 0x00287114 File Offset: 0x00285314
		public static KingShipAttribute GetRootAsKingShipAttribute(ByteBuffer _bb)
		{
			return KingShipAttribute.GetRootAsKingShipAttribute(_bb, default(KingShipAttribute));
		}

		// Token: 0x06008DCC RID: 36300 RVA: 0x00287130 File Offset: 0x00285330
		public static KingShipAttribute GetRootAsKingShipAttribute(ByteBuffer _bb, KingShipAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008DCD RID: 36301 RVA: 0x0028714D File Offset: 0x0028534D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008DCE RID: 36302 RVA: 0x0028715C File Offset: 0x0028535C
		public KingShipAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06008DCF RID: 36303 RVA: 0x0028716C File Offset: 0x0028536C
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

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06008DD0 RID: 36304 RVA: 0x002871A8 File Offset: 0x002853A8
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

		// Token: 0x06008DD1 RID: 36305 RVA: 0x002871DF File Offset: 0x002853DF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008DD2 RID: 36306 RVA: 0x002871EE File Offset: 0x002853EE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06008DD3 RID: 36307 RVA: 0x00287208 File Offset: 0x00285408
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

		// Token: 0x06008DD4 RID: 36308 RVA: 0x0028723F File Offset: 0x0028543F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008DD5 RID: 36309 RVA: 0x0028724E File Offset: 0x0028544E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06008DD6 RID: 36310 RVA: 0x00287268 File Offset: 0x00285468
		public string DesText
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

		// Token: 0x06008DD7 RID: 36311 RVA: 0x002872A0 File Offset: 0x002854A0
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008DD8 RID: 36312 RVA: 0x002872B0 File Offset: 0x002854B0
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040053FE RID: 21502
		private Table __p;
	}
}
