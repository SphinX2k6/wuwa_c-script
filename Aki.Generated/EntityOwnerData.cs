using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D19 RID: 3353
	public struct EntityOwnerData : IFlatbufferObject
	{
		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06006F81 RID: 28545 RVA: 0x00243191 File Offset: 0x00241391
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F82 RID: 28546 RVA: 0x0024319E File Offset: 0x0024139E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F83 RID: 28547 RVA: 0x002431A8 File Offset: 0x002413A8
		public static EntityOwnerData GetRootAsEntityOwnerData(ByteBuffer _bb)
		{
			return EntityOwnerData.GetRootAsEntityOwnerData(_bb, default(EntityOwnerData));
		}

		// Token: 0x06006F84 RID: 28548 RVA: 0x002431C4 File Offset: 0x002413C4
		public static EntityOwnerData GetRootAsEntityOwnerData(ByteBuffer _bb, EntityOwnerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x002431E1 File Offset: 0x002413E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x002431F0 File Offset: 0x002413F0
		public EntityOwnerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06006F87 RID: 28551 RVA: 0x00243200 File Offset: 0x00241400
		public string Guid
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F88 RID: 28552 RVA: 0x00243237 File Offset: 0x00241437
		public Span<byte> GetGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06006F89 RID: 28553 RVA: 0x00243246 File Offset: 0x00241446
		public byte[] GetGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06006F8A RID: 28554 RVA: 0x00243260 File Offset: 0x00241460
		public string Owner
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

		// Token: 0x06006F8B RID: 28555 RVA: 0x00243297 File Offset: 0x00241497
		public Span<byte> GetOwnerBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x002432A6 File Offset: 0x002414A6
		public byte[] GetOwnerArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005259 RID: 21081
		private Table __p;
	}
}
