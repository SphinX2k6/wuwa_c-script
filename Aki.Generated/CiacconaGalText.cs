using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5D RID: 3165
	public struct CiacconaGalText : IFlatbufferObject
	{
		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06005B73 RID: 23411 RVA: 0x002161F0 File Offset: 0x002143F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B74 RID: 23412 RVA: 0x002161FD File Offset: 0x002143FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x00216204 File Offset: 0x00214404
		public static CiacconaGalText GetRootAsCiacconaGalText(ByteBuffer _bb)
		{
			return CiacconaGalText.GetRootAsCiacconaGalText(_bb, default(CiacconaGalText));
		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x00216220 File Offset: 0x00214420
		public static CiacconaGalText GetRootAsCiacconaGalText(ByteBuffer _bb, CiacconaGalText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x0021623D File Offset: 0x0021443D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x0021624C File Offset: 0x0021444C
		public CiacconaGalText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06005B79 RID: 23417 RVA: 0x0021625C File Offset: 0x0021445C
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

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06005B7A RID: 23418 RVA: 0x00216298 File Offset: 0x00214498
		public string TextId
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

		// Token: 0x06005B7B RID: 23419 RVA: 0x002162CF File Offset: 0x002144CF
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005B7C RID: 23420 RVA: 0x002162DE File Offset: 0x002144DE
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005161 RID: 20833
		private Table __p;
	}
}
