using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED7 RID: 3799
	public struct PhantomBattleMasterTitle : IFlatbufferObject
	{
		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x0600A797 RID: 42903 RVA: 0x002B0FC6 File Offset: 0x002AF1C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x002B0FD3 File Offset: 0x002AF1D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x002B0FDC File Offset: 0x002AF1DC
		public static PhantomBattleMasterTitle GetRootAsPhantomBattleMasterTitle(ByteBuffer _bb)
		{
			return PhantomBattleMasterTitle.GetRootAsPhantomBattleMasterTitle(_bb, default(PhantomBattleMasterTitle));
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x002B0FF8 File Offset: 0x002AF1F8
		public static PhantomBattleMasterTitle GetRootAsPhantomBattleMasterTitle(ByteBuffer _bb, PhantomBattleMasterTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x002B1015 File Offset: 0x002AF215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x002B1024 File Offset: 0x002AF224
		public PhantomBattleMasterTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x0600A79D RID: 42909 RVA: 0x002B1034 File Offset: 0x002AF234
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

		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x0600A79E RID: 42910 RVA: 0x002B1070 File Offset: 0x002AF270
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

		// Token: 0x0600A79F RID: 42911 RVA: 0x002B10A7 File Offset: 0x002AF2A7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x002B10B6 File Offset: 0x002AF2B6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002672 RID: 9842
		// (get) Token: 0x0600A7A1 RID: 42913 RVA: 0x002B10D0 File Offset: 0x002AF2D0
		public string Icon
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

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x002B1107 File Offset: 0x002AF307
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x002B1116 File Offset: 0x002AF316
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002673 RID: 9843
		// (get) Token: 0x0600A7A4 RID: 42916 RVA: 0x002B1130 File Offset: 0x002AF330
		public string IconBg
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

		// Token: 0x0600A7A5 RID: 42917 RVA: 0x002B1168 File Offset: 0x002AF368
		public Span<byte> GetIconBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x002B1178 File Offset: 0x002AF378
		public byte[] GetIconBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F95 RID: 20373
		private Table __p;
	}
}
