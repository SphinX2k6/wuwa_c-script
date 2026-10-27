using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D54 RID: 3412
	public struct HotKeyIcon : IFlatbufferObject
	{
		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x0600820A RID: 33290 RVA: 0x0025C11D File Offset: 0x0025A31D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600820B RID: 33291 RVA: 0x0025C12A File Offset: 0x0025A32A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600820C RID: 33292 RVA: 0x0025C134 File Offset: 0x0025A334
		public static HotKeyIcon GetRootAsHotKeyIcon(ByteBuffer _bb)
		{
			return HotKeyIcon.GetRootAsHotKeyIcon(_bb, default(HotKeyIcon));
		}

		// Token: 0x0600820D RID: 33293 RVA: 0x0025C150 File Offset: 0x0025A350
		public static HotKeyIcon GetRootAsHotKeyIcon(ByteBuffer _bb, HotKeyIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x0025C16D File Offset: 0x0025A36D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x0025C17C File Offset: 0x0025A37C
		public HotKeyIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06008210 RID: 33296 RVA: 0x0025C18C File Offset: 0x0025A38C
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

		// Token: 0x06008211 RID: 33297 RVA: 0x0025C1C3 File Offset: 0x0025A3C3
		public Span<byte> GetKeyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008212 RID: 33298 RVA: 0x0025C1D2 File Offset: 0x0025A3D2
		public byte[] GetKeyNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06008213 RID: 33299 RVA: 0x0025C1EC File Offset: 0x0025A3EC
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

		// Token: 0x06008214 RID: 33300 RVA: 0x0025C223 File Offset: 0x0025A423
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x0025C232 File Offset: 0x0025A432
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DD3 RID: 19923
		private Table __p;
	}
}
