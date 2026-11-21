using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1D RID: 3101
	public struct BlueprintConfig : IFlatbufferObject
	{
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060053C3 RID: 21443 RVA: 0x00205611 File Offset: 0x00203811
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x0020561E File Offset: 0x0020381E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x00205628 File Offset: 0x00203828
		public static BlueprintConfig GetRootAsBlueprintConfig(ByteBuffer _bb)
		{
			return BlueprintConfig.GetRootAsBlueprintConfig(_bb, default(BlueprintConfig));
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x00205644 File Offset: 0x00203844
		public static BlueprintConfig GetRootAsBlueprintConfig(ByteBuffer _bb, BlueprintConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x00205661 File Offset: 0x00203861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x00205670 File Offset: 0x00203870
		public BlueprintConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060053C9 RID: 21449 RVA: 0x00205680 File Offset: 0x00203880
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

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060053CA RID: 21450 RVA: 0x002056BC File Offset: 0x002038BC
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

		// Token: 0x060053CB RID: 21451 RVA: 0x002056F3 File Offset: 0x002038F3
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x00205702 File Offset: 0x00203902
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060053CD RID: 21453 RVA: 0x0020571C File Offset: 0x0020391C
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

		// Token: 0x060053CE RID: 21454 RVA: 0x00205753 File Offset: 0x00203953
		public Span<byte> GetEntityTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x00205762 File Offset: 0x00203962
		public byte[] GetEntityTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060053D0 RID: 21456 RVA: 0x0020577C File Offset: 0x0020397C
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

		// Token: 0x060053D1 RID: 21457 RVA: 0x002057B4 File Offset: 0x002039B4
		public Span<byte> GetEntityLogicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x002057C4 File Offset: 0x002039C4
		public byte[] GetEntityLogicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060053D3 RID: 21459 RVA: 0x002057DC File Offset: 0x002039DC
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

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060053D4 RID: 21460 RVA: 0x0020581C File Offset: 0x00203A1C
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

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060053D5 RID: 21461 RVA: 0x0020585C File Offset: 0x00203A5C
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

		// Token: 0x04005118 RID: 20760
		private Table __p;
	}
}
