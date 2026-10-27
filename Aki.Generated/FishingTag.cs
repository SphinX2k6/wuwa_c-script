using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8C RID: 3212
	public struct FishingTag : IFlatbufferObject
	{
		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06007086 RID: 28806 RVA: 0x00234111 File Offset: 0x00232311
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007087 RID: 28807 RVA: 0x0023411E File Offset: 0x0023231E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007088 RID: 28808 RVA: 0x00234128 File Offset: 0x00232328
		public static FishingTag GetRootAsFishingTag(ByteBuffer _bb)
		{
			return FishingTag.GetRootAsFishingTag(_bb, default(FishingTag));
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x00234144 File Offset: 0x00232344
		public static FishingTag GetRootAsFishingTag(ByteBuffer _bb, FishingTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x00234161 File Offset: 0x00232361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x00234170 File Offset: 0x00232370
		public FishingTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x0600708C RID: 28812 RVA: 0x00234180 File Offset: 0x00232380
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

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x0600708D RID: 28813 RVA: 0x002341BC File Offset: 0x002323BC
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

		// Token: 0x0600708E RID: 28814 RVA: 0x002341F3 File Offset: 0x002323F3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x00234202 File Offset: 0x00232402
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06007090 RID: 28816 RVA: 0x0023421C File Offset: 0x0023241C
		public string Color
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

		// Token: 0x06007091 RID: 28817 RVA: 0x00234253 File Offset: 0x00232453
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x00234262 File Offset: 0x00232462
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CE1 RID: 19681
		private Table __p;
	}
}
