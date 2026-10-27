using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C36 RID: 3126
	public struct EntityOwnerData : IFlatbufferObject
	{
		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x0600697F RID: 27007 RVA: 0x00223E49 File Offset: 0x00222049
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x00223E56 File Offset: 0x00222056
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x00223E60 File Offset: 0x00222060
		public static EntityOwnerData GetRootAsEntityOwnerData(ByteBuffer _bb)
		{
			return EntityOwnerData.GetRootAsEntityOwnerData(_bb, default(EntityOwnerData));
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x00223E7C File Offset: 0x0022207C
		public static EntityOwnerData GetRootAsEntityOwnerData(ByteBuffer _bb, EntityOwnerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x00223E99 File Offset: 0x00222099
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x00223EA8 File Offset: 0x002220A8
		public EntityOwnerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06006985 RID: 27013 RVA: 0x00223EB8 File Offset: 0x002220B8
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

		// Token: 0x06006986 RID: 27014 RVA: 0x00223EEF File Offset: 0x002220EF
		public Span<byte> GetGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x00223EFE File Offset: 0x002220FE
		public byte[] GetGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06006988 RID: 27016 RVA: 0x00223F18 File Offset: 0x00222118
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

		// Token: 0x06006989 RID: 27017 RVA: 0x00223F4F File Offset: 0x0022214F
		public Span<byte> GetOwnerBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x00223F5E File Offset: 0x0022215E
		public byte[] GetOwnerArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C76 RID: 19574
		private Table __p;
	}
}
