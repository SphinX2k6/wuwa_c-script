using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3D RID: 2877
	public struct BlueprintConfig : IFlatbufferObject
	{
		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06004E01 RID: 19969 RVA: 0x001E52E9 File Offset: 0x001E34E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x001E52F6 File Offset: 0x001E34F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x001E5300 File Offset: 0x001E3500
		public static BlueprintConfig GetRootAsBlueprintConfig(ByteBuffer _bb)
		{
			return BlueprintConfig.GetRootAsBlueprintConfig(_bb, default(BlueprintConfig));
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x001E531C File Offset: 0x001E351C
		public static BlueprintConfig GetRootAsBlueprintConfig(ByteBuffer _bb, BlueprintConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x001E5339 File Offset: 0x001E3539
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x001E5348 File Offset: 0x001E3548
		public BlueprintConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06004E07 RID: 19975 RVA: 0x001E5358 File Offset: 0x001E3558
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

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06004E08 RID: 19976 RVA: 0x001E5394 File Offset: 0x001E3594
		public string BlueprintType
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

		// Token: 0x06004E09 RID: 19977 RVA: 0x001E53CB File Offset: 0x001E35CB
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x001E53DA File Offset: 0x001E35DA
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06004E0B RID: 19979 RVA: 0x001E53F4 File Offset: 0x001E35F4
		public string EntityType
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

		// Token: 0x06004E0C RID: 19980 RVA: 0x001E542B File Offset: 0x001E362B
		public Span<byte> GetEntityTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x001E543A File Offset: 0x001E363A
		public byte[] GetEntityTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06004E0E RID: 19982 RVA: 0x001E5454 File Offset: 0x001E3654
		public string EntityLogic
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

		// Token: 0x06004E0F RID: 19983 RVA: 0x001E548C File Offset: 0x001E368C
		public Span<byte> GetEntityLogicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x001E549C File Offset: 0x001E369C
		public byte[] GetEntityLogicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06004E11 RID: 19985 RVA: 0x001E54B4 File Offset: 0x001E36B4
		public int ModelId
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

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06004E12 RID: 19986 RVA: 0x001E54F4 File Offset: 0x001E36F4
		public int HalfHeight
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

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06004E13 RID: 19987 RVA: 0x001E5534 File Offset: 0x001E3734
		public int TrackHeight
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

		// Token: 0x04004B38 RID: 19256
		private Table __p;
	}
}
