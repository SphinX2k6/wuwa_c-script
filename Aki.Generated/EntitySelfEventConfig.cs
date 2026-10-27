using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C37 RID: 3127
	public struct EntitySelfEventConfig : IFlatbufferObject
	{
		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x0600698B RID: 27019 RVA: 0x00223F75 File Offset: 0x00222175
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x00223F82 File Offset: 0x00222182
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x00223F8C File Offset: 0x0022218C
		public static EntitySelfEventConfig GetRootAsEntitySelfEventConfig(ByteBuffer _bb)
		{
			return EntitySelfEventConfig.GetRootAsEntitySelfEventConfig(_bb, default(EntitySelfEventConfig));
		}

		// Token: 0x0600698E RID: 27022 RVA: 0x00223FA8 File Offset: 0x002221A8
		public static EntitySelfEventConfig GetRootAsEntitySelfEventConfig(ByteBuffer _bb, EntitySelfEventConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600698F RID: 27023 RVA: 0x00223FC5 File Offset: 0x002221C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006990 RID: 27024 RVA: 0x00223FD4 File Offset: 0x002221D4
		public EntitySelfEventConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06006991 RID: 27025 RVA: 0x00223FE4 File Offset: 0x002221E4
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

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06006992 RID: 27026 RVA: 0x00224020 File Offset: 0x00222220
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

		// Token: 0x06006993 RID: 27027 RVA: 0x00224057 File Offset: 0x00222257
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x00224066 File Offset: 0x00222266
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06006995 RID: 27029 RVA: 0x00224080 File Offset: 0x00222280
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

		// Token: 0x06006996 RID: 27030 RVA: 0x002240B7 File Offset: 0x002222B7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x002240C6 File Offset: 0x002222C6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06006998 RID: 27032 RVA: 0x002240E0 File Offset: 0x002222E0
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

		// Token: 0x06006999 RID: 27033 RVA: 0x00224118 File Offset: 0x00222318
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600699A RID: 27034 RVA: 0x00224128 File Offset: 0x00222328
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C77 RID: 19575
		private Table __p;
	}
}
