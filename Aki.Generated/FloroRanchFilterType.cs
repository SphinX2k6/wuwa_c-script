using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8E RID: 3470
	public struct FloroRanchFilterType : IFlatbufferObject
	{
		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x0600796A RID: 31082 RVA: 0x0025A15A File Offset: 0x0025835A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x0025A167 File Offset: 0x00258367
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600796C RID: 31084 RVA: 0x0025A170 File Offset: 0x00258370
		public static FloroRanchFilterType GetRootAsFloroRanchFilterType(ByteBuffer _bb)
		{
			return FloroRanchFilterType.GetRootAsFloroRanchFilterType(_bb, default(FloroRanchFilterType));
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x0025A18C File Offset: 0x0025838C
		public static FloroRanchFilterType GetRootAsFloroRanchFilterType(ByteBuffer _bb, FloroRanchFilterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x0025A1A9 File Offset: 0x002583A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x0025A1B8 File Offset: 0x002583B8
		public FloroRanchFilterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06007970 RID: 31088 RVA: 0x0025A1C8 File Offset: 0x002583C8
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

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06007971 RID: 31089 RVA: 0x0025A204 File Offset: 0x00258404
		public int FilterTypeId
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

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06007972 RID: 31090 RVA: 0x0025A240 File Offset: 0x00258440
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

		// Token: 0x06007973 RID: 31091 RVA: 0x0025A277 File Offset: 0x00258477
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007974 RID: 31092 RVA: 0x0025A286 File Offset: 0x00258486
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040052F2 RID: 21234
		private Table __p;
	}
}
