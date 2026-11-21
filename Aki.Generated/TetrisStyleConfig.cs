using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001260 RID: 4704
	public struct TetrisStyleConfig : IFlatbufferObject
	{
		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x0600EC04 RID: 60420 RVA: 0x00358AC4 File Offset: 0x00356CC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EC05 RID: 60421 RVA: 0x00358AD1 File Offset: 0x00356CD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EC06 RID: 60422 RVA: 0x00358AD8 File Offset: 0x00356CD8
		public static TetrisStyleConfig GetRootAsTetrisStyleConfig(ByteBuffer _bb)
		{
			return TetrisStyleConfig.GetRootAsTetrisStyleConfig(_bb, default(TetrisStyleConfig));
		}

		// Token: 0x0600EC07 RID: 60423 RVA: 0x00358AF4 File Offset: 0x00356CF4
		public static TetrisStyleConfig GetRootAsTetrisStyleConfig(ByteBuffer _bb, TetrisStyleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EC08 RID: 60424 RVA: 0x00358B11 File Offset: 0x00356D11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EC09 RID: 60425 RVA: 0x00358B20 File Offset: 0x00356D20
		public TetrisStyleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x0600EC0A RID: 60426 RVA: 0x00358B30 File Offset: 0x00356D30
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

		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x0600EC0B RID: 60427 RVA: 0x00358B6C File Offset: 0x00356D6C
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

		// Token: 0x0600EC0C RID: 60428 RVA: 0x00358BA3 File Offset: 0x00356DA3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EC0D RID: 60429 RVA: 0x00358BB2 File Offset: 0x00356DB2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x0600EC0E RID: 60430 RVA: 0x00358BCC File Offset: 0x00356DCC
		public string MaterialPath
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

		// Token: 0x0600EC0F RID: 60431 RVA: 0x00358C03 File Offset: 0x00356E03
		public Span<byte> GetMaterialPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EC10 RID: 60432 RVA: 0x00358C12 File Offset: 0x00356E12
		public byte[] GetMaterialPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x0600EC11 RID: 60433 RVA: 0x00358C2C File Offset: 0x00356E2C
		public string ImagePath
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

		// Token: 0x0600EC12 RID: 60434 RVA: 0x00358C64 File Offset: 0x00356E64
		public Span<byte> GetImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EC13 RID: 60435 RVA: 0x00358C74 File Offset: 0x00356E74
		public byte[] GetImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040058AB RID: 22699
		private Table __p;
	}
}
