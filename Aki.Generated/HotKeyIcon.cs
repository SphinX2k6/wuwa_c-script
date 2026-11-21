using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E39 RID: 3641
	public struct HotKeyIcon : IFlatbufferObject
	{
		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06008824 RID: 34852 RVA: 0x0027A849 File Offset: 0x00278A49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008825 RID: 34853 RVA: 0x0027A856 File Offset: 0x00278A56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008826 RID: 34854 RVA: 0x0027A860 File Offset: 0x00278A60
		public static HotKeyIcon GetRootAsHotKeyIcon(ByteBuffer _bb)
		{
			return HotKeyIcon.GetRootAsHotKeyIcon(_bb, default(HotKeyIcon));
		}

		// Token: 0x06008827 RID: 34855 RVA: 0x0027A87C File Offset: 0x00278A7C
		public static HotKeyIcon GetRootAsHotKeyIcon(ByteBuffer _bb, HotKeyIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008828 RID: 34856 RVA: 0x0027A899 File Offset: 0x00278A99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008829 RID: 34857 RVA: 0x0027A8A8 File Offset: 0x00278AA8
		public HotKeyIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x0600882A RID: 34858 RVA: 0x0027A8B8 File Offset: 0x00278AB8
		public string KeyName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600882B RID: 34859 RVA: 0x0027A8EF File Offset: 0x00278AEF
		public Span<byte> GetKeyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600882C RID: 34860 RVA: 0x0027A8FE File Offset: 0x00278AFE
		public byte[] GetKeyNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x0600882D RID: 34861 RVA: 0x0027A918 File Offset: 0x00278B18
		public string Icon
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

		// Token: 0x0600882E RID: 34862 RVA: 0x0027A94F File Offset: 0x00278B4F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600882F RID: 34863 RVA: 0x0027A95E File Offset: 0x00278B5E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040053B8 RID: 21432
		private Table __p;
	}
}
