using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1A RID: 3354
	public struct EntitySelfEventConfig : IFlatbufferObject
	{
		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06006F8D RID: 28557 RVA: 0x002432BD File Offset: 0x002414BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x002432CA File Offset: 0x002414CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x002432D4 File Offset: 0x002414D4
		public static EntitySelfEventConfig GetRootAsEntitySelfEventConfig(ByteBuffer _bb)
		{
			return EntitySelfEventConfig.GetRootAsEntitySelfEventConfig(_bb, default(EntitySelfEventConfig));
		}

		// Token: 0x06006F90 RID: 28560 RVA: 0x002432F0 File Offset: 0x002414F0
		public static EntitySelfEventConfig GetRootAsEntitySelfEventConfig(ByteBuffer _bb, EntitySelfEventConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x0024330D File Offset: 0x0024150D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x0024331C File Offset: 0x0024151C
		public EntitySelfEventConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06006F93 RID: 28563 RVA: 0x0024332C File Offset: 0x0024152C
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

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06006F94 RID: 28564 RVA: 0x00243368 File Offset: 0x00241568
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

		// Token: 0x06006F95 RID: 28565 RVA: 0x0024339F File Offset: 0x0024159F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006F96 RID: 28566 RVA: 0x002433AE File Offset: 0x002415AE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06006F97 RID: 28567 RVA: 0x002433C8 File Offset: 0x002415C8
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

		// Token: 0x06006F98 RID: 28568 RVA: 0x002433FF File Offset: 0x002415FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006F99 RID: 28569 RVA: 0x0024340E File Offset: 0x0024160E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06006F9A RID: 28570 RVA: 0x00243428 File Offset: 0x00241628
		public string Desc
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

		// Token: 0x06006F9B RID: 28571 RVA: 0x00243460 File Offset: 0x00241660
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x00243470 File Offset: 0x00241670
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400525A RID: 21082
		private Table __p;
	}
}
