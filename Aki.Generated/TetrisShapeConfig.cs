using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200125F RID: 4703
	public struct TetrisShapeConfig : IFlatbufferObject
	{
		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x0600EBF4 RID: 60404 RVA: 0x003588F9 File Offset: 0x00356AF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EBF5 RID: 60405 RVA: 0x00358906 File Offset: 0x00356B06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EBF6 RID: 60406 RVA: 0x00358910 File Offset: 0x00356B10
		public static TetrisShapeConfig GetRootAsTetrisShapeConfig(ByteBuffer _bb)
		{
			return TetrisShapeConfig.GetRootAsTetrisShapeConfig(_bb, default(TetrisShapeConfig));
		}

		// Token: 0x0600EBF7 RID: 60407 RVA: 0x0035892C File Offset: 0x00356B2C
		public static TetrisShapeConfig GetRootAsTetrisShapeConfig(ByteBuffer _bb, TetrisShapeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EBF8 RID: 60408 RVA: 0x00358949 File Offset: 0x00356B49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBF9 RID: 60409 RVA: 0x00358958 File Offset: 0x00356B58
		public TetrisShapeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DBE RID: 15806
		// (get) Token: 0x0600EBFA RID: 60410 RVA: 0x00358968 File Offset: 0x00356B68
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

		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x0600EBFB RID: 60411 RVA: 0x003589A4 File Offset: 0x00356BA4
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

		// Token: 0x0600EBFC RID: 60412 RVA: 0x003589DB File Offset: 0x00356BDB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EBFD RID: 60413 RVA: 0x003589EA File Offset: 0x00356BEA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x0600EBFE RID: 60414 RVA: 0x00358A04 File Offset: 0x00356C04
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

		// Token: 0x0600EBFF RID: 60415 RVA: 0x00358A3B File Offset: 0x00356C3B
		public Span<byte> GetLogicTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EC00 RID: 60416 RVA: 0x00358A4A File Offset: 0x00356C4A
		public byte[] GetLogicTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x0600EC01 RID: 60417 RVA: 0x00358A64 File Offset: 0x00356C64
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

		// Token: 0x0600EC02 RID: 60418 RVA: 0x00358A9C File Offset: 0x00356C9C
		public Span<byte> GetShapeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EC03 RID: 60419 RVA: 0x00358AAC File Offset: 0x00356CAC
		public byte[] GetShapeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040058AA RID: 22698
		private Table __p;
	}
}
