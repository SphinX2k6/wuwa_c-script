using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C30 RID: 3120
	public struct EncircleMapItem : IFlatbufferObject
	{
		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06006924 RID: 26916 RVA: 0x002232F9 File Offset: 0x002214F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x00223306 File Offset: 0x00221506
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x00223310 File Offset: 0x00221510
		public static EncircleMapItem GetRootAsEncircleMapItem(ByteBuffer _bb)
		{
			return EncircleMapItem.GetRootAsEncircleMapItem(_bb, default(EncircleMapItem));
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x0022332C File Offset: 0x0022152C
		public static EncircleMapItem GetRootAsEncircleMapItem(ByteBuffer _bb, EncircleMapItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x00223349 File Offset: 0x00221549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006929 RID: 26921 RVA: 0x00223358 File Offset: 0x00221558
		public EncircleMapItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x0600692A RID: 26922 RVA: 0x00223368 File Offset: 0x00221568
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

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x0600692B RID: 26923 RVA: 0x002233A4 File Offset: 0x002215A4
		public EncircleHexType Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EncircleHexType.Plain;
				}
				return (EncircleHexType)this.__p.bb.GetSbyte(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x0600692C RID: 26924 RVA: 0x002233E0 File Offset: 0x002215E0
		public string Memo
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

		// Token: 0x0600692D RID: 26925 RVA: 0x00223417 File Offset: 0x00221617
		public Span<byte> GetMemoBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x00223426 File Offset: 0x00221626
		public byte[] GetMemoArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x0600692F RID: 26927 RVA: 0x00223440 File Offset: 0x00221640
		public string ResourcePath
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

		// Token: 0x06006930 RID: 26928 RVA: 0x00223478 File Offset: 0x00221678
		public Span<byte> GetResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x00223488 File Offset: 0x00221688
		public byte[] GetResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06006932 RID: 26930 RVA: 0x002234A0 File Offset: 0x002216A0
		public string SpinePath
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

		// Token: 0x06006933 RID: 26931 RVA: 0x002234D8 File Offset: 0x002216D8
		public Span<byte> GetSpinePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x002234E8 File Offset: 0x002216E8
		public byte[] GetSpinePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C70 RID: 19568
		private Table __p;
	}
}
