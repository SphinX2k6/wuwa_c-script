using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC3 RID: 3779
	public struct LoopTeleportVolumeFunction : IFlatbufferObject
	{
		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x060095CE RID: 38350 RVA: 0x00299974 File Offset: 0x00297B74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060095CF RID: 38351 RVA: 0x00299981 File Offset: 0x00297B81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060095D0 RID: 38352 RVA: 0x00299988 File Offset: 0x00297B88
		public static LoopTeleportVolumeFunction GetRootAsLoopTeleportVolumeFunction(ByteBuffer _bb)
		{
			return LoopTeleportVolumeFunction.GetRootAsLoopTeleportVolumeFunction(_bb, default(LoopTeleportVolumeFunction));
		}

		// Token: 0x060095D1 RID: 38353 RVA: 0x002999A4 File Offset: 0x00297BA4
		public static LoopTeleportVolumeFunction GetRootAsLoopTeleportVolumeFunction(ByteBuffer _bb, LoopTeleportVolumeFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060095D2 RID: 38354 RVA: 0x002999C1 File Offset: 0x00297BC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060095D3 RID: 38355 RVA: 0x002999D0 File Offset: 0x00297BD0
		public LoopTeleportVolumeFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x060095D4 RID: 38356 RVA: 0x002999E0 File Offset: 0x00297BE0
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

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x060095D5 RID: 38357 RVA: 0x00299A1C File Offset: 0x00297C1C
		public int VolumeId
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

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x060095D6 RID: 38358 RVA: 0x00299A58 File Offset: 0x00297C58
		public string Desc
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

		// Token: 0x060095D7 RID: 38359 RVA: 0x00299A8F File Offset: 0x00297C8F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060095D8 RID: 38360 RVA: 0x00299A9E File Offset: 0x00297C9E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x060095D9 RID: 38361 RVA: 0x00299AB8 File Offset: 0x00297CB8
		public string Conditions
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

		// Token: 0x060095DA RID: 38362 RVA: 0x00299AF0 File Offset: 0x00297CF0
		public Span<byte> GetConditionsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060095DB RID: 38363 RVA: 0x00299B00 File Offset: 0x00297D00
		public byte[] GetConditionsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x060095DC RID: 38364 RVA: 0x00299B18 File Offset: 0x00297D18
		public string Actions
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x00299B50 File Offset: 0x00297D50
		public Span<byte> GetActionsBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060095DE RID: 38366 RVA: 0x00299B60 File Offset: 0x00297D60
		public byte[] GetActionsArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x060095DF RID: 38367 RVA: 0x00299B78 File Offset: 0x00297D78
		public string ClientLogic
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095E0 RID: 38368 RVA: 0x00299BB0 File Offset: 0x00297DB0
		public Span<byte> GetClientLogicBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060095E1 RID: 38369 RVA: 0x00299BC0 File Offset: 0x00297DC0
		public byte[] GetClientLogicArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400545F RID: 21599
		private Table __p;
	}
}
