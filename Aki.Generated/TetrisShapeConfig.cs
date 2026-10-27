using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001129 RID: 4393
	public struct TetrisShapeConfig : IFlatbufferObject
	{
		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x0600DE86 RID: 56966 RVA: 0x0032D325 File Offset: 0x0032B525
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE87 RID: 56967 RVA: 0x0032D332 File Offset: 0x0032B532
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE88 RID: 56968 RVA: 0x0032D33C File Offset: 0x0032B53C
		public static TetrisShapeConfig GetRootAsTetrisShapeConfig(ByteBuffer _bb)
		{
			return TetrisShapeConfig.GetRootAsTetrisShapeConfig(_bb, default(TetrisShapeConfig));
		}

		// Token: 0x0600DE89 RID: 56969 RVA: 0x0032D358 File Offset: 0x0032B558
		public static TetrisShapeConfig GetRootAsTetrisShapeConfig(ByteBuffer _bb, TetrisShapeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE8A RID: 56970 RVA: 0x0032D375 File Offset: 0x0032B575
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE8B RID: 56971 RVA: 0x0032D384 File Offset: 0x0032B584
		public TetrisShapeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x0600DE8C RID: 56972 RVA: 0x0032D394 File Offset: 0x0032B594
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

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x0600DE8D RID: 56973 RVA: 0x0032D3D0 File Offset: 0x0032B5D0
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

		// Token: 0x0600DE8E RID: 56974 RVA: 0x0032D407 File Offset: 0x0032B607
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DE8F RID: 56975 RVA: 0x0032D416 File Offset: 0x0032B616
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x0600DE90 RID: 56976 RVA: 0x0032D430 File Offset: 0x0032B630
		public string LogicType
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

		// Token: 0x0600DE91 RID: 56977 RVA: 0x0032D467 File Offset: 0x0032B667
		public Span<byte> GetLogicTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DE92 RID: 56978 RVA: 0x0032D476 File Offset: 0x0032B676
		public byte[] GetLogicTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A5D RID: 14941
		// (get) Token: 0x0600DE93 RID: 56979 RVA: 0x0032D490 File Offset: 0x0032B690
		public string Shape
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

		// Token: 0x0600DE94 RID: 56980 RVA: 0x0032D4C8 File Offset: 0x0032B6C8
		public Span<byte> GetShapeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DE95 RID: 56981 RVA: 0x0032D4D8 File Offset: 0x0032B6D8
		public byte[] GetShapeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005267 RID: 21095
		private Table __p;
	}
}
